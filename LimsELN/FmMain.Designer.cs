namespace LimsELN
{
    partial class FmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExportAll = new System.Windows.Forms.Button();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnExportAll
            // 
            this.btnExportAll.Location = new System.Drawing.Point(13, 13);
            this.btnExportAll.Name = "btnExportAll";
            this.btnExportAll.Size = new System.Drawing.Size(114, 36);
            this.btnExportAll.TabIndex = 0;
            this.btnExportAll.Text = "导出全部ELN";
            this.btnExportAll.UseVisualStyleBackColor = true;
            this.btnExportAll.Click += new System.EventHandler(this.btnExportAll_Click);
            // 
            // pb
            // 
            this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb.Location = new System.Drawing.Point(13, 76);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(575, 23);
            this.pb.TabIndex = 1;
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 111);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.btnExportAll);
            this.Name = "FmMain";
            this.Text = "Starlim ELN管理";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExportAll;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.ProgressBar pb;
    }
}

