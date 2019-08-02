using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DrawPics.Func;

namespace DrawPics.Test
{
    public partial class MultiLan : Form
    {
        public MultiLan()
        {
            InitializeComponent();
            InitLan();
        }

        private void InitLan()
        {
            List<Control> lst_Ctrl = new List<Control>();
            Dictionary<string, string> tDic = new Dictionary<string, string>();

            Label l;

            tDic = CRandW.GetContFromFile("ENG");

            lst_Ctrl = CRandW.getAllConstrols(this);

            for (int i = 0; i < lst_Ctrl.Count; i++)
            {
                foreach (KeyValuePair<string, string> kvp in tDic)
                {
                    if (kvp.Key == lst_Ctrl[i].TabIndex.ToString())
                    {
                        lst_Ctrl[i].Text = kvp.Value;
                    }
                }

                //MessageBox.Show(lst_Ctrl[i].GetType().Name.ToString());
                if (lst_Ctrl[i].GetType().Name.ToString() == "Label")
                {
                    l = (Label)(lst_Ctrl[i]);
                    l.AutoEllipsis = true;
                    l.AutoSize = false;
                    l.Size = new Size(152, 16);
                }
            }
            Console.WriteLine("实现控件多语言。");

            tDic.Clear();
            lst_Ctrl.Clear();
        }

        // 关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            byte[] bytes = System.Text.Encoding.Unicode.GetBytes("　");
            MessageBox.Show(bytes[0] + "" + bytes[1]);
            this.Dispose();
        }
    }
}
