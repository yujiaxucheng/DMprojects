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
}
