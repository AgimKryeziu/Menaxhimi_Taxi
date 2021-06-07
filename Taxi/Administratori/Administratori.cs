using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taxi.BO;
using Taxi.BLL;
using Taxi.DAL;

namespace Taxi.Stafi
{
    public partial class Admin : Form
    {
        PjesemarresiBLL pjesemarresiBLL;
        PjesemarresitBO pjesemarresitBO;
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
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            bool inserted = pjesemarresiBLL.CreateAdmin(InsertAdmin());
            if (inserted)
            {
                MessageBox.Show("Te dhenat u shtuan me sukses.");
            }
            else
            {
                MessageBox.Show("Regjistrimi deshtoi.");
            }
        }

        public PjesemarresitBO InsertAdmin()
        {
            RoletBO roletBO = new RoletBO();
            pjesemarresitBO = new PjesemarresitBO(roletBO, txtEmri.Text, txtMbiemri.Text, txtNrTel.Text, txtEmail.Text, txtNofka.Text, txtFjalekalimi.Text, "user", DateTime.Now);

            return pjesemarresitBO;
        }


        public void Clear()
        {
            //txtRoliId.Text = "";
            txtEmri.Text = "";
            txtMbiemri.Text = "";
            txtNrTel.Text = "";
            txtEmail.Text = "";
            txtFjalekalimi.Text = "";
            txtNofka.Text = "";

            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnShto.Enabled = false;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
