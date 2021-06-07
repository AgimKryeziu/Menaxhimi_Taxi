using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taxi.BLL;
using Taxi.BO;

namespace Taxi.Automjeti
{
    public partial class ShtoAutomjet : Form
    {
        AutomjetiBLL automjetiBLL;

        public ShtoAutomjet()
        {
            InitializeComponent();
            automjetiBLL = new AutomjetiBLL();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            bool aktiv;
            if (rbYes.Checked)
            {
                aktiv = true;
            }
            else
            {
                aktiv = false;
            }

            ModeletBO modeletBO = new ModeletBO(cmbModeliId.SelectedIndex + 1, cmbModeliId.Text);

            AutomjetiBO automjetiBO = new AutomjetiBO(modeletBO, txtTarga.Text, int.Parse(txtVitiIProdhimit.Text), aktiv, double.Parse(txtKm.Text), "User", DateTime.Now);
            bool inserted = automjetiBLL.InsertAutomjet(automjetiBO);
            if (inserted)
            {
                MessageBox.Show("Te dhenat u shtuan me sukses.");
            }
            else
            {
                MessageBox.Show("Regjistrimi deshtoi.");
            }

        }

        private void btnShtoModel_Click(object sender, EventArgs e)
        {
            Modelet modelet = new Modelet();
            modelet.Show();
        }

        private void ShtoAutomjet_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ModeletBLL.SelectModels();
            cmbModeliId.DataSource = dt;
            cmbModeliId.DisplayMember = dt.Columns[1].ColumnName;
            cmbModeliId.ValueMember = dt.Columns[0].ColumnName;
        }
    }
}
