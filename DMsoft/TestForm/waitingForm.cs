using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing;
using System.Drawing.Drawing2D;

namespace TestForm
{
    public partial class waitingForm : Form
    {
        private const float CIR_ANGLE = 360;        // 360°
        private int tickNo = 1;                     // 计次数
        private int subNum = 12;                    // 圈圈分subNum段

        public waitingForm()
        {
            InitializeComponent();
            this.tDraw.Enabled = true;
        }

        // 绘制等待圈圈事件
        private void tDraw_Tick(object sender, EventArgs e)
        {
            if (tickNo <= 100)
            {
                Draw();
                tickNo++;
            }
            else
            {
                tickNo = 1;
            }
        }

        /// <summary>
        /// 绘制等待圈圈
        /// </summary>
        private void Draw()
        {
            Point p0 = new Point(this.Width / 2, this.Height / 2);  // 坐标原点设在窗口正中
            Graphics g = this.CreateGraphics();                     // 创建画布

            this.TransparencyKey = Color.LightGray;                 // 背景色设置为透明
            this.BackColor = Color.LightGray;

            SetCoordinate(g, p0);                                   // 设置坐标原点
            DrawWaiting(g, tickNo % subNum);                        // 开始作图
            //DrawIronCircle(g, tickNo % subNum);                        // 开始作图
        }

        /// <summary>
        /// 绘制等待圈圈
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="no">第no个原色圆弧</param>
        public void DrawWaiting(Graphics g, int no)
        {
            float lineThickness = 50f;                          // 线粗细大小
            float waitingR = 100f;                              // 等待圈圈的半径
            Color lineColor = Color.Gray;                       // 线颜色
            Pen p = new Pen(lineColor, lineThickness);          // 画笔

            p.Color = Color.FromArgb(255, lineColor);                                       // 画笔原始色
            g.DrawArc(p, -waitingR, -waitingR, 2f * waitingR, 2f * waitingR, no * CIR_ANGLE / subNum, CIR_ANGLE / subNum / 2);  // 绘制等待圈圈首个圆弧
            for (int i = 1; i < subNum; i++)
            {
                p.Color = Color.FromArgb(255 - i * 255 / (subNum + 1), lineColor);                                      // 原始色逐渐淡化
                g.DrawArc(p, -waitingR, -waitingR, 2f * waitingR, 2f * waitingR, (no + i) * CIR_ANGLE / subNum, CIR_ANGLE / subNum / 2);    // 依次绘制等待圈圈后续圆弧
            }
        }

        /// <summary>
        /// 设置坐标系
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p0">绝对值位置作为坐标原点</param>
        public void SetCoordinate(Graphics g, Point p0)
        {
            g.Transform = new Matrix(1, 0, 0, 1, p0.X, p0.Y);
            g.Clear(Color.LightGray);
        }

        // 绘制反应堆
        public void DrawIronCircle(Graphics g, int no)
        {
            float lineThickness = 50f;                          // 线粗细大小
            float waitingR = 100f;                              // 等待圈圈的半径
            //Color lineColor = Color.FromArgb(220, 220, 220);    // 线颜色
            Color lineColor = Color.White;                      // 线颜色
            Pen p = new Pen(lineColor, lineThickness);          // 画笔

            Pen p1 = new Pen(Color.Blue, 2f);
            g.DrawArc(p1, -125, -125, 250, 250, 0, 360);
            g.DrawArc(p1, -75, -75, 150, 150, 0, 360);

            p.Color = Color.FromArgb(255, lineColor);                                       // 画笔原始色
            g.DrawArc(p, -waitingR, -waitingR, 2f * waitingR, 2f * waitingR, no * CIR_ANGLE / subNum, CIR_ANGLE / subNum / 2);  // 绘制等待圈圈首个圆弧
            for (int i = 1; i < subNum; i++)
            {
                p.Color = Color.FromArgb(255 - i * 255 / (subNum + 1), lineColor);                                      // 原始色逐渐淡化
                g.DrawArc(p, -waitingR, -waitingR, 2f * waitingR, 2f * waitingR, (no + i) * CIR_ANGLE / subNum, CIR_ANGLE / subNum / 2);    // 依次绘制等待圈圈后续圆弧
            }

            // 画内部圈
            //p.Width = 25f;
            g.DrawArc(p, -waitingR / 2, -waitingR / 2, waitingR, waitingR, no * CIR_ANGLE / subNum / 4, CIR_ANGLE / subNum / 8);  // 绘制等待圈圈首个圆弧
            for (int i = 1; i < subNum * 4; i++)
            {
                g.DrawArc(p, -waitingR / 2, -waitingR / 2, waitingR, waitingR, (no + i) * CIR_ANGLE / subNum / 4, CIR_ANGLE / subNum / 8);    // 依次绘制等待圈圈后续圆弧
            }

            p1.Width = 5f;
            g.DrawArc(p1, -45, -45, 90, 90, 0, 360);
        }
    }
}
