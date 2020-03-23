using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            CWheel whlGrp1 = new CW1(62.5, 30);
            CWheel whlGrp2 = new CRing(40, 10);
            Point p0 = new Point(this.pbWhlGrp1.Width / 4, this.pbWhlGrp1.Height / 2);

            whlGrp1.Draw(this.pbWhlGrp1.CreateGraphics(), p0);
            whlGrp2.Draw(this.pbWhlGrp2.CreateGraphics(), p0);
            this.tDrawWhlGrp.Enabled = false;
        }

        // 退出软件
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // 测试
        private void btnTest_Click(object sender, EventArgs e)
        {

        }
    }
}
