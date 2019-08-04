using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrawPics
{
    public class BasicData
    {
    }

    public struct Point 
    {
        public float X;
        public float Y;

        public Point(float fx, float fy)
        {
            this.X = fx;
            this.Y = fy;
        }
    }

    public class Language
    {
        public const int ZHS = 0;      // 简体
        public const int ZHC = 1;      // 繁体
        public const int ENG = 2;      // 英文

    }
}
