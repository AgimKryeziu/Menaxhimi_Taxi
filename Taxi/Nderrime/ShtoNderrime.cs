using System;
using System.Data;
using System.Windows.Forms;
using Taxi.BLL;
using Taxi.BO;
using Taxi.DAL;

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
            bool inserted = nderrimetBLL.InsertNderrim(InsertNderrim());
            if (inserted)
            {
                MessageBox.Show("Te dhenat u shtuan me sukses.");
            }
            else
            {
                MessageBox.Show("Regjistrimi deshtoi.");
            }
        }

        public NderrimetBO InsertNderrim()
        {
            modeletBO = new ModeletBO(int.Parse(cmbAutomjetiId.SelectedValue.ToString()), cmbAutomjetiId.Text);
            automjetiBO = new AutomjetiBO(int.Parse(cmbAutomjetiId.SelectedValue.ToString()), modeletBO);

            shoferiBO = new ShoferiBO(int.Parse(cmbShoferiId.SelectedValue.ToString()), cmbShoferiId.Text);

            DateTime kohaEFillimit = dtpFillimiINderrimit.Value;
            DateTime kohaEMbarimit = dtpMbarimiINderrimir.Value;

            nderrimetBO = new NderrimetBO(shoferiBO, automjetiBO, kohaEFillimit, kohaEMbarimit, Base.SaveUsername, DateTime.Now);
            return nderrimetBO;
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
            dt1 = AutomjetiBLL.SelectCab();
            cmbAutomjetiId.DataSource = dt1;
            cmbAutomjetiId.DisplayMember = dt1.Columns[1].ColumnName;
            cmbAutomjetiId.ValueMember = dt1.Columns[0].ColumnName;
        }

        private void btnPerditeso_Click(object sender, EventArgs e)
        {
            bool updated = nderrimetBLL.UpdateNderrim(UpdateNderrim());

            if (updated)
            {

                MessageBox.Show("U ndryshua");
            }
            else
            {
                MessageBox.Show("Ndryshimi deshtoi");

            }
        }

        public NderrimetBO UpdateNderrim()
        {
            int id = int.Parse(txtNderrimiId.Text);

            modeletBO = new ModeletBO(int.Parse(cmbAutomjetiId.SelectedValue.ToString()), cmbAutomjetiId.Text);
            automjetiBO = new AutomjetiBO(int.Parse(cmbAutomjetiId.SelectedValue.ToString()), modeletBO);

            shoferiBO = new ShoferiBO(int.Parse(cmbShoferiId.SelectedValue.ToString()), cmbShoferiId.Text);

            DateTime kohaEFillimit = dtpFillimiINderrimit.Value;
            DateTime kohaEMbarimit = dtpMbarimiINderrimir.Value;
            nderrimetBO = new NderrimetBO(id, shoferiBO, automjetiBO, kohaEFillimit, kohaEMbarimit, Base.SaveUsername, DateTime.Now, 1);

            return nderrimetBO;
        }
    }
}
