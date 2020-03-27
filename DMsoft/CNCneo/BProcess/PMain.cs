using System;
using CNCneo.Wheel;
using CNCneo.Tool;
using System.Collections.Generic;

namespace CNCneo
{
    /// <summary>
    /// 业务流：机床加载->砂轮加载->读取数据->界面初始化->用户修改->保存数据->进行加工
    /// </summary>
    public class PMain
    {
        #region 总工作流

        /// <summary>
        /// 机床系统初始化
        /// </summary>
        /// <returns>返回正确与否</returns>
        public static bool Init()
        {
            Console.WriteLine("软件初始化......");
            bool bRet = true;

            InitMachine();
            InitWheelGroup();
            InitLanguage();
            InitTool();

            return bRet;
        }

        #endregion

        #region 机床部分
        
        /// <summary>
        /// 初始化机床
        /// </summary>
        /// <returns>返回正确与否</returns>
        public static bool InitMachine()
        {
            Console.WriteLine("机床初始化......");

            return true;
        }

        #endregion

        #region 砂轮部分

        /// <summary>
        /// 主砂轮组
        /// </summary>
        public static CWheelGroup mainWheelGroup = new CWheelGroup("主砂轮组");

        /// <summary>
        /// 副砂轮组
        /// </summary>
        public static CWheelGroup viceWheelGroup = new CWheelGroup("副砂轮组");

        /// <summary>
        /// 初始化砂轮组
        /// </summary>
        /// <returns>返回正确与否</returns>
        public static bool InitWheelGroup()
        {
            Console.WriteLine("砂轮初始化......");

            // 这里应该放到砂轮界面去处理，这里应该进行初始化
            PMain.mainWheelGroup.AddWheel(new CW2(50, 60, 15, true));
            PMain.mainWheelGroup.AddWheel(new CRing(35, 15));
            PMain.mainWheelGroup.AddWheel(new CW1(100, 25));
            PMain.mainWheelGroup.AddWheel(new CRing(35, 25));
            PMain.mainWheelGroup.AddWheel(new CW3(110, 60, 60, 55, 45, 15, 20, 45));
            PMain.mainWheelGroup.AddWheel(new CRing(35, 25));
            PMain.mainWheelGroup.AddWheel(new CW2(50, 60, 15, false));

            PMain.viceWheelGroup.AddWheel(new CW2(50, 60, 15, false));
            PMain.viceWheelGroup.AddWheel(new CRing(35, 45));
            PMain.viceWheelGroup.AddWheel(new CW1(135, 25));
            PMain.viceWheelGroup.AddWheel(new CRing(35, 25));
            PMain.viceWheelGroup.AddWheel(new CW1(80, 25));
            PMain.viceWheelGroup.AddWheel(new CRing(35, 25));

            return true;
        }

        #endregion 

        #region 界面部分

        public static int lanCode = 0;      // 临时，需要从文件读取

        /// <summary>
        /// 加工工件
        /// </summary>
        public static CTool mTool = null;

        /// <summary>
        /// 初始化工件
        /// </summary>
        /// <returns>返回正确与否</returns>
        public static bool InitTool()
        {
            Console.WriteLine("工件初始化......");

            return true;
        }

        /// <summary>
        /// 初始化翻译文件
        /// </summary>
        /// <returns>返回正确与否</returns>
        public static bool InitLanguage()
        {
            Console.WriteLine("翻译文件初始化......");

            //CLan.dicLan = CLan.GetContFromFile(CLan.GetNameByLanCode(PMain.lanCode));

            return true;
        }

        #endregion

        #region 加工部分

        #endregion
    }
}
