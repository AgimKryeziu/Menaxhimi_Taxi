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

        public static bool albFlag { get; set; } = true;
        private void btnAlbLang_Click(object sender, EventArgs e)
        {
            var changeLang = new ChangeLang();
            changeLang.UpdateConfig("language", "sq");
            albFlag = true;
            Application.Restart();
        }

        private void btnEngLang_Click(object sender, EventArgs e)
        {
            var changeLang = new ChangeLang();
            changeLang.UpdateConfig("language", "en");
            albFlag = false;
            Application.Restart();
        }

        private void btnKyçu_Click(object sender, EventArgs e)
        {
            if (PjesemarresiBLL.CheckLogin(txtUserName.Text, txtPassword.Text))
            {
                Main mainMenu = new Main();
                if (albFlag = true) 
                {
                    var changeLang = new ChangeLang();
                    changeLang.UpdateConfig("language", "sq");
                    mainMenu.Show();
                }
                else
                {
                    var changeLang = new ChangeLang();
                    changeLang.UpdateConfig("language", "en");
                    mainMenu.Show();
                }

                Base.SaveUsername = txtUserName.Text;
                this.Visible = false;
            }
            else
            {
                if (albFlag)
                {
                    MessageBox.Show("Kredenciale te gabuara, ju lutem provoni perseri!");
                }
                else
                {
                    MessageBox.Show("Username or Password is incorect, please try again!");
                }
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

        private void btnCloseLoginForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void LogInForms_Load(object sender, EventArgs e)
        {
            albFlag = true;
        }
    }
}
