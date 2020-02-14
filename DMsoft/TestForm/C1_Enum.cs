using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestForm
{
    /// <summary>
    /// 枚举类
    /// </summary>
    public class C1_Enum
    {
        public enum Animal : int
        { 
            /// <summary>
            /// 狗
            /// </summary>
            Dog = 0,

            /// <summary>
            /// 猫
            /// </summary>
            Cat = 1,

            /// <summary>
            /// 鼠
            /// </summary>
            Mouse = 2
        }
    }
}
