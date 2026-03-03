using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using CymaticLabs.InfluxDB.Data;
using System.Runtime.Versioning;

namespace CymaticLabs.InfluxDB.Studio.Controls
{
    /// <summary>
    /// Renders the results for a single InfluxDB query.
    /// </summary>
    [SupportedOSPlatform("windows")]
    public partial class QueryResultsControl : UserControl
    {
        #region Fields

        // Used to give resulting rows an ID number
        int resultsCount = 0;

        // A cache of the last results received.
        InfluxDbSeries lastResult;

        // Cache for virtual mode rendering
        private List<List<object>> cachedValues;
        private List<string> cachedColumns;
        private int timeColumnIndex = -1;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets or sets the <see cref="InfluxDB.InfluxDbClient">InfluxDB connection</see> associated
        /// with the control.
        /// </summary>
        public InfluxDbClient InfluxDbClient { get; set; }

        /// <summary>
        /// Gets or sets the name of the database associated with the control.
        /// </summary>
        public string Database { get; set; }

        public string TimeDisplayFormat { get; set; }

        #endregion Properties

        #region Constructors

        public QueryResultsControl()
        {
            InitializeComponent();
            
            // Setup virtual mode for better performance with large datasets
            listView.VirtualMode = true;
            listView.RetrieveVirtualItem += ListView_RetrieveVirtualItem;
            listView.CacheVirtualItems += ListView_CacheVirtualItems;
        }

        #endregion Constructors

        #region Event Handlers

        // Export All -> CSV
        private async void exportAllCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await ExportToCsv();
        }

