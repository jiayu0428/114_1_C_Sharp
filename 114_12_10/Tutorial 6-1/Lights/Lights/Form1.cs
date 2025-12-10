using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lights
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void switchButton_Click(object sender, EventArgs e)
        {
           if(lightOffPictureBox.Visible==true)
            {
                
               turnLightOff();
            }
            else
            {
              turnLightOn();
            }
        }
        private void turnLightOn()
        {             lightOffPictureBox.Visible = false;
            lightOnPictureBox.Visible = true;
            lightStateLabel.Text = "ON";
        }
        private void turnLightOff()
        {
            lightOffPictureBox.Visible = true;
            lightOnPictureBox.Visible = false;
            lightStateLabel.Text = "OFF";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
