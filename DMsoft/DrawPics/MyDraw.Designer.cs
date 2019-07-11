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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbM11 = new System.Windows.Forms.TextBox();
            this.tbM12 = new System.Windows.Forms.TextBox();
            this.tbM22 = new System.Windows.Forms.TextBox();
            this.tbM21 = new System.Windows.Forms.TextBox();
            this.tDraw = new System.Windows.Forms.Timer(this.components);
            this.lPointInfo = new System.Windows.Forms.Label();
            this.tbL1 = new System.Windows.Forms.TextBox();
            this.tba1 = new System.Windows.Forms.TextBox();
            this.tbD1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbBasic = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbL2 = new System.Windows.Forms.TextBox();
            this.tba2 = new System.Windows.Forms.TextBox();
            this.tbD2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbR1 = new System.Windows.Forms.TextBox();
            this.tbArcX = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbArcY = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbS = new System.Windows.Forms.TextBox();
            this.tbSw = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.gbBasic.SuspendLayout();
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
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(1000, 27);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(118, 42);
            this.btnDraw.TabIndex = 13;
            this.btnDraw.Text = "作图";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "原点绝对坐标";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "矩阵";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(58, 51);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(100, 30);
            this.tbX.TabIndex = 1;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(58, 94);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(100, 30);
            this.tbY.TabIndex = 2;
            // 
            // tbM11
            // 
            this.tbM11.Location = new System.Drawing.Point(243, 51);
            this.tbM11.Name = "tbM11";
            this.tbM11.Size = new System.Drawing.Size(100, 30);
            this.tbM11.TabIndex = 3;
            // 
            // tbM12
            // 
            this.tbM12.Location = new System.Drawing.Point(434, 51);
            this.tbM12.Name = "tbM12";
            this.tbM12.Size = new System.Drawing.Size(100, 30);
            this.tbM12.TabIndex = 4;
            // 
            // tbM22
            // 
            this.tbM22.Location = new System.Drawing.Point(434, 94);
            this.tbM22.Name = "tbM22";
            this.tbM22.Size = new System.Drawing.Size(100, 30);
            this.tbM22.TabIndex = 6;
            // 
            // tbM21
            // 
            this.tbM21.Location = new System.Drawing.Point(243, 94);
            this.tbM21.Name = "tbM21";
            this.tbM21.Size = new System.Drawing.Size(100, 30);
            this.tbM21.TabIndex = 5;
            // 
            // tDraw
            // 
            this.tDraw.Tick += new System.EventHandler(this.tDraw_Tick);
            // 
            // lPointInfo
            // 
            this.lPointInfo.AutoSize = true;
            this.lPointInfo.Location = new System.Drawing.Point(996, 99);
            this.lPointInfo.Name = "lPointInfo";
            this.lPointInfo.Size = new System.Drawing.Size(89, 20);
            this.lPointInfo.TabIndex = 6;
            this.lPointInfo.Text = "点坐标：";
            // 
            // tbL1
            // 
            this.tbL1.Location = new System.Drawing.Point(87, 188);
            this.tbL1.Name = "tbL1";
            this.tbL1.Size = new System.Drawing.Size(100, 30);
            this.tbL1.TabIndex = 7;
            // 
            // tba1
            // 
            this.tba1.Location = new System.Drawing.Point(463, 188);
            this.tba1.Name = "tba1";
            this.tba1.Size = new System.Drawing.Size(100, 30);
            this.tba1.TabIndex = 9;
            // 
            // tbD1
            // 
            this.tbD1.Location = new System.Drawing.Point(272, 188);
            this.tbD1.Name = "tbD1";
            this.tbD1.Size = new System.Drawing.Size(100, 30);
            this.tbD1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "D1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "L1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "a1";
            // 
            // gbBasic
            // 
            this.gbBasic.Controls.Add(this.label14);
            this.gbBasic.Controls.Add(this.label13);
            this.gbBasic.Controls.Add(this.label1);
            this.gbBasic.Controls.Add(this.tbSw);
            this.gbBasic.Controls.Add(this.tbArcY);
            this.gbBasic.Controls.Add(this.label2);
            this.gbBasic.Controls.Add(this.tbY);
            this.gbBasic.Controls.Add(this.label12);
            this.gbBasic.Controls.Add(this.tbS);
            this.gbBasic.Controls.Add(this.tbM21);
            this.gbBasic.Controls.Add(this.tbArcX);
            this.gbBasic.Controls.Add(this.label3);
            this.gbBasic.Controls.Add(this.tbX);
            this.gbBasic.Controls.Add(this.tbM22);
            this.gbBasic.Controls.Add(this.label4);
            this.gbBasic.Controls.Add(this.tbM11);
            this.gbBasic.Controls.Add(this.tbM12);
            this.gbBasic.Location = new System.Drawing.Point(29, 23);
            this.gbBasic.Name = "gbBasic";
            this.gbBasic.Size = new System.Drawing.Size(934, 141);
            this.gbBasic.TabIndex = 1;
            this.gbBasic.TabStop = false;
            this.gbBasic.Text = "画布基本参数";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "D2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "L2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(406, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "a2";
            // 
            // tbL2
            // 
            this.tbL2.Location = new System.Drawing.Point(87, 232);
            this.tbL2.Name = "tbL2";
            this.tbL2.Size = new System.Drawing.Size(100, 30);
            this.tbL2.TabIndex = 10;
            // 
            // tba2
            // 
            this.tba2.Location = new System.Drawing.Point(463, 232);
            this.tba2.Name = "tba2";
            this.tba2.Size = new System.Drawing.Size(100, 30);
            this.tba2.TabIndex = 12;
            // 
            // tbD2
            // 
            this.tbD2.Location = new System.Drawing.Point(272, 232);
            this.tbD2.Name = "tbD2";
            this.tbD2.Size = new System.Drawing.Size(100, 30);
            this.tbD2.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(594, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "R1";
            // 
            // tbR1
            // 
            this.tbR1.Location = new System.Drawing.Point(651, 232);
            this.tbR1.Name = "tbR1";
            this.tbR1.Size = new System.Drawing.Size(100, 30);
            this.tbR1.TabIndex = 12;
            // 
            // tbArcX
            // 
            this.tbArcX.Location = new System.Drawing.Point(617, 51);
            this.tbArcX.Name = "tbArcX";
            this.tbArcX.Size = new System.Drawing.Size(100, 30);
            this.tbArcX.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(586, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Y";
            // 
            // tbArcY
            // 
            this.tbArcY.Location = new System.Drawing.Point(617, 94);
            this.tbArcY.Name = "tbArcY";
            this.tbArcY.Size = new System.Drawing.Size(100, 30);
            this.tbArcY.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(586, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "X";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(579, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "圆弧参考点";
            // 
            // tbS
            // 
            this.tbS.Location = new System.Drawing.Point(758, 51);
            this.tbS.Name = "tbS";
            this.tbS.Size = new System.Drawing.Size(100, 30);
            this.tbS.TabIndex = 1;
            // 
            // tbSw
            // 
            this.tbSw.Location = new System.Drawing.Point(758, 94);
            this.tbSw.Name = "tbSw";
            this.tbSw.Size = new System.Drawing.Size(100, 30);
            this.tbSw.TabIndex = 2;
            // 
            // MyDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 855);
            this.Controls.Add(this.gbBasic);
            this.Controls.Add(this.lPointInfo);
            this.Controls.Add(this.tbD2);
            this.Controls.Add(this.tbD1);
            this.Controls.Add(this.tbR1);
            this.Controls.Add(this.tba2);
            this.Controls.Add(this.tba1);
            this.Controls.Add(this.tbL2);
            this.Controls.Add(this.tbL1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.pbMain);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyDraw";
            this.Text = "MyDraw";
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.gbBasic.ResumeLayout(false);
            this.gbBasic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbM11;
        private System.Windows.Forms.TextBox tbM12;
        private System.Windows.Forms.TextBox tbM22;
        private System.Windows.Forms.TextBox tbM21;
        private System.Windows.Forms.Timer tDraw;
        private System.Windows.Forms.Label lPointInfo;
        private System.Windows.Forms.TextBox tbL1;
        private System.Windows.Forms.TextBox tba1;
        private System.Windows.Forms.TextBox tbD1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbBasic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbL2;
        private System.Windows.Forms.TextBox tba2;
        private System.Windows.Forms.TextBox tbD2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbR1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbArcY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbArcX;
        private System.Windows.Forms.TextBox tbSw;
        private System.Windows.Forms.TextBox tbS;
    }
}

