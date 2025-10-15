using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建構子：初始化表單元件
        /// </summary>
        public Form1()
        {
            InitializeComponent(); // 初始化表單上的所有控制項
        }

        /// <summary>
        /// 當使用者點擊「審核資格」按鈕時觸發此事件
        /// </summary>
        /// <param name="sender">事件來源物件</param>
        /// <param name="e">事件參數</param>
        private void checkButton_Click(object sender, EventArgs e)
        {
            // 這裡可以加入貸款資格審核的邏輯
            const decimal MINIMUM_SALARY = 1200000m; // 最低年薪要求
            const int MINIMUM_YEARS = 2; // 最低年資要求

            decimal salary; //  年薪
            int years; //  年資

            try
            {
                salary =decimal.Parse(salaryTextBox.Text); // 將輸入年薪轉換為decimal
                years = int.Parse(yearsTextBox.Text); // 將輸入年資轉換為int

                // 根據年薪與年資決定是否符合貸款資格
                    if (salary >= MINIMUM_SALARY)
                    {
                        if (years >= MINIMUM_YEARS)
                        {
                            decisionLabel.Text = "符合資格";
                        }
                        else
                        {
                            decisionLabel.Text = "不符合資格:年資未達最低標準";
                        }
                    }
                    else
                    {
                        decisionLabel.Text = "不符合資格:收入未達最低標準";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        /// <summary>
        /// 當使用者點擊「清除」按鈕時觸發此事件
        /// 清空所有輸入欄位與結果顯示，並將焦點移回年薪輸入框
        /// </summary>
        /// <param name="sender">事件來源物件</param>
        /// <param name="e">事件參數</param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空年薪與年資的輸入欄位
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            // 清空審核結果顯示
            decisionLabel.Text = "";

            // 將游標焦點移回年薪輸入欄位
            salaryTextBox.Focus();
        }

        /// <summary>
        /// 當使用者點擊「離開」按鈕時觸發此事件
        /// 關閉整個表單（程式結束）
        /// </summary>
        /// <param name="sender">事件來源物件</param>
        /// <param name="e">事件參數</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
