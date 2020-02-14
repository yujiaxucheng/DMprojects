using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestForm
{
    public class functions
    {
        /// <summary>
        /// 将字符串转换为int型
        /// </summary>
        /// <param name="strValue">字符串</param>
        /// <returns>int型数字</returns>
        public static int ConvertString2Int(string strValue)
        {
            int value = 0;

            try
            {
                value = Convert.ToInt32(strValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine("异常信息是：========\n" + ex.ToString() + "\n异常信息========");
            }

            return value;
        }
    }
}
