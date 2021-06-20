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
using Taxi.DAL;
using Taxi.BLL;

namespace Taxi.Nderrime
{
    public partial class ShtoNderrime : Form
    {
        NderrimetBO nderrimetBO;
        NderrimetBLL nderrimetBLL;
        ShoferiBO shoferiBO;
        AutomjetiBO automjetiBO;
        ModeletBO modeletBO;
        public ShtoNderrime()
        {
            InitializeComponent();
            nderrimetBLL = new NderrimetBLL();
        }

        private void bntRuaj_Click(object sender, EventArgs e)
        {
            modeletBO = new ModeletBO(cmbAutomjetiId.SelectedIndex + 1, cmbAutomjetiId.Text);
            automjetiBO = new AutomjetiBO(cmbAutomjetiId.SelectedIndex + 1, modeletBO);
            shoferiBO = new ShoferiBO(cmbShoferiId.SelectedIndex + 1, cmbShoferiId.Text);

           


            nderrimetBO = new NderrimetBO(shoferiBO, automjetiBO, Convert.ToDateTime(dtpFillimiINderrimit), Convert.ToDateTime(dtpMbarimiINderrimir), "User", DateTime.Now);
            bool inserted = nderrimetBLL.InsertNderrim(nderrimetBO);
            if (inserted)
            {
                MessageBox.Show("Te dhenat u shtuan me sukses.");
            }
            else
            {
                MessageBox.Show("Regjistrimi deshtoi.");
            }
        }

        public void LoadData(int nderrimiId)
        {
            nderrimetBO = nderrimetBLL.GetItem(nderrimiId);


            if (!string.IsNullOrEmpty(nderrimetBO.NderrimiId.ToString()))
            {
                txtNderrimiId.Text = nderrimiId.ToString();
                cmbAutomjetiId.Text = nderrimetBO.Automjeti.AutomjetiId.ToString();
                cmbShoferiId.Text = nderrimetBO.Shoferi.IdPunes.ToString();
            }
        }

        private void ShtoNderrime_Load_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ShoferiBLL.SelectDrivers();
            cmbShoferiId.DataSource = dt;
            cmbShoferiId.DisplayMember = dt.Columns[1].ColumnName;
            cmbShoferiId.ValueMember = dt.Columns[0].ColumnName;

            DataTable dt1 = new DataTable();
            dt1 = ModeletBLL.SelectModels();
            cmbAutomjetiId.DataSource = dt1;
            cmbAutomjetiId.DisplayMember = dt1.Columns[1].ColumnName;
            cmbAutomjetiId.ValueMember = dt1.Columns[0].ColumnName;
            
        }
    }
}
