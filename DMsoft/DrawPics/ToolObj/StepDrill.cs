using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

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

        public int ns;                                          // 阶梯钻阶梯数
        public int step_N;                                       // 当前阶梯序号

        public double topD;                                     // 钻尖直径

        public int[] arrShape = new int[STEP_NUM];              // 钻型
        public int[] arrLen = new int[STEP_NUM];                // 长度标注方式

        public double[] arrD = new double[STEP_NUM];            // 大端直径
        public double[] arrH = new double[STEP_NUM];            // 中间直径
        public double[] arrL = new double[STEP_NUM];            // 长度
        public double[] arrA1 = new double[STEP_NUM];           // 锥角1
        public double[] arrA2 = new double[STEP_NUM];           // 锥角2
        public double[] arrR1 = new double[STEP_NUM];           // 圆角1
        public double[] arrR2 = new double[STEP_NUM];           // 圆角2
        public double[] arrR3 = new double[STEP_NUM];           // 圆角3

        Point p0 = new Point(900f, 250f);

        public StepDrill()
        {
            
        }

        public StepDrill(double d, double topd)
        {
            this.D = d;
            this.topD = topd;
            this.ns = STEP_NUM;

            InitSD(d, topd, ns);
        }

        /// <summary>
        /// 初始化阶梯钻头各参数
        /// </summary>
        public void InitSD()
        {
            this.ns = STEP_NUM;

            for (int i = 0; i < STEP_NUM; i++)
            {
                this.arrShape[i] = i + 1;
                this.arrLen[i] = i + 1;

                this.arrD[i] = (D - topD) / ns + topD;
                this.arrH[i] = 0.5 * (D - topD) / ns + topD;
                this.arrA1[i] = 90d;
                this.arrA2[i] = 120d;
                this.arrR1[i] = 1d;
                this.arrR2[i] = 1d;
                this.arrR3[i] = 1d;
            }
        }

        public int InitSD(double d, double td, int ns)
        {
            this.ns = ns;

            for (int i = 0; i < STEP_NUM; i++)
            {
                this.arrShape[i] = i + 1;
                this.arrLen[i] = i + 1;

                this.arrD[i] = (d - td) / ns + td;
                this.arrH[i] = 0.5 * (d - td) / ns + td;
                this.arrL[i] = 5 * (i + 1);
                this.arrA1[i] = 90d;
                this.arrA2[i] = 120d;
                this.arrR1[i] = 1d;
                this.arrR2[i] = 1d;
                this.arrR3[i] = 1d;
            }
            return SIG_SUCCESS;
        }

        /// <summary>
        /// 绘制阶梯钻头
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p">画笔</param>
        public void Draw(Graphics g, Pen p)
        {
            #region 绘制钻头

            float fPos = 0f;

            double d;                                                           // 小端直径
            double D;                                                           // 大端直径
            double l;                                                           // 长度
            double a;                                                           // 锥角
            double r1, r2;

            int i;

            fPos = 0;                                                           // 从原点开始作图
            p.Color = Color.Blue;
            p.DashStyle = DashStyle.Solid;

            // 绘制钻尖，特殊处理
            fPos = DrawDrill(g, p, 0d, 6d, 0d, 0d, 140d, 0f);                    // 钻尖直径、锥度需要从主页获取
            step_N++;

            // 根据表格参数循环作图
            for (i = 0; i < ns; i++)
            {
                if (i == 0)
                    d = 6d;                                                         // 第一台阶 钻尖直径已给出
                else
                    d = arrD[i];  // 小端直径为上一台阶直径

                if (i == ns - 1)
                    D = 600;                                                        // 最后大端直径应为原料直径
                else
                    D = arrD[i];      // 否则大端直径为表格参数

                a = arrA1[i];          // 当前台阶尾部锥度
                r1 = arrR1[i];
                r2 = arrR2[i];

                // 从0开始
                if (arrLen[i] == 1)
                {
                    l = 15;
                    //l = Convert.ToDouble(this.dgvGrid.Rows[i].Cells[3].Value) + (double)fPosBgn[step_N - 1];
                }
                // 从圆柱起点开始
                else if (arrLen[i] == 2)
                {
                    l = 12;
                    //l = Convert.ToDouble(this.dgvGrid.Rows[i].Cells[3].Value) + (double)fPosBgn[step_N - 1] - (double)fPosBgn[0];
                }
                // 阶梯长度
                else if (arrLen[i] == 3)
                {
                    l = 5;
                    //l = Convert.ToDouble(this.dgvGrid.Rows[i].Cells[3].Value);
                }
                // 阶梯长度+过渡
                else
                {
                    l = 8;
                    //l = Convert.ToDouble(this.dgvGrid.Rows[i].Cells[3].Value) - (-(double)fPosBgn[step_N - 1] + (double)fPosEnd[step_N - 1]);
                }

                // 根据阶梯形状绘制
                switch (arrShape[i])
                {
                    case 1: // 锥形
                        fPos = DrawDrill(g, p, d, D, 0d, l, a, fPos);
                        break;
                    case 2: // 锥形+圆角
                        //fPos = DrawDrill(g, p, d, D, 0d, l, a, r1, r2, fPos);
                        break;
                    case 3: // 双锥内凹
                        fPos = DrawDrill(g, p, d, D, 0d, l, a, fPos);
                        break;
                    case 4: // 双锥内凹+圆角
                        //fPos = DrawDrill(g, p, d, D, 0d, l, a, fPos);
                        break;
                    case 5: // 双锥外凸
                        //fPos = DrawDrill(g, p, d, D, 0d, l, a, fPos);
                        break;
                    case 6: // 双锥外凸+圆角
                        //fPos = DrawDrill(g, p, d, D, 0d, l, a, fPos);
                        break;
                    default:
                        fPos = DrawDrill(g, p, d, D, 0d, l, a, fPos);
                        break;
                }
                step_N++;
            }

            step_N = 0;
            #endregion
        }

        /// <summary>
        /// 绘制钻头
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p">画笔</param>
        /// <param name="d">小端直径</param>
        /// <param name="D">大端直径</param>
        /// <param name="l_left">圆柱部分长度(左边部分)</param>
        /// <param name="l_right">圆柱部分长度(右边部分)</param>
        /// <param name="a">钻尖锥角</param>
        /// <param name="fPos">起始位置</param>
        /// <returns>终点位置</returns>
        private float DrawDrill(Graphics g, Pen p, double d, double D, double l_left, double l_right, double a, float fPos)
        {
            Point p1, p2, p3, p4, p5, p6, p7, p8;

            g.Transform = new Matrix(1, 0, 0, -1, p0.X, p0.Y);       // 设置矩阵

            // 计算点
            p1.X = p2.X = fPos;
            p3.X = p4.X = p1.X - (float)l_right;
            p5.X = p6.X = p3.X - (float)(0.5 * (D - d) / Tan(0.5 * a));
            p7.X = p8.X = p5.X - (float)l_left;
            p1.Y = +(float)(0.5 * d);
            p2.Y = -(float)(0.5 * d);
            p3.Y = +(float)(0.5 * d);
            p4.Y = -(float)(0.5 * d);
            p5.Y = p7.Y = +(float)(0.5 * D);
            p6.Y = p8.Y = -(float)(0.5 * D);

            g.DrawLine(p, p1.X, p1.Y, p3.X, p3.Y);
            g.DrawLine(p, p3.X, p3.Y, p5.X, p5.Y);
            g.DrawLine(p, p7.X, p7.Y, p5.X, p5.Y);
            g.DrawLine(p, p4.X, p4.Y, p2.X, p2.Y);
            g.DrawLine(p, p4.X, p4.Y, p6.X, p6.Y);
            g.DrawLine(p, p8.X, p8.Y, p6.X, p6.Y);

            g.DrawLine(p, p1.X, p1.Y, p2.X, p2.Y);
            g.DrawLine(p, p3.X, p3.Y, p4.X, p4.Y);
            g.DrawLine(p, p5.X, p5.Y, p6.X, p6.Y);
            g.DrawLine(p, p7.X, p7.Y, p8.X, p8.Y);

            fPos = p7.X;
            //fPosBgn[nStep] = p5.X;                                          // 圆柱起点位置
            //fPosEnd[nStep] = p3.X;                                          // 锥角起点位置
            return fPos;
        }

        #region 三角函数

        private const double PI = Math.PI;
        private const double A2R = Math.PI / 180d;
        private const double R2A = 180d / Math.PI;

        private double Sin(double a) { return Math.Sin(a * A2R); }
        private double Cos(double a) { return Math.Cos(a * A2R); }
        private double Tan(double a) { return Math.Tan(a * A2R); }

        #endregion

    }
}
