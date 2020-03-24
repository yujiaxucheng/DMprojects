using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing;
using System.Drawing.Drawing2D;
using CNCneo.AWheel;

namespace CNCneo
{
    public partial class winMain : Form
    {
        public winMain()
        {
            InitializeComponent();
            InitForm();
            InitByProduct();
        }

        /// <summary>
        /// 初始化界面控件
        /// </summary>
        private void InitForm()
        {
            int headWidth = this.Width * 1;
            int headHeight = this.Height * 2 / 16 ;
            int productWidth = this.Width * 13 / 16;
            int productHeight = this.Height * 6 / 16;
            int wheelWidth = this.Width * 13 / 16;
            int wheelHeight = this.Height * 8 / 16;
            int machineWidth = this.Width * 3 / 16;
            int machineHeight = this.Height * 14 / 16;

            // 头部Panel位置及大小
            this.pHead.Location = new Point(0, 0);
            this.pHead.Size = new Size(headWidth, headHeight);
            this.lVersion.Location = new Point(0, headHeight - this.lVersion.Size.Height - 5);
            this.lMachineNo.Location = new Point(headWidth / 2 - this.lMachineNo.Size.Width, headHeight - this.lMachineNo.Size.Height - 5);
            this.cbLan.Location = new Point(productWidth, headHeight - this.cbLan.Size.Height - 5);
            this.cbLan.DropDownStyle = ComboBoxStyle.DropDownList;

            // 产品区Panel位置及大小
            this.pProduct.Location = new Point(0, headHeight);
            this.pProduct.Size = new Size(productWidth, productHeight);

            // 砂轮区Panel位置及大小
            this.pWheel.Location = new Point(0, headHeight + productHeight);
            this.pWheel.Size = new Size(wheelWidth, wheelHeight);
            this.scWheel.SplitterDistance = wheelWidth / 2;
            this.scWheel.IsSplitterFixed = true;
            this.scWheel.FixedPanel = FixedPanel.Panel1;
            for (int i = 0; i < 4; i++)
            {
                this.dgvGroup1.Columns[i].Width = this.dgvGroup1.Width / 4 - 1;
                this.dgvGroup2.Columns[i].Width = this.dgvGroup2.Width / 4 - 1;
            }
            this.dgvGroup1.Rows.Add(1);
            this.dgvGroup2.Rows.Add(1);
            this.dgvGroup1.Rows[0].Height = this.dgvGroup1.Height - this.dgvGroup1.Rows[0].Height;
            this.dgvGroup2.Rows[0].Height = this.dgvGroup2.Height - this.dgvGroup2.Rows[0].Height;
            
            // 机床Panel位置及大小
            this.pMachine.Location = new Point(productWidth, headHeight);
            this.pMachine.Size = new Size(machineWidth, machineHeight);

            // 开始绘制砂轮组
            this.tDrawWhlGrp.Enabled = true;
        }

        /// <summary>
        /// 根据产品初始化界面
        /// </summary>
        private void InitByProduct()
        { 
            this.cbLan.SelectedIndex = 0;       // 临时
        }

        // 定时器绘制砂轮组
        private void tDrawWhlGrp_Tick(object sender, EventArgs e)
        {
            tempDrawWheelGroup2();
            this.tDrawWhlGrp.Enabled = false;
        }

        // 绘制砂轮组图，临时测试用
        private void tempDrawWheelGroup1()
        {
            Point p0 = new Point(this.pbWhlGrp1.Width / 3, this.pbWhlGrp1.Height / 2);
            Pen p = new Pen(Color.Red, 1f);
            Graphics g;

            g = this.pbWhlGrp1.CreateGraphics();
            p.DashStyle = DashStyle.DashDot;
            CDraw.DrawAxisXY(g, p, p0);

            CWheel[] whlGrp1 = new CWheel[8];
            whlGrp1[0] = new CW2(50, 60, 15);
            whlGrp1[1] = new CRing(35, 15);
            whlGrp1[2] = new CW1(100, 25);
            whlGrp1[3] = new CRing(35, 25);
            whlGrp1[4] = new CW3(120, 60, 60, 55, 45, 15, 20, 45);
            whlGrp1[5] = new CRing(35, 25);

            for (int i = 0; i < whlGrp1.Length; i++)
            {
                if (whlGrp1[i] == null)
                    break;

                if (i > 0)
                    whlGrp1[i].StartPos = whlGrp1[i - 1].EndPos;
                whlGrp1[i].Draw(g, p0);
            }

            g = this.pbWhlGrp2.CreateGraphics();
            CDraw.DrawAxisXY(g, p, p0);
            CWheel[] whlGrp2 = new CWheel[8];
            whlGrp2[0] = new CW2(50, 60, 15);
            whlGrp2[1] = new CRing(35, 45);
            whlGrp2[2] = new CW1(135, 25);
            whlGrp2[3] = new CRing(35, 25);
            whlGrp2[4] = new CW1(80, 25);
            whlGrp2[5] = new CRing(35, 25);

            ((CW2)whlGrp2[0]).F2B = false;

            for (int i = 0; i < whlGrp1.Length; i++)
            {
                if (whlGrp2[i] == null)
                    break;
                else
                {
                    if (i > 0)
                    {
                        whlGrp2[i].StartPos = whlGrp2[i - 1].EndPos;
                        whlGrp2[i].Draw(g, p0);
                    }
                    else
                        whlGrp2[i].Draw(g, p0);
                }
            }
        }

        private void tempDrawWheelGroup2()
        {
            WheelGroup wg1 = new WheelGroup();
            Point p0 = new Point(this.pbWhlGrp1.Width / 3, this.pbWhlGrp1.Height / 2);
            Pen p = new Pen(Color.Red, 1f);
            Graphics g = this.pbWhlGrp1.CreateGraphics();

            wg1.AddWheel(new CW2(50, 60, 15));
            wg1.AddWheel(new CRing(35, 15));
            wg1.AddWheel(new CW1(100, 25));
            wg1.AddWheel(new CRing(35, 25));
            wg1.AddWheel(new CW3(120, 60, 60, 55, 45, 15, 20, 45));
            wg1.AddWheel(new CRing(35, 25));
            wg1.AddWheel(new CW2(50, 60, 15));

            wg1.DrawWheelGroup(g, p0, p);
        }

        // 退出软件
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // 测试
        private void btnTest_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(CConst.LAN_FILE_PATH);
        }

        // 界面加载事件
        private void winMain_Load(object sender, EventArgs e)
        {
            this.cbLan.MouseWheel += CFunc.FBD_MouseWheel;          // 禁用鼠标滚轮
        }
    }
}
