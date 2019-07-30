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
}
