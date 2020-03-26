using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CNCneo
{
    public class CConst
    {
        #region 翻译相关

        /// <summary>
        /// 中文简体
        /// </summary>
        public const int ZHS = 0;

        /// <summary>
        /// 中文繁体
        /// </summary>
        public const int ZHC = 1;

        /// <summary>
        /// 英文
        /// </summary>
        public const int ENG = 2;

        #endregion

        #region 文件相关

        /// <summary>
        /// 语言文件存放目录
        /// </summary>
        public const string LAN_FILE_PATH = @"D:\Data\Lan\";

        /// <summary>
        /// 语言文件后缀
        /// </summary>
        public const string LAN_FILE_EXT = @".lan";

        /// <summary>
        /// 砂轮数据文件存放目录
        /// </summary>
        public const string WHEELDATA_FILE_PATH = @"D:\Data\Wheel\";

        /// <summary>
        /// 砂轮数据文件后缀
        /// </summary>
        public const string WHEELDATA_FILE_EXT = @".wdf";

        #endregion
    }
}
