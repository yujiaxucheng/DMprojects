﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DMsGame
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new RUAM());            // 勇下百层
            Application.Run(new snakeGame());     // 贪吃蛇
        }
    }
}