using System;
using System.Data;
using System.Windows.Forms;
using Taxi.Administratori;
using Taxi.BLL;

namespace Taxi.Stafi
{
    public partial class Admin : Form
    {
        PjesemarresiBLL pjesemarresiBLL;
        public static DataTable lista;

        public Admin()
        {
            InitializeComponent();
            pjesemarresiBLL = new PjesemarresiBLL();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            PopulateAdminList();
        }
        public void PopulateAdminList()
        {
            PjesemarresiBLL pjesemarresiBLL = new PjesemarresiBLL();
            lista = pjesemarresiBLL.ShowAdmins();
            dgvAdmin.DataSource = lista;
            dgvAdmin.Columns["PmID"].Visible = false;

            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();

            editButton.Name = "Edit";
            editButton.HeaderText = "Edit";
            editButton.Text = "Edit";
            editButton.UseColumnTextForButtonValue = true;

            editButton.Width = 60;
            dgvAdmin.Columns.Add(editButton);


            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();

            deleteButton.Name = "Delete";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;

            deleteButton.Width = 60;
            dgvAdmin.Columns.Add(deleteButton);
        }

        private void btnShto_Click_1(object sender, EventArgs e)
        {
            ShtoAdmin shtoAdmin = new ShtoAdmin();
            shtoAdmin.ShowDialog();
        }

        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pjesemarresiBLL = new PjesemarresiBLL();


            if (e.ColumnIndex == 8)
            {
                ShtoAdmin shtoAdmin = new ShtoAdmin();

                int adminId = Convert.ToInt32(dgvAdmin.Rows[e.RowIndex].Cells[0].Value.ToString());
                shtoAdmin.LoadData(adminId);
                shtoAdmin.ShowDialog();
            }
            if (e.ColumnIndex == 9)
            {
                int adminId = Convert.ToInt32(dgvAdmin.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (DialogResult.OK == MessageBox.Show("A jeni i sigurt qe deshironi te fshini kete item"))
                {
                    bool deleted = pjesemarresiBLL.DeleteAdmin(adminId);
                    if (deleted)
                    {
                        MessageBox.Show("Te dhenat jane fshir me sukses");
                        PopulateAdminList();
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
