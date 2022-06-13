namespace MLTDABD.Forms
{
    partial class FormDiff
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
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lv1 = new MLTDABD.Forms.ExplorerListView();
            this.lvDiff = new MLTDABD.Forms.ExplorerListView();
            this.lv2 = new MLTDABD.Forms.ExplorerListView();
            this.label4 = new System.Windows.Forms.Label();
            this.lvDownload = new MLTDABD.Forms.ExplorerListView();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveDiff = new System.Windows.Forms.Button();
            this.btnDiff = new System.Windows.Forms.Button();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.ctxL = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxAPD = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxR = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDL = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxClear = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ctxL.SuspendLayout();
            this.ctxR.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Local Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Remote Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hash";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Size";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Local Name";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Remote Name";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Hash";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Size";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "State";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Local Name";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Remote Name";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Hash";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Size";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(1, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1330, 647);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99812F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lv1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lvDiff, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lv2, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lvDownload, 3, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 38);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1322, 606);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(664, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Changed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Diff";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Base";
            // 
            // lv1
            // 
            this.lv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv1.FullRowSelect = true;
            this.lv1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv1.Location = new System.Drawing.Point(4, 18);
            this.lv1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(322, 585);
            this.lv1.TabIndex = 4;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.View = System.Windows.Forms.View.Details;
            // 
            // lvDiff
            // 
            this.lvDiff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDiff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvDiff.FullRowSelect = true;
            this.lvDiff.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDiff.Location = new System.Drawing.Point(334, 18);
            this.lvDiff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvDiff.Name = "lvDiff";
            this.lvDiff.Size = new System.Drawing.Size(322, 585);
            this.lvDiff.TabIndex = 5;
            this.lvDiff.UseCompatibleStateImageBehavior = false;
            this.lvDiff.View = System.Windows.Forms.View.Details;
            this.lvDiff.SelectedIndexChanged += new System.EventHandler(this.lvDiff_SelectedIndexChanged);
            this.lvDiff.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvDiff_MouseDoubleClick);
            this.lvDiff.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvDiff_MouseDown);
            // 
            // lv2
            // 
            this.lv2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lv2.FullRowSelect = true;
            this.lv2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv2.Location = new System.Drawing.Point(664, 18);
            this.lv2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lv2.Name = "lv2";
            this.lv2.Size = new System.Drawing.Size(322, 585);
            this.lv2.TabIndex = 6;
            this.lv2.UseCompatibleStateImageBehavior = false;
            this.lv2.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(993, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pending Downloads";
            // 
            // lvDownload
            // 
            this.lvDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDownload.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader15});
            this.lvDownload.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDownload.Location = new System.Drawing.Point(994, 18);
            this.lvDownload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvDownload.Name = "lvDownload";
            this.lvDownload.Size = new System.Drawing.Size(324, 585);
            this.lvDownload.TabIndex = 8;
            this.lvDownload.UseCompatibleStateImageBehavior = false;
            this.lvDownload.View = System.Windows.Forms.View.Details;
            this.lvDownload.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvDownload_MouseUp);
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Name";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Size";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.comboBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1322, 32);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(665, 3);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(653, 23);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(4, 3);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(653, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSaveDiff);
            this.panel2.Controls.Add(this.btnDiff);
            this.panel2.Location = new System.Drawing.Point(468, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 40);
            this.panel2.TabIndex = 1;
            // 
            // btnSaveDiff
            // 
            this.btnSaveDiff.Enabled = false;
            this.btnSaveDiff.Location = new System.Drawing.Point(178, 3);
            this.btnSaveDiff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveDiff.Name = "btnSaveDiff";
            this.btnSaveDiff.Size = new System.Drawing.Size(158, 29);
            this.btnSaveDiff.TabIndex = 5;
            this.btnSaveDiff.Text = "&Save Diff...";
            this.btnSaveDiff.UseVisualStyleBackColor = true;
            // 
            // btnDiff
            // 
            this.btnDiff.Location = new System.Drawing.Point(4, 3);
            this.btnDiff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDiff.Name = "btnDiff";
            this.btnDiff.Size = new System.Drawing.Size(158, 29);
            this.btnDiff.TabIndex = 4;
            this.btnDiff.Text = "&Diff";
            this.btnDiff.UseVisualStyleBackColor = true;
            // 
            // ctxL
            // 
            this.ctxL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxAPD});
            this.ctxL.Name = "ctxL";
            this.ctxL.Size = new System.Drawing.Size(220, 26);
            // 
            // ctxAPD
            // 
            this.ctxAPD.Name = "ctxAPD";
            this.ctxAPD.Size = new System.Drawing.Size(219, 22);
            this.ctxAPD.Text = "Add to Pending Downloads";
            this.ctxAPD.Click += new System.EventHandler(this.ctxAPD_Click);
            // 
            // ctxR
            // 
            this.ctxR.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.ctxRemove,
            this.ctxClear});
            this.ctxR.Name = "ctxR";
            this.ctxR.Size = new System.Drawing.Size(117, 70);
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxDL});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.actionToolStripMenuItem.Text = "&Action";
            // 
            // ctxDL
            // 
            this.ctxDL.Name = "ctxDL";
            this.ctxDL.Size = new System.Drawing.Size(220, 22);
            this.ctxDL.Text = "&Download Selected Assets...";
            this.ctxDL.Click += new System.EventHandler(this.ctxDL_Click);
            // 
            // ctxRemove
            // 
            this.ctxRemove.Name = "ctxRemove";
            this.ctxRemove.Size = new System.Drawing.Size(116, 22);
            this.ctxRemove.Text = "&Remove";
            this.ctxRemove.Click += new System.EventHandler(this.ctxRemove_Click);
            // 
            // ctxClear
            // 
            this.ctxClear.Name = "ctxClear";
            this.ctxClear.Size = new System.Drawing.Size(116, 22);
            this.ctxClear.Text = "&Clear";
            this.ctxClear.Click += new System.EventHandler(this.ctxClear_Click);
            // 
            // FormDiff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 696);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormDiff";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manifest Diff";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ctxL.ResumeLayout(false);
            this.ctxR.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSaveDiff;
        private System.Windows.Forms.Button btnDiff;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private ContextMenuStrip ctxL;
        private ToolStripMenuItem ctxAPD;
        private ContextMenuStrip ctxR;
        private ToolStripMenuItem ctxRemove;
        private ToolStripMenuItem ctxClear;
        private ExplorerListView lv1;
        private ExplorerListView lvDiff;
        private ExplorerListView lv2;
        private Label label4;
        private ExplorerListView lvDownload;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ToolStripMenuItem actionToolStripMenuItem;
        private ToolStripMenuItem ctxDL;
    }
}