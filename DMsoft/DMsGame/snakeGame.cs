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
    public partial class snakeGame : Form
    {
        /// <summary>
        /// 上
        /// </summary>
        public const int DIR_UP = 1;

        /// <summary>
        /// 右
        /// </summary>
        public const int DIR_RIGHT = 2;

        /// <summary>
        /// 下
        /// </summary>
        public const int DIR_DOWN = 3;

        /// <summary>
        /// 左
        /// </summary>
        public const int DIR_LEFT = 4;

        public const int SNAKE_MAX_LENGTH = 500;                // 蛇最大长度

        public Point foodLct = new Point();                     // 缓存食物的坐标 
        public Point[] snakeArr = new Point[SNAKE_MAX_LENGTH];  // 蛇身数组
 
        public int snakeLen = 6;                                // 蛇初始长度
        public int snakeDirection = DIR_RIGHT;                  // 存储方向键
        public bool flg = true;                                 // 标志

        public snakeGame()
        {
            InitializeComponent();
        }

        // 开始
        private void btnStart_Click(object sender, EventArgs e)
        {
            int temp = 0;
            snakeLen = 6;

            ClearScreen();

            for (int i = snakeLen - 1; i >= 0; i--)
            {
                snakeArr[i].X = temp;
                snakeArr[i].Y = 0;
                temp += 15;
            }

            snakeDirection = DIR_RIGHT;
            this.timer1.Enabled = true;
        }

        // 清除画面
        public void ClearScreen()
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Control.DefaultBackColor); 
        }

        /// <summary>  
        /// 时间事件           
        /// </summary>  
        private void timer1_Tick(object sender, EventArgs e)
        {
            ClearScreen();
            Forward(snakeDirection);                            // 蛇向前移
            for (int i = 0; i < snakeLen; i++)                  // 绘制蛇身
            {
                DrawShape(snakeArr[i].X, snakeArr[i].Y);
            }

            if (flg)
            {
                ShowFood();
                flg = false;
            }

            if (AteFoot(foodLct))
            {
                ShowFood();
                DrawFood(foodLct.X, foodLct.Y);
            }
            else
            {
                DrawFood(foodLct.X, foodLct.Y);
            }

            if (CheckSnakeHeadInSnakeBody() || CheckSnakeBodyInFrm())
            {
                this.timer1.Enabled = false;
                MessageBox.Show("游戏结束！");
            }
        }

        /// <summary>  
        /// 画蛇身一个小方块           
        /// </summary>  
        public void DrawShape(int x, int y)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Blue, 2);

            g.DrawRectangle(pen, x, y, 15, 15);
            g.FillRectangle(Brushes.Green, x, y, 15, 15);
        }

        /// <summary>  
        /// 画一个食物           
        /// </summary>  
        public void DrawFood(int x, int y)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2);

            g.DrawRectangle(pen, x, y, 15, 15);
            g.FillRectangle(Brushes.Black, x, y, 15, 15);
        }

        /// <summary>  
        /// 随机显示食物
        /// </summary>  
        public void ShowFood()
        {
            int x, y;
            Random rmd = new Random();

            x = rmd.Next(0, this.Width / 15 - 1) * 15;
            y = rmd.Next(0, this.Height / 15 - 2) * 15;

            //while (this.CheckInSnakeBody(x, y, 1))   
            //{            
            //    x = rmd.Next(0, 32) * 15;    
            //    y = 32 + rmd.Next(0, 30) * 15;           
            //}  

            foodLct.X = x;
            foodLct.Y = y;

            Console.WriteLine("食物坐标是({0},{1})", x, y);
        }

        /// <summary>  
        /// 设置Point数组坐标           
        /// </summary>  
        public void Forward(int direction)
        {
            Point temp = snakeArr[0];

            // 相当于实现蛇向前进一单元
            for (int i = snakeLen - 1; i > 0; i--)
            {
                snakeArr[i].X = snakeArr[i - 1].X;
                snakeArr[i].Y = snakeArr[i - 1].Y;
            }

            // 蛇头方向重新变化
            switch (direction)
            {
                case DIR_UP:
                    snakeArr[0].X = temp.X; 
                    snakeArr[0].Y = temp.Y - 15; 
                    break;
                case DIR_RIGHT:
                    snakeArr[0].X = temp.X + 15; 
                    snakeArr[0].Y = temp.Y; 
                    break;
                case DIR_DOWN: 
                    snakeArr[0].X = temp.X; 
                    snakeArr[0].Y = temp.Y + 15; 
                    break;
                case DIR_LEFT: 
                    snakeArr[0].X = temp.X - 15; 
                    snakeArr[0].Y = temp.Y; 
                    break; 
            }
        }

        /// <summary>  
        /// 按下方向键
        /// </summary>  
        private void frmSnake_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                snakeDirection = DIR_UP;
            else if (e.KeyCode == Keys.Down)
                snakeDirection = DIR_DOWN;
            else if (e.KeyCode == Keys.Right)
                snakeDirection = DIR_RIGHT;
            else if (e.KeyCode == Keys.Left)
                snakeDirection = DIR_LEFT;
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
        /// 判断是否撞到自己
        /// </summary>  
        public bool CheckSnakeHeadInSnakeBody()
        {
            return this.CheckInSnakeBody(this.snakeArr[0].X, this.snakeArr[0].Y, 1);
        }

        /// <summary>  
        /// 检查输入的坐标是否在蛇的身上
        /// </summary>  
        public bool CheckInSnakeBody(int x, int y, int snkHead)
        {
            for (int i = snkHead; i < snakeLen; i++)
            {
                if (x == this.snakeArr[i].X && y == this.snakeArr[i].Y)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>  
        /// 判断是否撞墙
        /// </summary>  
        public bool CheckSnakeBodyInFrm()
        {
            if (this.snakeArr[0].X >= this.Width    || 
                this.snakeArr[0].Y >= this.Height   || 
                this.snakeArr[0].X < 0              || 
                this.snakeArr[0].Y < 0)
                return true;
            else
                return false;
        }

        /// <summary>  
        /// 判断是否吃到食物
        /// </summary>  
        public bool AteFoot(Point FoodLct)
        {
            if (snakeArr[0].X == FoodLct.X && snakeArr[0].Y == FoodLct.Y)
            {
                if (snakeLen < SNAKE_MAX_LENGTH)
                {
                    snakeLen++;
                    snakeArr[snakeLen].X = snakeArr[snakeLen - 1].X; 
                    snakeArr[snakeLen].Y = snakeArr[snakeLen - 1].Y;
                } 
                return true;
            }
            else
                return false;
        }
    }
}
