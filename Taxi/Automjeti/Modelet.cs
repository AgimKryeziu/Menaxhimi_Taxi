using System;
using System.Windows.Forms;
using Taxi.BLL;
using Taxi.BO;

namespace Taxi.Automjeti
{
    public partial class Modelet : Form
    {
        ModeletBLL modeletBLL;

        public Modelet()
        {
            InitializeComponent();
            modeletBLL = new ModeletBLL();
        }

        bool albFlag = LogInForms.albFlag;

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            ModeletBO modeletBO = new ModeletBO(txtEmri.Text, txtPershkrimi.Text, Base.SaveUsername, DateTime.Now);
            bool inserted = modeletBLL.InsertModelet(modeletBO);
            if (inserted)
            {
                MessageBox.Show("Te dhenat u shtuan me sukses.");
            }
            else
            {
                MessageBox.Show("Regjistrimi deshtoi.");
            }
        }

        private void btnHelpModel_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"E:\Agim_Kryeziu\Semestri 4\TI1\Projekti_TI1\Faza 4\Manual\ShtoModel.htm");
        }
    }
}
