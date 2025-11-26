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

namespace Friend_File
{
    public partial class Form1 : Form
    {
        private string count;

        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            
            StreamWriter outputFile;
            saveFileDialog1.InitialDirectory = @"C:\Users\m303\Desktop";
            saveFileDialog1.Title = "儲存朋友名單";

            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                outputFile = File.AppendText(saveFileDialog1.FileName);
                outputFile.WriteLine(count + ":" + nameTextBox.Text);
                outputFile.Close();
            }
            else
            {
                MessageBox.Show("未選擇檔案");
            }



            nameTextBox.Text = "";
            nameTextBox.Focus();
             
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
