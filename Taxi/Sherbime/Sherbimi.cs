using System;
using System.Data;
using System.Windows.Forms;
using Taxi.BLL;

namespace Taxi.Sherbime
{
    public partial class Sherbimi : Form
    {
        public static DataTable lista;
        public static int sherbimiId;
        SherbimetBLL sherbimetBLL;
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

            if (e.ColumnIndex == 9)
            {
                ShtoSherbim addShofer = new ShtoSherbim();
                sherbimiId = Convert.ToInt32(dgvSherbimet.Rows[e.RowIndex].Cells[0].Value.ToString());
                addShofer.LoadData(sherbimiId);
                addShofer.ShowDialog();
            }
        }

        private void bntShto_Click(object sender, EventArgs e)
        {
            Sherbime.ShtoSherbim shtoSherbim = new ShtoSherbim();
            shtoSherbim.ShowDialog();
        }

    }
}
