using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            String account = txtAccount.Text;
            String password = txtPassword.Text;

            //if (account == "admin" && password == "123456")
            //{
            //    lblResult.Text = "登入成功";
            //}
            //else
            //{
            //    lblResult.Text = "帳號或密碼錯誤";
            //}
            if (account.Length == 0 || password.Length == 0)
            {
                lblResult.Text = "請輸入帳號及密碼";
            }
            else
            {
                if (string.Compare(account, "admin", true) == 0)
                {
                    if (string.Compare(password, "123456", false) == 0)
                    {
                        lblResult.Text = "登入成功";
                    }
                    else
                    {
                        lblResult.Text = "密碼錯誤";
                    }
                }
                else
                {
                    lblResult.Text = "帳號錯誤";
                }
            }
        }
    }
}
