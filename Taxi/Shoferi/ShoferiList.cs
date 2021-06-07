using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taxi.DAL;
using Taxi.BLL;
using Sho = Taxi.Shoferi;
using Taxi.BO;

namespace Taxi.Shoferi
{
    public partial class ShoferiList : Form
    {
        public ShoferiList()
        {
            InitializeComponent();
        }

        public static DataTable lista;
        public static int shoferiId;

        private void ShoferiList_Load(object sender, EventArgs e)
        {
            PopulateShoferiList();
        }

        public void PopulateShoferiList()
        {
            ShoferiBLL shoferi = new ShoferiBLL();
            lista = shoferi.ShowShoferat();
            dgvShoferiList.DataSource = lista;
            dgvShoferiList.Columns["ShoferiId"].Visible = false;

            DataGridViewButtonColumn editButtton = new DataGridViewButtonColumn();
            editButtton.Name = "Edit";
            editButtton.HeaderText = "Edit";
            editButtton.Text = "Edit";
            editButtton.UseColumnTextForButtonValue = true;

            editButtton.Width = 60;
            dgvShoferiList.Columns.Add(editButtton);
        }   

        private void dgvShoferiList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {
                ShtoShofer addShofer = new ShtoShofer();
                shoferiId = Convert.ToInt32(dgvShoferiList.Rows[e.RowIndex].Cells[0].Value.ToString());
                addShofer.LoadData(shoferiId);
                addShofer.ShowDialog();
            }
        }


        private void btnShtoShofer_Click(object sender, EventArgs e)
        {
            ShtoShofer shtoShofer = new ShtoShofer();
            shtoShofer.Show();

        }
    }
}
