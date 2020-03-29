using System;
using System.Drawing;
using System.Windows.Forms;

namespace DMsGame
{
    public partial class snakeGame : Form
    {
        public const int DIR_UP = 1;                            // 上
        public const int DIR_DOWN = 3;                          // 下
        public const int DIR_LEFT = 4;                          // 左
        public const int DIR_RIGHT = 2;                         // 右
        public const int SNAKE_MAX_LENGTH = 500;                // 蛇最大长度

        public Point foodLct = new Point();                     // 缓存食物的坐标 
        public Point[] snakeArr = new Point[SNAKE_MAX_LENGTH];  // 蛇身数组
 
        public int snakeDirection = DIR_RIGHT;                  // 存储方向键
        public int snakeLen = 6;                                // 蛇初始长度
        public int score = 0;                                   // 当前分数
        public int historyScore = 0;                            // 历史最高分
        public int speed = 5;                                   // 默认初始速度

        /// 构造函数
        public snakeGame()
        {
            InitializeComponent();
            this.nudSpeed.Value = speed;
        }

        /// 开始
        private void btnStart_Click(object sender, EventArgs e)
        {
            Init();
            this.tDraw.Enabled = true;
        }

        /// 控制蛇的速度
        private void nudSpeed_ValueChanged(object sender, EventArgs e)
        {
            speed = Convert.ToInt32(this.nudSpeed.Value);
            this.tDraw.Interval = 500 / speed;
        }

        /// 定时器事件
        private void tDraw_Tick(object sender, EventArgs e)
        {
            ClearScreen();                                      // 清除画面
            Forward();                                          // 蛇向前移
            ShowSnakeFood();                                    // 显示蛇和食物
            EatFood();                                          // 吃食

            if (IfBiteSelf() || IfHitWall())                    // 如果咬到自己或撞墙则游戏结束
                GameOver();
        }

        #region 捕获键盘方向键

        /// 方向键
        private void frmSnake_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                default:
                case Keys.Up:
                    snakeDirection = DIR_UP;
                    break;
                case Keys.Down:
                    snakeDirection = DIR_DOWN;
                    break;
                case Keys.Right:
                    snakeDirection = DIR_RIGHT;
                    break;
                case Keys.Left:
                    snakeDirection = DIR_LEFT;
                    break;
            }
        }

        /// 重写ProcessDialogKey，允许监听方向键
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

        #endregion

        /// 清除画布
        public void ClearScreen()
        {
            this.pbMain.CreateGraphics().Clear(Control.DefaultBackColor);   // PictureBox背景色设置默认
        }

        /// 画一个小方块
        public void DrawCube(Graphics g, Point p, Brush b)
        {
            g.DrawRectangle(new Pen(Color.Black, 2f), p.X, p.Y, 15, 15);
            g.FillRectangle(b, p.X, p.Y, 15, 15);
        }

        /// 创建食物随机坐标
        public void CreateFood()
        {
            Random rd = new Random();

            foodLct.X = rd.Next(0, this.pbMain.Width / 15 - 1) * 15;
            foodLct.Y = rd.Next(0, this.pbMain.Height / 15 - 2) * 15;
        }

        /// 初始化蛇身数组
        public void Init()
        {
            int tmp = 0;
            snakeLen = 6;
            score = 0;
            snakeDirection = DIR_RIGHT;                     // 开始时蛇向右移动

            CreateFood();

            for (int i = snakeLen - 1; i >= 0; i--)         // 从左上角坐标开始绘制蛇
            {
                snakeArr[i].X = tmp;
                snakeArr[i].Y = 0;
                tmp += 15;
            }

            this.tDraw.Interval = 1000 / speed;
        }

        /// 显示蛇和食物
        public void ShowSnakeFood()
        {
            Console.WriteLine("食物坐标({0}，{1})蛇头坐标({2},{3})", foodLct.X, foodLct.Y, snakeArr[0].X, snakeArr[0].Y);

            for (int i = 0; i < snakeLen; i++)                  // 绘制蛇身
                DrawCube(this.pbMain.CreateGraphics(), new Point(snakeArr[i].X, snakeArr[i].Y), Brushes.Green);
            DrawCube(this.pbMain.CreateGraphics(), new Point(foodLct.X, foodLct.Y), Brushes.Yellow);    // 绘制食物
        }

        /// 吃食物
        public void EatFood()
        {
            if (snakeArr[0] == foodLct)                                 // 蛇头点与食物点重合
            {
                if (snakeLen < SNAKE_MAX_LENGTH)
                {
                    snakeArr[snakeLen] = snakeArr[snakeLen - 1];
                    snakeLen++;                                         // 蛇身长度+1
                }
               
                this.lScore.Text = "分数：" + (++score).ToString();
                CreateFood();
            }
        }

        /// Game Over
        public void GameOver()
        {
            this.tDraw.Enabled = false;
            MessageBox.Show("GAME OVER！");

            if (score > historyScore)
                historyScore = score;

            score = 0;
            this.lScore.Text = "分数：" + score.ToString();
            this.lhisScore.Text = "历史最高分：" + historyScore.ToString();
        }

        /// 蛇身数组前进一单位
        public void Forward()
        {
            Point temp = snakeArr[0];

            for (int i = snakeLen - 1; i > 0; i--)
                snakeArr[i] = snakeArr[i - 1];              // 蛇身依次向前

            switch (snakeDirection)
            {
                default:
                case DIR_UP:
                    snakeArr[0].X = temp.X;                 // 蛇头为指定方向前一单位
                    snakeArr[0].Y = temp.Y - 15; 
                    break;
                case DIR_DOWN: 
                    snakeArr[0].X = temp.X; 
                    snakeArr[0].Y = temp.Y + 15; 
                    break;
                case DIR_LEFT: 
                    snakeArr[0].X = temp.X - 15; 
                    snakeArr[0].Y = temp.Y; 
                    break; 
                case DIR_RIGHT:
                    snakeArr[0].X = temp.X + 15; 
                    snakeArr[0].Y = temp.Y; 
                    break;
            }
        }

        /// 判断是否咬到自己，头与身子重合
        public bool IfBiteSelf()
        {
            for (int i = 1; i < snakeLen; i++)
            {
                if (snakeArr[0] == this.snakeArr[i])
                    return true;
            }

            return false;
        }

        /// 判断是否撞墙
        public bool IfHitWall()
        {
            if (this.snakeArr[0].X >= this.pbMain.Width || this.snakeArr[0].Y >= this.pbMain.Height || 
                this.snakeArr[0].X < 0                  || this.snakeArr[0].Y < 0)
                return true;
            else
                return false;
        }
    }
}
