﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DrawPics.ToolObj;
using DrawPics.Test;

namespace DrawPics
{
    public partial class MyDraw : Form
    {
        private Point p0 = new Point();                                     // 原点坐标
        private Point mouseDownPoint = new Point();
        private Point p0_tmp = new Point();

        private float m11, m12, m21, m22;                                   // 矩阵值
        private float rate;                                                 // 比例

        private int nStep = 0;                                              // 当前绘制第nStep阶梯
        private float fPos;                                                 // X轴绘制起始点
        private float[] fPosBgn = new float[10];                            // 阶梯圆柱起点位置
        private float[] fPosEnd = new float[10];                            // 阶梯圆柱终点位置

        private bool MouseIsHold = false;                                   // 鼠标是否长按

        public MyDraw()
        {
            InitializeComponent();
            Init();
        }

        // 作图按钮
        private void btnDraw_Click(object sender, EventArgs e)
        {
            this.m11 = 1f * rate;
            this.m12 = 0f;
            this.m21 = 0f;
            this.m22 = -1f * rate;

            this.tDraw.Enabled = true;
        }

        // 作图
        private void tDraw_Tick(object sender, EventArgs e)
        {
            Pen p = new Pen(Color.Blue, 0.5f);

            DrawCoor(pbMain.CreateGraphics(), p);

            StepDrill msd = new StepDrill(20, 10);
            msd.Draw(pbMain.CreateGraphics(), p);

            this.tDraw.Enabled = false;
        }

        // 单击表格
        private void dgvGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = this.dgvGrid.CurrentCell.RowIndex;
            int iCol = this.dgvGrid.CurrentCell.ColumnIndex;

        }

        #region 初始化

