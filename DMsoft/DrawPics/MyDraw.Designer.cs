namespace DrawPics
{
    partial class MyDraw
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
            this.components = new System.ComponentModel.Container();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.tDraw = new System.Windows.Forms.Timer(this.components);
            this.lPointInfo = new System.Windows.Forms.Label();
            this.dgvGrid = new System.Windows.Forms.DataGridView();
            this.C7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nRate = new System.Windows.Forms.NumericUpDown();
            this.lrate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRate)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMain
            // 
            this.pbMain.BackColor = System.Drawing.Color.LightGray;
            this.pbMain.Location = new System.Drawing.Point(29, 295);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(1000, 500);
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            this.pbMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseDown);
            this.pbMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseMove);
            this.pbMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseUp);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(1054, 103);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(118, 42);
            this.btnDraw.TabIndex = 13;
            this.btnDraw.Text = "作图";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // tDraw
            // 
            this.tDraw.Tick += new System.EventHandler(this.tDraw_Tick);
            // 
            // lPointInfo
            // 
            this.lPointInfo.AutoSize = true;
            this.lPointInfo.Location = new System.Drawing.Point(844, 154);
            this.lPointInfo.Name = "lPointInfo";
            this.lPointInfo.Size = new System.Drawing.Size(72, 16);
            this.lPointInfo.TabIndex = 6;
            this.lPointInfo.Text = "点坐标：";
            // 
            // dgvGrid
            // 
            this.dgvGrid.AllowUserToAddRows = false;
            this.dgvGrid.AllowUserToDeleteRows = false;
            this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C7,
            this.C6,
            this.C1,
            this.C2,
            this.C3,
            this.C4,
            this.C5});
            this.dgvGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvGrid.Location = new System.Drawing.Point(29, 23);
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.RowHeadersWidth = 10;
            this.dgvGrid.RowTemplate.Height = 23;
            this.dgvGrid.Size = new System.Drawing.Size(795, 266);
            this.dgvGrid.TabIndex = 14;
            this.dgvGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrid_CellClick);
            // 
            // C7
            // 
            this.C7.HeaderText = "阶梯形状";
            this.C7.Name = "C7";
            // 
            // C6
            // 
            this.C6.HeaderText = "长度标注方式";
            this.C6.Name = "C6";
            this.C6.Width = 150;
            // 
            // C1
            // 
            this.C1.HeaderText = "直径";
            this.C1.Name = "C1";
            // 
            // C2
            // 
            this.C2.HeaderText = "长度";
            this.C2.Name = "C2";
            // 
            // C3
            // 
            this.C3.HeaderText = "锥度";
            this.C3.Name = "C3";
            // 
            // C4
            // 
            this.C4.HeaderText = "圆角1";
            this.C4.Name = "C4";
            // 
            // C5
            // 
            this.C5.HeaderText = "圆角2";
            this.C5.Name = "C5";
            // 
            // nRate
            // 
            this.nRate.Location = new System.Drawing.Point(1067, 33);
            this.nRate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nRate.Name = "nRate";
            this.nRate.Size = new System.Drawing.Size(120, 26);
            this.nRate.TabIndex = 15;
            this.nRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nRate.ValueChanged += new System.EventHandler(this.nRate_ValueChanged);
            // 
            // lrate
            // 
            this.lrate.AutoSize = true;
            this.lrate.Location = new System.Drawing.Point(1007, 35);
            this.lrate.Name = "lrate";
            this.lrate.Size = new System.Drawing.Size(40, 16);
            this.lrate.TabIndex = 16;
            this.lrate.Text = "比例";
            // 
            // MyDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 759);
            this.Controls.Add(this.lrate);
            this.Controls.Add(this.nRate);
            this.Controls.Add(this.dgvGrid);
            this.Controls.Add(this.lPointInfo);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.pbMain);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyDraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MyDraw";
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Timer tDraw;
        private System.Windows.Forms.Label lPointInfo;
        private System.Windows.Forms.DataGridView dgvGrid;
        private System.Windows.Forms.NumericUpDown nRate;
        private System.Windows.Forms.Label lrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn C7;
        private System.Windows.Forms.DataGridViewTextBoxColumn C6;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2;
        private System.Windows.Forms.DataGridViewTextBoxColumn C3;
        private System.Windows.Forms.DataGridViewTextBoxColumn C4;
        private System.Windows.Forms.DataGridViewTextBoxColumn C5;
    }
}

