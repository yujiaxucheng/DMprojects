using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace CNCneo
{
    public class CFunc
    {
        /// <summary>
        /// 禁用鼠标滚轮
        /// </summary>
        public static void FBD_MouseWheel(object sender, MouseEventArgs e)
        {
            HandledMouseEventArgs h = e as HandledMouseEventArgs;
            if (h != null)
                h.Handled = true;
        }
    }
}
