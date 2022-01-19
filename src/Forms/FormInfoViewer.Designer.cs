namespace MLTDABD.Forms
{
    partial class FormIV
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnManifestFilterRegex = new System.Windows.Forms.Button();
            this.btnManifestReset = new System.Windows.Forms.Button();
            this.btnManifestFilterString = new System.Windows.Forms.Button();
            this.txtManifestFilter = new System.Windows.Forms.TextBox();
            this.lvwManifest = new System.Windows.Forms.ListView();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxMenuDownloadSelectedAssets = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelectManifestDatabase = new System.Windows.Forms.Button();
            this.txtManifestDatabasePath = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvwCards = new System.Windows.Forms.ListView();
            this.btnSelectCardsDatabase = new System.Windows.Forms.Button();
            this.txtCardsDatabasePath = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lvwCostumes = new System.Windows.Forms.ListView();
            this.btnSelectCostumesDatabase = new System.Windows.Forms.Button();
            this.txtCostumesDatabasePath = new System.Windows.Forms.TextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ctxMenu.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(14, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(821, 465);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnManifestFilterRegex);
            this.tabPage1.Controls.Add(this.btnManifestReset);
            this.tabPage1.Controls.Add(this.btnManifestFilterString);
            this.tabPage1.Controls.Add(this.txtManifestFilter);
            this.tabPage1.Controls.Add(this.lvwManifest);
            this.tabPage1.Controls.Add(this.btnSelectManifestDatabase);
            this.tabPage1.Controls.Add(this.txtManifestDatabasePath);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(813, 437);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Manifest";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnManifestFilterRegex
            // 
            this.btnManifestFilterRegex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManifestFilterRegex.Location = new System.Drawing.Point(634, 399);
            this.btnManifestFilterRegex.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnManifestFilterRegex.Name = "btnManifestFilterRegex";
            this.btnManifestFilterRegex.Size = new System.Drawing.Size(82, 27);
            this.btnManifestFilterRegex.TabIndex = 9;
            this.btnManifestFilterRegex.Text = "Regex";
            this.btnManifestFilterRegex.UseVisualStyleBackColor = true;
            this.btnManifestFilterRegex.Click += new System.EventHandler(this.BtnManifestFilterRegex_Click);
            // 
            // btnManifestReset
            // 
            this.btnManifestReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManifestReset.Location = new System.Drawing.Point(722, 399);
            this.btnManifestReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnManifestReset.Name = "btnManifestReset";
            this.btnManifestReset.Size = new System.Drawing.Size(82, 27);
            this.btnManifestReset.TabIndex = 8;
            this.btnManifestReset.Text = "Reset";
            this.btnManifestReset.UseVisualStyleBackColor = true;
            this.btnManifestReset.Click += new System.EventHandler(this.BtnManifestReset_Click);
            // 
            // btnManifestFilterString
            // 
            this.btnManifestFilterString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManifestFilterString.Location = new System.Drawing.Point(545, 399);
            this.btnManifestFilterString.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnManifestFilterString.Name = "btnManifestFilterString";
            this.btnManifestFilterString.Size = new System.Drawing.Size(82, 27);
            this.btnManifestFilterString.TabIndex = 7;
            this.btnManifestFilterString.Text = "String";
            this.btnManifestFilterString.UseVisualStyleBackColor = true;
            this.btnManifestFilterString.Click += new System.EventHandler(this.BtnManifestFilter_Click);
            // 
            // txtManifestFilter
            // 
            this.txtManifestFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtManifestFilter.Location = new System.Drawing.Point(7, 399);
            this.txtManifestFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtManifestFilter.Name = "txtManifestFilter";
            this.txtManifestFilter.Size = new System.Drawing.Size(530, 23);
            this.txtManifestFilter.TabIndex = 6;
            // 
            // lvwManifest
            // 
            this.lvwManifest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwManifest.ContextMenuStrip = this.ctxMenu;
            this.lvwManifest.FullRowSelect = true;
            this.lvwManifest.Location = new System.Drawing.Point(6, 42);
            this.lvwManifest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwManifest.Name = "lvwManifest";
            this.lvwManifest.Size = new System.Drawing.Size(797, 348);
            this.lvwManifest.TabIndex = 5;
            this.lvwManifest.UseCompatibleStateImageBehavior = false;
            this.lvwManifest.View = System.Windows.Forms.View.Details;
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenuDownloadSelectedAssets});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(229, 26);
            // 
            // ctxMenuDownloadSelectedAssets
            // 
            this.ctxMenuDownloadSelectedAssets.Name = "ctxMenuDownloadSelectedAssets";
            this.ctxMenuDownloadSelectedAssets.Size = new System.Drawing.Size(228, 22);
            this.ctxMenuDownloadSelectedAssets.Text = "&Download Selected Asset(s)...";
            // 
            // btnSelectManifestDatabase
            // 
            this.btnSelectManifestDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectManifestDatabase.Location = new System.Drawing.Point(726, 8);
            this.btnSelectManifestDatabase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSelectManifestDatabase.Name = "btnSelectManifestDatabase";
            this.btnSelectManifestDatabase.Size = new System.Drawing.Size(82, 27);
            this.btnSelectManifestDatabase.TabIndex = 4;
            this.btnSelectManifestDatabase.Text = "Select...";
            this.btnSelectManifestDatabase.UseVisualStyleBackColor = true;
            this.btnSelectManifestDatabase.Click += new System.EventHandler(this.BtnSelectManifestDatabase_Click);
            // 
            // txtManifestDatabasePath
            // 
            this.txtManifestDatabasePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtManifestDatabasePath.Location = new System.Drawing.Point(6, 8);
            this.txtManifestDatabasePath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtManifestDatabasePath.Name = "txtManifestDatabasePath";
            this.txtManifestDatabasePath.ReadOnly = true;
            this.txtManifestDatabasePath.Size = new System.Drawing.Size(712, 23);
            this.txtManifestDatabasePath.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvwCards);
            this.tabPage2.Controls.Add(this.btnSelectCardsDatabase);
            this.tabPage2.Controls.Add(this.txtCardsDatabasePath);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(813, 437);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Cards";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvwCards
            // 
            this.lvwCards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwCards.FullRowSelect = true;
            this.lvwCards.Location = new System.Drawing.Point(7, 42);
            this.lvwCards.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwCards.Name = "lvwCards";
            this.lvwCards.Size = new System.Drawing.Size(797, 382);
            this.lvwCards.TabIndex = 2;
            this.lvwCards.UseCompatibleStateImageBehavior = false;
            this.lvwCards.View = System.Windows.Forms.View.Details;
            // 
            // btnSelectCardsDatabase
            // 
            this.btnSelectCardsDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectCardsDatabase.Location = new System.Drawing.Point(727, 8);
            this.btnSelectCardsDatabase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSelectCardsDatabase.Name = "btnSelectCardsDatabase";
            this.btnSelectCardsDatabase.Size = new System.Drawing.Size(82, 27);
            this.btnSelectCardsDatabase.TabIndex = 1;
            this.btnSelectCardsDatabase.Text = "Select...";
            this.btnSelectCardsDatabase.UseVisualStyleBackColor = true;
            this.btnSelectCardsDatabase.Click += new System.EventHandler(this.BtnSelectCardsDatabase_Click);
            // 
            // txtCardsDatabasePath
            // 
            this.txtCardsDatabasePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCardsDatabasePath.Location = new System.Drawing.Point(7, 8);
            this.txtCardsDatabasePath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCardsDatabasePath.Name = "txtCardsDatabasePath";
            this.txtCardsDatabasePath.ReadOnly = true;
            this.txtCardsDatabasePath.Size = new System.Drawing.Size(712, 23);
            this.txtCardsDatabasePath.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lvwCostumes);
            this.tabPage3.Controls.Add(this.btnSelectCostumesDatabase);
            this.tabPage3.Controls.Add(this.txtCostumesDatabasePath);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Size = new System.Drawing.Size(813, 437);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Costumes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lvwCostumes
            // 
            this.lvwCostumes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwCostumes.FullRowSelect = true;
            this.lvwCostumes.Location = new System.Drawing.Point(6, 42);
            this.lvwCostumes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwCostumes.Name = "lvwCostumes";
            this.lvwCostumes.Size = new System.Drawing.Size(797, 382);
            this.lvwCostumes.TabIndex = 5;
            this.lvwCostumes.UseCompatibleStateImageBehavior = false;
            this.lvwCostumes.View = System.Windows.Forms.View.Details;
            // 
            // btnSelectCostumesDatabase
            // 
            this.btnSelectCostumesDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectCostumesDatabase.Location = new System.Drawing.Point(726, 8);
            this.btnSelectCostumesDatabase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSelectCostumesDatabase.Name = "btnSelectCostumesDatabase";
            this.btnSelectCostumesDatabase.Size = new System.Drawing.Size(82, 27);
            this.btnSelectCostumesDatabase.TabIndex = 4;
            this.btnSelectCostumesDatabase.Text = "Select...";
            this.btnSelectCostumesDatabase.UseVisualStyleBackColor = true;
            this.btnSelectCostumesDatabase.Click += new System.EventHandler(this.BtnSelectCostumesDatabase_Click);
            // 
            // txtCostumesDatabasePath
            // 
            this.txtCostumesDatabasePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCostumesDatabasePath.Location = new System.Drawing.Point(6, 8);
            this.txtCostumesDatabasePath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCostumesDatabasePath.Name = "txtCostumesDatabasePath";
            this.txtCostumesDatabasePath.ReadOnly = true;
            this.txtCostumesDatabasePath.Size = new System.Drawing.Size(712, 23);
            this.txtCostumesDatabasePath.TabIndex = 3;
            // 
            // FormIV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 495);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormIV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info Viewer";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ctxMenu.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnManifestFilterRegex;
        private System.Windows.Forms.Button btnManifestFilterString;
        private System.Windows.Forms.Button btnManifestReset;
        private System.Windows.Forms.Button btnSelectCardsDatabase;
        private System.Windows.Forms.Button btnSelectCostumesDatabase;
        private System.Windows.Forms.Button btnSelectManifestDatabase;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuDownloadSelectedAssets;
        private System.Windows.Forms.ListView lvwCards;
        private System.Windows.Forms.ListView lvwCostumes;
        private System.Windows.Forms.ListView lvwManifest;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtCardsDatabasePath;
        private System.Windows.Forms.TextBox txtCostumesDatabasePath;
        private System.Windows.Forms.TextBox txtManifestDatabasePath;
        private System.Windows.Forms.TextBox txtManifestFilter;

        #endregion

    }
}