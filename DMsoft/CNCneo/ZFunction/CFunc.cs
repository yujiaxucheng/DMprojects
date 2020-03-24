using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace CNCneo
{
    /// <summary>
    /// 通用函数方法
    /// </summary>
    public class CFunc
    {
        #region 控件部分

        /// <summary>
        /// 禁用鼠标滚轮
        /// </summary>
        public static void FBD_MouseWheel(object sender, MouseEventArgs e)
        {
            HandledMouseEventArgs h = e as HandledMouseEventArgs;
            if (h != null)
                h.Handled = true;
        }

        #endregion 

        #region 数学公式

        public static double Tan(double a)
        {
            return Math.Tan(Math.PI * a / 180d);
        }

        #endregion

    }
}
