using System;
using System.Windows.Forms;
using Taxi.BLL;
using Taxi.BO;

namespace Taxi
{
    public partial class LogInForms : Form
    {


        public LogInForms()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static string UserInUse { get; set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (PjesemarresiBLL.CheckLogin(txtUserName.Text, txtPassword.Text))
            {
                Main mainMenu = new Main();
                mainMenu.Show();
                Base.SaveUsername = txtUserName.Text;
                this.Visible = false;
            }
            else if (txtUserName.Text == "" && txtPassword.Text == "")
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
    }
}
