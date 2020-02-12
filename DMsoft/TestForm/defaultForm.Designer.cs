namespace TestForm
{
    partial class defaultForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbFileOrFolderName = new System.Windows.Forms.TextBox();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.tbFileOrFolderName2 = new System.Windows.Forms.TextBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFileOrFolderName
            // 
            this.tbFileOrFolderName.Font = new System.Drawing.Font("宋体", 12F);
            this.tbFileOrFolderName.Location = new System.Drawing.Point(102, 83);
            this.tbFileOrFolderName.Name = "tbFileOrFolderName";
            this.tbFileOrFolderName.Size = new System.Drawing.Size(646, 30);
            this.tbFileOrFolderName.TabIndex = 0;
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Font = new System.Drawing.Font("宋体", 12F);
            this.btnChooseFolder.Location = new System.Drawing.Point(769, 83);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(75, 30);
            this.btnChooseFolder.TabIndex = 1;
            this.btnChooseFolder.Text = "…";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // tbFileOrFolderName2
            // 
            this.tbFileOrFolderName2.Font = new System.Drawing.Font("宋体", 12F);
            this.tbFileOrFolderName2.Location = new System.Drawing.Point(102, 156);
            this.tbFileOrFolderName2.Name = "tbFileOrFolderName2";
            this.tbFileOrFolderName2.Size = new System.Drawing.Size(646, 30);
            this.tbFileOrFolderName2.TabIndex = 0;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Font = new System.Drawing.Font("宋体", 12F);
            this.btnChooseFile.Location = new System.Drawing.Point(769, 156);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 30);
            this.btnChooseFile.TabIndex = 1;
            this.btnChooseFile.Text = "…";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("宋体", 16F);
            this.btnStart.Location = new System.Drawing.Point(112, 505);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(215, 41);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "打开Excel";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // defaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 613);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.btnChooseFolder);
            this.Controls.Add(this.tbFileOrFolderName2);
            this.Controls.Add(this.tbFileOrFolderName);
            this.Name = "defaultForm";
            this.Text = "默认窗口";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFileOrFolderName;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.TextBox tbFileOrFolderName2;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnStart;
    }
}

