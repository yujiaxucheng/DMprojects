using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestForm.DesignPattener
{
    /// <summary>
    /// 设计模式一：简单工厂类
    /// </summary>
    public class DP_SimpleFactory
    {
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
    }
    
    /// <summary>
    /// 简单工厂类
    /// </summary>
    public class myFactory
    {
        public Tool Produce(string toolName)
        {
            switch (toolName)
            {
                case "EndMill":
                    return new EndMill();
                case "BallMill":
                    return new BallMill();
                default:
                    throw new Exception("暂无该工件！");
            }
        }
    }

    /// <summary>
    /// 抽象一个工件类
    /// </summary>
    public abstract class Tool
    {
        public abstract string Create();
    }

    /// <summary>
    /// 铣刀
    /// </summary>
    public class EndMill : Tool
    {
        public override string Create()
        {
            return "创建铣刀";
        }
    }

    /// <summary>
    /// 球刀
    /// </summary>
    public class BallMill : Tool
    {
        public override string Create()
        {
            return "创建球刀";
        }
    }

    #region 简单工厂类实例

    /// <summary>
    /// 运算类
    /// </summary>
    public class Operation
    {
        private double _numberA = 0;
        private double _numberB = 0;

        /// <summary>
        /// 数字A
        /// </summary>
        public double NumberA
        {
            get
            {
                return _numberA;
            }
            set
            {
                _numberA = value;
            }
        }

        /// <summary>
        /// 数字B
        /// </summary>
        public double NumberB
        {
            get
            {
                return _numberB;
            }
            set
            {
                _numberB = value;
            }
        }

        /// <summary>
        /// 得到运算结果
        /// </summary>
        /// <returns></returns>
        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }

        /// <summary>
        /// 检查输入的字符串是否准确
        /// </summary>
        /// <param name="currentNumber"></param>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string checkNumberInput(string currentNumber, string inputString)
        {
            string result = "";

            if (inputString == ".")
            {
                if (currentNumber.IndexOf(".") < 0)
                {
                    if (currentNumber.Length == 0)
                        result = "0" + inputString;
                    else
                        result = currentNumber + inputString;
                }
            }
            else if (currentNumber == "0")
            {
                result = inputString;
            }
            else
            {
                result = currentNumber + inputString;
            }

            return result;
        }
    }

    /// <summary>
    /// 运算类工厂
    /// </summary>
    public class OperationFactory
    {
        public static Operation createOperate(string operate)
        {
            Operation oper = null;

            switch (operate)
            {
                case "+":
                    {
                        oper = new OperationAdd();
                        break;
                    }
                case "-":
                    {
                        oper = new OperationSub();
                        break;
                    }
                case "*":
                    {
                        oper = new OperationMul();
                        break;
                    }
                case "/":
                    {
                        oper = new OperationDiv();
                        break;
                    }
                case "sqr":
                    {
                        oper = new OperationSqr();
                        break;
                    }
                case "sqrt":
                    {
                        oper = new OperationSqrt();
                        break;
                    }
                case "+/-":
                    {
                        oper = new OperationReverse();
                        break;
                    }
            }

            return oper;
        }
    }

    #region 具体算法子类

    /// <summary>
    /// 加法类
    /// </summary>
    class OperationAdd : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }

    /// <summary>
    /// 减法类
    /// </summary>
    class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }

    /// <summary>
    /// 乘法类
    /// </summary>
    class OperationMul : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }

    /// <summary>
    /// 除法类
    /// </summary>
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0)
                throw new Exception("除数不能为0。");
            result = NumberA / NumberB;
            return result;
        }
    }

    /// <summary>
    /// 平方类
    /// </summary>
    class OperationSqr : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberB * NumberB;
            return result;
        }
    }

    /// <summary>
    /// 平方根类
    /// </summary>
    class OperationSqrt : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB < 0)
                throw new Exception("负数不能开平方根。");
            result = Math.Sqrt(NumberB);
            return result;
        }
    }

    /// <summary>
    /// 相反数类
    /// </summary>
    class OperationReverse : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = -NumberB;
            return result;
        }
    }

    #endregion

    #endregion
}
