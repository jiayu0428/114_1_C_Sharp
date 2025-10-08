using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 當「計算平均」按鈕被點擊時執行
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 宣告三個 double 變數用來存放三個成績
            double test1, test2, test3;
            try
            {
                // 將三個 TextBox 的文字轉換為 double 型別
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                // 計算三科成績的平均值
                double average = (test1 + test2 + test3) / 3.0;
                // 將平均值顯示於 averageLabel，格式為小數點後兩位
                averageLabel.Text = average.ToString("n2");
            }
            catch (FormatException ex)
            {
                // 若輸入格式錯誤，顯示錯誤訊息視窗
                MessageBox.Show(ex.Message, "例外發生!");
                // 清除三個成績輸入框與平均顯示標籤的內容
                test1TextBox.Text = "";
                test2TextBox.Text = "";
                test3TextBox.Text = "";
                averageLabel.Text = "";

                // 將游標焦點移回第一個成績輸入框
                test1TextBox.Focus();
            }
        }

        // 當「清除」按鈕被點擊時執行
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除三個成績輸入框與平均顯示標籤的內容
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
                
            // 將游標焦點移回第一個成績輸入框
            test1TextBox.Focus();
        }

        // 當「離開」按鈕被點擊時執行
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉整個表單（程式結束）
            this.Close();
        }

        // test2TextBox 內容變更時觸發（目前未實作任何功能）
        private void test2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        // outputDescriptionLabel 被點擊時觸發（目前未實作任何功能）
        private void outputDescriptionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
