﻿using System;
using System.Data;
using System.Windows.Forms;
using Taxi.BLL;
using Taxi.BO;

namespace Taxi.Automjeti
{
    public partial class ShtoAutomjet : Form
    {
        AutomjetiBLL automjetiBLL;
        bool albFlag = LogInForms.albFlag;
        public ShtoAutomjet()
        {
            InitializeComponent();
            automjetiBLL = new AutomjetiBLL();
        }

        AutomjetiBO automjetiBO;
        ModeletBO modeletBO;
        public static bool isShto = false;

        private void btnRuaj_Click(object sender, EventArgs e)
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

            modeletBO = new ModeletBO(int.Parse(cmbModeliId.SelectedValue.ToString()), cmbModeliId.Text);

            automjetiBO = new AutomjetiBO(modeletBO, txtTarga.Text, int.Parse(txtVitiIProdhimit.Text), aktiv, double.Parse(txtKm.Text), Base.SaveUsername, DateTime.Now);
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

        private void btnPerditeso_Click(object sender, EventArgs e)
        {

            bool updated = automjetiBLL.UpdateAutomjet(UpdateAutomjet());

            if (updated)
            {

                MessageBox.Show("U ndryshua");
            }
            else
            {
                MessageBox.Show("Ndryshimi deshtoi");

            }
        }

        public void LoadData(int automjetiId)
        {
            automjetiBO = automjetiBLL.GetItem(automjetiId);


            if (!string.IsNullOrEmpty(automjetiBO.AutomjetiId.ToString()))
            {
                txtAutomjetiId.Text = automjetiId.ToString();
                txtTarga.Text = automjetiBO.Targa;
                cmbModeliId.Text = automjetiBO.Modelet.ModeliId.ToString();
                txtKm.Text = automjetiBO.Km.ToString();
                txtVitiIProdhimit.Text = automjetiBO.VitiIProdhimit.ToString();
            }
        }

        private void btnShtoModel_Click(object sender, EventArgs e)
        {
            Modelet modelet = new Modelet();
            var changeLang = new ChangeLang();
            if (albFlag)
            {
                changeLang.UpdateConfig("language", "sq");
                modelet.ShowDialog();
            }
            else
            {
                changeLang.UpdateConfig("language", "en");
                modelet.ShowDialog();
            }
        }

        private void ShtoAutomjet_Load(object sender, EventArgs e)
        {
            btnRuaj.Enabled = isShto;
            btnPerditeso.Enabled = !isShto;

            DataTable dt = new DataTable();
            dt = ModeletBLL.SelectModels();
            cmbModeliId.DataSource = dt;
            cmbModeliId.DisplayMember = dt.Columns[1].ColumnName;
            cmbModeliId.ValueMember = dt.Columns[0].ColumnName;
        }

        public AutomjetiBO UpdateAutomjet()
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

            int id = int.Parse(txtAutomjetiId.Text);
            modeletBO = new ModeletBO(cmbModeliId.SelectedIndex + 1, cmbModeliId.Text);
            automjetiBO = new AutomjetiBO(id, modeletBO, txtTarga.Text, int.Parse(txtVitiIProdhimit.Text), aktiv, double.Parse(txtKm.Text), Base.SaveUsername, DateTime.Now, 1);

            return automjetiBO;
        }

        private void btnHelpAddCab_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"E:\Agim_Kryeziu\Semestri 4\TI1\Projekti_TI1\Faza 4\Manual\ShtoAutomjet.htm");
        }
    }
}
