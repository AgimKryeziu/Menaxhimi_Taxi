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
using Taxi.BO;

namespace Taxi.Automjeti
{
    public partial class Modelet : Form
    {
        public Modelet()
        {
            InitializeComponent();
        }

        ModeletBLL modeletBLL;

        private void btnShto_Click(object sender, EventArgs e)
        {
            ModeletBO modeletBO = new ModeletBO(txtEmri.Text, txtPershkrimi.Text, "User", DateTime.Now);
            modeletBLL.InsertModelt(modeletBO);
        }
    }
}
