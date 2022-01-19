namespace MLTDABD.Forms
{
    partial class AssetTreeList
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.lv = new MLTDABD.Forms.ExplorerListView();
            this.tv = new MLTDABD.Forms.ExplorerTreeView();
            this.SuspendLayout();
            // 
            // lv
            // 
            this.lv.FullRowSelect = true;
            this.lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv.Location = new System.Drawing.Point(53, 42);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(232, 178);
            this.lv.TabIndex = 0;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Lv_MouseDoubleClick);
            this.lv.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Lv_MouseUp);
            // 
            // tv
            // 
            this.tv.Location = new System.Drawing.Point(277, 105);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(281, 233);
            this.tv.TabIndex = 1;
            this.tv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Tv_MouseDoubleClick);
            this.tv.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tv_MouseUp);
            // 
            // AssetTreeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tv);
            this.Controls.Add(this.lv);
            this.Name = "AssetTreeList";
            this.Size = new System.Drawing.Size(607, 441);
            this.Resize += new System.EventHandler(this.UserControl_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private MLTDABD.Forms.ExplorerListView lv;
        private MLTDABD.Forms.ExplorerTreeView tv;
    }
}
