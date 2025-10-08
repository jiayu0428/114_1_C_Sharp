using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者按下「計算特價」按鈕時執行此方法
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 宣告變數：原價、折扣百分比、特價
            decimal originalPrice;
            decimal discountPercentage;
            decimal salePrice;

            // 將原價文字方塊的內容轉換為 decimal 型別
            originalPrice = decimal.Parse(originalPriceTextBox.Text);

            // 將折扣百分比文字方塊的內容轉換為 decimal 型別
            discountPercentage = decimal.Parse(discountPercentageTextBox.Text);

            // 計算特價：原價 * (1 - 折扣百分比 / 100)
            salePrice = originalPrice * (1 - discountPercentage / 100.0m);

            // 將計算結果以貨幣格式顯示在特價標籤上
            salePriceLabel.Text = salePrice.ToString("C");
        }

        // 當使用者按下「離開」按鈕時執行此方法
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        // 原價文字方塊內容變更時觸發（目前未實作任何功能）
        private void originalPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        // 特價標籤被點擊時觸發（目前未實作任何功能）
        private void salePriceLabel_Click(object sender, EventArgs e)
        {

        }

        // 折扣百分比文字方塊內容變更時觸發（目前未實作任何功能）
        private void discountPercentageTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
