namespace MLTDABD.Forms
{
    partial class FormAsset
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
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MenuStrip();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewTree = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuActionDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuActionSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuActionExport = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxL = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxLAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxR = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxRRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxRClear = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cboFilterField = new System.Windows.Forms.ComboBox();
            this.btnFilterReset = new System.Windows.Forms.Button();
            this.btnFilterByRegex = new System.Windows.Forms.Button();
            this.btnFilterByText = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.assetTreeList1 = new MLTDABD.Forms.AssetTreeList();
            this.label2 = new System.Windows.Forms.Label();
            this.lvDownload = new MLTDABD.Forms.ExplorerListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.mainMenu1.SuspendLayout();
            this.ctxL.SuspendLayout();
            this.ctxR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuView,
            this.mnuAction});
            this.mainMenu1.Location = new System.Drawing.Point(0, 0);
            this.mainMenu1.Name = "mainMenu1";
            this.mainMenu1.Size = new System.Drawing.Size(1135, 24);
            this.mainMenu1.TabIndex = 0;
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewList,
            this.mnuViewTree});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(44, 20);
            this.mnuView.Text = "&View";
            this.mnuView.Click += new System.EventHandler(this.MnuViewList_Click);
            // 
            // mnuViewList
            // 
            this.mnuViewList.Checked = true;
            this.mnuViewList.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuViewList.MergeIndex = 0;
            this.mnuViewList.Name = "mnuViewList";
            this.mnuViewList.Size = new System.Drawing.Size(180, 22);
            this.mnuViewList.Text = "&List";
            // 
            // mnuViewTree
            // 
            this.mnuViewTree.Name = "mnuViewTree";
            this.mnuViewTree.Size = new System.Drawing.Size(180, 22);
            this.mnuViewTree.Text = "&Tree";
            this.mnuViewTree.Click += new System.EventHandler(this.MnuViewTree_Click);
            // 
            // mnuAction
            // 
            this.mnuAction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuActionDownload,
            this.mnuActionSave,
            this.mnuActionExport});
            this.mnuAction.Name = "mnuAction";
            this.mnuAction.Size = new System.Drawing.Size(54, 20);
            this.mnuAction.Text = "&Action";
            // 
            // mnuActionDownload
            // 
            this.mnuActionDownload.Name = "mnuActionDownload";
            this.mnuActionDownload.Size = new System.Drawing.Size(220, 22);
            this.mnuActionDownload.Text = "&Download Selected Assets...";
            this.mnuActionDownload.Click += new System.EventHandler(this.MnuActionDownload_Click);
            // 
            // mnuActionSave
            // 
            this.mnuActionSave.Name = "mnuActionSave";
            this.mnuActionSave.Size = new System.Drawing.Size(220, 22);
            this.mnuActionSave.Text = "&Save Manifest...";
            this.mnuActionSave.Click += new System.EventHandler(this.MnuActionSave_Click);
            // 
            // mnuActionExport
            // 
            this.mnuActionExport.Name = "mnuActionExport";
            this.mnuActionExport.Size = new System.Drawing.Size(220, 22);
            this.mnuActionExport.Text = "E&xport Manifest as Text...";
            this.mnuActionExport.Click += new System.EventHandler(this.MnuActionExport_Click);
            // 
            // ctxL
            // 
            this.ctxL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxLAdd});
            this.ctxL.Name = "ctxL";
            this.ctxL.Size = new System.Drawing.Size(220, 26);
            // 
            // ctxLAdd
            // 
            this.ctxLAdd.Name = "ctxLAdd";
            this.ctxLAdd.Size = new System.Drawing.Size(219, 22);
            this.ctxLAdd.Text = "&Add to Pending Downloads";
            this.ctxLAdd.Click += new System.EventHandler(this.CtxLAdd_Click);
            // 
            // ctxR
            // 
            this.ctxR.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxRRemove,
            this.ctxRClear});
            this.ctxR.Name = "ctxR";
            this.ctxR.Size = new System.Drawing.Size(117, 48);
            // 
            // ctxRRemove
            // 
            this.ctxRRemove.Name = "ctxRRemove";
            this.ctxRRemove.Size = new System.Drawing.Size(116, 22);
            this.ctxRRemove.Text = "&Remove";
            this.ctxRRemove.Click += new System.EventHandler(this.CtxRRemove_Click);
            // 
            // ctxRClear
            // 
            this.ctxRClear.Name = "ctxRClear";
            this.ctxRClear.Size = new System.Drawing.Size(116, 22);
            this.ctxRClear.Text = "&Clear";
            this.ctxRClear.Click += new System.EventHandler(this.CtxRClear_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cboFilterField);
            this.splitContainer1.Panel1.Controls.Add(this.btnFilterReset);
            this.splitContainer1.Panel1.Controls.Add(this.btnFilterByRegex);
            this.splitContainer1.Panel1.Controls.Add(this.btnFilterByText);
            this.splitContainer1.Panel1.Controls.Add(this.txtFilter);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.assetTreeList1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.lvDownload);
            this.splitContainer1.Size = new System.Drawing.Size(1135, 681);
            this.splitContainer1.SplitterDistance = 599;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // cboFilterField
            // 
            this.cboFilterField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFilterField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterField.FormattingEnabled = true;
            this.cboFilterField.Items.AddRange(new object[] {
            "Local Name",
            "Remote Name",
            "Hash"});
            this.cboFilterField.Location = new System.Drawing.Point(278, 651);
            this.cboFilterField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboFilterField.Name = "cboFilterField";
            this.cboFilterField.Size = new System.Drawing.Size(86, 23);
            this.cboFilterField.TabIndex = 7;
            // 
            // btnFilterReset
            // 
            this.btnFilterReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterReset.Location = new System.Drawing.Point(537, 650);
            this.btnFilterReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFilterReset.Name = "btnFilterReset";
            this.btnFilterReset.Size = new System.Drawing.Size(58, 25);
            this.btnFilterReset.TabIndex = 6;
            this.btnFilterReset.Text = "Reset";
            this.btnFilterReset.UseVisualStyleBackColor = true;
            this.btnFilterReset.Click += new System.EventHandler(this.BtnFilterReset_Click);
            // 
            // btnFilterByRegex
            // 
            this.btnFilterByRegex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterByRegex.Location = new System.Drawing.Point(454, 650);
            this.btnFilterByRegex.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFilterByRegex.Name = "btnFilterByRegex";
            this.btnFilterByRegex.Size = new System.Drawing.Size(76, 25);
            this.btnFilterByRegex.TabIndex = 5;
            this.btnFilterByRegex.Text = "By Regex";
            this.btnFilterByRegex.UseVisualStyleBackColor = true;
            this.btnFilterByRegex.Click += new System.EventHandler(this.BtnFilterByRegex_Click);
            // 
            // btnFilterByText
            // 
            this.btnFilterByText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterByText.Location = new System.Drawing.Point(371, 650);
            this.btnFilterByText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFilterByText.Name = "btnFilterByText";
            this.btnFilterByText.Size = new System.Drawing.Size(76, 25);
            this.btnFilterByText.TabIndex = 4;
            this.btnFilterByText.Text = "By Text";
            this.btnFilterByText.UseVisualStyleBackColor = true;
            this.btnFilterByText.Click += new System.EventHandler(this.BtnFilterByText_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(51, 652);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(219, 23);
            this.txtFilter.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 655);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filter:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assets";
            // 
            // assetTreeList1
            // 
            this.assetTreeList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assetTreeList1.Location = new System.Drawing.Point(4, 29);
            this.assetTreeList1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.assetTreeList1.Name = "assetTreeList1";
            this.assetTreeList1.Size = new System.Drawing.Size(592, 616);
            this.assetTreeList1.TabIndex = 0;
            this.assetTreeList1.View = MLTDABD.Forms.TreeListView.ListView;
            this.assetTreeList1.ItemDoubleClick += new System.EventHandler<System.Windows.Forms.MouseEventArgs>(this.AssetTreeList1_ItemDoubleClick);
            this.assetTreeList1.ItemsContextRequested += new System.EventHandler<System.Windows.Forms.MouseEventArgs>(this.AssetTreeList1_ItemsContextRequested);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pending Downloads";
            // 
            // lvDownload
            // 
            this.lvDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDownload.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvDownload.FullRowSelect = true;
            this.lvDownload.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDownload.Location = new System.Drawing.Point(4, 29);
            this.lvDownload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvDownload.Name = "lvDownload";
            this.lvDownload.Size = new System.Drawing.Size(521, 648);
            this.lvDownload.TabIndex = 0;
            this.lvDownload.UseCompatibleStateImageBehavior = false;
            this.lvDownload.View = System.Windows.Forms.View.Details;
            this.lvDownload.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LvDownload_MouseUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size";
            // 
            // FormAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 681);
            this.Controls.Add(this.mainMenu1);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.mainMenu1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormAsset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manifest";
            this.Load += new System.EventHandler(this.FormAsset_Load);
            this.mainMenu1.ResumeLayout(false);
            this.mainMenu1.PerformLayout();
            this.ctxL.ResumeLayout(false);
            this.ctxR.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip mainMenu1;

        private System.Windows.Forms.ToolStripMenuItem mnuAction;

        private System.Windows.Forms.ToolStripMenuItem mnuActionDownload;

        private System.Windows.Forms.ToolStripMenuItem mnuActionExport;

        private System.Windows.Forms.ToolStripMenuItem mnuView;

        private System.Windows.Forms.ToolStripMenuItem mnuViewList;

        private System.Windows.Forms.ToolStripMenuItem mnuViewTree;

        #endregion
        private System.Windows.Forms.ContextMenuStrip ctxL;
        private System.Windows.Forms.ToolStripMenuItem ctxLAdd;
        private System.Windows.Forms.ContextMenuStrip ctxR;
        private System.Windows.Forms.ToolStripMenuItem ctxRRemove;
        private System.Windows.Forms.ToolStripMenuItem ctxRClear;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private AssetTreeList assetTreeList1;
        private ExplorerListView lvDownload;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem mnuActionSave;
        private System.Windows.Forms.Button btnFilterReset;
        private System.Windows.Forms.Button btnFilterByRegex;
        private System.Windows.Forms.Button btnFilterByText;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboFilterField;
    }
}