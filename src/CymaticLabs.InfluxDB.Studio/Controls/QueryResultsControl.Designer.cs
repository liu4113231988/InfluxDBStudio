namespace CymaticLabs.InfluxDB.Studio.Controls
{
    partial class QueryResultsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listView = new System.Windows.Forms.ListView();
            contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(components);
            exportAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportAllCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportSelectedCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            jSONToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            copyJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            splitContainer = new System.Windows.Forms.SplitContainer();
            tagsTextBox = new System.Windows.Forms.TextBox();
            saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            copyCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // listView
            // 
            listView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            listView.ContextMenuStrip = contextMenuStrip;
            listView.Dock = System.Windows.Forms.DockStyle.Fill;
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Location = new System.Drawing.Point(0, 0);
            listView.Margin = new System.Windows.Forms.Padding(4);
            listView.Name = "listView";
            listView.Size = new System.Drawing.Size(803, 562);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = System.Windows.Forms.View.Details;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { exportAllToolStripMenuItem, exportSelectedToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new System.Drawing.Size(181, 70);
            // 
            // exportAllToolStripMenuItem
            // 
            exportAllToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { exportAllCsvToolStripMenuItem, jSONToolStripMenuItem });
            exportAllToolStripMenuItem.Name = "exportAllToolStripMenuItem";
            exportAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            exportAllToolStripMenuItem.Text = "Export All";
            // 
            // exportAllCsvToolStripMenuItem
            // 
            exportAllCsvToolStripMenuItem.Name = "exportAllCsvToolStripMenuItem";
            exportAllCsvToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            exportAllCsvToolStripMenuItem.Text = "CSV";
            exportAllCsvToolStripMenuItem.Click += exportAllCsvToolStripMenuItem_Click;
            // 
            // jSONToolStripMenuItem
            // 
            jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            jSONToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            jSONToolStripMenuItem.Text = "JSON";
            jSONToolStripMenuItem.Click += jSONToolStripMenuItem_Click;
            // 
            // exportSelectedToolStripMenuItem
            // 
            exportSelectedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { exportSelectedCsvToolStripMenuItem, jSONToolStripMenuItem1, copyJSONToolStripMenuItem, copyCSVToolStripMenuItem });
            exportSelectedToolStripMenuItem.Name = "exportSelectedToolStripMenuItem";
            exportSelectedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            exportSelectedToolStripMenuItem.Text = "Export Selected";
            // 
            // exportSelectedCsvToolStripMenuItem
            // 
            exportSelectedCsvToolStripMenuItem.Name = "exportSelectedCsvToolStripMenuItem";
            exportSelectedCsvToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            exportSelectedCsvToolStripMenuItem.Text = "CSV";
            exportSelectedCsvToolStripMenuItem.Click += exportSelectedCsvToolStripMenuItem_Click;
            // 
            // jSONToolStripMenuItem1
            // 
            jSONToolStripMenuItem1.Name = "jSONToolStripMenuItem1";
            jSONToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            jSONToolStripMenuItem1.Text = "JSON";
            jSONToolStripMenuItem1.Click += jSONToolStripMenuItem1_Click;
            // 
            // copyJSONToolStripMenuItem
            // 
            copyJSONToolStripMenuItem.Name = "copyJSONToolStripMenuItem";
            copyJSONToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            copyJSONToolStripMenuItem.Text = "Copy JSON";
            copyJSONToolStripMenuItem.Click += copyJSONToolStripMenuItem_Click;
            // 
            // splitContainer
            // 
            splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer.Location = new System.Drawing.Point(0, 0);
            splitContainer.Margin = new System.Windows.Forms.Padding(4);
            splitContainer.Name = "splitContainer";
            splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(tagsTextBox);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(listView);
            splitContainer.Size = new System.Drawing.Size(803, 599);
            splitContainer.SplitterDistance = 32;
            splitContainer.SplitterWidth = 5;
            splitContainer.TabIndex = 4;
            // 
            // tagsTextBox
            // 
            tagsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            tagsTextBox.Location = new System.Drawing.Point(0, 0);
            tagsTextBox.Margin = new System.Windows.Forms.Padding(4);
            tagsTextBox.Multiline = true;
            tagsTextBox.Name = "tagsTextBox";
            tagsTextBox.ReadOnly = true;
            tagsTextBox.Size = new System.Drawing.Size(803, 32);
            tagsTextBox.TabIndex = 1;
            // 
            // copyCSVToolStripMenuItem
            // 
            copyCSVToolStripMenuItem.Name = "copyCSVToolStripMenuItem";
            copyCSVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            copyCSVToolStripMenuItem.Text = "Copy CSV";
            copyCSVToolStripMenuItem.Click += copyCSVToolStripMenuItem_Click;
            // 
            // QueryResultsControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(splitContainer);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "QueryResultsControl";
            Size = new System.Drawing.Size(803, 599);
            contextMenuStrip.ResumeLayout(false);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TextBox tagsTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exportAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAllCsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSelectedCsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyCSVToolStripMenuItem;
    }
}
