using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CNCneo.AWheel
{
    /// <summary>
    /// 砂轮父类
    /// </summary>
    public class CWheel
    {
        private int whlType;                        // 砂轮种类
        private string whlName;                     // 砂轮名
        private double radius = 60;                 // 砂轮半径
        private double thickness = 30;              // 砂轮厚度
        private int startPos = 0;                   // 起始安装位置

        public int WhlType
        {
            get { return whlType; }
            set { whlType = value; }
        }

        public string WhlName
        {
            get { return whlName; }
            set { whlName = value; }
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double Thickness
        {
            get { return thickness; }
            set { thickness = value; }
        }

        public int StartPos
        {
            get { return startPos; }
            set { startPos = value; }
        }

        /// <summary>
        /// 绘制砂轮图
        /// </summary>
        public virtual void Draw(Graphics g, Point p0)
        {
            Console.WriteLine("调用砂轮父类型绘图。");
        }
    }
    
    /// <summary>
    /// 圆形砂轮
    /// </summary>
    class CW1 : CWheel
    {
        double angR = 0;

        public double AngR{
            get { return angR; }
            set { angR = value; }
        } 

        public CW1(double r, double t)
        {
            this.Radius = r;
            this.Thickness = t;
        }

        public override void Draw(Graphics g, Point p0)
        {
            Console.WriteLine("调用CW1型砂轮绘图。");

            Pen p = new Pen(Color.Black, 1f);
            p.DashStyle = DashStyle.DashDot;
  
            CDraw.DrawCoordinate(g, p0, p);                 // 绘制坐标

            p.Color = Color.Blue;
            p.DashStyle = DashStyle.Solid;
            Point p1, p2, p3, p4;
            p1 = new Point(base.StartPos, (int)base.Radius);
            p2 = new Point(base.StartPos, -(int)base.Radius);
            p3 = new Point(base.StartPos + (int)base.Thickness, (int)base.Radius);
            p4 = new Point(base.StartPos + (int)base.Thickness, -(int)base.Radius);

            g.DrawLine(p, p1, p2);
            g.DrawLine(p, p3, p4);
            g.DrawLine(p, p1, p3);
            g.DrawLine(p, p2, p4);
        }
    }

    /// <summary>
    /// 梯形砂轮
    /// </summary>
    class CW2 : CWheel
    {
        private double radiusS = 60;                    // 砂轮较小一面半径默认值
        private bool f2b = true;                        // 砂轮正装还是倒装

        public double RadiusS {
            get { return radiusS; }
            set { radiusS = value; }
        }

        public bool F2B {
            get { return f2b; }
            set { f2b = value; }
        }

        public override void Draw(Graphics g, Point p0)
        {
            Console.WriteLine("调用CW2型砂轮绘图。");

            Pen p = new Pen(Color.Black, 1f);
            p.DashStyle = DashStyle.DashDot;

            CDraw.DrawCoordinate(g, p0, p);                 // 绘制坐标

            p.Color = Color.Blue;
            p.DashStyle = DashStyle.Solid;
            Point p1, p2, p3, p4;
            int leftR, rightR;
            if (this.f2b)
            {// 如果正装，则大的一边在起始点
                leftR = (int)base.Radius;
                rightR = (int)this.RadiusS;
            }
            else
            {// 如果倒装，则小的一边在起始点
                leftR = (int)this.RadiusS; 
                rightR = (int)base.Radius;              
            }
            p1 = new Point(base.StartPos, leftR);
            p2 = new Point(base.StartPos, -leftR);
            p3 = new Point(base.StartPos + (int)base.Thickness, rightR);
            p4 = new Point(base.StartPos + (int)base.Thickness, -rightR);

            g.DrawLine(p, p1, p2);
            g.DrawLine(p, p3, p4);
            g.DrawLine(p, p1, p3);
            g.DrawLine(p, p2, p4);
        }
    }

    /// <summary>
    /// V型砂轮
    /// </summary>
    class CW3 : CWheel
    {
        public override void Draw(Graphics g, Point p0)
        {
            Console.WriteLine("调用CW3型砂轮绘图。");
        }
    }

    /// <summary>
    /// 其它砂轮
    /// </summary>
    class CW4 : CWheel
    {
        public override void Draw(Graphics g, Point p0)
        {
            Console.WriteLine("调用CW4型砂轮绘图。");
        }
    }

    /// <summary>
    /// 垫圈
    /// </summary>
    class CRing : CWheel
    {
        public CRing(double r, double t)
        {
            this.Radius = r;
            this.Thickness = t;
        }

        public override void Draw(Graphics g, Point p0)
        {
            Console.WriteLine("调用垫圈绘图。");

            SolidBrush b = new SolidBrush(Color.AliceBlue);
            Pen p = new Pen(Color.Black, 1f);
            p.DashStyle = DashStyle.DashDot;

            CDraw.DrawCoordinate(g, p0, p);                 // 绘制坐标

            p.Color = Color.Blue;
            p.DashStyle = DashStyle.Solid;

            Point p1, p2, p3, p4;
            p1 = new Point(base.StartPos, (int)base.Radius);
            p2 = new Point(base.StartPos, -(int)base.Radius);
            p3 = new Point(base.StartPos + (int)base.Thickness, (int)base.Radius);
            p4 = new Point(base.StartPos + (int)base.Thickness, -(int)base.Radius);
            Point[] arrPoints = { p1, p2, p4, p3 };

            //g.DrawLine(p, p1, p2);
            //g.DrawLine(p, p3, p4);
            //g.DrawLine(p, p1, p3);
            //g.DrawLine(p, p2, p4);
            g.FillPolygon(b, arrPoints);
        }
    }
}
