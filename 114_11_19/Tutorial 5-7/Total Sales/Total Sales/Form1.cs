using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            decimal totalSales = 0;
            decimal currentSales = 0;

            try
            {
                inputFile= File.OpenText("Sales.txt");// 開啟Sales.txt檔案
                salesListBox.Items.Clear();// 清空ListBox內容

                while (!inputFile.EndOfStream)// 讀取直到檔案結尾
                {
                    String line = inputFile.ReadLine();
                    salesListBox.Items.Add(line);
                    currentSales = decimal.Parse(line);// 讀取當前銷售額並轉換為decimal
                    totalSales += currentSales;// 累加到總銷售額
                    
                }
                inputFile.Close();// 關閉檔案
                totalLabel.Text = totalSales.ToString("C");// 顯示總銷售額
            }
            catch(Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message);
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
