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
using System.Globalization;

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
            decimal totalSales = 0.0m; // 儲存總銷售額
            decimal currentSales = 0.0m; // 儲存目前讀取的銷售額

            // 檔案路徑（請確認此路徑為正確檔案位置，單一檔名）
            string path = @"C:\Users\m303\Downloads\Sales_modified_en.txt";

            if (!File.Exists(path))
            {
                MessageBox.Show("檔案不存在: " + path);
                return;
            }

            try
            {
                salesListBox.Items.Clear(); // 清除清單框內容

                string content;
                // 使用 using 自動關閉 StreamReader
                using (var inputFile = new StreamReader(path, Encoding.Default))
                {
                    content = inputFile.ReadToEnd();
ons.RemoveEmptyEntries);

                // 以任意空白字元（空格、tab、換行）切割為 token
                var tokens = content.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 0)
                {
                    MessageBox.Show("檔案內沒有可解析的內容。");
                    return;
                }

            try
                {
                    MessageBox.Show("警告：項目數為奇數，最後一個項目將被忽略。");
                }

                var styles = NumberStyles.Number | NumberStyles.AllowCurrencySymbol | NumberStyles.AllowThousands;

                // 逐對處理 token（month, amount）
                for (int i = 0; i + 1 < tokens.Length; i += 2)
                {
                    string month = tokens[i];
                    string amountText = tokens[i + 1];

                    // 嘗試以當地文化或不變文化解析數值
                    if (decimal.TryParse(amountText, styles, CultureInfo.CurrentCulture, out currentSales)
                        || decimal.TryParse(amountText, styles, CultureInfo.InvariantCulture, out currentSales))
                    {
                        salesListBox.Items.Add(string.Format("{0}: {1}", month, currentSales.ToString("C", CultureInfo.CurrentCulture)));
                        totalSales += currentSales;
                    }
                    else
                    {
                        // 遇到解析失敗則略過該配對並提示
                        MessageBox.Show("無法解析金額（已略過）： " + month + " " + amountText);
                    }
                }

                totalLabel.Text = totalSales.ToString("C", CultureInfo.CurrentCulture); // 顯示總銷售額
            }
            catch (Exception ex)
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