        /// <summary>
        /// 初始化表格
        /// </summary>
        private void InitDGV()
        {
            this.dgvGrid.Rows.Add(6);                                           // 设置表格行数为6

            for (int i = 0; i < this.dgvGrid.Rows.Count; i++)
            {
                for (int j = 0; j < this.dgvGrid.Columns.Count; j++)
                {
                    this.dgvGrid.Rows[i].Cells[j].Value = "20";                 // 表格赋值默认值
                }
            }

            this.dgvGrid.Rows[0].Cells[0].Value = "1";
            this.dgvGrid.Rows[1].Cells[0].Value = "2";
            this.dgvGrid.Rows[2].Cells[0].Value = "3";
            this.dgvGrid.Rows[3].Cells[0].Value = "4";
            this.dgvGrid.Rows[4].Cells[0].Value = "5";
            this.dgvGrid.Rows[5].Cells[0].Value = "6";

            this.dgvGrid.Rows[0].Cells[1].Value = "1";
            this.dgvGrid.Rows[1].Cells[1].Value = "2";
            this.dgvGrid.Rows[2].Cells[1].Value = "3";
            this.dgvGrid.Rows[3].Cells[1].Value = "4";

            this.dgvGrid.Rows[0].Cells[2].Value = "8";
            this.dgvGrid.Rows[1].Cells[2].Value = "15";
            this.dgvGrid.Rows[2].Cells[2].Value = "20";
            this.dgvGrid.Rows[3].Cells[2].Value = "24";
            this.dgvGrid.Rows[4].Cells[2].Value = "36";
            this.dgvGrid.Rows[5].Cells[2].Value = "48";

            this.dgvGrid.Rows[0].Cells[3].Value = "20";
            this.dgvGrid.Rows[1].Cells[3].Value = "30";
            this.dgvGrid.Rows[2].Cells[3].Value = "40";
            this.dgvGrid.Rows[3].Cells[3].Value = "50";
            this.dgvGrid.Rows[4].Cells[3].Value = "60";
            this.dgvGrid.Rows[5].Cells[3].Value = "70";

            this.dgvGrid.Rows[0].Cells[4].Value = "90";
            this.dgvGrid.Rows[1].Cells[4].Value = "60";
            this.dgvGrid.Rows[2].Cells[4].Value = "100";
            this.dgvGrid.Rows[3].Cells[4].Value = "90";
            this.dgvGrid.Rows[4].Cells[4].Value = "80";
            this.dgvGrid.Rows[5].Cells[4].Value = "60";

        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void Init()
        {
            this.rate = 1f;                                                 // 比例默认为1
            this.p0.X = 900f;
            this.p0.Y = 250f;

            InitDGV();
        }

        #endregion

        #region 画图操作

        private void Draw(Graphics g, Pen p)
        {
            #region 绘制钻头

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
            nStep++;

            // 根据表格参数循环作图
            for (i = 0; i < this.dgvGrid.Rows.Count; i++)
            {
                if (i == 0)
                    d = 6d;                                                         // 第一台阶 钻尖直径已给出
                else
                    d = Convert.ToDouble(this.dgvGrid.Rows[i - 1].Cells[2].Value);  // 小端直径为上一台阶直径

                if (i == this.dgvGrid.Rows.Count - 1)
                    D = 600;                                                        // 最后大端直径应为原料直径
                else
                    D = Convert.ToDouble(this.dgvGrid.Rows[i].Cells[2].Value);      // 否则大端直径为表格参数

                a = Convert.ToDouble(this.dgvGrid.Rows[i].Cells[4].Value);          // 当前台阶尾部锥度
                r1 = Convert.ToDouble(this.dgvGrid.Rows[i].Cells[5].Value);
                r2 = Convert.ToDouble(this.dgvGrid.Rows[i].Cells[6].Value);

                // 从0开始
                if (Convert.ToInt32(this.dgvGrid.Rows[i].Cells[1].Value) == 1)
                {
                    l = Convert.ToDouble(this.dgvGrid.Rows[i].Cells[3].Value) + (double)fPosBgn[nStep - 1];
                }
                // 从圆柱起点开始
                else if (Convert.ToInt32(this.dgvGrid.Rows[i].Cells[1].Value) == 2)
                {
                    l = Convert.ToDouble(this.dgvGrid.Rows[i].Cells[3].Value) + (double)fPosBgn[nStep - 1] - (double)fPosBgn[0];
                }
                // 阶梯长度
                else if (Convert.ToInt32(this.dgvGrid.Rows[i].Cells[1].Value) == 3)
                {
                    l = Convert.ToDouble(this.dgvGrid.Rows[i].Cells[3].Value);
                }
                // 阶梯长度+过渡
                else
                {
                    l = Convert.ToDouble(this.dgvGrid.Rows[i].Cells[3].Value) - (-(double)fPosBgn[nStep - 1] + (double)fPosEnd[nStep - 1]);
                }

                // 根据阶梯形状绘制
                switch (Convert.ToInt32(this.dgvGrid.Rows[i].Cells[0].Value))
                {
                    case 1: // 锥形
                        fPos = DrawDrill(g, p, d, D, 0d, l, a, fPos);
                        break;
                    case 2: // 锥形+圆角
                        fPos = DrawDrill(g, p, d, D, 0d, l, a, r1, r2, fPos);
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
                        //fPos = DrawDrill(pbMain.CreateGraphics(), p, d, D, l, a, fPos);
                        break;
                }
                nStep++;
            }

            nStep = 0;
            #endregion
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

            g.Transform = new Matrix(m11, m12, m21, m22, p0.X, p0.Y);       // 设置矩阵

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
            fPosBgn[nStep] = p5.X;                                          // 圆柱起点位置
            fPosEnd[nStep] = p3.X;                                          // 锥角起点位置
            return fPos;
        }

        /// <summary>
        /// 绘制带R角钻头
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p">画笔</param>
        /// <param name="d">小端直径</param>
        /// <param name="D">大端直径</param>
        /// <param name="l_right">圆柱部分长度</param>
        /// <param name="l_left">圆柱部分长度</param>
        /// <param name="a">钻尖锥角</param>
        /// <param name="R1">R1角</param>
        /// <param name="R2">R2角</param>
        /// <param name="fPos">起始位置</param>
        /// <returns>终点位置</returns>
        private float DrawDrill(Graphics g, Pen p, double d, double D, double l_left, double l_right, double a, double R1, double R2, float fPos)
        {
            Point p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12;            // 钻头图形上点
            Point p_A1, p_A2, p_A3, p_A4;                                       // 圆弧辅助点
            Point p_t1, p_t2, p_t3, p_t4;                                       // 钻头图辅助点

            g.Transform = new Matrix(m11, m12, m21, m22, p0.X, p0.Y);           // 设置矩阵

            // 计算点
            p1.X = p2.X = fPos;
            p1.Y = +(float)(0.5 * d);
            p2.Y = -(float)(0.5 * d);

            p_t1.X = p_t2.X = fPos - (float)l_right;
            p_t1.Y = +(float)(0.5 * d);
            p_t2.Y = -(float)(0.5 * d);

            p3.X = p4.X = p_t1.X + (float)(R1 * Tan(0.25 * a));
            p3.Y = +(float)(0.5 * d);
            p4.Y = -(float)(0.5 * d);

            p5.X = p6.X = p3.X - (float)(2d * R1 * Sin(0.25 * a) * Cos(0.25 * a));
            p5.Y = p3.Y + (float)(2d * R1 * Sin(0.25 * a) * Sin(0.25 * a));
            p6.Y = p4.Y - (float)(2d * R1 * Sin(0.25 * a) * Sin(0.25 * a));

            p_t3.X = p_t4.X = p_t1.X - (float)(0.5 * (D - d) / Tan(0.5 * a));
            p_t3.Y = +(float)(0.5 * D);
            p_t4.Y = -(float)(0.5 * D);

            p9.X = p10.X = p_t3.X - (float)(R2 * Tan(0.25 * a));
            p9.Y = +(float)(0.5 * D);
            p10.Y = -(float)(0.5 * D);

            p7.X = p8.X = p9.X + (float)(2d * R2 * Sin(0.25 * a) * Cos(0.25 * a));
            p7.Y = p9.Y - (float)(2d * R2 * Sin(0.25 * a) * Sin(0.25 * a));
            p8.Y = p10.Y + (float)(2d * R2 * Sin(0.25 * a) * Sin(0.25 * a));

            p11.X = p12.X = p_t3.X - (float)l_left;
            p11.Y = +(float)(0.5 * D);
            p12.Y = -(float)(0.5 * D);

            // 钻头除圆角之外的连线
            g.DrawLine(p, p1.X, p1.Y, p3.X, p3.Y);
            g.DrawLine(p, p5.X, p5.Y, p7.X, p7.Y);
            //g.DrawLine(p, p9.X, p9.Y, p11.X, p11.Y);

            g.DrawLine(p, p2.X, p2.Y, p4.X, p4.Y);
            g.DrawLine(p, p6.X, p6.Y, p8.X, p8.Y);
            //g.DrawLine(p, p10.X, p10.Y, p12.X, p12.Y);

            g.DrawLine(p, p1.X, p1.Y, p2.X, p2.Y);
            g.DrawLine(p, p3.X, p3.Y, p4.X, p4.Y);
            g.DrawLine(p, p5.X, p5.Y, p6.X, p6.Y);
            g.DrawLine(p, p7.X, p7.Y, p8.X, p8.Y);
            g.DrawLine(p, p9.X, p9.Y, p10.X, p10.Y);
            //g.DrawLine(p, p11.X, p11.Y, p12.X, p12.Y);

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

            fPos = p9.X;
            fPosBgn[nStep] = p_t3.X;                                          // 圆柱起点位置
            fPosEnd[nStep] = p_t1.X;                                          // 锥角起点位置
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

            g.DrawArc(p, P.X, P.Y, (float)R * 2, (float)R * 2, (float)start, (float)a);

            return fPos;
        }

        #endregion

        #region 实现拖曳和等比例放大功能

        // 按下鼠标
        private void pbMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                p0_tmp.X = p0.X;                                            // 保护起来
                p0_tmp.Y = p0.Y;

                mouseDownPoint.X = e.X;
                mouseDownPoint.Y = e.Y;

                pbMain.Cursor = Cursors.SizeAll;
                MouseIsHold = true;
            }
        }
        // 松开鼠标
        private void pbMain_MouseUp(object sender, MouseEventArgs e)
        {
            MouseIsHold = false;
            pbMain.Cursor = Cursors.Default;
        }
        // 移动鼠标
        private void pbMain_MouseMove(object sender, MouseEventArgs e)
        {
            Pen p = new Pen(Color.Blue, 0.5f);
            if (MouseIsHold)
            {
                p0.X = p0_tmp.X + e.X - mouseDownPoint.X;
                p0.Y = p0_tmp.Y + e.Y - mouseDownPoint.Y;

                this.tDraw.Enabled = true;

                this.lPointInfo.Text =  "\n 鼠标坐标X:"  + e.X.ToString()       + ", Y:"  + e.Y.ToString() + 
                                        "\n 坐标系原点X0:" + p0.X.ToString()      + ", Y0:" + p0.Y.ToString() +
                                        "\n 点击坐标X1:" + mouseDownPoint.X.ToString() + ", Y1:" + mouseDownPoint.Y.ToString() +
                                        "\n 鼠标与点击点差值X-X1:" + (e.X - mouseDownPoint.X).ToString() + ", Y-Y1:" + (e.Y - mouseDownPoint.Y).ToString() +
                                        "\n 新坐标系原点newX0:" + (p0.X + e.X - mouseDownPoint.X).ToString() + ", newY0:" + (p0.Y + e.Y - mouseDownPoint.Y).ToString();
           
            }
        }

        // 修改绘图比例
        private void nRate_ValueChanged(object sender, EventArgs e)
        {
            this.rate = (float)(this.nRate.Value / 100);

            this.m11 = 1f * rate;
            this.m12 = 0f;
            this.m21 = 0f;
            this.m22 = -1f * rate;

            this.tDraw.Enabled = true;
        }

        #endregion

        #region 三角函数

        private const double PI = Math.PI;
        private const double A2R = Math.PI / 180d;
        private const double R2A = 180d / Math.PI;

        private double Sin(double a) { return Math.Sin(a * A2R); }
        private double Cos(double a) { return Math.Cos(a * A2R); }
        private double Tan(double a) { return Math.Tan(a * A2R); }

        #endregion

        #region 临时不用

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

            return fPos;
        }

        #endregion 

        private void btnTest_Click(object sender, EventArgs e)
        {
            this.Hide();

            MultiLan ml = new MultiLan();
            ml.ShowDialog();

            this.Show();
        }
    }
}
