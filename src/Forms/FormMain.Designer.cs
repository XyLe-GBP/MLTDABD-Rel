namespace MLTDABD_Rel
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpenLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpenRemote = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDLManifest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsDiff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsIV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsAS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.mainMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuTools,
            this.mnuWindows,
            this.mnuHelp});
            this.mainMenu1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mainMenu1.Location = new System.Drawing.Point(0, 0);
            this.mainMenu1.MdiWindowListItem = this.mnuWindows;
            this.mainMenu1.Name = "mainMenu1";
            this.mainMenu1.Size = new System.Drawing.Size(1143, 24);
            this.mainMenu1.TabIndex = 0;
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpen,
            this.mnuDLManifest,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpenLocal,
            this.mnuFileOpenRemote});
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(180, 22);
            this.mnuFileOpen.Text = "&Open";
            // 
            // mnuFileOpenLocal
            // 
            this.mnuFileOpenLocal.Name = "mnuFileOpenLocal";
            this.mnuFileOpenLocal.Size = new System.Drawing.Size(123, 22);
            this.mnuFileOpenLocal.Text = "&Local...";
            this.mnuFileOpenLocal.Click += new System.EventHandler(this.MnuFileOpenLocal_Click);
            // 
            // mnuFileOpenRemote
            // 
            this.mnuFileOpenRemote.Name = "mnuFileOpenRemote";
            this.mnuFileOpenRemote.Size = new System.Drawing.Size(123, 22);
            this.mnuFileOpenRemote.Text = "&Remote...";
            this.mnuFileOpenRemote.Click += new System.EventHandler(this.MnuFileOpenRemote_Click);
            // 
            // mnuDLManifest
            // 
            this.mnuDLManifest.Name = "mnuDLManifest";
            this.mnuDLManifest.Size = new System.Drawing.Size(180, 22);
            this.mnuDLManifest.Text = "Download Manifest";
            this.mnuDLManifest.Click += new System.EventHandler(this.MnuDLManifest_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(180, 22);
            this.mnuExit.Text = "&Exit";
            this.mnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolsDiff,
            this.mnuToolsIV,
            this.mnuToolsAS});
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(46, 20);
            this.mnuTools.Text = "&Tools";
            // 
            // mnuToolsDiff
            // 
            this.mnuToolsDiff.Name = "mnuToolsDiff";
            this.mnuToolsDiff.Size = new System.Drawing.Size(180, 22);
            this.mnuToolsDiff.Text = "Di&ff..";
            this.mnuToolsDiff.Click += new System.EventHandler(this.MnuToolsDiff_Click);
            // 
            // mnuToolsIV
            // 
            this.mnuToolsIV.Name = "mnuToolsIV";
            this.mnuToolsIV.Size = new System.Drawing.Size(180, 22);
            this.mnuToolsIV.Text = "Info Viewer";
            this.mnuToolsIV.Click += new System.EventHandler(this.MnuToolsIV_Click);
            // 
            // mnuToolsAS
            // 
            this.mnuToolsAS.Name = "mnuToolsAS";
            this.mnuToolsAS.Size = new System.Drawing.Size(180, 22);
            this.mnuToolsAS.Text = "AssetStudio";
            this.mnuToolsAS.Click += new System.EventHandler(this.mnuToolsAS_Click);
            // 
            // mnuWindows
            // 
            this.mnuWindows.Name = "mnuWindows";
            this.mnuWindows.Size = new System.Drawing.Size(68, 20);
            this.mnuWindows.Text = "&Windows";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(180, 22);
            this.mnuHelpAbout.Text = "&About";
            this.mnuHelpAbout.Click += new System.EventHandler(this.MnuHelpAbout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 698);
            this.Controls.Add(this.mainMenu1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MLTDABD Rel";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.mainMenu1.ResumeLayout(false);
            this.mainMenu1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip mainMenu1;

        private System.Windows.Forms.ToolStripMenuItem mnuFile;

        private System.Windows.Forms.ToolStripMenuItem mnuWindows;

        private System.Windows.Forms.ToolStripMenuItem mnuHelp;

        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;

        private System.Windows.Forms.ToolStripMenuItem mnuFileOpenRemote;

        private System.Windows.Forms.ToolStripMenuItem mnuTools;

        private System.Windows.Forms.ToolStripMenuItem mnuToolsDiff;

        private System.Windows.Forms.ToolStripMenuItem mnuFileOpenLocal;

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.OpenFileDialog ofd;
        private ToolStripMenuItem mnuToolsIV;
        private ToolStripMenuItem mnuDLManifest;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuToolsAS;
    }
}