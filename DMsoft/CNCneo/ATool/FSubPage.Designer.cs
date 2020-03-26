namespace CNCneo.Tool
{
    partial class FSubPage
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
            this.pHead = new System.Windows.Forms.Panel();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lPageTitle = new System.Windows.Forms.Label();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.pHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pHead
            // 
            this.pHead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pHead.Controls.Add(this.lPageTitle);
            this.pHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHead.Location = new System.Drawing.Point(0, 0);
            this.pHead.Name = "pHead";
            this.pHead.Size = new System.Drawing.Size(1600, 100);
            this.pHead.TabIndex = 0;
            // 
            // scMain
            // 
            this.scMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 100);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.pbMain);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.btnConfirm);
            this.scMain.Size = new System.Drawing.Size(1600, 800);
            this.scMain.SplitterDistance = 350;
            this.scMain.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("宋体", 20F);
            this.btnConfirm.Location = new System.Drawing.Point(1039, 729);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(200, 64);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lPageTitle
            // 
            this.lPageTitle.AutoSize = true;
            this.lPageTitle.Font = new System.Drawing.Font("宋体", 28F);
            this.lPageTitle.Location = new System.Drawing.Point(350, 25);
            this.lPageTitle.Name = "lPageTitle";
            this.lPageTitle.Size = new System.Drawing.Size(349, 47);
            this.lPageTitle.TabIndex = 1;
            this.lPageTitle.Text = "其他参数界面名";
            // 
            // pbMain
            // 
            this.pbMain.Location = new System.Drawing.Point(1, 1);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(350, 350);
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            // 
            // FSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.ControlBox = false;
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.pHead);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FSub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FSub";
            this.pHead.ResumeLayout(false);
            this.pHead.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pHead;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lPageTitle;
        private System.Windows.Forms.PictureBox pbMain;
    }
}