        // Export All -> JSON
        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToJson();
        }

        // Export Selected -> CSV
        private async void exportSelectedCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await ExportToCsv(true);
        }

        // Export Selected -> JSON
        private void jSONToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExportToJson(true);
        }

        #endregion Event Handlers

        #region Methods

        /// <summary>
        /// Clears the current query results from the UI.
        /// </summary>
        public void ClearResults()
        {
            // Clear out current items
            resultsCount = 0;
            tagsTextBox.Text = null;
            listView.BeginUpdate();
            listView.Columns.Clear();
            listView.Items.Clear();
            listView.EndUpdate();
        }

        /// <summary>
        /// Updates the query control's query results UI with the supplied result.
        /// </summary>
        /// <param name="result">The query result to render.</param>
        /// <returns>The total number of results found.</returns>

        public int UpdateResults(InfluxDbSeries result, bool clear = false)
        {
            if (result == null) throw new ArgumentNullException("result");

            // Cache
            lastResult = result;

            // Clear as needed
            if (clear)
            {
                ClearResults();
                cachedValues = null;
                cachedColumns = null;
                timeColumnIndex = -1;
            }

            // Add tag values to to results
            if (result.Tags.Count > 0)
            {
                splitContainer.Panel1Collapsed = false;
                var tagCount = result.Tags.Count;
                var tagCounter = 0;
                var sb = new StringBuilder();

                foreach (var tag in result.Tags)
                {
                    sb.AppendFormat("{0} = {1}{2}", tag.Key, tag.Value, ++tagCounter < tagCount ? ", " : null);
                }

                tagsTextBox.Text = sb.ToString();
            }
            // Hide tag area if there are no tag values
            else
            {
                splitContainer.Panel1Collapsed = true;
            }

            // Cache columns and values for virtual mode
            cachedColumns = result.Columns != null ? result.Columns.ToList() : new List<string>();
            cachedValues = result.Values != null
                ? result.Values.Select(r => r != null ? r.ToList() : new List<object>()).ToList()
                : new List<List<object>>();
            
            // Find time column index
            if (TimeDisplayFormat == null)
            {
                timeColumnIndex = result.Columns.IndexOf("time");
            }
            else
            {
                timeColumnIndex = -1;
            }

            // Start to update the list view with the new results
            listView.BeginUpdate();

            // Clear existing columns and items
            listView.Columns.Clear();

            // Build the first column
            var colRecordNum = new ColumnHeader() { Text = "#" };
            listView.Columns.Add(colRecordNum);

            // Build the dynamic columns
            foreach (var c in result.Columns)
            {
                var col = new ColumnHeader();
                col.Text = c;
                listView.Columns.Add(col);
            }

            // Set the virtual list size to the number of rows
            int itemCount = result.Values.Count;
            listView.VirtualListSize = itemCount;
            resultsCount += itemCount;

            // Resize each column
            if (listView.Columns.Count > 0)
            {
                var columnWidth = (Width - 12) / listView.Columns.Count;
                if (columnWidth < 96) columnWidth = 96;
                foreach (ColumnHeader col in listView.Columns) col.Width = columnWidth;
            }

            listView.EndUpdate();

            return resultsCount;
        }

        // Exports series data to CSV

        async Task ExportToCsv(bool onlySelected = false)
        {
            try
            {
                // Configure save dialog and open
                saveFileDialog.FileName = string.Format("{0}.csv", InfluxDbClient.Connection.Name + "_" + Database);
                saveFileDialog.Filter = "CSV files|*.csv|All files|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var sb = new StringBuilder();

                    // Create a stream writer to write the CSV file
                    using (var sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        sb.Clear();

                        // Write the CSV column names (skip first column which is just row # label)
                        for (var i = 1; i < listView.Columns.Count; i++)
                        {
                            sb.Append(listView.Columns[i].Text);
                            if (i < listView.Columns.Count - 1) sb.Append(",");
                        }

                        await sw.WriteLineAsync(sb.ToString());

                        // Now write each series row
                        if (cachedValues != null && cachedColumns != null)
                        {
                            for (var rowIndex = 0; rowIndex < cachedValues.Count; rowIndex++)
                            {
                                // Check if row is selected if required (use SelectedIndices for virtual mode)
                                if (onlySelected && !listView.SelectedIndices.Contains(rowIndex))
                                {
                                    continue;
                                }

                                sb.Clear();
                                var row = cachedValues[rowIndex];

                                // Write column values (skip first which is row number)
                                for (var i = 0; i < row.Count; i++)
                                {
                                    var v = row[i];
                                    string val = null;

                                    // Format time column if needed
                                    if (timeColumnIndex == i && v != null)
                                    {
                                        if (v is long longValue)
                                        {
                                            val = DateTimeOffset.FromUnixTimeMilliseconds(longValue).DateTime.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss.fff");
                                        }
                                        else
                                        {
                                            val = v.ToString();
                                        }
                                    }
                                    else
                                    {
                                        val = v != null ? v.ToString() : null;
                                    }

                                    sb.Append(val);
                                    if (i < row.Count - 1) sb.Append(",");
                                }

                                await sw.WriteLineAsync(sb.ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AppForm.DisplayException(ex);
            }
        }

        // Exports series data to a JSON array

        void ExportToJson(bool onlySelected = false)
        {
            try
            {
                // Configure save dialog and open
                saveFileDialog.FileName = string.Format("{0}.json", InfluxDbClient.Connection.Name + "_" + Database);
                saveFileDialog.Filter = "JSON files|*.json|All files|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    // Serialize to json
                    var json = GetSelectedItem2Json(onlySelected);

                    // Write to disk
                    File.WriteAllText(saveFileDialog.FileName, json);
                }
            }
            catch (Exception ex)
            {
                AppForm.DisplayException(ex);
            }
        }

        /// <summary>
        /// Event handler for retrieving virtual items on demand.
        /// This is called by the ListView when it needs to display items.
        /// </summary>
        private void ListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (cachedValues == null || e.ItemIndex >= cachedValues.Count)
                return;

            try
            {
                var rowData = cachedValues[e.ItemIndex];
                var rowNumber = e.ItemIndex + 1;

                // Create the list view item with the row number
                var li = new ListViewItem(rowNumber.ToString());

                // Add subitems for each column
                for (var x = 0; x < rowData.Count; x++)
                {
                    var v = rowData[x];
                    string val = null;

                    // Format time column if needed
                    if (timeColumnIndex == x && v != null)
                    {
                        if (v is long longValue)
                        {
                            val = DateTimeOffset.FromUnixTimeMilliseconds(longValue).DateTime.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss.fff");
                        }
                        else
                        {
                            val = v.ToString();
                        }
                    }
                    else
                    {
                        val = v != null ? v.ToString() : null;
                    }

                    var subItem = new ListViewItem.ListViewSubItem(li, val);
                    subItem.Tag = rowData;
                    li.SubItems.Add(subItem);
                }

                e.Item = li;
            }
            catch (Exception ex)
            {
                AppForm.Log?.Error("Error retrieving virtual item", ex);
            }
        }

        /// <summary>
        /// Event handler for caching virtual items.
        /// This is called to optimize rendering performance.
        /// </summary>
        private void ListView_CacheVirtualItems(object sender, CacheVirtualItemsEventArgs e)
        {
            // This event is used to cache items as they are needed for display
            // In our implementation, we keep all data in memory, so this is a no-op
            // But we keep the handler for potential future optimizations
        }

        #endregion Methods

        private void copyJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string jsonString = GetSelectedItem2Json(true);
            Clipboard.SetText(jsonString);
        }


        string GetSelectedItem2Json(bool onlySelected)
        {
            var array = new List<object>();

            if (lastResult != null)
            {
                // Build name lookup
                var indexToName = new Dictionary<int, string>();

                foreach (var colName in lastResult.Columns)
                {
                    if (!indexToName.ContainsKey(indexToName.Count))
                        indexToName.Add(indexToName.Count, colName);
                }

                // Build selected states from UI state (use SelectedIndices for virtual mode)
                var selectedByRowId = new Dictionary<int, bool>();

                for (var i = 0; i < lastResult.Values.Count; i++)
                {
                    selectedByRowId.Add(i, listView.SelectedIndices.Contains(i));
                }

                // Convert results to JSON for export
                for (var i = 0; i < lastResult.Values.Count; i++)
                {
                    var r = lastResult.Values[i];

                    if (onlySelected && !selectedByRowId[i]) continue;

                    // Convert to outgoing dictionary
                    var d = new Dictionary<string, object>();

                    for (var x = 0; x < r.Count; x++)
                    {
                        var key = indexToName[x];
                        var value = r[x];

                        if (d.ContainsKey(key)) d[key] = value;
                        else d.Add(key, value);
                    }

                    // Add to outgoing json structure
                    array.Add(d);
                }
            }

            // Serialize to json
            var json = JsonConvert.SerializeObject(array, Formatting.Indented);
            return json;
        }

        private void copyCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            bool onlySelected = true;
            
            // Write the CSV column names (skip first column which is just row # label)
            string column = "";
            for (var i = 1; i < listView.Columns.Count; i++)
            {
                column += listView.Columns[i].Text;
                if (i < listView.Columns.Count - 1) column += ",";
            }
            sb.AppendLine(column);

            // Now write each series row
            if (cachedValues != null && cachedColumns != null)
            {
                for (var rowIndex = 0; rowIndex < cachedValues.Count; rowIndex++)
                {
                    // Check if row is selected if required (use SelectedIndices for virtual mode)
                    if (onlySelected && !listView.SelectedIndices.Contains(rowIndex))
                    {
                        continue;
                    }

                    var row = cachedValues[rowIndex];
                    string content = "";

                    // Write column values
                    for (var i = 0; i < row.Count; i++)
                    {
                        var v = row[i];
                        string val = null;

                        // Format time column if needed
                        if (timeColumnIndex == i && v != null)
                        {
                            if (v is long longValue)
                            {
                                val = DateTimeOffset.FromUnixTimeMilliseconds(longValue).DateTime.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss.fff");
                            }
                            else
                            {
                                val = v.ToString();
                            }
                        }
                        else
                        {
                            val = v != null ? v.ToString() : null;
                        }

                        content += val;
                        if (i < row.Count - 1) content += ",";
                    }
                    sb.AppendLine(content);
                }
            }

            Clipboard.SetText(sb.ToString());
        }
    }
}
