using System;
using System.Windows.Forms;
using Taxi.BLL;
using Taxi.BO;

namespace Taxi.Administratori
{
    public partial class ShtoRol : Form
    {
        RoletBO roletBO;
        RoliBLL roletBLL;
        bool albFlag = LogInForms.albFlag;
        public ShtoRol()
        {
            InitializeComponent();
            roletBLL = new RoliBLL();
        }

        private void btnShto_Click_1(object sender, EventArgs e)
        {
            roletBO = new RoletBO(txtPershkrimi.Text, Base.SaveUsername, DateTime.Now);
            bool inserted = roletBLL.CreateRole(roletBO);
            if (inserted)
            {
                MessageBox.Show("Te dhenat u shtuan me sukses.");
            }
            else
            {
                MessageBox.Show("Regjistrimi deshtoi.");
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "E:\\Agim_Kryeziu\\Semestri 4\\TI1\\Projekti_TI1\\Faza 4\\Helper Manual.chm", HelpNavigator.Topic, "ShtoRol.htm");

        }

        private void btnHelpAddRole_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"E:\Agim_Kryeziu\Semestri 4\TI1\Projekti_TI1\Faza 4\Manual\ShtoRol.htm");
        }
    }
}
