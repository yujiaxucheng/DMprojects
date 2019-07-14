using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawPics
{
    public partial class MyDraw : Form
    {
        private Point p0 = new Point();             // 原点坐标
        private Point pArc = new Point();           // 圆弧参考点坐标
        private float m11, m12, m21, m22;           // 矩阵值
        private float fPos;                         // X轴绘制起始点

        private double L1, D1, a1;                  // 定义钻头长度、直径、角度
        private double L2, D2, a2;
        private double R1, sa, swa;                 // 圆角半径 起始角，扫过角度

        public MyDraw()
        {
            InitializeComponent();
            Init();
        }

        #region 三角函数

        private const double PI = Math.PI;
        private const double A2R = Math.PI / 180d;
        private const double R2A = 180d / Math.PI;

        private double Sin(double a) { return Math.Sin(a * A2R); }
        private double Cos(double a) { return Math.Cos(a * A2R); }
        private double Tan(double a) { return Math.Tan(a * A2R); }

        #endregion

        // 作图按钮
        private void btnDraw_Click(object sender, EventArgs e)
        {
            this.p0.X = Convert.ToSingle(this.tbX.Text);
            this.p0.Y = Convert.ToSingle(this.tbY.Text);

            this.m11 = Convert.ToSingle(this.tbM11.Text);
            this.m12 = Convert.ToSingle(this.tbM12.Text);
            this.m21 = Convert.ToSingle(this.tbM21.Text);
            this.m22 = Convert.ToSingle(this.tbM22.Text);

            this.L1 = Convert.ToSingle(this.tbL1.Text);
            this.D1 = Convert.ToSingle(this.tbD1.Text);
            this.a1 = Convert.ToSingle(this.tba1.Text);

            this.L2 = Convert.ToSingle(this.tbL2.Text);
            this.D2 = Convert.ToSingle(this.tbD2.Text);
            this.a2 = Convert.ToSingle(this.tba2.Text);

            this.R1 = Convert.ToSingle(this.tbR1.Text);

            this.tDraw.Enabled = true;
        }

        // 作图
        private void tDraw_Tick(object sender, EventArgs e)
        {
            Pen p = new Pen(Color.Blue, 0.5f);

            DrawCoor(pbMain.CreateGraphics(), p);

            fPos = DrawDrill(pbMain.CreateGraphics(), p, D1, D2, L1, L2, a1, R1, R1, 0f);

            this.tDraw.Enabled = false;
        }

        #region 自定义方法

        /// <summary>
        /// 初始化
        /// </summary>
        private void Init()
        {
            this.tbX.Text = "900";
            this.tbY.Text = "250";
            
            this.tbM11.Text = "1";
            this.tbM12.Text = "0";
            this.tbM21.Text = "0";
            this.tbM22.Text = "-1";

            this.tbL1.Text = "180";
            this.tbD1.Text = "90";
            this.tba1.Text = "120";
            this.tbL2.Text = "300";
            this.tbD2.Text = "200";
            this.tba2.Text = "90";

            this.tbR1.Text = "50";

            pArc.X = -298;
            pArc.Y = 25;
            sa = 90;
            swa = -60;

            this.dgvGrid.Rows.Add(6);
        }

        /// <summary>
        /// 绘制坐标系
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p">画笔</param>
        private void DrawCoor(Graphics g, Pen p)
        {
            Font f = new Font("Arial", 6);
            Brush b = Brushes.Blue;

            g.Clear(Color.LightGray);
            g.Transform = new Matrix(m11, m12, m21, m22, p0.X, p0.Y);       // 设置矩阵

            p.Color = Color.Red;
            p.DashStyle = DashStyle.DashDot;                                // 线型
            g.DrawLine(p, -1000f, 0f, 1000f, 0f);                           // 绘制X轴
            g.DrawLine(p, 0f, -1000f, 0f, 1000f);                           // 绘制Y轴
        }

        /// <summary>
        /// 绘制钻头
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p">画笔</param>
        /// <param name="D1">小端直径</param>
        /// <param name="D2">大端直径</param>
        /// <param name="L">圆柱部分长度</param>
        /// <param name="a">钻尖锥角</param>
        /// <param name="fPos">起始位置</param>
        /// <returns>终点位置</returns>
        private float DrawDrill(Graphics g, Pen p, double D1, double D2, double L, double a, float fPos)
        {
            Point p1, p2, p3, p4, p5, p6;

            g.Transform = new Matrix(m11, m12, m21, m22, p0.X, p0.Y);       // 设置矩阵
            p.Color = Color.Blue;                                           // 线颜色
            p.DashStyle = DashStyle.Solid;                                  // 线型

            // 计算点
            p1.X = p2.X = fPos;
            p3.X = p4.X = fPos - (float)(0.5 * (D2 - D1) / Tan(0.5 * a));
            p5.X = p6.X = p3.X - (float)L;
            p1.Y = +(float)(0.5 * D1);
            p2.Y = -(float)(0.5 * D1);
            p3.Y = p5.Y = +(float)(0.5 * D2);
            p4.Y = p6.Y = -(float)(0.5 * D2);

            g.DrawLine(p, p1.X, p1.Y, p3.X, p3.Y);
            g.DrawLine(p, p5.X, p5.Y, p3.X, p3.Y);
            g.DrawLine(p, p2.X, p2.Y, p4.X, p4.Y);
            g.DrawLine(p, p6.X, p6.Y, p4.X, p4.Y);

            g.DrawLine(p, p1.X, p1.Y, p2.X, p2.Y);
            g.DrawLine(p, p3.X, p3.Y, p4.X, p4.Y);
            g.DrawLine(p, p5.X, p5.Y, p6.X, p6.Y);

            fPos = p5.X;
            return fPos;
        }

        /// <summary>
        /// 绘制带R角钻头
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p">画笔</param>
        /// <param name="D1">小端直径</param>
        /// <param name="D2">大端直径</param>
        /// <param name="L1">圆柱部分长度</param>
        /// <param name="L2">圆柱部分长度</param>
        /// <param name="a">钻尖锥角</param>
        /// <param name="R1">R1角</param>
        /// <param name="R2">R2角</param>
        /// <param name="fPos">起始位置</param>
        /// <returns>终点位置</returns>
        private float DrawDrill(Graphics g, Pen p, double D1, double D2, double L1, double L2, double a, double R1, double R2, float fPos)
        {
            Point p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12;            // 钻头图形上点
            Point p_A1, p_A2, p_A3, p_A4;                                       // 圆弧辅助点
            Point p_t1, p_t2, p_t3, p_t4;                                       // 钻头图辅助点

            g.Transform = new Matrix(m11, m12, m21, m22, p0.X, p0.Y);           // 设置矩阵
            p.Color = Color.Blue;                                               // 线颜色
            p.DashStyle = DashStyle.Solid;                                      // 线型

            // 计算点
            p1.X = p2.X = fPos; ;
            p1.Y = +(float)(0.5 * D1);
            p2.Y = -(float)(0.5 * D1);

            p_t1.X = p_t2.X = fPos - (float)L1; ;
            p_t1.Y = +(float)(0.5 * D1);
            p_t2.Y = -(float)(0.5 * D1);

            p3.X = p4.X = p_t1.X + (float)(R1 * Tan(0.25 * a));
            p3.Y = +(float)(0.5 * D1);
            p4.Y = -(float)(0.5 * D1);

            p5.X = p6.X = p3.X - (float)(2d * R1 * Sin(0.25 * a) * Cos(0.25 * a));
            p5.Y = p3.Y + (float)(2d * R1 * Sin(0.25 * a) * Sin(0.25 * a));
            p6.Y = p4.Y - (float)(2d * R1 * Sin(0.25 * a) * Sin(0.25 * a));

            p_t3.X = p_t4.X = p_t1.X - (float)(0.5 * (D2 - D1) / Tan(0.5 * a));
            p_t3.Y = +(float)(0.5 * D2);
            p_t4.Y = -(float)(0.5 * D2);

            p9.X = p10.X = p_t3.X - (float)(R1 * Tan(0.25 * a));
            p9.Y = +(float)(0.5 * D2);
            p10.Y = -(float)(0.5 * D2);

            p7.X = p8.X = p9.X + (float)(2d * R1 * Sin(0.25 * a) * Cos(0.25 * a));
            p7.Y = p9.Y - (float)(2d * R1 * Sin(0.25 * a) * Sin(0.25 * a));
            p8.Y = p10.Y + (float)(2d * R1 * Sin(0.25 * a) * Sin(0.25 * a));

            p11.X = p12.X = p_t3.X - (float)L2;
            p11.Y = +(float)(0.5 * D2);
            p12.Y = -(float)(0.5 * D2);

            // 钻头除圆角之外的连线
            g.DrawLine(p, p1.X, p1.Y, p3.X, p3.Y);
            g.DrawLine(p, p5.X, p5.Y, p7.X, p7.Y);
            g.DrawLine(p, p9.X, p9.Y, p11.X, p11.Y);

            g.DrawLine(p, p2.X, p2.Y, p4.X, p4.Y);
            g.DrawLine(p, p6.X, p6.Y, p8.X, p8.Y);
            g.DrawLine(p, p10.X, p10.Y, p12.X, p12.Y);

            g.DrawLine(p, p1.X, p1.Y, p2.X, p2.Y);
            g.DrawLine(p, p3.X, p3.Y, p4.X, p4.Y);
            g.DrawLine(p, p5.X, p5.Y, p6.X, p6.Y);
            g.DrawLine(p, p7.X, p7.Y, p8.X, p8.Y);
            g.DrawLine(p, p9.X, p9.Y, p10.X, p10.Y);
            g.DrawLine(p, p11.X, p11.Y, p12.X, p12.Y);

            // 圆弧辅助矩形左下顶点
            p_A1.X = p3.X - (float)R1;
            p_A1.Y = p3.Y;
            p_A2.X = p4.X - (float)R1;
            p_A2.Y = p4.Y - (float)(2d * R1);
            p_A3.X = p9.X - (float)R2;
            p_A3.Y = p9.Y - (float)(2d * R2);
            p_A4.X = p10.X - (float)R2;
            p_A4.Y = p10.Y;

            DrawArc(g, p, p_A1, R1, -90, -(a * 0.5));
            DrawArc(g, p, p_A2, R1, 90, (a * 0.5));
            DrawArc(g, p, p_A3, R2, 90, -(a * 0.5));
            DrawArc(g, p, p_A4, R2, -90, (a * 0.5));

            this.lPointInfo.Text = "";
            PrintPoint(this.lPointInfo, p1, "p1");
            PrintPoint(this.lPointInfo, p2, "p2");
            PrintPoint(this.lPointInfo, p3, "p3");
            PrintPoint(this.lPointInfo, p4, "p4");
            PrintPoint(this.lPointInfo, p5, "p5");
            PrintPoint(this.lPointInfo, p6, "p6");
            PrintPoint(this.lPointInfo, p7, "p7");
            PrintPoint(this.lPointInfo, p8, "p8");
            PrintPoint(this.lPointInfo, p9, "p9");
            PrintPoint(this.lPointInfo, p10, "p10");
            PrintPoint(this.lPointInfo, p11, "p11");
            PrintPoint(this.lPointInfo, p12, "p12");

            fPos = p11.X;
            return fPos;
        }

        /// <summary>
        /// 绘制圆弧曲线
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p">画笔</param>
        /// <param name="P">圆弧矩阵坐标</param>
        /// <param name="R">半径</param>
        /// <param name="start">起始角</param>
        /// <param name="a">顺时针扫过角</param>
        private float DrawArc(Graphics g, Pen p, Point P, double R, double start, double a)
        {
            g.Transform = new Matrix(m11, m12, m21, m22, p0.X, p0.Y);       // 设置矩阵
            p.Color = Color.Blue;                                           // 线颜色
            p.DashStyle = DashStyle.Solid;                                  // 线型
            
            g.DrawArc(p, P.X, P.Y, (float)R * 2, (float)R * 2, (float)start, (float)a);

            return fPos;
        }

        // 临时输出点坐标
        private void PrintPoint(Label l, Point p, string name)
        {
            l.Text += "\n" + name + "：X:" + p.X.ToString() + "  " + "Y:" + p.Y.ToString();
        }

        /// <summary>
        /// 绘制钻尖
        /// </summary>
        /// <param name="L">长度</param>
        /// <param name="D">直径</param>
        /// <param name="a">角度</param>
        private float DrawTop(Graphics g, Pen p, double L, double D, double a)
        {
            Point p1, p2, p3, p4;

            g.Transform = new Matrix(m11, m12, m21, m22, p0.X, p0.Y);       // 设置矩阵

            // 计算点
            p1.X = p2.X = -(float)L;
            p3.X = p4.X = -(float)(0.5 * D * Tan(90d - 0.5 * a));
            p1.Y = p3.Y = +(float)(0.5 * D);
            p2.Y = p4.Y = -(float)(0.5 * D);
            fPos = -(float)L;

            p.Color = Color.Blue;                                           // 线颜色
            p.DashStyle = DashStyle.Solid;                                  // 线型
            g.DrawLine(p, p1.X, p1.Y, p3.X, p3.Y);
            g.DrawLine(p, 0f, 0f, p3.X, p3.Y);
            g.DrawLine(p, 0f, 0f, p4.X, p4.Y);
            g.DrawLine(p, p2.X, p2.Y, p4.X, p4.Y);

            return fPos;
        }

        /// <summary>
        /// 绘制中间过渡部分
        /// </summary>
        /// <param name="D1">小端直径</param>
        /// <param name="D2">大端直径</param>
        /// <param name="a">角度</param>
        /// <param name="fPos">绘图起点</param>
        private float DrawMid(Graphics g, Pen p, double D1, double D2, double a, float fPos)
        {
            Point p1, p2, p3, p4;

            g.Transform = new Matrix(m11, m12, m21, m22, p0.X, p0.Y);       // 设置矩阵

            // 计算点
            p1.X = p2.X = fPos - (float)((D2 - D1) / Tan(0.5 * a));
            p3.X = p4.X = fPos;
            p1.Y = +(float)(0.5 * D2);
            p2.Y = -(float)(0.5 * D2);
            p3.Y = +(float)(0.5 * D1);
            p4.Y = -(float)(0.5 * D1);
            fPos = p1.X;

            p.Color = Color.Blue;                                           // 线颜色
            p.DashStyle = DashStyle.Solid;                                  // 线型
            g.DrawLine(p, p1.X, p1.Y, p3.X, p3.Y);
            g.DrawLine(p, p2.X, p2.Y, p4.X, p4.Y);

            this.lPointInfo.Text = "";
            PrintPoint(this.lPointInfo, p0, "p0");
            PrintPoint(this.lPointInfo, p1, "p1");
            PrintPoint(this.lPointInfo, p2, "p2");
            PrintPoint(this.lPointInfo, p3, "p3");
            PrintPoint(this.lPointInfo, p4, "p4");

            return fPos;
        }

        #endregion
    }
}
