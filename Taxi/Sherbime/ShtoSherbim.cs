using System;
using System.Data;
using System.Windows.Forms;
using Taxi.BLL;
using Taxi.BO;

namespace Taxi.Sherbime
{
    public partial class ShtoSherbim : Form
    {

        SherbimetBO sherbimetBO;
        NderrimetBO nderrimetBO;
        DestinacioniBO destinacioniBO;
        ShoferiBO shoferiBO;
        AdresaBO adresaBO;
        SherbimetBLL sherbimetBLL;


        public ShtoSherbim()
        {
            InitializeComponent();
            sherbimetBLL = new SherbimetBLL();
        }

        private void btnShtoDestimacion_Click(object sender, EventArgs e)
        {
            Destinacione.Destinacioni destinacioni = new Destinacione.Destinacioni();
            destinacioni.Show();
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            bool inserted = sherbimetBLL.CreateService(InsertService());
            if (inserted)
            {
                MessageBox.Show("Te dhenat u shtuan me sukses.");
            }
            else
            {
                MessageBox.Show("Regjistrimi deshtoi.");
            }
        }

        public SherbimetBO InsertService()
        {
            bool anulohet;
            if (rBtnPo.Checked)
            {
                anulohet = true;
            }
            else
            {
                anulohet = false;
            }
            shoferiBO = new ShoferiBO(int.Parse(cmbNdrrimiId.SelectedValue.ToString()), cmbNdrrimiId.Text);
            nderrimetBO = new NderrimetBO(int.Parse(cmbNdrrimiId.SelectedValue.ToString()), shoferiBO);

            adresaBO = new AdresaBO(int.Parse(cmbDestinacioniId.SelectedValue.ToString()), cmbDestinacioniId.Text);
            destinacioniBO = new DestinacioniBO(int.Parse(cmbDestinacioniId.SelectedValue.ToString()), adresaBO);


            DateTime kohaENisjes = dtpKohaENisjes.Value;
            DateTime kohaEMberritjes = dtpKohaEMberritjes.Value;

            sherbimetBO = new SherbimetBO(nderrimetBO, kohaENisjes, txtVendTakimi.Text, destinacioniBO, kohaEMberritjes, double.Parse(txtDistanca.Text), anulohet, Base.SaveUsername, DateTime.Now);
            return sherbimetBO;
        }

        private void btnPerditeso_Click(object sender, EventArgs e)
        {
            bool updated = sherbimetBLL.UpdateService(UpdateService());

            if (updated)
            {
                MessageBox.Show("U ndryshua");
            }
            else
            {
                MessageBox.Show("Ndryshimi deshtoi");

            }
        }

        public SherbimetBO UpdateService()
        {
            bool anulohet;
            if (rBtnPo.Checked)
            {
                anulohet = true;
            }
            else
            {
                anulohet = false;
            }
            shoferiBO = new ShoferiBO(int.Parse(cmbNdrrimiId.SelectedValue.ToString()), cmbNdrrimiId.Text);
            nderrimetBO = new NderrimetBO(int.Parse(cmbNdrrimiId.SelectedValue.ToString()), shoferiBO);

            adresaBO = new AdresaBO(int.Parse(cmbDestinacioniId.SelectedValue.ToString()), cmbDestinacioniId.Text);
            destinacioniBO = new DestinacioniBO(int.Parse(cmbDestinacioniId.SelectedValue.ToString()), adresaBO);


            DateTime kohaENisjes = dtpKohaENisjes.Value;
            DateTime kohaEMberritjes = dtpKohaEMberritjes.Value;
            int id = int.Parse(txtSherbimiId.Text);
            sherbimetBO = new SherbimetBO(id, nderrimetBO, kohaENisjes, txtVendTakimi.Text, destinacioniBO, kohaEMberritjes, double.Parse(txtDistanca.Text), anulohet, Base.SaveUsername, DateTime.Now, 1);

            return sherbimetBO;
        }

        public void LoadData(int sherbimiId)
        {
            sherbimetBO = sherbimetBLL.GetItem(sherbimiId);

            if (!string.IsNullOrEmpty(sherbimetBO.SherbimiId.ToString()))
            {
                txtDistanca.Text = sherbimetBO.Distanca.ToString();
                txtVendTakimi.Text = sherbimetBO.Vendtakimi;
                cmbDestinacioniId.Text = sherbimetBO.Destinacioni.DestinacioniId.ToString();
                cmbNdrrimiId.Text = sherbimetBO.Ndrrimet.NderrimiId.ToString();
                txtSherbimiId.Text = sherbimiId.ToString();
            }
        }

        private void ShtoSherbim_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = NderrimetBLL.SelectNderrimet();
                cmbNdrrimiId.DataSource = dt;
                cmbNdrrimiId.DisplayMember = dt.Columns[1].ColumnName;
                cmbNdrrimiId.ValueMember = dt.Columns[0].ColumnName;

                DataTable dt1 = new DataTable();
                dt1 = DestinacionetBLL.SelectDestinacionet();
                cmbDestinacioniId.DataSource = dt1;
                cmbDestinacioniId.DisplayMember = dt1.Columns[1].ColumnName;
                cmbDestinacioniId.ValueMember = dt1.Columns[0].ColumnName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            
            }
            
        }
    }
}
