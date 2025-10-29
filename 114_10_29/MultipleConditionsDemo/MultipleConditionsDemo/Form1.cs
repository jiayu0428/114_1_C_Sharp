using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleConditionsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void judgeButton_Click(object sender, EventArgs e)
        {
            try
                {
                int score = int.Parse(scoreTextBox.Text);
                string grade;
                //if (score >= 90)
                //{
                //    grade = "A";
                //}
                //else if (score >= 80)// score<90是隱含條件
                //{
                //    grade = "B";
                //}
                //else if (score >= 70)// score<80是隱含條件
                //{
                 //   grade = "C";
                //}
                //else if (score >= 60)// score<70是隱含條件
                //{
                //    grade = "D";
                //}
                //else
                //{
                 //   grade = "F";
                //}
                

                


                gradeTextBox.Text = $"成績等級:"+grade; 
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入有效的數字成績。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
