using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p132_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void coinHeadsPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            coinHeadsPictureBox.Visible = false;
            coinTailsPictureBox.Visible = false;
        }

        private void showHeadsButton_Click(object sender, EventArgs e)
        {
            coinHeadsPictureBox.Visible = true;
            coinTailsPictureBox.Visible = false;
        }

        private void showTailsButton_Click(object sender, EventArgs e)
        {
            coinTailsPictureBox.Visible = true;
            coinHeadsPictureBox.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
