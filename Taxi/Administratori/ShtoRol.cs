using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taxi.BO;
using Taxi.BLL;

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
            roletBO = new RoletBO(txtPershkrimi.Text, "User", DateTime.Now);
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
