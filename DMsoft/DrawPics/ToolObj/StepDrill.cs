using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrawPics.ToolObj
{
    /// <summary>
    /// 阶梯钻头
    /// </summary>
    public class StepDrill : Drill
    {
        public const int STEP_NUM = 10;

        public const int SIG_SUCCESS = 0;                       // 成功
        public const int SIG_FAILURE = 1;                       // 失败

        public const int[] ERR = new int[100];                  // 错误代码序列

        public int ns;                                          // 阶梯钻阶梯数

        public double topD;                                     // 钻尖直径
        //public double orgD;                                     // 钻头直径

        public double[] arrD = new double[STEP_NUM];          // 大端直径
        public double[] arrH = new double[STEP_NUM];          // 中间直径
        public double[] arrA1 = new double[STEP_NUM];         // 锥角1
        public double[] arrA2 = new double[STEP_NUM];         // 锥角2
        public double[] arrR1 = new double[STEP_NUM];         // 圆角1
        public double[] arrR2 = new double[STEP_NUM];         // 圆角2
        public double[] arrR3 = new double[STEP_NUM];         // 圆角3

        public StepDrill()
        { }

        public StepDrill(double d, double topd)
        {
            this.D = d;
            this.topD = topd;
        }

        /// <summary>
        /// 初始化阶梯钻头各参数
        /// </summary>
        public void InitSD()
        {
            this.ns = STEP_NUM;

            for (int i = 0; i < STEP_NUM; i++)
            {
                this.arrD[i] = (D - topD) / ns + topD;
            }
        }

        public int InitSD(double d, double td, double ns)
        {


            return SIG_SUCCESS;
        }
    }
}
