using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrawPics.ToolObj
{
    /// <summary>
    /// 工件父类
    /// </summary>
    public class Tool
    {
        public const int MILL = 1;                      // 铣刀
        public const int DRILL = 2;                     // 钻头
        public const int VICE = 3;                      // 钳子

        public const int MILL_END = 11;                 // 端铣刀
        public const int MILL_R = 12;                   // R角铣刀
        public const int MILL_C = 13;                   // C角铣刀
        public const int MILL_BALL = 14;                // 球头铣刀

        public const int DRILL_STD = 21;                // 标准钻头
        public const int DRILL_STEEL = 22;              // 钢板钻
        public const int DRILL_STEP = 23;               // 阶梯钻头

        public string sName { set; get; }              // 工件名称
        public int PorM { set; get; }                  // 生产或修磨
        public double D { set; get; }                  // 工件直径
        public double L { set; get; }                  // 工件长度

        public Tool()
        { }

        public Tool(double d)
        {
            this.D = d;
        }
    }

    /// <summary>
    /// 钻头父类
    /// </summary>
    public class Drill : Tool
    {
        public Drill()
        { }

        public Drill(double d)
        {
            this.D = d;
        }
    }
}
