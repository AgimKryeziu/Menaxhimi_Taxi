using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxi
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Close();
        }
    }
}
