namespace CNCneo
{
    partial class winMain
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
            this.pHead = new System.Windows.Forms.Panel();
            this.cbLan = new System.Windows.Forms.ComboBox();
            this.lMachineNo = new System.Windows.Forms.Label();
            this.lVersion = new System.Windows.Forms.Label();
            this.lTM = new System.Windows.Forms.Label();
            this.pMachine = new System.Windows.Forms.Panel();
            this.pWheel = new System.Windows.Forms.Panel();
            this.pProduct = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.rdoP6 = new System.Windows.Forms.RadioButton();
            this.rdoP7 = new System.Windows.Forms.RadioButton();
            this.rdoP5 = new System.Windows.Forms.RadioButton();
            this.rdoP4 = new System.Windows.Forms.RadioButton();
            this.rdoP3 = new System.Windows.Forms.RadioButton();
            this.rdoP2 = new System.Windows.Forms.RadioButton();
            this.rdoP1 = new System.Windows.Forms.RadioButton();
            this.btnQuit = new System.Windows.Forms.Button();
            this.scWheel = new System.Windows.Forms.SplitContainer();
            this.dgvGroup1 = new System.Windows.Forms.DataGridView();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.Whl1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Whl2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Whl3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Whl4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGroup2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.btnSetting = new System.Windows.Forms.Button();
            this.pHead.SuspendLayout();
            this.pMachine.SuspendLayout();
            this.pWheel.SuspendLayout();
            this.pProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scWheel)).BeginInit();
            this.scWheel.Panel1.SuspendLayout();
            this.scWheel.Panel2.SuspendLayout();
            this.scWheel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.SuspendLayout();
            // 
            // pHead
            // 
            this.pHead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pHead.Controls.Add(this.cbLan);
            this.pHead.Controls.Add(this.lMachineNo);
            this.pHead.Controls.Add(this.lVersion);
            this.pHead.Controls.Add(this.lTM);
            this.pHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHead.Location = new System.Drawing.Point(0, 0);
            this.pHead.Name = "pHead";
            this.pHead.Size = new System.Drawing.Size(1600, 125);
            this.pHead.TabIndex = 0;
            // 
            // cbLan
            // 
            this.cbLan.FormattingEnabled = true;
            this.cbLan.Items.AddRange(new object[] {
            "中文简体",
            "中文繁体",
            "English"});
            this.cbLan.Location = new System.Drawing.Point(1360, 76);
            this.cbLan.Name = "cbLan";
            this.cbLan.Size = new System.Drawing.Size(199, 28);
            this.cbLan.TabIndex = 21;
            this.cbLan.Text = "界面语言";
            // 
            // lMachineNo
            // 
            this.lMachineNo.AutoSize = true;
            this.lMachineNo.Location = new System.Drawing.Point(782, 84);
            this.lMachineNo.Name = "lMachineNo";
            this.lMachineNo.Size = new System.Drawing.Size(139, 20);
            this.lMachineNo.TabIndex = 20;
            this.lMachineNo.Text = "No.2003230001";
            // 
            // lVersion
            // 
            this.lVersion.AutoSize = true;
            this.lVersion.Location = new System.Drawing.Point(37, 84);
            this.lVersion.Name = "lVersion";
            this.lVersion.Size = new System.Drawing.Size(249, 20);
            this.lVersion.TabIndex = 19;
            this.lVersion.Text = "Version 1.0.0.0.20200323";
            // 
            // lTM
            // 
            this.lTM.AutoSize = true;
            this.lTM.Font = new System.Drawing.Font("宋体", 36F);
            this.lTM.Location = new System.Drawing.Point(669, 3);
            this.lTM.Name = "lTM";
            this.lTM.Size = new System.Drawing.Size(295, 60);
            this.lTM.TabIndex = 18;
            this.lTM.Text = "TradeMark";
            // 
            // pMachine
            // 
            this.pMachine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pMachine.Controls.Add(this.btnQuit);
            this.pMachine.Controls.Add(this.btnSetting);
            this.pMachine.Controls.Add(this.btnLogin);
            this.pMachine.Dock = System.Windows.Forms.DockStyle.Right;
            this.pMachine.Location = new System.Drawing.Point(1300, 125);
            this.pMachine.Name = "pMachine";
            this.pMachine.Size = new System.Drawing.Size(300, 775);
            this.pMachine.TabIndex = 1;
            // 
            // pWheel
            // 
            this.pWheel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pWheel.Controls.Add(this.scWheel);
            this.pWheel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pWheel.Location = new System.Drawing.Point(0, 450);
            this.pWheel.Name = "pWheel";
            this.pWheel.Size = new System.Drawing.Size(1300, 450);
            this.pWheel.TabIndex = 2;
            // 
            // pProduct
            // 
            this.pProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pProduct.Controls.Add(this.rdoP6);
            this.pProduct.Controls.Add(this.rdoP7);
            this.pProduct.Controls.Add(this.rdoP5);
            this.pProduct.Controls.Add(this.rdoP4);
            this.pProduct.Controls.Add(this.rdoP3);
            this.pProduct.Controls.Add(this.rdoP2);
            this.pProduct.Controls.Add(this.rdoP1);
            this.pProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pProduct.Location = new System.Drawing.Point(0, 125);
            this.pProduct.Name = "pProduct";
            this.pProduct.Size = new System.Drawing.Size(1300, 325);
            this.pProduct.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("宋体", 16F);
            this.btnLogin.Location = new System.Drawing.Point(3, 74);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(256, 64);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "进入系统";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // rdoP6
            // 
            this.rdoP6.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoP6.Location = new System.Drawing.Point(215, 174);
            this.rdoP6.Name = "rdoP6";
            this.rdoP6.Size = new System.Drawing.Size(130, 125);
            this.rdoP6.TabIndex = 14;
            this.rdoP6.TabStop = true;
            this.rdoP6.Text = "产品6";
            this.rdoP6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.rdoP6.UseVisualStyleBackColor = true;
            // 
            // rdoP7
            // 
            this.rdoP7.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoP7.Location = new System.Drawing.Point(397, 174);
            this.rdoP7.Name = "rdoP7";
            this.rdoP7.Size = new System.Drawing.Size(130, 125);
            this.rdoP7.TabIndex = 15;
            this.rdoP7.TabStop = true;
            this.rdoP7.Text = "产品7";
            this.rdoP7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.rdoP7.UseVisualStyleBackColor = true;
            // 
            // rdoP5
            // 
            this.rdoP5.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoP5.Location = new System.Drawing.Point(33, 174);
            this.rdoP5.Name = "rdoP5";
            this.rdoP5.Size = new System.Drawing.Size(130, 125);
            this.rdoP5.TabIndex = 17;
            this.rdoP5.TabStop = true;
            this.rdoP5.Text = "产品5";
            this.rdoP5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.rdoP5.UseVisualStyleBackColor = true;
            // 
            // rdoP4
            // 
            this.rdoP4.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoP4.Location = new System.Drawing.Point(585, 24);
            this.rdoP4.Name = "rdoP4";
            this.rdoP4.Size = new System.Drawing.Size(130, 125);
            this.rdoP4.TabIndex = 19;
            this.rdoP4.TabStop = true;
            this.rdoP4.Text = "产品4";
            this.rdoP4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.rdoP4.UseVisualStyleBackColor = true;
            // 
            // rdoP3
            // 
            this.rdoP3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoP3.Location = new System.Drawing.Point(401, 24);
            this.rdoP3.Name = "rdoP3";
            this.rdoP3.Size = new System.Drawing.Size(130, 125);
            this.rdoP3.TabIndex = 21;
            this.rdoP3.TabStop = true;
            this.rdoP3.Text = "产品3";
            this.rdoP3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.rdoP3.UseVisualStyleBackColor = true;
            // 
            // rdoP2
            // 
            this.rdoP2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoP2.Location = new System.Drawing.Point(217, 24);
            this.rdoP2.Name = "rdoP2";
            this.rdoP2.Size = new System.Drawing.Size(130, 125);
            this.rdoP2.TabIndex = 23;
            this.rdoP2.TabStop = true;
            this.rdoP2.Text = "产品2";
            this.rdoP2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.rdoP2.UseVisualStyleBackColor = true;
            // 
            // rdoP1
            // 
            this.rdoP1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoP1.Location = new System.Drawing.Point(33, 24);
            this.rdoP1.Name = "rdoP1";
            this.rdoP1.Size = new System.Drawing.Size(130, 125);
            this.rdoP1.TabIndex = 24;
            this.rdoP1.TabStop = true;
            this.rdoP1.Text = "产品1";
            this.rdoP1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.rdoP1.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("宋体", 16F);
            this.btnQuit.Location = new System.Drawing.Point(3, 144);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(256, 64);
            this.btnQuit.TabIndex = 14;
            this.btnQuit.Text = "退出软件";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // scWheel
            // 
            this.scWheel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scWheel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scWheel.Location = new System.Drawing.Point(0, 0);
            this.scWheel.Name = "scWheel";
            // 
            // scWheel.Panel1
            // 
            this.scWheel.Panel1.Controls.Add(this.pb1);
            this.scWheel.Panel1.Controls.Add(this.dgvGroup1);
            // 
            // scWheel.Panel2
            // 
            this.scWheel.Panel2.Controls.Add(this.pb2);
            this.scWheel.Panel2.Controls.Add(this.dgvGroup2);
            this.scWheel.Size = new System.Drawing.Size(1296, 446);
            this.scWheel.SplitterDistance = 648;
            this.scWheel.TabIndex = 0;
            // 
            // dgvGroup1
            // 
            this.dgvGroup1.AllowUserToAddRows = false;
            this.dgvGroup1.AllowUserToDeleteRows = false;
            this.dgvGroup1.AllowUserToResizeColumns = false;
            this.dgvGroup1.AllowUserToResizeRows = false;
            this.dgvGroup1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroup1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Whl1,
            this.Whl2,
            this.Whl3,
            this.Whl4});
            this.dgvGroup1.Location = new System.Drawing.Point(3, 5);
            this.dgvGroup1.Name = "dgvGroup1";
            this.dgvGroup1.ReadOnly = true;
            this.dgvGroup1.RowHeadersVisible = false;
            this.dgvGroup1.RowTemplate.Height = 27;
            this.dgvGroup1.Size = new System.Drawing.Size(640, 72);
            this.dgvGroup1.TabIndex = 0;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(3, 81);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(640, 353);
            this.pb1.TabIndex = 1;
            this.pb1.TabStop = false;
            // 
            // Whl1
            // 
            this.Whl1.HeaderText = "1号砂轮";
            this.Whl1.Name = "Whl1";
            this.Whl1.ReadOnly = true;
            this.Whl1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Whl1.Width = 159;
            // 
            // Whl2
            // 
            this.Whl2.HeaderText = "2号砂轮";
            this.Whl2.Name = "Whl2";
            this.Whl2.ReadOnly = true;
            this.Whl2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Whl2.Width = 159;
            // 
            // Whl3
            // 
            this.Whl3.HeaderText = "3号砂轮";
            this.Whl3.Name = "Whl3";
            this.Whl3.ReadOnly = true;
            this.Whl3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Whl3.Width = 159;
            // 
            // Whl4
            // 
            this.Whl4.HeaderText = "4号砂轮";
            this.Whl4.Name = "Whl4";
            this.Whl4.ReadOnly = true;
            this.Whl4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Whl4.Width = 159;
            // 
            // dgvGroup2
            // 
            this.dgvGroup2.AllowUserToAddRows = false;
            this.dgvGroup2.AllowUserToDeleteRows = false;
            this.dgvGroup2.AllowUserToResizeColumns = false;
            this.dgvGroup2.AllowUserToResizeRows = false;
            this.dgvGroup2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroup2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvGroup2.Location = new System.Drawing.Point(2, 5);
            this.dgvGroup2.Name = "dgvGroup2";
            this.dgvGroup2.ReadOnly = true;
            this.dgvGroup2.RowHeadersVisible = false;
            this.dgvGroup2.RowTemplate.Height = 27;
            this.dgvGroup2.Size = new System.Drawing.Size(640, 72);
            this.dgvGroup2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "1号砂轮";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 159;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "2号砂轮";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 159;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "3号砂轮";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 159;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "4号砂轮";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 159;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(2, 81);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(640, 353);
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            // 
            // btnSetting
            // 
            this.btnSetting.Font = new System.Drawing.Font("宋体", 16F);
            this.btnSetting.Location = new System.Drawing.Point(4, 4);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(256, 64);
            this.btnSetting.TabIndex = 14;
            this.btnSetting.Text = "系统设置";
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // winMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.ControlBox = false;
            this.Controls.Add(this.pProduct);
            this.Controls.Add(this.pWheel);
            this.Controls.Add(this.pMachine);
            this.Controls.Add(this.pHead);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "winMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "演示系统";
            this.pHead.ResumeLayout(false);
            this.pHead.PerformLayout();
            this.pMachine.ResumeLayout(false);
            this.pWheel.ResumeLayout(false);
            this.pProduct.ResumeLayout(false);
            this.scWheel.Panel1.ResumeLayout(false);
            this.scWheel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scWheel)).EndInit();
            this.scWheel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pHead;
        private System.Windows.Forms.ComboBox cbLan;
        private System.Windows.Forms.Label lMachineNo;
        private System.Windows.Forms.Label lVersion;
        private System.Windows.Forms.Label lTM;
        private System.Windows.Forms.Panel pMachine;
        private System.Windows.Forms.Panel pWheel;
        private System.Windows.Forms.Panel pProduct;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RadioButton rdoP6;
        private System.Windows.Forms.RadioButton rdoP7;
        private System.Windows.Forms.RadioButton rdoP5;
        private System.Windows.Forms.RadioButton rdoP4;
        private System.Windows.Forms.RadioButton rdoP3;
        private System.Windows.Forms.RadioButton rdoP2;
        private System.Windows.Forms.RadioButton rdoP1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.SplitContainer scWheel;
        private System.Windows.Forms.DataGridView dgvGroup1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Whl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Whl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Whl3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Whl4;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.DataGridView dgvGroup2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnSetting;

    }
}

