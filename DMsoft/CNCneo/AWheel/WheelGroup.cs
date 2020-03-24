using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Drawing.Drawing2D;

namespace CNCneo.AWheel
{
    public class WheelGroup
    {
        public const int MAX_LENGTH = 8;                // 砂轮组部件数
        public const int WHL_MAXNUM = 4;                // 砂轮最大数

        private int count = 1;

        public int Count {
            get { return count; }
            set { count = value; }
        }

        public CWheel []wheels = new CWheel[MAX_LENGTH];

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
            }
        }

        /// <summary>
        /// 绘制砂轮组
        /// </summary>
        /// <param name="g">画布</param>
        /// <param name="p0">原点</param>
        /// <param name="p">画笔</param>
        public void DrawWheelGroup(Graphics g, Point p0, Pen p)
        {
            p.DashStyle = DashStyle.DashDot;
            CDraw.DrawAxisXY(g, p, p0);

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
