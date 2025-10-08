using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        // 定義 5 分、10 分、25 分、50 分硬幣的常數（單位：分）
        const decimal FIVE_CENT = 5.0m;
        const decimal TEN_CENT = 10.0m; 
        const decimal TWENTY_FIVE_CENT = 25.0m;
        const decimal FIFTY_CENT = 50.0m;

        // 用來儲存目前累計的總金額（單位：分）
        private decimal total;

        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者點擊 5 分硬幣圖片時執行
        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            // 將 5 分加入總金額
            total = total + 5;
            // 顯示目前總金額於標籤
            totalLabel.Text = total.ToString();
        }

        // 當使用者點擊 10 分硬幣圖片時執行
        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            // 將 10 分加入總金額
            total = total + 10;
            // 顯示目前總金額於標籤
            totalLabel.Text = total.ToString();
        }

        // 當使用者點擊 25 分硬幣圖片時執行
        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            // 將 25 分加入總金額
            total = total + 25;
            // 顯示目前總金額於標籤
            totalLabel.Text = total.ToString();
        }

        // 當使用者點擊 50 分硬幣圖片時執行
        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            // 將 50 分加入總金額
            total = total + 50;
            // 顯示目前總金額於標籤
            totalLabel.Text = total.ToString();
        }

        // 當使用者點擊「離開」按鈕時執行
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
