using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace CNCneo
{
    public class CLan
    {
        /// <summary>
        /// 存放翻译文件数据
        /// </summary>
        public static Dictionary<string, string> dicLan = new Dictionary<string, string>();

        /// <summary>
        /// 获取指定文件内容到字典中
        /// </summary>
        /// <param name="fileName">文件名</param>
        /// <returns>键值对字典表</returns>
        public static Dictionary<string, string> GetContFromFile(string fileName)
        {
            Console.WriteLine("获取翻译文件{0}", fileName);
            return CFunc.GetContFromFile(fileName);
        }

        /// <summary>
        /// 根据语言代码获取文件名
        /// </summary>
        /// <param name="lanCode">语言代码</param>
        public static string GetNameByLanCode(int lanCode)
        {
            string fileName;

            switch (lanCode)
            { 
                default:
                case CConst.ZHS:
                    fileName = "ZHS";
                    break;
                case CConst.ZHC:
                    fileName = "ZHC";
                    break;
                case CConst.ENG:
                    fileName = "ENG";
                    break;
            }

            return CConst.LAN_FILE_PATH + fileName + CConst.LAN_FILE_EXT;
        }

    }
}
