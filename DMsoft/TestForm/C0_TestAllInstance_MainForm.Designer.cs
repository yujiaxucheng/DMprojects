namespace TestForm
{
    partial class C0_TestAllInstance_MainForm
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
            this.btnTestInstance = new System.Windows.Forms.Button();
            this.tbPara1 = new System.Windows.Forms.TextBox();
            this.lInfo = new System.Windows.Forms.Label();
            this.nudInstanceNo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudInstanceNo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTestInstance
            // 
            this.btnTestInstance.Location = new System.Drawing.Point(59, 176);
            this.btnTestInstance.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestInstance.Name = "btnTestInstance";
            this.btnTestInstance.Size = new System.Drawing.Size(108, 31);
            this.btnTestInstance.TabIndex = 0;
            this.btnTestInstance.Text = "测试实例按钮";
            this.btnTestInstance.UseVisualStyleBackColor = true;
            this.btnTestInstance.Click += new System.EventHandler(this.btnTestInstance_Click);
            // 
            // tbPara1
            // 
            this.tbPara1.Location = new System.Drawing.Point(266, 103);
            this.tbPara1.Margin = new System.Windows.Forms.Padding(4);
            this.tbPara1.Name = "tbPara1";
            this.tbPara1.Size = new System.Drawing.Size(124, 30);
            this.tbPara1.TabIndex = 1;
            // 
            // lInfo
            // 
            this.lInfo.AutoSize = true;
            this.lInfo.Location = new System.Drawing.Point(469, 33);
            this.lInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(49, 20);
            this.lInfo.TabIndex = 2;
            this.lInfo.Text = "输出";
            // 
            // nudInstanceNo
            // 
            this.nudInstanceNo.Location = new System.Drawing.Point(266, 33);
            this.nudInstanceNo.Margin = new System.Windows.Forms.Padding(4);
            this.nudInstanceNo.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudInstanceNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInstanceNo.Name = "nudInstanceNo";
            this.nudInstanceNo.Size = new System.Drawing.Size(150, 30);
            this.nudInstanceNo.TabIndex = 3;
            this.nudInstanceNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInstanceNo.ValueChanged += new System.EventHandler(this.nudInstanceNo_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "参数1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "选择实例序号";
            // 
            // C0_TestAllInstance_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 533);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudInstanceNo);
            this.Controls.Add(this.lInfo);
            this.Controls.Add(this.tbPara1);
            this.Controls.Add(this.btnTestInstance);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "C0_TestAllInstance_MainForm";
            this.Text = "C0_TestAllInstance_MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudInstanceNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestInstance;
        private System.Windows.Forms.TextBox tbPara1;
        private System.Windows.Forms.Label lInfo;
        private System.Windows.Forms.NumericUpDown nudInstanceNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}