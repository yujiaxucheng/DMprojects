using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.IO;

namespace CNCneo
{
    /// <summary>
    /// 通用函数方法
    /// </summary>
    public class CFunc
    {
        #region 控件部分

        /// <summary>
        /// 存放控件集合
        /// </summary>
        private static List<Control> listCtrl = new List<Control>();                    // 存放控件

        /// <summary>
        /// 禁用鼠标滚轮
        /// </summary>
        public static void FBD_MouseWheel(object sender, MouseEventArgs e)
        {
            HandledMouseEventArgs h = e as HandledMouseEventArgs;
            if (h != null)
                h.Handled = true;
        }

        /// <summary>
        /// 递归遍历所有控件和子控件，存入集合
        /// </summary>
        /// <param name="ctrl">传入控件名</param>
        /// <returns>控件集合</returns>
        public static List<Control> getAllControls(Control ctrl)
        {
            for (int i = 0; i < ctrl.Controls.Count; i++)
            {
                listCtrl.Add(ctrl.Controls[i]);                                         // 加入集合

                if (ctrl.Controls[i].HasChildren)
                    getAllControls(ctrl.Controls[i]);
            }
            return listCtrl;
        }

        #endregion 

        #region 数学公式

        /// <summary>
        /// 正弦值
        /// </summary>
        /// <param name="a">角度</param>
        /// <returns>正弦值</returns>
        public static double Tan(double a)
        {
            return Math.Tan(Math.PI * a / 180d);
        }

        #endregion

        #region 文件读写

        /// <summary>
        /// 获取指定文件内容到字典中（键值对用“=”隔开，类别名用“#”隔开）
        /// </summary>
        /// <param name="fileName">文件名</param>
        /// <returns>键值对字典表</returns>
        public static Dictionary<string, string> GetContFromFile(string fileName)
        {
            Dictionary<string, string> dicStrStr = new Dictionary<string, string>();
            FileStream fs = new FileStream(fileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            string tStr = "";
            string tCategory = "";

            while (sr.EndOfStream == false)
            {
                tStr = sr.ReadLine();
                if (tStr.IndexOf("=") < (tStr.Length - 1) && tStr.IndexOf("=") > 1)
                {
                    dicStrStr.Add(tCategory + tStr.Substring(0, tStr.IndexOf("=")), tStr.Substring(tStr.IndexOf("=") + 1));
                }
                else
                {
                    //tCategory = tStr + "_"; // 老方法
                    continue;
                }
            }

            sr.Close();
            fs.Close();
            return dicStrStr;
        }

        /// <summary>
        /// 将控件c中的文本存到fileName中
        /// </summary>
        /// <param name="c">控件</param>
        /// <param name="fileName">文件名</param>
        public static void SaveControlText2File(Control c, string fileName)
        { 
            
        }

        #endregion
    }
}
