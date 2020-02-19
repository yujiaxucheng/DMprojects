namespace DMsGame
{
    partial class RUAM
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
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // t1
            // 
            this.t1.Tick += new System.EventHandler(this.t1_Tick);
            // 
            // RUAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 555);
            this.KeyPreview = true;
            this.Name = "RUAM";
            this.Text = "是男人就勇下一百层";
            this.Click += new System.EventHandler(this.RUAM_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ruam_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer t1;
    }
}