using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TestForm.DesignPattener;

namespace TestForm
{
    public partial class C0_TestAllInstance_MainForm : Form
    {
        int instanceNo = 0;     // 实例序号

        int intPara1 = 1;       // int型参数1

        public C0_TestAllInstance_MainForm()
        {
            InitializeComponent();
        }

        // 测试实例按钮
        private void btnTestInstance_Click(object sender, EventArgs e)
        {
            RunInstance(instanceNo);
        }

        // 选择实例序号
        private void nudInstanceNo_ValueChanged(object sender, EventArgs e)
        {
            instanceNo = Convert.ToInt32(this.nudInstanceNo.Value);
        }

        /// <summary>
        /// 运行实例No
        /// </summary>
        /// <param name="no">实例序号</param>
        public void RunInstance(int no)
        {
            switch (no)
            {
                default:
                    MessageBox.Show("待开发……");
                    break;
                case 7:
                    intPara1 = functions.ConvertString2Int(this.tbPara1.Text);
                    this.lInfo.Text = C0_TestAllInstance_Main.Ins7_PrintAnimalName((C1_Enum.Animal)intPara1);
                    break;
                case 38:
                    if (string.IsNullOrEmpty(this.tbPara1.Text))
                        this.lInfo.Text = C0_TestAllInstance_Main.Ins38_PrintProvinces();
                    else
                        this.lInfo.Text = C0_TestAllInstance_Main.Ins38_GetCitysFromProvince(this.tbPara1.Text);
                    break;
                case 40:
                    this.lInfo.Text = C0_TestAllInstance_Main.Ins40_TestQueue();
                    break;
                case 41:
                    if (string.IsNullOrEmpty(this.tbPara1.Text))
                        MessageBox.Show("需要在para1对话框输入带括号表达式！");
                    else
                        this.lInfo.Text = C0_TestAllInstance_Main.Ins41_TestStack(this.tbPara1.Text);
                    break;

                // 简单工厂模式
                case 88:
                    //this.lInfo.Text = C0_TestAllInstance_Main.Ins88_SimpleFactory();
                    this.lInfo.Text = DP_SimpleFactory.Ins88_SimpleFactory();
                    break;
            }
        }

    }
}
