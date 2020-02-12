using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Office.Interop.Excel;               // Excel 交互命名空间

namespace TestForm
{
    /// <summary>
    /// 操作Excel类
    /// 参考《C#程序设计经典300例》
    ///     17章  访问Office
    ///     实例198 创建Excel
    ///     实例199 保存Excel
    ///     实例201 读取Excel
    /// </summary>
    public class ExcelOperator
    {
        public Application appExcel;                // Excel应用对象
        public Workbook workBook;                   // Excel工作簿
        public Worksheet workSheet;                 // Excel工作表

        public ExcelOperator()
        {
            appExcel = new Application();           // 创建App对象
            appExcel.Visible = false;               // 创建完成后是否打开Excel
        }

        /// <summary>
        /// 创建Excel
        /// </summary>
        public void CreateExcel()
        {
            workBook = appExcel.Workbooks.Add(true);            // 添加工作簿
            workSheet = workBook.Worksheets[1] as Worksheet;    // 获取工作表
        }

        /// <summary>
        /// 打开Excel
        /// </summary>
        public void OpenExcel(string fileName)
        {
            workBook = appExcel.Workbooks.Open(fileName);       // 添加工作簿
            workSheet = workBook.Worksheets[1] as Worksheet;    // 获取工作表
        }

        /// <summary>
        /// 保存Excel
        /// </summary>
        /// <param name="fileName">保存文件名</param>
        public void SaveExcel(string fileName)
        {
            appExcel.DisplayAlerts = false;             // 禁止弹出保存提示
            appExcel.AlertBeforeOverwriting = false;    // 禁止弹出覆盖询问提示框

            object objFileName = fileName;              // 文件名
            object objPassword = "";
            object objWriteResPassword = "";
            object objReadOnlyRecommended = false;
            object objCreateBackup = false;

            workBook.SaveAs(objFileName, Type.Missing, objPassword, objWriteResPassword, objReadOnlyRecommended, objCreateBackup, XlSaveAsAccessMode.xlNoChange);
        }

        /// <summary>
        /// 退出Excel
        /// </summary>
        public void QuitExcel()
        {
            appExcel.Quit();
        }

        /// <summary>
        /// 定义索引器
        /// </summary>
        /// <param name="iRow">行号</param>
        /// <param name="iCol">列号</param>
        /// <returns></returns>
        public Range this[object iRow, object iCol]
        {
            get { return workSheet.Cells[iRow, iCol]; }         // 返回指定单元格
        }

        /// <summary>
        /// 在控制台显示Excel信息
        /// </summary>
        /// <param name="fileName">文件名</param>
        public void ShowExcelInfo(string fileName)
        {
            this.OpenExcel(fileName);

            int rNo = 1;                                        // 行号
            int cNo = 1;                                        // 列号
            Range range = this[rNo, cNo];                       // 获取单元格

            // 遍历行
            while (range.Value2 != null)
            {
                // 遍历列
                while (range.Value2 != null)
                {
                    Console.Write(range.Value2 + "\t");         // 输出单元格内容
                    range = this[rNo, ++cNo];
                }

                cNo = 1;
                range = this[++rNo, cNo];
                Console.WriteLine();
            }
        }
    }
}
