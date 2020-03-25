using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace CNCneo
{
    public class CLanguage
    {
        /// <summary>
        /// 存放翻译文件数据
        /// </summary>
        Dictionary<string, string> dicLan = new Dictionary<string, string>();

        /// <summary>
        /// 获取指定文件内容到字典中
        /// </summary>
        /// <param name="fileName">文件名</param>
        /// <returns>键值对字典表</returns>
        public static Dictionary<string, string> GetContFromFile(string fileName)
        {
            return CFunc.GetContFromFile(fileName);
        }

    }
}
