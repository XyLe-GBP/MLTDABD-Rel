namespace MLTDABD.Forms
{
    partial class FormDownload
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboResVersion = new System.Windows.Forms.ComboBox();
            this.radResManual = new System.Windows.Forms.RadioButton();
            this.radResLatest = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radPlatformIos = new System.Windows.Forms.RadioButton();
            this.radPlatformAndroid = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAssetVersion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboHost = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvState = new MLTDABD.Forms.ExplorerListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.txtSaveToDir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalSize = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtAssetVersion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboHost);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 167);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cboResVersion);
            this.panel3.Controls.Add(this.radResManual);
            this.panel3.Controls.Add(this.radResLatest);
            this.panel3.Location = new System.Drawing.Point(145, 65);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 52);
            this.panel3.TabIndex = 31;
            // 
            // cboResVersion
            // 
            this.cboResVersion.Enabled = false;
            this.cboResVersion.FormattingEnabled = true;
            this.cboResVersion.Location = new System.Drawing.Point(84, 25);
            this.cboResVersion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboResVersion.Name = "cboResVersion";
            this.cboResVersion.Size = new System.Drawing.Size(146, 23);
            this.cboResVersion.TabIndex = 2;
            // 
            // radResManual
            // 
            this.radResManual.AutoSize = true;
            this.radResManual.Location = new System.Drawing.Point(4, 27);
            this.radResManual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radResManual.Name = "radResManual";
            this.radResManual.Size = new System.Drawing.Size(66, 19);
            this.radResManual.TabIndex = 1;
            this.radResManual.Text = "Specify:";
            this.radResManual.UseVisualStyleBackColor = true;
            this.radResManual.Click += new System.EventHandler(this.RadResManual_Click);
            // 
            // radResLatest
            // 
            this.radResLatest.AutoSize = true;
            this.radResLatest.Checked = true;
            this.radResLatest.Location = new System.Drawing.Point(4, 0);
            this.radResLatest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radResLatest.Name = "radResLatest";
            this.radResLatest.Size = new System.Drawing.Size(56, 19);
            this.radResLatest.TabIndex = 0;
            this.radResLatest.TabStop = true;
            this.radResLatest.Text = "Latest";
            this.radResLatest.UseVisualStyleBackColor = true;
            this.radResLatest.Click += new System.EventHandler(this.RadResLatest_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Resource Version:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radPlatformIos);
            this.panel2.Controls.Add(this.radPlatformAndroid);
            this.panel2.Location = new System.Drawing.Point(145, 123);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 37);
            this.panel2.TabIndex = 25;
            // 
            // radPlatformIos
            // 
            this.radPlatformIos.AutoSize = true;
            this.radPlatformIos.Location = new System.Drawing.Point(131, 8);
            this.radPlatformIos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radPlatformIos.Name = "radPlatformIos";
            this.radPlatformIos.Size = new System.Drawing.Size(43, 19);
            this.radPlatformIos.TabIndex = 3;
            this.radPlatformIos.Text = "iOS";
            this.radPlatformIos.UseVisualStyleBackColor = true;
            // 
            // radPlatformAndroid
            // 
            this.radPlatformAndroid.AutoSize = true;
            this.radPlatformAndroid.Checked = true;
            this.radPlatformAndroid.Location = new System.Drawing.Point(4, 8);
            this.radPlatformAndroid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radPlatformAndroid.Name = "radPlatformAndroid";
            this.radPlatformAndroid.Size = new System.Drawing.Size(68, 19);
            this.radPlatformAndroid.TabIndex = 2;
            this.radPlatformAndroid.TabStop = true;
            this.radPlatformAndroid.Text = "Android";
            this.radPlatformAndroid.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Platform:";
            // 
            // txtAssetVersion
            // 
            this.txtAssetVersion.Location = new System.Drawing.Point(144, 35);
            this.txtAssetVersion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAssetVersion.Name = "txtAssetVersion";
            this.txtAssetVersion.Size = new System.Drawing.Size(78, 23);
            this.txtAssetVersion.TabIndex = 22;
            this.txtAssetVersion.Text = "2018";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Unity Asset Version:";
            // 
            // cboHost
            // 
            this.cboHost.FormattingEnabled = true;
            this.cboHost.Items.AddRange(new object[] {
            "td-assets.bn765.com",
            "d2sf4w9bkv485c.cloudfront.net"});
            this.cboHost.Location = new System.Drawing.Point(144, 3);
            this.cboHost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboHost.Name = "cboHost";
            this.cboHost.Size = new System.Drawing.Size(230, 23);
            this.cboHost.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Host:";
            // 
            // lvState
            // 
            this.lvState.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvState.FullRowSelect = true;
            this.lvState.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvState.Location = new System.Drawing.Point(422, 14);
            this.lvState.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvState.Name = "lvState";
            this.lvState.Size = new System.Drawing.Size(384, 504);
            this.lvState.TabIndex = 4;
            this.lvState.UseCompatibleStateImageBehavior = false;
            this.lvState.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Downloaded";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Size";
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(14, 258);
            this.pb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(401, 28);
            this.pb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb.TabIndex = 5;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(14, 240);
            this.lblCurrent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(60, 15);
            this.lblCurrent.TabIndex = 6;
            this.lblCurrent.Text = "10%: A.txt";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(163, 489);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(122, 29);
            this.btnGo.TabIndex = 7;
            this.btnGo.Text = "&Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(293, 489);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 29);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnBrowseFolder);
            this.panel4.Controls.Add(this.txtSaveToDir);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(14, 188);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(401, 48);
            this.panel4.TabIndex = 9;
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Location = new System.Drawing.Point(351, 5);
            this.btnBrowseFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(47, 29);
            this.btnBrowseFolder.TabIndex = 32;
            this.btnBrowseFolder.Text = "...";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.BtnBrowseFolder_Click);
            // 
            // txtSaveToDir
            // 
            this.txtSaveToDir.Location = new System.Drawing.Point(72, 8);
            this.txtSaveToDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSaveToDir.Name = "txtSaveToDir";
            this.txtSaveToDir.Size = new System.Drawing.Size(271, 23);
            this.txtSaveToDir.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Save To:";
            // 
            // lblTotalSize
            // 
            this.lblTotalSize.AutoSize = true;
            this.lblTotalSize.Location = new System.Drawing.Point(10, 290);
            this.lblTotalSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalSize.Name = "lblTotalSize";
            this.lblTotalSize.Size = new System.Drawing.Size(60, 15);
            this.lblTotalSize.TabIndex = 10;
            this.lblTotalSize.Text = "10%: A.txt";
            // 
            // FormDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 532);
            this.Controls.Add(this.lblTotalSize);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.lvState);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDownload";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset Download";
            this.Load += new System.EventHandler(this.FAssetDownload_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radPlatformIos;
        private System.Windows.Forms.RadioButton radPlatformAndroid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAssetVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboHost;
        private System.Windows.Forms.Label label1;
        private ExplorerListView lvState;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboResVersion;
        private System.Windows.Forms.RadioButton radResManual;
        private System.Windows.Forms.RadioButton radResLatest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.TextBox txtSaveToDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalSize;
    }
}