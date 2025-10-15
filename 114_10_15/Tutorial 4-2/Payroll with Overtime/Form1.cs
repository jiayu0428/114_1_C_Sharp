using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // 初始化表單元件
        }

        // 當使用者點擊「計算薪資」按鈕時執行此事件處理函式
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 定義常數：基本工時與加班時薪倍率
            const decimal BASE_HOURS = 40m;         // 一般工時上限（40小時）
            const decimal OVERTIME_RATE = 1.5m;     // 加班時薪倍率（1.5倍）

            decimal hoursWorked;    // 實際工作時數
            decimal hourlyPayRate;  // 時薪
            decimal grossPay;       // 總薪資

            try
            {
                // 取得使用者輸入的工時與時薪，並轉換為 decimal 型別
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);

                // 判斷是否有加班
                if (hoursWorked <= BASE_HOURS)
                    // 沒有加班，總薪資 = 工時 * 時薪
                    grossPay = hoursWorked * hourlyPayRate;
                else
                    // 有加班，總薪資 = (基本工時 * 時薪) + (加班工時 * 時薪 * 加班倍率)
                    grossPay = (BASE_HOURS * hourlyPayRate) +
                               ((hoursWorked - BASE_HOURS) *
                                hourlyPayRate * OVERTIME_RATE);

                // 將計算結果顯示於標籤，格式化為貨幣格式
                grossPayLabel.TextAlign= ContentAlignment.MiddleCenter;
                grossPayLabel.Text = grossPay.ToString("c");
            }
            catch (Exception ex)
            {
                // 若輸入格式錯誤或發生例外，顯示錯誤訊息
                MessageBox.Show(ex.Message);
            }
        }

        // 當使用者點擊「清除」按鈕時執行此事件處理函式
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空所有輸入框與結果標籤
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            // 將游標焦點移回工時輸入框
            hoursWorkedTextBox.Focus();
        }

        // 當使用者點擊「離開」按鈕時執行此事件處理函式
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
