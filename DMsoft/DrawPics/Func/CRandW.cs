using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Windows.Forms;

namespace DrawPics.Func
{
    /// <summary>
    /// 读写类
    /// </summary>
    public class CRandW
    {
        static List<Control> ListCtrl = new List<Control>();        //存放控件

        /// <summary>
        /// 获取指定文件内容到字典中
        /// </summary>
        /// <param name="iniFileName">文件名</param>
        /// <returns>键值对字典表</returns>
        public static Dictionary<string, string> GetContFromFile(string iniFileName)
        {
            string fileName = @"C:\DiskD\myGitHub\DMprojects\DMsoft\DrawPics\Files\" + iniFileName + @".lan";

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
    }
}
