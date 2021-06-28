using System;
using System.Data;
using System.Windows.Forms;
using Taxi.BLL;
using Taxi.BO;

namespace Taxi.Nderrime
{
    public partial class NderrimetList : Form
    {
        bool albFlag = LogInForms.albFlag;
        NderrimetBLL nderrimetBLL;
        public static int nderrimiId;
        public static DataTable lista;

        public NderrimetList()
        {
            InitializeComponent();
            nderrimetBLL = new NderrimetBLL();
        }

        private void NderrimetList_Load(object sender, EventArgs e)
        {
            PopulateNderrimiList();
        }

        public void PopulateNderrimiList()
        {
            PjesemarresiBLL pjesemarresiBLL = new PjesemarresiBLL();
            lista = nderrimetBLL.ShowNderrimet();
            dgvNdrrimet.DataSource = lista;
            dgvNdrrimet.Columns["NderrimiId"].Visible = false;

            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();

            editButton.Name = "Edit";
            editButton.HeaderText = "Edit";
            editButton.Text = "Edit";
            editButton.UseColumnTextForButtonValue = true;

            editButton.Width = 60;
            dgvNdrrimet.Columns.Add(editButton);


            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();

            deleteButton.Name = "Delete";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;

            deleteButton.Width = 60;
            dgvNdrrimet.Columns.Add(deleteButton);
        }



        private void btnShtoShofer_Click(object sender, EventArgs e)
        {
            ShtoNderrime shtoNderrime = new ShtoNderrime();
            ShtoNderrime.isShto = true;
            if (albFlag)
            {
                var changeLang = new ChangeLang();
                changeLang.UpdateConfig("language", "sq");
                shtoNderrime.ShowDialog();
            }
            else
            {
                var changeLang = new ChangeLang();
                changeLang.UpdateConfig("language", "en");
                shtoNderrime.ShowDialog();
            }            
        }

        private void dgvNdrrimet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nderrimetBLL = new NderrimetBLL();


            if (e.ColumnIndex == 0)
            {
                ShtoNderrime shtoNderrime = new ShtoNderrime();
                ShtoNderrime.isShto = false;
                nderrimiId = Convert.ToInt32(dgvNdrrimet.Rows[e.RowIndex].Cells[2].Value.ToString()); ;
                shtoNderrime.LoadData(nderrimiId);
                shtoNderrime.ShowDialog();
            }
            if (e.ColumnIndex == 1)
            {
                nderrimiId = Convert.ToInt32(dgvNdrrimet.Rows[e.RowIndex].Cells[2].Value.ToString());
                if (DialogResult.OK == MessageBox.Show("A jeni i sigurt qe deshironi te fshini kete item"))
                {
                    bool deleted = nderrimetBLL.DeleteNderrimin(nderrimiId);
                    if (deleted)
                    {
                        MessageBox.Show("Te dhenat jane fshir me sukses");
                        PopulateNderrimiList();
                    }
                    else
                    {
                        MessageBox.Show("Fshirja e te dhenave deshtoi! provoni me vone");
                    }
                }
            }

        }


    }
}
