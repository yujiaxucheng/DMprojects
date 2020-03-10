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
        private int iLan = Language.ZHS;
        private int[] arrLen = new int[100];                        // 存放翻译文字长度

        public MultiLan()
        {
            InitializeComponent();
            InitLan();
        }

        /// <summary>
        /// 初始化语言
        /// </summary>
        private void InitLan()
        {
            string lanName = "中文简体";                                                // 语言名称

            switch (iLan)
            {
                case Language.ZHS:
                default:
                    lanName = "中文简体";
                    break;
                case Language.ZHC:
                    lanName = "中文繁体";
                    break;
                case Language.ENG:
                    lanName = "英文";
                    break;
            }
            this.cbLan.Text = lanName;
        }

        /// <summary>
        /// 修改界面语言
        /// </summary>
        /// <param name="ilan">语言代码</param>
        private void ChangeLan(int ilan)
        {
            string fileName = "ZHS";                                                // 文件名
            List<Control> lst_Ctrl = new List<Control>();                           // 控件列表
            Dictionary<string, string> tDic = new Dictionary<string, string>();     // 键值对

            Label l;

            switch(ilan)
            {
                case Language.ZHS:
                    fileName = "ZHS";
                    break;
                case Language.ZHC:
                    fileName = "ZHC";
                    break;
                case Language.ENG:
                    fileName = "ENG";
                    break;
            }
            tDic = CRandW.GetContFromFile(fileName);

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

                if (lst_Ctrl[i].GetType().Name.ToString() == "Label")
                {
                    l = (Label)(lst_Ctrl[i]);
                    l.AutoEllipsis = true;
                    l.AutoSize = true;
                    //l.Size = new Size(152, 16);
                    l.Font = new System.Drawing.Font("Arial", CRandW.CalcSize(lst_Ctrl[i].Text), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)));
                }
            }
            Console.WriteLine("实现控件多语言。");

            tDic.Clear();
            lst_Ctrl.Clear();
        }

        // 关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // 测试按钮
        private void btnTest_Click(object sender, EventArgs e)
        {
            this.label3.Text = "文字长度：" + this.label1.Text.Length.ToString() + Environment.NewLine + "文字长度：" + this.label2.Text.Length.ToString();
        }

        // 多语言选择
        private void cbLan_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.iLan = this.cbLan.SelectedIndex;
            ChangeLan(this.iLan);
        }

        // 加载页面
        private void MultiLan_Load(object sender, EventArgs e)
        {

        }
    }
}
