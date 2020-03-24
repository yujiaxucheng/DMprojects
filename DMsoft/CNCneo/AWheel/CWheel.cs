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
        private int endPos = 0;                   // 结束安装位置

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

        public int EndPos
        {
            get { return endPos; }
            set { endPos = value; }
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
  
            CDraw.SetCoordinate(g, p0);                 // 设置坐标

            p.Color = Color.Blue;
            p.DashStyle = DashStyle.Solid;
            Point p1, p2, p3, p4;
            p1 = new Point(base.StartPos, (int)base.Radius);
            p2 = new Point(base.StartPos, -(int)base.Radius);
            p3 = new Point(base.StartPos + (int)base.Thickness, (int)base.Radius);
            p4 = new Point(base.StartPos + (int)base.Thickness, -(int)base.Radius);

            EndPos = p3.X;

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
        
        public CW2(double shortR, double longR, double t)
        {
            this.RadiusS = shortR;
            this.Radius = longR;
            this.Thickness = t;
        }

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

            CDraw.SetCoordinate(g, p0);                 // 设置坐标

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

            EndPos = p3.X;

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
        private double radiusS = 60;                    // 砂轮较小一面半径默认值
        private double radiusI = 40;                    // 砂轮内部半径
        private double mainThickness = 50;              // 砂轮主要厚度
        private double edgeThickness = 10;              // 砂轮边缘厚度
        private double edgeWidth = 20;                  // 砂轮边缘宽度
        private double ang = 45;                        // 倾斜度数

        public double RadiusS
        {
            get { return radiusS; }
            set { radiusS = value; }
        }

        public double RadiusI
        {
            get { return radiusI; }
            set { radiusI = value; }
        }

        public double MainThickness
        {
            get { return mainThickness; }
            set { mainThickness = value; }
        }

        public double EdgeThickness
        {
            get { return edgeThickness; }
            set { edgeThickness = value; }
        }

        public double EdgeWidth
        {
            get { return edgeWidth; }
            set { edgeWidth = value; }
        }

        public double Ang
        {
            get { return ang; }
            set { ang = value; }
        }

        public CW3(double longR, double thickness, double shortR, double innerR, double mT, double eT, double eW, double a)
        {
            this.Radius = longR;
            this.Thickness = thickness;

            this.RadiusS = shortR;
            this.RadiusI = innerR;
            this.MainThickness = mT;
            this.EdgeThickness = eT;
            this.EdgeWidth = eW;
            this.Ang = a;
        }

        public override void Draw(Graphics g, Point p0)
        {
            Console.WriteLine("调用CW3型砂轮绘图。");

            Pen p = new Pen(Color.Black, 1f);
            p.DashStyle = DashStyle.DashDot;

            CDraw.SetCoordinate(g, p0);                 // 设置坐标

            p.Color = Color.Blue;
            p.DashStyle = DashStyle.Solid;
            Point p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14;
            p1 = new Point(base.StartPos, (int)radiusS);
            p2 = new Point(base.StartPos, -(int)radiusS);
            p3 = new Point(base.StartPos + (int)mainThickness, (int)(mainThickness * CFunc.Tan(ang) + radiusS));
            p4 = new Point(base.StartPos + (int)mainThickness, -(int)(mainThickness * CFunc.Tan(ang) + radiusS));
            p5 = new Point(p3.X, (int)base.Radius);
            p6 = new Point(p3.X, -(int)base.Radius);
            p7 = new Point(base.StartPos + (int)base.Thickness, (int)base.Radius);
            p8 = new Point(base.StartPos + (int)base.Thickness, -(int)base.Radius);
            p9 = new Point(base.StartPos + (int)edgeThickness, (int)radiusI);
            p10 = new Point(base.StartPos + (int)edgeThickness, -(int)radiusI);
            p11 = new Point(p3.X, (int)((mainThickness - edgeThickness) * CFunc.Tan(ang) + radiusS));
            p12 = new Point(p3.X, -(int)((mainThickness - edgeThickness) * CFunc.Tan(ang) + radiusS));
            p13 = new Point(base.StartPos + (int)base.Thickness, p11.Y);
            p14 = new Point(base.StartPos + (int)base.Thickness, p12.Y);

            EndPos = p13.X;

            g.DrawLine(p, p1, p3);
            g.DrawLine(p, p5, p7);
            g.DrawLine(p, p5, p11);
            g.DrawLine(p, p7, p13);
            g.DrawLine(p, p11, p13);

            g.DrawLine(p, p2, p4);
            g.DrawLine(p, p6, p8);
            g.DrawLine(p, p6, p12);
            g.DrawLine(p, p8, p14);
            g.DrawLine(p, p12, p14);

            g.DrawLine(p, p1, p2);
            p.DashStyle = DashStyle.Dot;
            g.DrawLine(p, p9, p10);
            g.DrawLine(p, p9, p11);
            g.DrawLine(p, p10, p12);
            g.DrawLine(p, p11, p12);
            g.DrawLine(p, p13, p14);

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

            CDraw.SetCoordinate(g, p0);                 // 设置坐标

            p.Color = Color.Blue;
            p.DashStyle = DashStyle.Solid;

            Point p1, p2, p3, p4;
            p1 = new Point(base.StartPos, (int)base.Radius);
            p2 = new Point(base.StartPos, -(int)base.Radius);
            p3 = new Point(base.StartPos + (int)base.Thickness, (int)base.Radius);
            p4 = new Point(base.StartPos + (int)base.Thickness, -(int)base.Radius);
            //Point[] arrPoints = { p1, p2, p4, p3 };

            EndPos = p3.X;

            g.DrawLine(p, p1, p2);
            g.DrawLine(p, p3, p4);
            g.DrawLine(p, p1, p3);
            g.DrawLine(p, p2, p4);
            //g.FillPolygon(b, arrPoints);
        }
    }
}
