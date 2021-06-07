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

namespace Taxi.Destinacione
{
    public partial class Destinacioni : Form
    {
        DestinacionetBLL destinacionetBLL;
        public Destinacioni()
        {
            InitializeComponent();
            destinacionetBLL = new DestinacionetBLL();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            AdresaBO adresaBO = new AdresaBO(txtShteti.Text, txtQyteti.Text, txtLagjja.Text, txtRruga.Text, "user", DateTime.Now);
            DestinacioniBO destinacioniBO = new DestinacioniBO(adresaBO);

            bool inserted = destinacionetBLL.CreateDestinacion(destinacioniBO);
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
