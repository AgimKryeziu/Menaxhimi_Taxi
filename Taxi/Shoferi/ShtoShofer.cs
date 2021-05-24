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

namespace Taxi.Shoferi
{
    public partial class ShtoShofer : Form
    {
        ShoferiBO shoferiBO;
        ShoferiBLL shoferiBLL;

        public ShtoShofer()
        {
            InitializeComponent();
            shoferiBLL = new ShoferiBLL();
        }

       
        private void btnRuaj_Click(object sender, EventArgs e)
        {
            ShoferiBLL shoferiBLL = new ShoferiBLL();
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

            shoferiBO = new ShoferiBO(txtEmri.Text, txtMbiemri.Text, gender, txtNrTel.Text, txtNrPersonal.Text, txtBiografia.Text, int.Parse(txtViti.Text), "user", DateTime.Now);
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
            }
        }
    }
}
