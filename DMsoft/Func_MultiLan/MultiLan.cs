using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace Func_MultiLan
{
    public partial class MultiLan : Form
    {
        private const int LAN_ZHS = 0;              // 简体
        private const int LAN_ZHC = 1;              // 繁体
        private const int LAN_ENG = 2;              // 英文
        private const int LAN_ITL = 3;              // 意大利

        private int lanCode = LAN_ZHS;              // 语言代码

        public static List<Control> ListCtrl = new List<Control>();                 // 存放控件

        public MultiLan()
        {
            InitializeComponent();
            this.cbLan.MouseWheel += new MouseEventHandler(FBD_MouseWheel);
        }

        // 多语言下拉框
        private void cbLan_SelectedIndexChanged(object sender, EventArgs e)
        {
            lanCode = this.cbLan.SelectedIndex;
            InitLan(lanCode);
        }

        #region 多语言实现方法

        /// <summary>
        /// 初始化语言
        /// </summary>
        /// <param name="ilan">语言代码</param>
        private void InitLan(int ilan)
        {
            string fileName = "";                                                   // 文件名
            List<Control> lst_Ctrl = new List<Control>();                           // 控件列表
            Dictionary<string, string> tDic = new Dictionary<string, string>();     // 键值对

            this.cbLan.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbLan.SelectedIndex = lanCode;
            //Label l;

            switch (ilan)
            {
                default:
                case LAN_ZHS:
                    fileName = "ZHS";
                    break;
                case LAN_ZHC:
                    fileName = "ZHC";
                    break;
                case LAN_ENG:
                    fileName = "ENG";
                    break;
                case LAN_ITL:
                    fileName = "ITL";
                    break;
            }

            tDic = GetContFromFile(fileName);       // 获取翻译文件内容，返回键值对
            lst_Ctrl = getAllConstrols(this);       // 获取当前界面所有控件

            for (int i = 0; i < lst_Ctrl.Count; i++)
            {
                foreach (KeyValuePair<string, string> kvp in tDic)
                {
                    if (kvp.Key == lst_Ctrl[i].TabIndex.ToString())
                    {
                        lst_Ctrl[i].Text = kvp.Value;
                    }
                }

                //if (lst_Ctrl[i].GetType().Name.ToString() == "Label")
                //{
                //    l = (Label)(lst_Ctrl[i]);
                //}
            }
            Console.WriteLine("实现控件多语言。");

            tDic.Clear();
            lst_Ctrl.Clear();
        }

        /// <summary>
        /// 获取指定文件内容到字典中
        /// </summary>
        /// <param name="iniFileName">文件名</param>
        /// <returns>键值对字典表</returns>
        public static Dictionary<string, string> GetContFromFile(string iniFileName)
        {
            string tmpPath = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = AppDomain.CurrentDomain.BaseDirectory + iniFileName + @".ini";

            tmpPath = tmpPath.Substring(0, tmpPath.IndexOf("bin")) + @"res\";
            fileName = tmpPath + iniFileName + @".ini";

            Dictionary<string, string> dicStrStr = new Dictionary<string, string>();
            FileStream fs = new FileStream(fileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            string tStr = "";

            while (sr.EndOfStream == false)
            {
                tStr = sr.ReadLine();
                if (tStr.IndexOf("=") < (tStr.Length - 1))
                {
                    dicStrStr.Add(tStr.Substring(0, tStr.IndexOf("=")), tStr.Substring(tStr.IndexOf("=") + 1));
                }
            }

            sr.Close();
            fs.Close();
            return dicStrStr;
        }

        /// <summary>
        /// 遍历所有控件并返回控件类型的值
        /// </summary>
        /// <param name="c">控件名</param>
        /// <returns>控件list</returns>
        public static List<Control> getAllConstrols(Control c)
        {
            for (int i = 0; i < c.Controls.Count; i++)
            {
                ListCtrl.Add(c.Controls[i]);
                if (c.Controls[i].HasChildren)
                {
                    getAllConstrols(c.Controls[i]);
                }
            }
            return ListCtrl;
        }

        #endregion

        #region 禁用鼠标滚轮

        private void FBD_MouseWheel(object sender, MouseEventArgs e)
        {
            
        }

        #endregion
    }
}
