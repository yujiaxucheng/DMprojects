namespace CNCneo.Tool
{
    partial class MainPage
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
            this.lDataFileName = new System.Windows.Forms.Label();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.scProcess = new System.Windows.Forms.SplitContainer();
            this.btnProNo = new System.Windows.Forms.Button();
            this.btnProName = new System.Windows.Forms.Button();
            this.btnProTime = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tlpProcess = new System.Windows.Forms.TableLayoutPanel();
            this.btnProcess1 = new System.Windows.Forms.Button();
            this.pHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scProcess)).BeginInit();
            this.scProcess.Panel1.SuspendLayout();
            this.scProcess.Panel2.SuspendLayout();
            this.scProcess.SuspendLayout();
            this.tlpProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // pHead
            // 
            this.pHead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pHead.Controls.Add(this.btnSaveAs);
            this.pHead.Controls.Add(this.btnSave);
            this.pHead.Controls.Add(this.btnOpen);
            this.pHead.Controls.Add(this.lDataFileName);
            this.pHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHead.Location = new System.Drawing.Point(0, 0);
            this.pHead.Name = "pHead";
            this.pHead.Size = new System.Drawing.Size(1600, 100);
            this.pHead.TabIndex = 0;
            // 
            // lDataFileName
            // 
            this.lDataFileName.AutoSize = true;
            this.lDataFileName.Font = new System.Drawing.Font("宋体", 28F);
            this.lDataFileName.Location = new System.Drawing.Point(553, 23);
            this.lDataFileName.Name = "lDataFileName";
            this.lDataFileName.Size = new System.Drawing.Size(255, 47);
            this.lDataFileName.TabIndex = 1;
            this.lDataFileName.Text = "数据文件名";
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
            this.scMain.Panel1.Controls.Add(this.scProcess);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.btnConfirm);
            this.scMain.Size = new System.Drawing.Size(1600, 800);
            this.scMain.SplitterDistance = 500;
            this.scMain.TabIndex = 1;
            // 
            // scProcess
            // 
            this.scProcess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scProcess.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scProcess.IsSplitterFixed = true;
            this.scProcess.Location = new System.Drawing.Point(0, 0);
            this.scProcess.Name = "scProcess";
            this.scProcess.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scProcess.Panel1
            // 
            this.scProcess.Panel1.Controls.Add(this.tlpProcess);
            // 
            // scProcess.Panel2
            // 
            this.scProcess.Panel2.Controls.Add(this.btnLoad);
            this.scProcess.Size = new System.Drawing.Size(500, 800);
            this.scProcess.SplitterDistance = 500;
            this.scProcess.TabIndex = 0;
            // 
            // btnProNo
            // 
            this.btnProNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProNo.Font = new System.Drawing.Font("宋体", 16F);
            this.btnProNo.Location = new System.Drawing.Point(5, 5);
            this.btnProNo.Name = "btnProNo";
            this.btnProNo.Size = new System.Drawing.Size(91, 41);
            this.btnProNo.TabIndex = 0;
            this.btnProNo.Text = "序号";
            this.btnProNo.UseVisualStyleBackColor = true;
            // 
            // btnProName
            // 
            this.btnProName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProName.Font = new System.Drawing.Font("宋体", 16F);
            this.btnProName.Location = new System.Drawing.Point(104, 5);
            this.btnProName.Name = "btnProName";
            this.btnProName.Size = new System.Drawing.Size(286, 41);
            this.btnProName.TabIndex = 0;
            this.btnProName.Text = "工序";
            this.btnProName.UseVisualStyleBackColor = true;
            // 
            // btnProTime
            // 
            this.btnProTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProTime.Font = new System.Drawing.Font("宋体", 16F);
            this.btnProTime.Location = new System.Drawing.Point(398, 5);
            this.btnProTime.Name = "btnProTime";
            this.btnProTime.Size = new System.Drawing.Size(93, 41);
            this.btnProTime.TabIndex = 0;
            this.btnProTime.Text = "时间";
            this.btnProTime.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("宋体", 20F);
            this.btnConfirm.Location = new System.Drawing.Point(889, 729);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(200, 64);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("宋体", 18F);
            this.btnOpen.Location = new System.Drawing.Point(3, 18);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(160, 56);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 18F);
            this.btnSave.Location = new System.Drawing.Point(168, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 56);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Font = new System.Drawing.Font("宋体", 18F);
            this.btnSaveAs.Location = new System.Drawing.Point(333, 18);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(160, 56);
            this.btnSaveAs.TabIndex = 2;
            this.btnSaveAs.Text = "另存为...";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoad.Font = new System.Drawing.Font("宋体", 32F);
            this.btnLoad.Location = new System.Drawing.Point(0, 0);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(496, 292);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "开始运行";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // tlpProcess
            // 
            this.tlpProcess.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpProcess.ColumnCount = 3;
            this.tlpProcess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpProcess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpProcess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpProcess.Controls.Add(this.btnProcess1, 1, 1);
            this.tlpProcess.Controls.Add(this.btnProNo, 0, 0);
            this.tlpProcess.Controls.Add(this.btnProTime, 2, 0);
            this.tlpProcess.Controls.Add(this.btnProName, 1, 0);
            this.tlpProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpProcess.Location = new System.Drawing.Point(0, 0);
            this.tlpProcess.Name = "tlpProcess";
            this.tlpProcess.RowCount = 2;
            this.tlpProcess.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProcess.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProcess.Size = new System.Drawing.Size(496, 100);
            this.tlpProcess.TabIndex = 0;
            // 
            // btnProcess1
            // 
            this.btnProcess1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProcess1.Font = new System.Drawing.Font("宋体", 16F);
            this.btnProcess1.Location = new System.Drawing.Point(104, 54);
            this.btnProcess1.Name = "btnProcess1";
            this.btnProcess1.Size = new System.Drawing.Size(286, 41);
            this.btnProcess1.TabIndex = 1;
            this.btnProcess1.Text = "工序1";
            this.btnProcess1.UseVisualStyleBackColor = true;
            this.btnProcess1.Click += new System.EventHandler(this.btnProcess1_Click);
            // 
            // MainPage
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
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FSub";
            this.pHead.ResumeLayout(false);
            this.pHead.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.scProcess.Panel1.ResumeLayout(false);
            this.scProcess.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scProcess)).EndInit();
            this.scProcess.ResumeLayout(false);
            this.tlpProcess.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pHead;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lDataFileName;
        private System.Windows.Forms.SplitContainer scProcess;
        private System.Windows.Forms.Button btnProNo;
        private System.Windows.Forms.Button btnProName;
        private System.Windows.Forms.Button btnProTime;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TableLayoutPanel tlpProcess;
        private System.Windows.Forms.Button btnProcess1;
    }
}