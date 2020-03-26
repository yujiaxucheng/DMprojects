using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CNCneo.Tool
{
    public partial class FSubPage : Form
    {
        public FSubPage()
        {
            InitializeComponent();
            InitFormCtrl();
        }

        /// <summary>
        /// 确认其他参数界面名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        /// <summary>
        /// 初始化控件布局
        /// </summary>
        public void InitFormCtrl()
        {
            int x = this.scMain.Panel2.Width - this.btnConfirm.Width - 3;
            int y = this.scMain.Panel2.Height - this.btnConfirm.Height - 3;
            this.btnConfirm.Location = new Point(x, y);
        }
    }
}
