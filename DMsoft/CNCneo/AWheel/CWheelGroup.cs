using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CNCneo.Wheel
{
    /// <summary>
    /// 砂轮组类
    /// </summary>
    public class CWheelGroup
    {
        public const int MAX_LENGTH = 8;                // 砂轮组部件数
        public const int WHL_MAXNUM = 4;                // 砂轮最大数

        private int count = 1;
        private string whlGroupName = "";

        public int Count {
            get { return count; }
            set { count = value; }
        }

        public CWheel[] wheels = new CWheel[MAX_LENGTH];

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name">砂轮组名字</param>
        public CWheelGroup(string name)
        {
            this.whlGroupName = name;
        }

        /// <summary>
        /// 增加砂轮
        /// </summary>
        /// <param name="cw">砂轮</param>
        public void AddWheel(CWheel cw)
        {
            if (count < MAX_LENGTH)
            {
                wheels[count - 1] = cw;
                count++;
                Console.WriteLine("{0} 装夹 {1} {2}", this.whlGroupName, cw.WhlType, cw.WhlName);
            }
        }

        /// <summary>
        /// 在PictureBox中绘制砂轮组
        /// </summary>
        /// <param name="pb">图片控件</param>
        public void Draw(PictureBox pb)
        {
            Graphics g = pb.CreateGraphics();
            Point p0 = new Point(pb.Width / 3, pb.Height / 2);
            Pen p = new Pen(Color.Red, 1f);

            p.DashStyle = DashStyle.DashDot;
            CDraw.SetCoordinate(g, p0, 1f);
            CDraw.DrawAxisXY(g, p);

            for (int i = 0; i < wheels.Length; i++)
            {
                if (wheels[i] == null)
                    break;

                if (i > 0)
                    wheels[i].StartPos = wheels[i - 1].EndPos;
                wheels[i].Draw(g, p0);
            }
        }
    }
}
