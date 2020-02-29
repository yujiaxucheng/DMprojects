using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TestForm.DesignPattener;

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

        /// <summary>
        /// Instance038 输出省市
        /// </summary>
        public static string Ins38_PrintProvinces()
        {
            string strValue = "";

            Dictionary<string, List<string>> provinsces = new Dictionary<string,List<string>>();

            List<string> jiangSu = new List<string>();
            provinsces.Add("江苏", jiangSu);
            jiangSu.Add("A南京");
            jiangSu.Add("B无锡");
            jiangSu.Add("C徐州");
            jiangSu.Add("D常州");
            jiangSu.Add("E苏州");
            jiangSu.Add("F南通");
            jiangSu.Add("G连云港");
            jiangSu.Add("H淮安");
            jiangSu.Add("J盐城");
            jiangSu.Add("K扬州");
            jiangSu.Add("L镇江");
            jiangSu.Add("M泰州");
            jiangSu.Add("N宿迁");

            List<string> heBei = new List<string>();
            provinsces.Add("河北", heBei);
            heBei.Add("石家庄");
            heBei.Add("唐山");

            foreach (KeyValuePair<string, List<string>> p in provinsces)
            {
                strValue += p.Key.ToString() + "省\n";

                foreach (string city in p.Value)
                {
                    strValue += "      " + city.ToString() + "市\n";
                }
            }

            return strValue;
        }

        /// <summary>
        /// Instance038 获取省内城市
        /// </summary>
        /// <param name="proName"></param>
        public static string Ins38_GetCitysFromProvince(string proName)
        {
            string strValue = "";

            Dictionary<string, List<string>> provinsces = new Dictionary<string, List<string>>();

            List<string> jiangSu = new List<string>();
            provinsces.Add("江苏", jiangSu);
            jiangSu.Add("A南京");
            jiangSu.Add("B无锡");
            jiangSu.Add("C徐州");
            jiangSu.Add("D常州");
            jiangSu.Add("E苏州");
            jiangSu.Add("F南通");
            jiangSu.Add("G连云港");
            jiangSu.Add("H淮安");
            jiangSu.Add("J盐城");
            jiangSu.Add("K扬州");
            jiangSu.Add("L镇江");
            jiangSu.Add("M泰州");
            jiangSu.Add("N宿迁");

            List<string> heBei = new List<string>();
            provinsces.Add("河北", heBei);
            heBei.Add("石家庄");
            heBei.Add("唐山");

            if (provinsces.ContainsKey(proName))
            {
                foreach (string city in provinsces[proName])
                {
                    strValue += "      " + city.ToString() + "市\n";
                }
            }
            else
            {
                strValue = "未录入该信息";
            }

            return strValue;
        }

        /// <summary>
        /// 实例40  队列
        /// </summary>
        public static string Ins40_TestQueue()
        {
            string strValue = "";

            string[] men = new string[] { "男一", "男二", "男三", "男四", "男五" };
            string[] women = new string[] { "女一", "女二", "女三" };

            Queue<string> waitingMen = new Queue<string>();
            Queue<string> waitingWomen = new Queue<string>();
            Queue<string> dancingMen = new Queue<string>();
            Queue<string> dancingWomen = new Queue<string>();

            foreach (string man in men)
            {
                waitingMen.Enqueue(man);
            }

            foreach (string woman in women)
            {
                waitingWomen.Enqueue(woman);
            }

            int turns = 1;

            do
            {
                // 舞曲开始
                strValue += "第" + turns.ToString() + "场舞曲开始\n";

                // 等待的男女逐个配对跳舞
                while (waitingMen.Count > 0 && waitingWomen.Count > 0)
                {
                    string man = waitingMen.Dequeue();
                    string woman = waitingWomen.Dequeue();

                    strValue += man.ToString() + " and " + woman.ToString() + " are dancing. \n";

                    dancingMen.Enqueue(man);
                    dancingWomen.Enqueue(woman);
                }

                // 输出剩余没有配对的人
                foreach (var man in waitingMen)
                    strValue += man.ToString() + "先生 在等待…… \n";
                foreach (var woman in waitingWomen)
                    strValue += woman.ToString() + "女士 在等待…… \n";

                // 舞曲结束
                while (dancingMen.Count > 0 && dancingWomen.Count > 0)
                {
                    string man = dancingMen.Dequeue();
                    string woman = dancingWomen.Dequeue();

                    strValue += man.ToString() + " is waiting now. \n";
                    strValue += woman.ToString() + " is waiting now. \n";

                    waitingMen.Enqueue(man);
                    waitingWomen.Enqueue(woman);
                }

                turns++;
            } while (turns <= 3);

            return strValue;
        }

        /// <summary>
        /// 实例41  栈  检测括号匹配
        /// </summary>
        /// <param name="inputString">带符号队列</param>
        public static string Ins41_TestStack(string inputString)
        {
            string strValue = "";

            Stack<char> brackets = new Stack<char>();

            foreach (char bracket in inputString)
            {
                if (bracket == '(' || bracket == '[' || bracket == '{')
                {
                    brackets.Push(bracket);
                }
                else if (bracket == ')' && brackets.Pop() != '('
                      || bracket == ']' && brackets.Pop() != '['
                      || bracket == '}' && brackets.Pop() != '{')
                {
                    strValue += "括号匹配错误\n";
                    return strValue;
                }
            }

            if (brackets.Count > 0)
                strValue += "括号匹配错误。";
            else
                strValue += "括号匹配正确。";

            return strValue;
        }

        #region 设计模式

        /// <summary>
        /// 简单工厂模式
        /// </summary>
        /// <returns></returns>
        public static string Ins88_SimpleFactory()
        {
            string strVal = "";

            myFactory f = new myFactory();

            Tool xidao = f.Produce("EndMill");
            strVal += "\n" + xidao.Create();

            Tool qiudao = f.Produce("BallMill");
            strVal += "\n" + qiudao.Create();

            return strVal;
        }

        #endregion
    }
}
