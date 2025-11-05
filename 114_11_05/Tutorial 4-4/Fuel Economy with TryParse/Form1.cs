using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy_with_TryParse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double kms;
            double liters;
            double fuelEconomy;

            // 先驗證公里數輸入是否為有效數字
            if (!double.TryParse(milesTextBox.Text, out kms))
            {
                MessageBox.Show("請輸入有效的公里數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                milesTextBox.Focus();
                return;
            }

            // 再驗證公升數輸入是否為有效數字
            if (!double.TryParse(gallonsTextBox.Text, out liters))
            {
                MessageBox.Show("請輸入有效的公升數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gallonsTextBox.Focus();
                return;
            }

            // 檢查公升數不能為 0（避免除以零）
            if (liters == 0.0)
            {
                MessageBox.Show("公升數不能為 0。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gallonsTextBox.Focus();
                return;
            }

            // 計算 km/L 並格式化顯示到介面
            fuelEconomy = kms / liters;
            mpgLabel.Text = fuelEconomy.ToString("n2") + " 公里/公升";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
