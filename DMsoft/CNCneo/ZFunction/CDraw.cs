using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Drawing.Drawing2D;

namespace CNCneo
{
    public class CDraw
    {
        /// <summary>
        /// 设置坐标系
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p0">绝对值位置作为坐标原点</param>
        public static void SetCoordinate(Graphics g, Point p0)
        {
            Console.WriteLine("坐标系原点绝对值位置为：({0}, {1})", p0.X, p0.Y);
            g.Transform = new Matrix(1, 0, 0, 1, p0.X, p0.Y);
        }

        /// <summary>
        /// 设置放大比例
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p0">绝对值位置作为坐标原点</param>
        /// <param name="rate">放大比例</param>
        public static void SetCoordinate(Graphics g, Point p0, float rate)
        {
            g.Transform = new Matrix(rate, 0, 0, rate, p0.X, p0.Y);
        }

        /// <summary>
        /// 绘制XY轴
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p">画笔</param>
        public static void DrawAxisXY(Graphics g, Pen p)
        {
            Point x1 = new Point(-1000, 0);
            Point x2 = new Point(1000, 0);
            Point y1 = new Point(0, 1000);
            Point y2 = new Point(0, -1000);

            g.DrawLine(p, x1, x2);
            g.DrawLine(p, y1, y2);
        }
    }
}
