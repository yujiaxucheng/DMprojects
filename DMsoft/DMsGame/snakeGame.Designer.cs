namespace DMsGame
{
    partial class snakeGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(snakeGame));
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.lScore = new System.Windows.Forms.Label();
            this.lSpeed = new System.Windows.Forms.Label();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.lhisScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("宋体", 16F);
            this.btnStart.Location = new System.Drawing.Point(493, 412);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 46);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbMain
            // 
            this.pbMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMain.Location = new System.Drawing.Point(12, 8);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(450, 450);
            this.pbMain.TabIndex = 2;
            this.pbMain.TabStop = false;
            // 
            // lScore
            // 
            this.lScore.AutoSize = true;
            this.lScore.Font = new System.Drawing.Font("宋体", 18F);
            this.lScore.Location = new System.Drawing.Point(488, 25);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(118, 30);
            this.lScore.TabIndex = 3;
            this.lScore.Text = "分数：0";
            // 
            // lSpeed
            // 
            this.lSpeed.AutoSize = true;
            this.lSpeed.Font = new System.Drawing.Font("宋体", 16F);
            this.lSpeed.Location = new System.Drawing.Point(488, 306);
            this.lSpeed.Name = "lSpeed";
            this.lSpeed.Size = new System.Drawing.Size(93, 27);
            this.lSpeed.TabIndex = 4;
            this.lSpeed.Text = "速度：";
            // 
            // nudSpeed
            // 
            this.nudSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudSpeed.Font = new System.Drawing.Font("宋体", 16F);
            this.nudSpeed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nudSpeed.Location = new System.Drawing.Point(493, 347);
            this.nudSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.ReadOnly = true;
            this.nudSpeed.Size = new System.Drawing.Size(120, 38);
            this.nudSpeed.TabIndex = 5;
            this.nudSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeed.ValueChanged += new System.EventHandler(this.nudSpeed_ValueChanged);
            // 
            // lhisScore
            // 
            this.lhisScore.Font = new System.Drawing.Font("宋体", 12F);
            this.lhisScore.Location = new System.Drawing.Point(477, 94);
            this.lhisScore.Name = "lhisScore";
            this.lhisScore.Size = new System.Drawing.Size(146, 58);
            this.lhisScore.TabIndex = 6;
            this.lhisScore.Text = "历史最高分：";
            this.lhisScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // snakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 463);
            this.Controls.Add(this.lhisScore);
            this.Controls.Add(this.nudSpeed);
            this.Controls.Add(this.lSpeed);
            this.Controls.Add(this.lScore);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "snakeGame";
            this.Text = "小游戏贪吃蛇";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSnake_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Label lScore;
        private System.Windows.Forms.Label lSpeed;
        private System.Windows.Forms.NumericUpDown nudSpeed;
        private System.Windows.Forms.Label lhisScore;
    }
}