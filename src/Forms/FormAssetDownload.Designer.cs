namespace MLTDABD.Forms
{
    partial class FormAssetDownload
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboHost = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAssetVersion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboResVersion = new System.Windows.Forms.ComboBox();
            this.radResManual = new System.Windows.Forms.RadioButton();
            this.radResLatest = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radPlatformIos = new System.Windows.Forms.RadioButton();
            this.radPlatformAndroid = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host:";
            // 
            // cboHost
            // 
            this.cboHost.FormattingEnabled = true;
            this.cboHost.Items.AddRange(new object[] {
            "td-assets.bn765.com",
            "d2sf4w9bkv485c.cloudfront.net"});
            this.cboHost.Location = new System.Drawing.Point(153, 18);
            this.cboHost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboHost.Name = "cboHost";
            this.cboHost.Size = new System.Drawing.Size(230, 23);
            this.cboHost.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unity Asset Version:";
            // 
            // txtAssetVersion
            // 
            this.txtAssetVersion.Location = new System.Drawing.Point(153, 50);
            this.txtAssetVersion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAssetVersion.Name = "txtAssetVersion";
            this.txtAssetVersion.Size = new System.Drawing.Size(78, 23);
            this.txtAssetVersion.TabIndex = 3;
            this.txtAssetVersion.Text = "2018";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resource Version:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboResVersion);
            this.panel1.Controls.Add(this.radResManual);
            this.panel1.Controls.Add(this.radResLatest);
            this.panel1.Location = new System.Drawing.Point(153, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 52);
            this.panel1.TabIndex = 5;
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
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(153, 210);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(122, 29);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(284, 210);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 29);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Platform:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radPlatformIos);
            this.panel2.Controls.Add(this.radPlatformAndroid);
            this.panel2.Location = new System.Drawing.Point(153, 138);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 37);
            this.panel2.TabIndex = 9;
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
            // FormAssetDownload
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(424, 253);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAssetVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboHost);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAssetDownload";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download Manifest";
            this.Load += new System.EventHandler(this.FManifestDownload_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAssetVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboResVersion;
        private System.Windows.Forms.RadioButton radResManual;
        private System.Windows.Forms.RadioButton radResLatest;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radPlatformIos;
        private System.Windows.Forms.RadioButton radPlatformAndroid;
    }
}