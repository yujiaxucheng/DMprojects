using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CNCneo.Tool
{
    /// <summary>
    /// 工件类父类
    /// </summary>
    public class CTool
    {
        #region 定义砂轮常量

        public const int TOOL_NULL = -1;            // 无
        public const int TOOL_P1 = 1;
        public const int TOOL_P2 = 2;
        public const int TOOL_P3 = 3;
        public const int TOOL_P4 = 4;
        public const int TOOL_P5 = 5;
        public const int TOOL_P6 = 6;
        public const int TOOL_P7 = 7;

        #endregion

        private int toolType;                       // 工件种类
        private string toolName;                    // 工件名
        private string sPath;                       // 数据文件存储位置

        private double diameter;
        private double radius;
        private double length;

        public int ToolType
        {
            get { return toolType; }
            set { toolType = value; }
        }

        public string ToolName
        {
            get { return toolName; }
            set { toolName = value; }
        }

        public string SPath
        {
            get { return sPath; }
            set { sPath = value; }
        }

        public double Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public CTool()
        { 
            
        }

        /// <summary>
        /// 初始化工件数据
        /// </summary>
        public virtual void Init()
        { 
            
        }

        /// <summary>
        /// 保存数据文件
        /// </summary>
        /// <param name="fileName">保存文件名</param>
        public virtual void Save(string fileName)
        { }

        /// <summary>
        /// 读取数据文件
        /// </summary>
        /// <param name="fileName">打开文件名</param>
        public virtual void Open(string fileName)
        { }
    }

    /// <summary>
    /// 产品1
    /// </summary>
    class CProduct1 : CTool
    {

    }

    /// <summary>
    /// 产品2
    /// </summary>
    class CProduct2 : CTool
    {

    }

    /// <summary>
    /// 产品3
    /// </summary>
    class CProduct3 : CTool
    {

    }

    /// <summary>
    /// 产品4
    /// </summary>
    class CProduct4 : CTool
    {

    }
}
