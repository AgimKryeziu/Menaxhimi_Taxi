using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taxi.BLL;
using Taxi.DAL;
using Taxi.BO;

namespace Taxi
{
    public partial class LogInForms : Form
    {

        public static bool albFlag { get; set; } = true;

        public LogInForms()
        {
            InitializeComponent();
        }

        Base obj = new Base();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static string UserInUse { get; set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            
            if (PjesemarresiBLL.CheckLogin(txtUserName.Text, txtPassword.Text))
            {
                mainMenu.Show();
                obj.SaveUsername = txtUserName.Text;
            }
            else if(txtUserName.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Please write Username or Password!");
            }
            else
            {
                MessageBox.Show("Username or Password is incorect, please try again!");
            }
        }

        private void chbShfaq_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShfaq.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
