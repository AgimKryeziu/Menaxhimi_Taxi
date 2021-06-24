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
    }
}
