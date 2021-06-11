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

namespace Taxi.Automjeti
{
    public partial class Automjeti : Form
    {
        public Automjeti()
        {
            InitializeComponent();
        }

        private void Automjeti_Load(object sender, EventArgs e)
        {
            PopulateAutomjetiList();
        }

        public static DataTable lista;
        AutomjetiBLL automjetiBLL;
        public static int automjetiId;

        public void PopulateAutomjetiList()
        {
            automjetiBLL = new AutomjetiBLL();
            lista = automjetiBLL.ShowAllCab();
            dgvAutomjeti.DataSource = lista;
            dgvAutomjeti.Columns["AutomjetiId"].Visible = false;

            DataGridViewButtonColumn editButtton = new DataGridViewButtonColumn();
            editButtton.Name = "Edit";
            editButtton.HeaderText = "Edit";
            editButtton.Text = "Edit";
            editButtton.UseColumnTextForButtonValue = true;

            editButtton.Width = 60;
            dgvAutomjeti.Columns.Add(editButtton);


            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();

            deleteButton.Name = "Delete";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;

            deleteButton.Width = 60;
            dgvAutomjeti.Columns.Add(deleteButton);
        }


        private void btnShto_Click(object sender, EventArgs e)
        {
            Taxi.Automjeti.ShtoAutomjet shtoAutomjet = new ShtoAutomjet();
            shtoAutomjet.Show();
        }

        private void dgvAutomjeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            automjetiBLL = new AutomjetiBLL();

            if (e.ColumnIndex == 5)
            {
                ShtoAutomjet addAutomjet = new ShtoAutomjet();

                automjetiId = Convert.ToInt32(dgvAutomjeti.Rows[e.RowIndex].Cells[0].Value.ToString());
                addAutomjet.LoadData(automjetiId);
                addAutomjet.ShowDialog();
            }
            if (e.ColumnIndex == 6)
            {
                int automjetiId = Convert.ToInt32(dgvAutomjeti.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (DialogResult.OK == MessageBox.Show("A jeni i sigurt qe deshironi te fshini kete item"))
                {
                    bool deleted = automjetiBLL.DeleteAutomjet(automjetiId);
                    if (deleted)
                    {
                        MessageBox.Show("Te dhenat jane fshir me sukses");
                        PopulateAutomjetiList();
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
