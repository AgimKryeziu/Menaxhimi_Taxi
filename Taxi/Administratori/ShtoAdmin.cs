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
using Taxi.DAL;

namespace Taxi.Administratori
{
    public partial class ShtoAdmin : Form
    {

        PjesemarresitBO pjesemarresitBO;
        PjesemarresiBLL pjesemarresiBLL;
        RoletBO roletBO;

        public ShtoAdmin()
        {
            InitializeComponent();
            pjesemarresiBLL = new PjesemarresiBLL();
        }


        public void LoadData(int adminId)
        {
            pjesemarresitBO = pjesemarresiBLL.GetItem(adminId);

            if (!String.IsNullOrEmpty(pjesemarresitBO.PmId.ToString()))
            {
                txtAdminId.Text = adminId.ToString();
                txtEmri.Text = pjesemarresitBO.Emri;
                txtMbiemri.Text = pjesemarresitBO.Mbiemri;
                txtEmail.Text = pjesemarresitBO.Email;
                txtNrTel.Text = pjesemarresitBO.NrTelefonit;
                txtNofka.Text = pjesemarresitBO.Username;
                txtFjalekalimi.Text = pjesemarresitBO.Password;
                cmbPershkrimiId.Text = pjesemarresitBO.RoletBO.RoliId.ToString();
            }
        }
        private void btnShto_Click(object sender, EventArgs e)
        {
            roletBO = new RoletBO(cmbPershkrimiId.SelectedIndex + 1, cmbPershkrimiId.Text);
            pjesemarresitBO = new PjesemarresitBO(roletBO, txtEmri.Text, txtMbiemri.Text, txtNrTel.Text, txtEmail.Text, txtNofka.Text, txtFjalekalimi.Text, "user", DateTime.Now);
            bool inserted = pjesemarresiBLL.CreateAdmin(pjesemarresitBO);
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

            bool updated = pjesemarresiBLL.UpdateAdmin(UpdateAdmin());

            if (updated)
            {
                MessageBox.Show("U ndryshua");
            }
            else
            {
                MessageBox.Show("Ndryshimi deshtoi");

            }
        }

        public PjesemarresitBO UpdateAdmin()
        {
            
            int id = int.Parse(txtAdminId.Text);

            roletBO = new RoletBO(cmbPershkrimiId.SelectedIndex + 1, cmbPershkrimiId.Text);
            pjesemarresitBO = new PjesemarresitBO(id, roletBO, txtEmri.Text, txtMbiemri.Text, txtNrTel.Text, txtEmail.Text, txtNofka.Text, txtFjalekalimi.Text, "user", DateTime.Now, 1);

            return pjesemarresitBO;
        }

        private void ShtoAdmin_Load(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            dt = RoliBLL.SelectRoles();
            cmbPershkrimiId.DataSource = dt;
            cmbPershkrimiId.DisplayMember = dt.Columns[1].ColumnName;
            cmbPershkrimiId.ValueMember = dt.Columns[0].ColumnName;
        }

        private void btnShtoRol_Click(object sender, EventArgs e)
        {
            ShtoRol shtoRol = new ShtoRol();
            shtoRol.Show();
        }
    }
}
