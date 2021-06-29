using System;
using System.Data;
using System.Windows.Forms;
using Taxi.BLL;
using Taxi.BO;

namespace Taxi.Sherbime
{
    public partial class Sherbimi : Form
    {
        public static DataTable lista;
        public static int sherbimiId;
        SherbimetBLL sherbimetBLL;
        bool albFlag = LogInForms.albFlag;
        public Sherbimi()
        {
            InitializeComponent();
        }

        private void Sherbimi_Load(object sender, EventArgs e)
        {
            PopulateShoferiList();
        }

        public void PopulateShoferiList()
        {
            sherbimetBLL = new SherbimetBLL();
            lista = sherbimetBLL.ShowServices();
            dgvSherbimet.DataSource = lista;
            dgvSherbimet.Columns["SherbimiId"].Visible = false;

            DataGridViewButtonColumn editButtton = new DataGridViewButtonColumn();
            editButtton.Name = "Edit";
            editButtton.HeaderText = "Edit";
            editButtton.Text = "Edit";
            editButtton.UseColumnTextForButtonValue = true;

            editButtton.Width = 60;
            dgvSherbimet.Columns.Add(editButtton);
        }

        private void dgvSherbimet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sherbimetBLL = new SherbimetBLL();

            if (e.ColumnIndex == 0)
            {
                ShtoSherbim addShofer = new ShtoSherbim();
                ShtoSherbim.isShto = false;
                sherbimiId = Convert.ToInt32(dgvSherbimet.Rows[e.RowIndex].Cells[1].Value.ToString());
                addShofer.LoadData(sherbimiId);
                addShofer.ShowDialog();
            }
        }

        private void bntShto_Click(object sender, EventArgs e)
        {
            Sherbime.ShtoSherbim shtoSherbim = new ShtoSherbim();
            ShtoSherbim.isShto = true;

            var changeLang = new ChangeLang();
            if (albFlag)
            {
                changeLang.UpdateConfig("language", "sq");
                shtoSherbim.ShowDialog();
            }
            else
            {
                changeLang.UpdateConfig("language", "en");
                shtoSherbim.ShowDialog();
            }           
        }

        private void btnHelpService_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"E:\Agim_Kryeziu\Semestri 4\TI1\Projekti_TI1\Faza 4\Manual\Sherbimet.htm");
        }
    }
}
