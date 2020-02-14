using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestForm
{
    /// <summary>
    /// 调用程序汇总，根据实例序号进行调用
    /// </summary>
    public class C0_TestAllInstance_Main
    {
        /// <summary>
        /// Instance007 输入枚举例子，输出动物名
        /// </summary>
        /// <returns>动物种类名</returns>
        public static string Ins7_PrintAnimalName(C1_Enum.Animal animal)
        {
            string rtnName = "";

            switch (animal)
            {
                case C1_Enum.Animal.Cat:
                    rtnName =  "猫";
                    break;
                case C1_Enum.Animal.Dog:
                    rtnName =  "狗";
                    break;
                case C1_Enum.Animal.Mouse:
                    rtnName =  "鼠";
                    break;
                default:
                    rtnName = "N/A";
                    break;
            }
            rtnName = "根据实例007 输出动物类型为:" + rtnName;

            return rtnName;
        }

        //public static string Ins13_

    }
}
