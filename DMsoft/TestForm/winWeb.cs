using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestForm
{
    public partial class winWeb : Form
    {
        public winWeb()
        {
            InitializeComponent();
        }

        
        private void btnStart_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(this.textBox1.Text.Trim());
        }
    }
}
