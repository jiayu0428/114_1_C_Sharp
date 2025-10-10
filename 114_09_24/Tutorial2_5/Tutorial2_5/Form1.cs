using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial2_5
{
    // 定義主視窗 Form1，繼承自 Windows Form
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent(); // 初始化表單上的所有控制項
        }

        // 當表單載入時觸發的事件處理函式
        private void Form1_Load(object sender, EventArgs e)
        {
            // 預設將卡牌背面與正面圖片隱藏
            cardbackPictureBox.Visible = false; // 隱藏卡牌背面圖片
            cardfacePictureBox.Visible = false; // 隱藏卡牌正面圖片
        }

        // 當「顯示背面」按鈕被點擊時觸發的事件處理函式
        private void showBackButton_Click(object sender, EventArgs e)
        {
            cardbackPictureBox.Visible = true;  // 顯示卡牌背面圖片
            cardfacePictureBox.Visible = false; // 隱藏卡牌正面圖片
        }

        // 當「顯示正面」按鈕被點擊時觸發的事件處理函式
        private void showFaceButton_Click(object sender, EventArgs e)
        {
            cardfacePictureBox.Visible = true;  // 顯示卡牌正面圖片
            cardbackPictureBox.Visible = false; // 隱藏卡牌背面圖片
        }

        private void cardbackPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
