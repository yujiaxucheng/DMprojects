using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing;
using System.Drawing.Drawing2D;
using CNCneo.Wheel;
using CNCneo.Tool;

namespace CNCneo
{
    public partial class winMain : Form
    {
        public winMain()
        {
            InitializeComponent();
            Console.WriteLine("进入主界面......");

            InitLan();
            InitForm();
            InitByProduct();
        }

        // 退出软件
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // 界面加载触发
        private void winMain_Load(object sender, EventArgs e)
        {
            this.tDrawWhlGrp.Enabled = true;
            this.cbLan.MouseWheel += CFunc.FBD_MouseWheel;          // 禁用鼠标滚轮
        }

        // 定时器绘制砂轮组
        private void tDrawWhlGrp_Tick(object sender, EventArgs e)
        {
            PMain.mainWheelGroup.Draw(this.pbWhlGrp1);
            PMain.viceWheelGroup.Draw(this.pbWhlGrp2);

            this.tDrawWhlGrp.Enabled = false;
        }

        // 测试
        private void btnTest_Click(object sender, EventArgs e)
        {
            
        }

        #region 自定义操作

        /// <summary>
        /// 初始化界面控件
        /// </summary>
        private void InitForm()
        {
            int headWidth = this.Width * 1;
            int headHeight = this.Height * 2 / 16 ;
            int productWidth = this.Width * 13 / 16;
            int productHeight = this.Height * 5 / 16;
            int wheelWidth = this.Width * 13 / 16;
            int wheelHeight = this.Height * 9 / 16;
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
        /// 初始化语言
        /// </summary>
        private void InitLan()
        {
            this.lTM.Text = CLan.dicLan["公司名"];
            this.lVersion.Text = CLan.dicLan["版本号"];
            this.rdoP1.Text = CLan.dicLan["产品1"];
            this.rdoP2.Text = CLan.dicLan["产品3"];
            this.rdoP3.Text = CLan.dicLan["产品1"];
            this.rdoP4.Text = CLan.dicLan["产品4"];
            this.rdoP5.Text = CLan.dicLan["产品5"];
            this.rdoP6.Text = CLan.dicLan["产品6"];
            this.rdoP7.Text = CLan.dicLan["产品7"];
        }

        /// <summary>
        /// 根据产品初始化界面
        /// </summary>
        private void InitByProduct()
        { 
            this.cbLan.SelectedIndex = PMain.lanCode;
        }

        #endregion 

        // 进入系统，设置工件数据
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (PMain.mTool == null)
            //    MessageBox.Show(CLan.dicLan["请选择一个工件"]);
            //else
            {
                DialogResult dr;
                MainPage pdMain = new MainPage();
                //this.Hide();
                dr = pdMain.ShowDialog();
                //if (dr == System.Windows.Forms.DialogResult.OK)
                //    this.Show();
            }
        }

        // 语言选择改变
        private void cbLan_SelectedIndexChanged(object sender, EventArgs e)
        {
            PMain.lanCode = this.cbLan.SelectedIndex;
            CLan.dicLan = CLan.GetContFromFile(CLan.GetNameByLanCode(PMain.lanCode));
            InitLan();
        }

    }
}
