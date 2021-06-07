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

namespace Taxi.Automjeti
{
    public partial class Automjeti : Form
    {
        public Automjeti()
        {
            InitializeComponent();
        }


        public static DataTable lista;


        private void Automjeti_Load(object sender, EventArgs e)
        {
            PopulateAutomjetiList();
        }

        public void PopulateAutomjetiList()
        {
            AutomjetiBLL shoferi = new AutomjetiBLL();
            lista = shoferi.ShowAllCab();
            dgvAutomjeti.DataSource = lista;
            dgvAutomjeti.Columns["AutomjetiId"].Visible = false;
        }


        private void btnShto_Click(object sender, EventArgs e)
        {
            Taxi.Automjeti.ShtoAutomjet shtoAutomjet = new ShtoAutomjet();
            shtoAutomjet.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Taxi.Automjeti.ShtoAutomjet shtoAutomjet = new ShtoAutomjet();
            shtoAutomjet.Show();
        }
    }
}
