using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CNCneo.AWheel
{
    public class WheelGroup
    {
        public const int MAX_LENGTH = 8;                // 砂轮组部件数
        public const int WHL_MAXNUM = 4;                // 砂轮最大数

        public CWheel []wheels = new CWheel[MAX_LENGTH];

        /// <summary>
        /// 获取砂轮数量
        /// </summary>
        public void GetWheelNum()
        { 
            
        }

        /// <summary>
        /// 增加砂轮
        /// </summary>
        /// <param name="cw"></param>
        public void AddWheel(CWheel cw)
        { 
            
        }
    }
}
