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
        /// 
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p0">绝对值位置作为坐标原点</param>
        /// <param name="p">画笔</param>
        public static void DrawCoordinate(Graphics g, Point p0, Pen p)
        {
            Console.WriteLine("坐标系原点绝对值位置为：({0}, {1})", p0.X, p0.Y);
            g.Transform = new Matrix(1, 0, 0, 1, p0.X, p0.Y);

            Point x1 = new Point(-1000, 0);
            Point x2 = new Point(1000, 0);
            Point y1 = new Point(0, 1000);
            Point y2 = new Point(0, -1000);

            g.DrawLine(p, x1, x2);
            g.DrawLine(p, y1, y2);
        }

        /// <summary>
        /// 绘制XY轴
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p">画笔</param>
        /// <param name="p0">绝对值位置作为坐标原点</param>
        public static void DrawAxisXY(Graphics g, Pen p, Point p0)
        {
            g.Transform = new Matrix(1, 0, 0, 1, p0.X, p0.Y);

            Point x1 = new Point(-1000, 0);
            Point x2 = new Point(1000, 0);
            Point y1 = new Point(0, 1000);
            Point y2 = new Point(0, -1000);

            g.DrawLine(p, x1, x2);
            g.DrawLine(p, y1, y2);
        }

        /// <summary>
        /// 绘制砂轮侧视图
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p">画笔</param>
        /// <param name="startPos">起始点</param>
        /// <param name="radius">半径</param>
        /// <param name="thickness">厚度</param>
        public static void DrawWhl1(Graphics g, Pen p, int startPos, float radius, float thickness)
        {
            Point p1, p2, p3, p4;
            p1 = new Point(startPos, (int)radius);
            p2 = new Point(startPos, -(int)radius);
            p3 = new Point(startPos + (int)thickness, (int)radius);
            p4 = new Point(startPos + (int)thickness, -(int)radius);

            g.DrawLine(p, p1, p2);
            g.DrawLine(p, p3, p4);
            g.DrawLine(p, p1, p3);
            g.DrawLine(p, p2, p4);
        }
    }
}
