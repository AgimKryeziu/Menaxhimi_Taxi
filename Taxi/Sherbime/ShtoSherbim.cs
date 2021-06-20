using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxi.Sherbime
{
    public partial class ShtoSherbim : Form
    {
        public ShtoSherbim()
        {
            InitializeComponent();
        }

        private void btnShtoDestimacion_Click(object sender, EventArgs e)
        {
            Destinacione.Destinacioni destinacioni = new Destinacione.Destinacioni();
            destinacioni.Show();
        }
    }
}
