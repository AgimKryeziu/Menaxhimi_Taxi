using System;
using System.Windows.Forms;
using Taxi.BLL;
using Taxi.BO;

namespace Taxi.Shoferi
{
    public partial class ShtoShofer : Form
    {
        ShoferiBO shoferiBO;
        ShoferiBLL shoferiBLL;
        public static bool isShto = false;

        public ShtoShofer()
        {
            InitializeComponent();
            shoferiBLL = new ShoferiBLL();
        }

        private void btnRuaj_Click_1(object sender, EventArgs e)
        {
            bool inserted = shoferiBLL.CreateShofer(InsertShofer());
            if (inserted)
            {
                MessageBox.Show("Te dhenat u shtuan me sukses.");
            }
            else
            {
                MessageBox.Show("Regjistrimi deshtoi.");
            }
        }

        public ShoferiBO InsertShofer()
        {
            char gender;
            if (rBtnGenderF.Checked)
            {
                gender = 'F';
            }
            else
            {
                gender = 'M';
            }

            shoferiBO = new ShoferiBO(txtEmri.Text, txtMbiemri.Text, gender, txtNrTel.Text, txtNrPersonal.Text, txtBiografia.Text, int.Parse(txtViti.Text), Base.SaveUsername, DateTime.Now);
            return shoferiBO;
        }


        public void LoadData(int shoferiId)
        {
            shoferiBO = shoferiBLL.GetItem(shoferiId);

            if (!string.IsNullOrEmpty(shoferiBO.IdPunes.ToString()))
            {
                txtEmri.Text = shoferiBO.Emri;
                txtMbiemri.Text = shoferiBO.Mbiemri;
                txtNrPersonal.Text = shoferiBO.NrPersonal;
                txtNrTel.Text = shoferiBO.NrTelefonit;
                txtViti.Text = shoferiBO.VitiNisjesPunes.ToString();
                txtBiografia.Text = shoferiBO.Biografia;
                gbGjinia.Text = shoferiBO.Gjinia.ToString();
                dtpDatelindja.Text = shoferiBO.Datelindja.ToString();
                txtShoferID.Text = shoferiId.ToString();
            }
        }

        private void btnPerditeso_Click_1(object sender, EventArgs e)
        {
            bool updated = shoferiBLL.UpdateShofer(UpdateShofer());

            if (updated)
            {
                MessageBox.Show("U ndryshua");
            }
            else
            {
                MessageBox.Show("Ndryshimi deshtoi");

            }
        }

        public ShoferiBO UpdateShofer()
        {
            char gender;
            if (rBtnGenderF.Checked)
            {
                gender = 'F';
            }
            else
            {
                gender = 'M';
            }

            DateTime datelindja = dtpDatelindja.Value;
            int id = int.Parse(txtShoferID.Text);
            shoferiBO = new ShoferiBO(id, txtEmri.Text, txtMbiemri.Text, datelindja, gender, txtNrTel.Text, txtNrPersonal.Text, txtBiografia.Text, int.Parse(txtViti.Text), Base.SaveUsername, DateTime.Now, 1);

            return shoferiBO;
        }

        private void ShtoShofer1_Load(object sender, EventArgs e)
        {
            btnRuaj.Enabled = isShto;
            btnPerditeso.Enabled = !isShto;
        }

        private void btnAlbLang_Click(object sender, EventArgs e)
        {
            var changeLang = new ChangeLang();
            changeLang.UpdateConfig("language", "sq");
            Application.Restart();

        }

        private void btnEngLang_Click(object sender, EventArgs e)
        {
            var changeLang = new ChangeLang();
            changeLang.UpdateConfig("language", "en");
            Application.Restart();
        }

        private void btnHelpAddDriver_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"E:\Agim_Kryeziu\Semestri 4\TI1\Projekti_TI1\Faza 4\Manual\ShtoShofer.htm");
        }
    }
}
