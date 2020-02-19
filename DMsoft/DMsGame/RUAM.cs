using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DMsGame
{
    public partial class RUAM : Form
    {
        /// <summary>
        /// 左
        /// </summary>
        public const int DIR_LEFT = 1;

        /// <summary>
        /// 右
        /// </summary>
        public const int DIR_RIGHT = 2;

        /// <summary>
        /// 台阶长度
        /// </summary>
        public const int STEP_LENGTH = 7;

        /// <summary>
        /// 台阶数量
        /// </summary>
        public const int STEP_COUNT = 6;

        public Point[] stepArr = new Point[STEP_LENGTH];  // 台阶数组
        public int direction = DIR_LEFT;
        public int jumpNum = 0;
        public int timeNum = 1;

        public RUAM()
        {
            InitializeComponent();
            this.t1.Interval = 500;
        }

        /// <summary>
        /// 清除画面
        /// </summary>
        public void ClearScreen()
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);
        }

        /// <summary>
        /// 初始化台阶坐标
        /// </summary>
        public void InitStep()
        {
            Random rmd = new Random();

            for (int i = 0; i < STEP_COUNT; i++)
            {
                stepArr[i].X = rmd.Next(1, this.Width / 15 - 8) * 15;
            }
        }

        /// <summary>
        /// 画方块
        /// </summary>
        /// <param name="x">X坐标</param>
        /// <param name="y">Y坐标</param>
        public void DrawCube(int x, int y)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Black, 2);

            g.DrawRectangle(pen, x, y, 15, 15);
            g.FillRectangle(Brushes.Blue, x, y, 15, 15);
        }

        /// <summary>
        /// 画台阶
        /// </summary>
        /// <param name="x">X坐标</param>
        /// <param name="y">Y坐标</param>
        public void DrawStep(int x, int y)
        {
            for (int i = 0; i < STEP_LENGTH; i++)
            {
                DrawCube(x + i * 15, y);
            }
        }

        /// <summary>  
        /// 随机画台阶
        /// </summary>  
        public void ShowStep()
        {
            int i;
            Random rmd = new Random();

            if (timeNum > 5 && timeNum % 5 == 0)
            {
                for (i = 0; i < STEP_COUNT - 1; i++)
                {
                    stepArr[i].X = stepArr[i + 1].X;
                    stepArr[i].Y = stepArr[i + 1].Y;
                }

                stepArr[STEP_COUNT - 1].X = rmd.Next(1, this.Width / 15 - 8) * 15;
                stepArr[STEP_COUNT - 1].Y = 15;
            }

            for (i = 0; i < STEP_COUNT; i++)
            {
                DrawStep(stepArr[i].X, (timeNum % 5) * 15 + i * 5 * 15);
            }
        }

        /// <summary>
        /// 重写ProcessDialogKey，来允许监听方向键
        /// </summary>
        protected override bool ProcessDialogKey(Keys keycode)
        {
            switch (keycode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Right:
                case Keys.Down:
                    return false;
            }
            return true;
        }

        /// <summary>  
        /// 按下方向键
        /// </summary>  
        private void ruam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                direction = DIR_RIGHT;
            else if (e.KeyCode == Keys.Left)
                direction = DIR_LEFT;
        }

        // 时间事件
        private void t1_Tick(object sender, EventArgs e)
        {
            ClearScreen();
            timeNum++;

            ShowStep();

            if (timeNum == 300)
            {
                this.t1.Enabled = false;
            }
        }

        // 单击启动
        private void RUAM_Click(object sender, EventArgs e)
        {
            if (this.t1.Enabled == true)
            {
                this.t1.Enabled = false;
            }
            else
            {
                timeNum = 0;
                InitStep();
                this.t1.Enabled = true;
            }
        }
    }
}
