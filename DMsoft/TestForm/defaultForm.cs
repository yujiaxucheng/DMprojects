﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestForm
{
    public partial class defaultForm : Form
    {
        private string fName = "";

        public defaultForm()
        {
            InitializeComponent();
        }

        #region 调用对话框

        // 原文链接：https://blog.csdn.net/weixin_44490080/article/details/100712683

        // 打开文件夹，并在文本框显示名称
        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "选择目录";
            if (folder.ShowDialog() == DialogResult.OK)
            {
                fName = folder.SelectedPath;
            }
            this.tbFileOrFolderName.Text = fName;
        }

        // 打开文件，并在文本框显示名称
        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "请选择图片";
            dialog.Multiselect = false;                 //是否支持多个文件的打开：否
            dialog.Filter = "表格(*.xls)|*.xls";

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fName = dialog.FileName;
            }
            this.tbFileOrFolderName.Text = fName;
        }

        #endregion

        // 开始操作
        private void btnStart_Click(object sender, EventArgs e)
        {
            ExcelOperator myExcel = new ExcelOperator();

            //myExcel.CreateExcel();
            //myExcel.SaveExcel(@"D:\DiskE\Test" + @"\TestSaveExcel.xls");

            myExcel.ShowExcelInfo(@"D:\DiskE\Test" + @"\TestSaveExcel.xls");

            myExcel.QuitExcel();
        }

    }
}
