﻿namespace CymaticLabs.InfluxDB.Studio
{
    partial class AppForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Measurement", 3, 3);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Database", 2, 2, new System.Windows.Forms.TreeNode[] { treeNode1 });
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Connection", 1, 1, new System.Windows.Forms.TreeNode[] { treeNode2 });
            menuStrip = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            importAppSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportAppSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            connectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newQueryToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            runQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            showQueriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            timeFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            timeFormatComboBox = new System.Windows.Forms.ToolStripComboBox();
            dateFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dateFormatComboBox = new System.Windows.Forms.ToolStripComboBox();
            allowUntrustedSSLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            timeDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cbxTimeDisplay = new System.Windows.Forms.ToolStripComboBox();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            imageList = new System.Windows.Forms.ImageList(components);
            toolStrip = new System.Windows.Forms.ToolStrip();
            manageConnectionsButton = new System.Windows.Forms.ToolStripButton();
            disconnectButton = new System.Windows.Forms.ToolStripButton();
            showPoliciesButton = new System.Windows.Forms.ToolStripButton();
            showUsersButton = new System.Windows.Forms.ToolStripButton();
            showStatsButton = new System.Windows.Forms.ToolStripButton();
            showDiagnosticsButton = new System.Windows.Forms.ToolStripButton();
            showQueriesButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            refreshButton = new System.Windows.Forms.ToolStripButton();
            newQueryButton = new System.Windows.Forms.ToolStripButton();
            runQueryButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            createDatabaseButton = new System.Windows.Forms.ToolStripButton();
            continuousQueryButton = new System.Windows.Forms.ToolStripButton();
            backFillButton = new System.Windows.Forms.ToolStripButton();
            dropDatabaseButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            tagKeysButton = new System.Windows.Forms.ToolStripButton();
            tagValuesButton = new System.Windows.Forms.ToolStripButton();
            fieldKeysButton = new System.Windows.Forms.ToolStripButton();
            showSeriesButton = new System.Windows.Forms.ToolStripButton();
            dropSeriesButton = new System.Windows.Forms.ToolStripButton();
            dropMeasurementButton = new System.Windows.Forms.ToolStripButton();
            statusStrip = new System.Windows.Forms.StatusStrip();
            statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            splitContainer = new System.Windows.Forms.SplitContainer();
            connectionsTreeView = new System.Windows.Forms.TreeView();
            tabControl = new Controls.ExtendedTabControl();
            connectionsContextMenu = new System.Windows.Forms.ContextMenuStrip(components);
            connectionRefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            createDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            showPoliciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            showUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            showQueriesContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            showStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            diagnosticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            databaseContextMenu = new System.Windows.Forms.ContextMenuStrip(components);
            databaseRefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            continousQueriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            backFillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dropDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            measurementContextMenu = new System.Windows.Forms.ContextMenuStrip(components);
            newQueryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            tagKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tagValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fieldKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            showSeriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dropMeasurementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dropSeriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            openFileDialog = new System.Windows.Forms.OpenFileDialog();
            tabContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(components);
            closeTabMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            closeAllButThisMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            closeAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            connectionsContextMenu.SuspendLayout();
            databaseContextMenu.SuspendLayout();
            measurementContextMenu.SuspendLayout();
            tabContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, connectionsToolStripMenuItem, queryToolStripMenuItem, settingsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            menuStrip.Size = new System.Drawing.Size(915, 27);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { importToolStripMenuItem, exportToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { importAppSettingsMenuItem });
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            importToolStripMenuItem.Text = "Import";
            // 
            // importAppSettingsMenuItem
            // 
            importAppSettingsMenuItem.Name = "importAppSettingsMenuItem";
            importAppSettingsMenuItem.Size = new System.Drawing.Size(122, 22);
            importAppSettingsMenuItem.Text = "Settings";
            importAppSettingsMenuItem.Click += importAppSettingsMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { exportAppSettingsMenuItem });
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            exportToolStripMenuItem.Text = "Export";
            // 
            // exportAppSettingsMenuItem
            // 
            exportAppSettingsMenuItem.Name = "exportAppSettingsMenuItem";
            exportAppSettingsMenuItem.Size = new System.Drawing.Size(122, 22);
            exportAppSettingsMenuItem.Text = "Settings";
            exportAppSettingsMenuItem.Click += exportAppSettingsMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // connectionsToolStripMenuItem
            // 
            connectionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { refreshToolStripMenuItem, manageToolStripMenuItem });
            connectionsToolStripMenuItem.Name = "connectionsToolStripMenuItem";
            connectionsToolStripMenuItem.Size = new System.Drawing.Size(91, 21);
            connectionsToolStripMenuItem.Text = "Connections";
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Image = Properties.Resources.Refresh;
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            refreshToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            refreshToolStripMenuItem.Text = "Refresh";
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("manageToolStripMenuItem.Image");
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            manageToolStripMenuItem.Text = "Manage";
            manageToolStripMenuItem.Click += manageToolStripMenuItem_Click;
            // 
            // queryToolStripMenuItem
            // 
            queryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { newQueryToolStripMenuItem2, runQueryToolStripMenuItem, showQueriesToolStripMenuItem });
            queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            queryToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            queryToolStripMenuItem.Text = "Query";
            // 
            // newQueryToolStripMenuItem2
            // 
            newQueryToolStripMenuItem2.Image = Properties.Resources.NewQuery;
            newQueryToolStripMenuItem2.Name = "newQueryToolStripMenuItem2";
            newQueryToolStripMenuItem2.Size = new System.Drawing.Size(156, 22);
            newQueryToolStripMenuItem2.Text = "New Query";
            newQueryToolStripMenuItem2.Click += newQueryToolStripMenuItem2_Click;
            // 
            // runQueryToolStripMenuItem
            // 
            runQueryToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("runQueryToolStripMenuItem.Image");
            runQueryToolStripMenuItem.Name = "runQueryToolStripMenuItem";
            runQueryToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R;
            runQueryToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            runQueryToolStripMenuItem.Text = "Run";
            runQueryToolStripMenuItem.Click += runQueryToolStripMenuItem_Click;
            // 
            // showQueriesToolStripMenuItem
            // 
            showQueriesToolStripMenuItem.Image = Properties.Resources.ShowQueries;
            showQueriesToolStripMenuItem.Name = "showQueriesToolStripMenuItem";
            showQueriesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            showQueriesToolStripMenuItem.Text = "Show Queries";
            showQueriesToolStripMenuItem.Click += showQueriesToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { timeFormatToolStripMenuItem, dateFormatToolStripMenuItem, allowUntrustedSSLToolStripMenuItem, timeDisplayToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // timeFormatToolStripMenuItem
            // 
            timeFormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { timeFormatComboBox });
            timeFormatToolStripMenuItem.Image = Properties.Resources.Time;
            timeFormatToolStripMenuItem.Name = "timeFormatToolStripMenuItem";
            timeFormatToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            timeFormatToolStripMenuItem.Text = "Time Format";
            // 
            // timeFormatComboBox
            // 
            timeFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            timeFormatComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            timeFormatComboBox.Items.AddRange(new object[] { "2:30:45.123 PM  12 Hour", "    14:30:45.123  24 Hour" });
            timeFormatComboBox.Name = "timeFormatComboBox";
            timeFormatComboBox.Size = new System.Drawing.Size(136, 25);
            timeFormatComboBox.SelectedIndexChanged += timeFormatComboBox_SelectedIndexChanged;
            // 
            // dateFormatToolStripMenuItem
            // 
            dateFormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dateFormatComboBox });
            dateFormatToolStripMenuItem.Image = Properties.Resources.Date;
            dateFormatToolStripMenuItem.Name = "dateFormatToolStripMenuItem";
            dateFormatToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            dateFormatToolStripMenuItem.Text = "Date Format";
            // 
            // dateFormatComboBox
            // 
            dateFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            dateFormatComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            dateFormatComboBox.Items.AddRange(new object[] { "12/31/2016  mm/dd/yyyy", "31/12/2016  dd/mm/yyyy " });
            dateFormatComboBox.Name = "dateFormatComboBox";
            dateFormatComboBox.Size = new System.Drawing.Size(160, 25);
            dateFormatComboBox.SelectedIndexChanged += dateFormatComboBox_SelectedIndexChanged;
            // 
            // allowUntrustedSSLToolStripMenuItem
            // 
            allowUntrustedSSLToolStripMenuItem.CheckOnClick = true;
            allowUntrustedSSLToolStripMenuItem.Name = "allowUntrustedSSLToolStripMenuItem";
            allowUntrustedSSLToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            allowUntrustedSSLToolStripMenuItem.Text = "Allow Untrusted SSL";
            allowUntrustedSSLToolStripMenuItem.CheckedChanged += allowUntrustedSSLToolStripMenuItem_CheckedChanged;
            // 
            // timeDisplayToolStripMenuItem
            // 
            timeDisplayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { cbxTimeDisplay });
            timeDisplayToolStripMenuItem.Name = "timeDisplayToolStripMenuItem";
            timeDisplayToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            timeDisplayToolStripMenuItem.Text = "Time Display";
            // 
            // cbxTimeDisplay
            // 
            cbxTimeDisplay.Items.AddRange(new object[] { "默认", "ms", "s" });
            cbxTimeDisplay.Name = "cbxTimeDisplay";
            cbxTimeDisplay.Size = new System.Drawing.Size(121, 25);
            cbxTimeDisplay.SelectedIndexChanged += cbxTimeDisplay_SelectedIndexChanged;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // imageList
            // 
            imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = System.Drawing.Color.Transparent;
            imageList.Images.SetKeyName(0, "Loading");
            imageList.Images.SetKeyName(1, "Connection");
            imageList.Images.SetKeyName(2, "Database");
            imageList.Images.SetKeyName(3, "Measurement");
            // 
            // toolStrip
            // 
            toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { manageConnectionsButton, disconnectButton, showPoliciesButton, showUsersButton, showStatsButton, showDiagnosticsButton, showQueriesButton, toolStripSeparator1, refreshButton, newQueryButton, runQueryButton, toolStripSeparator2, createDatabaseButton, continuousQueryButton, backFillButton, dropDatabaseButton, toolStripSeparator3, tagKeysButton, tagValuesButton, fieldKeysButton, showSeriesButton, dropSeriesButton, dropMeasurementButton });
            toolStrip.Location = new System.Drawing.Point(0, 27);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new System.Drawing.Size(915, 25);
            toolStrip.TabIndex = 2;
            toolStrip.Text = "toolStrip1";
            // 
            // manageConnectionsButton
            // 
            manageConnectionsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            manageConnectionsButton.Image = Properties.Resources.EditConnection;
            manageConnectionsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            manageConnectionsButton.Name = "manageConnectionsButton";
            manageConnectionsButton.Size = new System.Drawing.Size(23, 22);
            manageConnectionsButton.Text = "manageConnectionsButton";
            manageConnectionsButton.ToolTipText = "Manage Connections";
            manageConnectionsButton.Click += manageConnectionsButton_Click;
            // 
            // disconnectButton
            // 
            disconnectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            disconnectButton.Image = Properties.Resources.Disconnect;
            disconnectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            disconnectButton.Name = "disconnectButton";
            disconnectButton.Size = new System.Drawing.Size(23, 22);
            disconnectButton.Text = "disconnectButton";
            disconnectButton.ToolTipText = "Disconnect";
            disconnectButton.Click += disconnectButton_Click;
            // 
            // showPoliciesButton
            // 
            showPoliciesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            showPoliciesButton.Image = Properties.Resources.RetentionPolicy;
            showPoliciesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            showPoliciesButton.Name = "showPoliciesButton";
            showPoliciesButton.Size = new System.Drawing.Size(23, 22);
            showPoliciesButton.Text = "Show Retention Policies";
            showPoliciesButton.Click += showPoliciesButton_Click;
            // 
            // showUsersButton
            // 
            showUsersButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            showUsersButton.Image = Properties.Resources.Users;
            showUsersButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            showUsersButton.Name = "showUsersButton";
            showUsersButton.Size = new System.Drawing.Size(23, 22);
            showUsersButton.Text = "Show Users";
            showUsersButton.Click += showUsersButton_Click;
            // 
            // showStatsButton
            // 
            showStatsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            showStatsButton.Image = Properties.Resources.Stats;
            showStatsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            showStatsButton.Name = "showStatsButton";
            showStatsButton.Size = new System.Drawing.Size(23, 22);
            showStatsButton.Text = "toolStripButton1";
            showStatsButton.ToolTipText = "Show Statistics";
            showStatsButton.Click += showStatsButton_Click;
            // 
            // showDiagnosticsButton
            // 
            showDiagnosticsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            showDiagnosticsButton.Image = Properties.Resources.Diagnostics;
            showDiagnosticsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            showDiagnosticsButton.Name = "showDiagnosticsButton";
            showDiagnosticsButton.Size = new System.Drawing.Size(23, 22);
            showDiagnosticsButton.Text = "showDiagnosticsButton";
            showDiagnosticsButton.ToolTipText = "Show Diagnostics";
            showDiagnosticsButton.Click += showDiagnosticsButton_Click;
            // 
            // showQueriesButton
            // 
            showQueriesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            showQueriesButton.Image = Properties.Resources.ShowQueries;
            showQueriesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            showQueriesButton.Name = "showQueriesButton";
            showQueriesButton.Size = new System.Drawing.Size(23, 22);
            showQueriesButton.Text = "Show Queries";
            showQueriesButton.Click += showQueriesButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // refreshButton
            // 
            refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            refreshButton.Image = Properties.Resources.Refresh;
            refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new System.Drawing.Size(23, 22);
            refreshButton.Text = "Refresh";
            refreshButton.ToolTipText = "Refresh";
            refreshButton.Click += refreshButton_Click;
            // 
            // newQueryButton
            // 
            newQueryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            newQueryButton.Image = Properties.Resources.NewQuery;
            newQueryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            newQueryButton.Name = "newQueryButton";
            newQueryButton.Size = new System.Drawing.Size(23, 22);
            newQueryButton.Text = "newQueryButton";
            newQueryButton.ToolTipText = "New Query";
            newQueryButton.Click += newQueryButton_Click;
            // 
            // runQueryButton
            // 
            runQueryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            runQueryButton.Image = Properties.Resources.RunQuery;
            runQueryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            runQueryButton.Name = "runQueryButton";
            runQueryButton.Size = new System.Drawing.Size(23, 22);
            runQueryButton.Text = "runQueryButton";
            runQueryButton.ToolTipText = "Run Query";
            runQueryButton.Click += runQueryButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // createDatabaseButton
            // 
            createDatabaseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            createDatabaseButton.Image = Properties.Resources.CreateDatabase;
            createDatabaseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            createDatabaseButton.Name = "createDatabaseButton";
            createDatabaseButton.Size = new System.Drawing.Size(23, 22);
            createDatabaseButton.Text = "createDatabaseButton";
            createDatabaseButton.ToolTipText = "Create Database";
            createDatabaseButton.Click += createDatabaseButton_Click;
            // 
            // continuousQueryButton
            // 
            continuousQueryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            continuousQueryButton.Image = Properties.Resources.ContinuousQuery;
            continuousQueryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            continuousQueryButton.Name = "continuousQueryButton";
            continuousQueryButton.Size = new System.Drawing.Size(23, 22);
            continuousQueryButton.Text = "Show Continuous Queries";
            continuousQueryButton.Click += continuousQueryButton_Click;
            // 
            // backFillButton
            // 
            backFillButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            backFillButton.Image = Properties.Resources.BackFill;
            backFillButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            backFillButton.Name = "backFillButton";
            backFillButton.Size = new System.Drawing.Size(23, 22);
            backFillButton.Text = "Run Backfill";
            backFillButton.Click += backFillButton_Click;
            // 
            // dropDatabaseButton
            // 
            dropDatabaseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            dropDatabaseButton.Image = Properties.Resources.DropDatabase;
            dropDatabaseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            dropDatabaseButton.Name = "dropDatabaseButton";
            dropDatabaseButton.Size = new System.Drawing.Size(23, 22);
            dropDatabaseButton.Text = "dropDatabaseButton";
            dropDatabaseButton.ToolTipText = "Drop Database";
            dropDatabaseButton.Click += dropDatabaseButton_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tagKeysButton
            // 
            tagKeysButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tagKeysButton.Image = Properties.Resources.TagKeys;
            tagKeysButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            tagKeysButton.Name = "tagKeysButton";
            tagKeysButton.Size = new System.Drawing.Size(23, 22);
            tagKeysButton.Text = "A";
            tagKeysButton.ToolTipText = "Show Tag Keys";
            tagKeysButton.Click += tagKeysButton_Click;
            // 
            // tagValuesButton
            // 
            tagValuesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tagValuesButton.Image = Properties.Resources.TagValues;
            tagValuesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            tagValuesButton.Name = "tagValuesButton";
            tagValuesButton.Size = new System.Drawing.Size(23, 22);
            tagValuesButton.Text = "Tag Values";
            tagValuesButton.ToolTipText = "Show Tag Values";
            tagValuesButton.Click += tagValuesButton_Click;
            // 
            // fieldKeysButton
            // 
            fieldKeysButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            fieldKeysButton.Image = Properties.Resources.FieldKeys;
            fieldKeysButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            fieldKeysButton.Name = "fieldKeysButton";
            fieldKeysButton.Size = new System.Drawing.Size(23, 22);
            fieldKeysButton.Text = "Field Keys";
            fieldKeysButton.ToolTipText = "Show Field Keys";
            fieldKeysButton.Click += fieldKeysButton_Click;
            // 
            // showSeriesButton
            // 
            showSeriesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            showSeriesButton.Image = Properties.Resources.Series;
            showSeriesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            showSeriesButton.Name = "showSeriesButton";
            showSeriesButton.Size = new System.Drawing.Size(23, 22);
            showSeriesButton.Text = "showSeriesButton";
            showSeriesButton.ToolTipText = "Show Show Series";
            showSeriesButton.Click += showSeriesButton_Click;
            // 
            // dropSeriesButton
            // 
            dropSeriesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            dropSeriesButton.Image = Properties.Resources.DropSeries;
            dropSeriesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            dropSeriesButton.Name = "dropSeriesButton";
            dropSeriesButton.Size = new System.Drawing.Size(23, 22);
            dropSeriesButton.Text = "dropSeriesButton";
            dropSeriesButton.ToolTipText = "Drop Series";
            dropSeriesButton.Click += dropSeriesButton_Click;
            // 
            // dropMeasurementButton
            // 
            dropMeasurementButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            dropMeasurementButton.Image = Properties.Resources.DropMeasurement;
            dropMeasurementButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            dropMeasurementButton.Name = "dropMeasurementButton";
            dropMeasurementButton.Size = new System.Drawing.Size(23, 22);
            dropMeasurementButton.Text = "dropMeasurementButton";
            dropMeasurementButton.ToolTipText = "Drop Measurement";
            dropMeasurementButton.Click += dropMeasurementButton_Click;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusLabel });
            statusStrip.Location = new System.Drawing.Point(0, 713);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip.Size = new System.Drawing.Size(915, 22);
            statusStrip.TabIndex = 3;
            statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(17, 17);
            statusLabel.Text = "...";
            // 
            // splitContainer
            // 
            splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer.Location = new System.Drawing.Point(0, 52);
            splitContainer.Margin = new System.Windows.Forms.Padding(4);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(connectionsTreeView);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(tabControl);
            splitContainer.Size = new System.Drawing.Size(915, 661);
            splitContainer.SplitterDistance = 196;
            splitContainer.SplitterWidth = 5;
            splitContainer.TabIndex = 4;
            // 
            // connectionsTreeView
            // 
            connectionsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            connectionsTreeView.FullRowSelect = true;
            connectionsTreeView.HideSelection = false;
            connectionsTreeView.ImageIndex = 0;
            connectionsTreeView.ImageList = imageList;
            connectionsTreeView.Location = new System.Drawing.Point(0, 0);
            connectionsTreeView.Margin = new System.Windows.Forms.Padding(4);
            connectionsTreeView.Name = "connectionsTreeView";
            treeNode1.ImageIndex = 3;
            treeNode1.Name = "Node2";
            treeNode1.SelectedImageIndex = 3;
            treeNode1.Text = "Measurement";
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "Node1";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Text = "Database";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "Node0";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "Connection";
            connectionsTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { treeNode3 });
            connectionsTreeView.SelectedImageIndex = 0;
            connectionsTreeView.Size = new System.Drawing.Size(196, 661);
            connectionsTreeView.TabIndex = 1;
            connectionsTreeView.AfterExpand += connectionsTreeView_AfterExpand;
            connectionsTreeView.AfterSelect += connectionsTreeView_AfterSelect;
            connectionsTreeView.NodeMouseClick += connectionsTreeView_NodeMouseClick;
            connectionsTreeView.NodeMouseDoubleClick += connectionsTreeView_NodeMouseDoubleClick;
            // 
            // tabControl
            // 
            tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            tabControl.Location = new System.Drawing.Point(0, 0);
            tabControl.Margin = new System.Windows.Forms.Padding(4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.ShowTabCloseArea = true;
            tabControl.Size = new System.Drawing.Size(714, 661);
            tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            tabControl.TabCloseSpace = 8;
            tabControl.TabCloseWidth = 16;
            tabControl.TabImageHeight = 16;
            tabControl.TabImageLeft = 4;
            tabControl.TabImageTop = 4;
            tabControl.TabImageWidth = 16;
            tabControl.TabIndex = 0;
            tabControl.TabLeadingOffset = 8;
            tabControl.TabClosed += tabControl_TabClosed;
            // 
            // connectionsContextMenu
            // 
            connectionsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { connectionRefreshToolStripMenuItem, createDatabaseToolStripMenuItem, showPoliciesToolStripMenuItem, showUsersToolStripMenuItem, showQueriesContextMenuItem, showStatisticsToolStripMenuItem, diagnosticsToolStripMenuItem, disconnectToolStripMenuItem });
            connectionsContextMenu.Name = "connectionsContextMenu";
            connectionsContextMenu.Size = new System.Drawing.Size(214, 180);
            // 
            // connectionRefreshToolStripMenuItem
            // 
            connectionRefreshToolStripMenuItem.Image = Properties.Resources.Refresh;
            connectionRefreshToolStripMenuItem.Name = "connectionRefreshToolStripMenuItem";
            connectionRefreshToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            connectionRefreshToolStripMenuItem.Text = "Refresh";
            connectionRefreshToolStripMenuItem.Click += connectionRefreshToolStripMenuItem_Click;
            // 
            // createDatabaseToolStripMenuItem
            // 
            createDatabaseToolStripMenuItem.Image = Properties.Resources.CreateDatabase;
            createDatabaseToolStripMenuItem.Name = "createDatabaseToolStripMenuItem";
            createDatabaseToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            createDatabaseToolStripMenuItem.Text = "Create Database";
            createDatabaseToolStripMenuItem.Click += createDatabaseToolStripMenuItem_Click;
            // 
            // showPoliciesToolStripMenuItem
            // 
            showPoliciesToolStripMenuItem.Image = Properties.Resources.RetentionPolicy;
            showPoliciesToolStripMenuItem.Name = "showPoliciesToolStripMenuItem";
            showPoliciesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            showPoliciesToolStripMenuItem.Text = "Show Retention Policies";
            showPoliciesToolStripMenuItem.Click += showRetentionPoliciesToolStripMenuItem_Click;
            // 
            // showUsersToolStripMenuItem
            // 
            showUsersToolStripMenuItem.Image = Properties.Resources.Users;
            showUsersToolStripMenuItem.Name = "showUsersToolStripMenuItem";
            showUsersToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            showUsersToolStripMenuItem.Text = "Show Users";
            showUsersToolStripMenuItem.Click += showUsersToolStripMenuItem_Click;
            // 
            // showQueriesContextMenuItem
            // 
            showQueriesContextMenuItem.Image = Properties.Resources.ShowQueries;
            showQueriesContextMenuItem.Name = "showQueriesContextMenuItem";
            showQueriesContextMenuItem.Size = new System.Drawing.Size(213, 22);
            showQueriesContextMenuItem.Text = "Show Queries";
            showQueriesContextMenuItem.Click += showQueriesContextMenuItem_Click;
            // 
            // showStatisticsToolStripMenuItem
            // 
            showStatisticsToolStripMenuItem.Image = Properties.Resources.Stats;
            showStatisticsToolStripMenuItem.Name = "showStatisticsToolStripMenuItem";
            showStatisticsToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            showStatisticsToolStripMenuItem.Text = "Show Statistics";
            showStatisticsToolStripMenuItem.Click += showStatisticsToolStripMenuItem_Click;
            // 
            // diagnosticsToolStripMenuItem
            // 
            diagnosticsToolStripMenuItem.Image = Properties.Resources.Diagnostics;
            diagnosticsToolStripMenuItem.Name = "diagnosticsToolStripMenuItem";
            diagnosticsToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            diagnosticsToolStripMenuItem.Text = "Diagnostics";
            diagnosticsToolStripMenuItem.Click += diagnosticsToolStripMenuItem_Click;
            // 
            // disconnectToolStripMenuItem
            // 
            disconnectToolStripMenuItem.Image = Properties.Resources.Disconnect;
            disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            disconnectToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            disconnectToolStripMenuItem.Text = "Disconnect";
            disconnectToolStripMenuItem.Click += disconnectToolStripMenuItem_Click;
            // 
            // databaseContextMenu
            // 
            databaseContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { databaseRefreshToolStripMenuItem, newQueryToolStripMenuItem, continousQueriesToolStripMenuItem, backFillToolStripMenuItem, dropDatabaseToolStripMenuItem });
            databaseContextMenu.Name = "databaseContextMenu";
            databaseContextMenu.Size = new System.Drawing.Size(219, 114);
            // 
            // databaseRefreshToolStripMenuItem
            // 
            databaseRefreshToolStripMenuItem.Image = Properties.Resources.Refresh;
            databaseRefreshToolStripMenuItem.Name = "databaseRefreshToolStripMenuItem";
            databaseRefreshToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            databaseRefreshToolStripMenuItem.Text = "Refresh";
            databaseRefreshToolStripMenuItem.Click += databaseRefreshToolStripMenuItem_Click;
            // 
            // newQueryToolStripMenuItem
            // 
            newQueryToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("newQueryToolStripMenuItem.Image");
            newQueryToolStripMenuItem.Name = "newQueryToolStripMenuItem";
            newQueryToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            newQueryToolStripMenuItem.Text = "New Query";
            newQueryToolStripMenuItem.Click += newQueryMenuItem_Click;
            // 
            // continousQueriesToolStripMenuItem
            // 
            continousQueriesToolStripMenuItem.Image = Properties.Resources.ContinuousQuery;
            continousQueriesToolStripMenuItem.Name = "continousQueriesToolStripMenuItem";
            continousQueriesToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            continousQueriesToolStripMenuItem.Text = "Show Continous Queries";
            continousQueriesToolStripMenuItem.Click += continousQueriesToolStripMenuItem_Click;
            // 
            // backFillToolStripMenuItem
            // 
            backFillToolStripMenuItem.Image = Properties.Resources.BackFill;
            backFillToolStripMenuItem.Name = "backFillToolStripMenuItem";
            backFillToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            backFillToolStripMenuItem.Text = "Run Backfill";
            backFillToolStripMenuItem.Click += backFillToolStripMenuItem_Click;
            // 
            // dropDatabaseToolStripMenuItem
            // 
            dropDatabaseToolStripMenuItem.Image = Properties.Resources.DropDatabase;
            dropDatabaseToolStripMenuItem.Name = "dropDatabaseToolStripMenuItem";
            dropDatabaseToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            dropDatabaseToolStripMenuItem.Text = "Drop Database";
            dropDatabaseToolStripMenuItem.Click += dropDatabaseToolStripMenuItem_Click;
            // 
            // measurementContextMenu
            // 
            measurementContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { newQueryToolStripMenuItem1, tagKeysToolStripMenuItem, tagValuesToolStripMenuItem, fieldKeysToolStripMenuItem, showSeriesToolStripMenuItem, dropMeasurementToolStripMenuItem, dropSeriesToolStripMenuItem });
            measurementContextMenu.Name = "measurementContextMenu";
            measurementContextMenu.Size = new System.Drawing.Size(191, 158);
            // 
            // newQueryToolStripMenuItem1
            // 
            newQueryToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("newQueryToolStripMenuItem1.Image");
            newQueryToolStripMenuItem1.Name = "newQueryToolStripMenuItem1";
            newQueryToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            newQueryToolStripMenuItem1.Text = "New Query";
            newQueryToolStripMenuItem1.Click += newQueryMenuItem_Click;
            // 
            // tagKeysToolStripMenuItem
            // 
            tagKeysToolStripMenuItem.Image = Properties.Resources.TagKeys;
            tagKeysToolStripMenuItem.Name = "tagKeysToolStripMenuItem";
            tagKeysToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            tagKeysToolStripMenuItem.Text = "Show Tag Keys";
            tagKeysToolStripMenuItem.Click += tagKeysToolStripMenuItem_Click;
            // 
            // tagValuesToolStripMenuItem
            // 
            tagValuesToolStripMenuItem.Image = Properties.Resources.TagValues;
            tagValuesToolStripMenuItem.Name = "tagValuesToolStripMenuItem";
            tagValuesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            tagValuesToolStripMenuItem.Text = "Show Tag Values";
            tagValuesToolStripMenuItem.Click += tagValuesToolStripMenuItem_Click;
            // 
            // fieldKeysToolStripMenuItem
            // 
            fieldKeysToolStripMenuItem.Image = Properties.Resources.FieldKeys;
            fieldKeysToolStripMenuItem.Name = "fieldKeysToolStripMenuItem";
            fieldKeysToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            fieldKeysToolStripMenuItem.Text = "Show Field Keys";
            fieldKeysToolStripMenuItem.Click += fieldKeysToolStripMenuItem_Click;
            // 
            // showSeriesToolStripMenuItem
            // 
            showSeriesToolStripMenuItem.Image = Properties.Resources.Series;
            showSeriesToolStripMenuItem.Name = "showSeriesToolStripMenuItem";
            showSeriesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            showSeriesToolStripMenuItem.Text = "Show Series";
            showSeriesToolStripMenuItem.Click += showSeriesToolStripMenuItem_Click;
            // 
            // dropMeasurementToolStripMenuItem
            // 
            dropMeasurementToolStripMenuItem.Image = Properties.Resources.DropMeasurement;
            dropMeasurementToolStripMenuItem.Name = "dropMeasurementToolStripMenuItem";
            dropMeasurementToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            dropMeasurementToolStripMenuItem.Text = "Drop Measurement";
            dropMeasurementToolStripMenuItem.Click += dropMeasurementToolStripMenuItem_Click;
            // 
            // dropSeriesToolStripMenuItem
            // 
            dropSeriesToolStripMenuItem.Image = Properties.Resources.DropSeries;
            dropSeriesToolStripMenuItem.Name = "dropSeriesToolStripMenuItem";
            dropSeriesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            dropSeriesToolStripMenuItem.Text = "Drop Series";
            dropSeriesToolStripMenuItem.Click += dropSeriesToolStripMenuItem_Click;
            // 
            // saveFileDialog
            // 
            saveFileDialog.FileName = "InfluxDBStudio.json";
            saveFileDialog.Filter = "JSON files|*.json|All files|*.*";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "InfluxDBStudio.json";
            openFileDialog.Filter = "JSON files|*.json|All files|*.*";
            // 
            // tabContextMenuStrip
            // 
            tabContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { closeTabMenuItem, closeAllButThisMenuItem, closeAllMenuItem });
            tabContextMenuStrip.Name = "tabContextMenuStrip";
            tabContextMenuStrip.Size = new System.Drawing.Size(177, 70);
            // 
            // closeTabMenuItem
            // 
            closeTabMenuItem.Name = "closeTabMenuItem";
            closeTabMenuItem.Size = new System.Drawing.Size(176, 22);
            closeTabMenuItem.Text = "Close";
            // 
            // closeAllButThisMenuItem
            // 
            closeAllButThisMenuItem.Name = "closeAllButThisMenuItem";
            closeAllButThisMenuItem.Size = new System.Drawing.Size(176, 22);
            closeAllButThisMenuItem.Text = "Close All But This";
            // 
            // closeAllMenuItem
            // 
            closeAllMenuItem.Name = "closeAllMenuItem";
            closeAllMenuItem.Size = new System.Drawing.Size(176, 22);
            closeAllMenuItem.Text = "Close All";
            // 
            // AppForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(915, 735);
            Controls.Add(splitContainer);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "AppForm";
            Text = "InfluxDB Studio";
            Load += AppForm_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            connectionsContextMenu.ResumeLayout(false);
            databaseContextMenu.ResumeLayout(false);
            measurementContextMenu.ResumeLayout(false);
            tabContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView connectionsTreeView;
        private System.Windows.Forms.ContextMenuStrip connectionsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionRefreshToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip databaseContextMenu;
        private System.Windows.Forms.ToolStripMenuItem databaseRefreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropDatabaseToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip measurementContextMenu;
        private System.Windows.Forms.ToolStripMenuItem dropMeasurementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropSeriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newQueryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem diagnosticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem continousQueriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showSeriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton manageConnectionsButton;
        private System.Windows.Forms.ToolStripButton refreshButton;
        private System.Windows.Forms.ToolStripButton createDatabaseButton;
        private System.Windows.Forms.ToolStripButton showDiagnosticsButton;
        private System.Windows.Forms.ToolStripButton disconnectButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton runQueryButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton newQueryButton;
        private System.Windows.Forms.ToolStripButton dropDatabaseButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton showSeriesButton;
        private System.Windows.Forms.ToolStripButton dropSeriesButton;
        private System.Windows.Forms.ToolStripButton dropMeasurementButton;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newQueryToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tagKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fieldKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagValuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tagKeysButton;
        private System.Windows.Forms.ToolStripButton tagValuesButton;
        private System.Windows.Forms.ToolStripButton fieldKeysButton;
        private System.Windows.Forms.ToolStripMenuItem showUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton showUsersButton;
        private System.Windows.Forms.ToolStripButton continuousQueryButton;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAppSettingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importAppSettingsMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Controls.ExtendedTabControl tabControl;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton backFillButton;
        private System.Windows.Forms.ToolStripMenuItem backFillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox timeFormatComboBox;
        private System.Windows.Forms.ToolStripMenuItem dateFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox dateFormatComboBox;
        private System.Windows.Forms.ToolStripMenuItem allowUntrustedSSLToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton showQueriesButton;
        private System.Windows.Forms.ToolStripMenuItem showQueriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showQueriesContextMenuItem;
        private System.Windows.Forms.ToolStripButton showStatsButton;
        private System.Windows.Forms.ToolStripMenuItem showStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton showPoliciesButton;
        private System.Windows.Forms.ToolStripMenuItem showPoliciesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip tabContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem closeTabMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllButThisMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeDisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cbxTimeDisplay;
    }
}

