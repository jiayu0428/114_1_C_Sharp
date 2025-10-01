using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者點擊「計算每加侖英里數」按鈕時觸發
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double kilometers;  // 宣告公里數變數 
            double liters;      // 宣告公升數變數
            double kpml;      // 宣告每公升公里數變數

            kilometers=double.Parse(milesTextBox.Text); 
            liters=double.Parse(gallonsTextBox.Text);
            kpml = kilometers / liters;

            kpml=kilometers/liters;

            mpgLabel.Text = kpml.ToString("n2") + " 公里/公升";



        }

        // 當使用者點擊「離開」按鈕時觸發
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
