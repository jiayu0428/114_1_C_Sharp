using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    /// <summary>
    /// 撲克牌展示窗體
    /// 用於展示和選擇不同的撲克牌，並顯示對應的牌張圖片
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 初始化窗體
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 「顯示牌張」按鈕點擊事件
        /// 根據列表框中選擇的牌張，顯示對應的圖片
        /// </summary>
        private void showCardButton_Click(object sender, EventArgs e)
        {
            if (cardListBox.SelectedIndex != -1)
            {
                showSelectedCard(cardListBox.SelectedItem.ToString());
            }
            else
            {
                // 如果沒有選擇任何牌張，顯示提示信息
                MessageBox.Show("請先選擇一張牌！");
            }
        }

        private void showSelectedCard(string cardName)
        {
            // 根據選擇的牌張名稱，設置對應的圖片
            switch (cardName)
            {
                case "黑桃A":
                    // 顯示黑桃A的圖片
                    showAceSpades();
                    break;
                case "紅心10":
                // 顯示紅心10的圖片
                    showTenHearts();
                    break;
               
                case "梅花K":
                // 顯示梅花K的圖片
                    showKingClubs();
                    break;
                default:
                    MessageBox.Show("未知的牌張選擇！");
                    break;
            }
        }


        private void showAceSpades()
        {
            aceSpadesPictureBox.Visible = true;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
        }
        private void showTenHearts()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = true;
            kingClubsPictureBox.Visible = false;
        }

        private void showKingClubs()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = true;
        }
        /// 關閉當前窗體
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉窗體
            this.Close();
        }
    }
}
