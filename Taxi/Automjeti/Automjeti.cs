using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxi.Automjeti
{
    public partial class Automjeti : Form
    {
        public Automjeti()
        {
            InitializeComponent();
        }

        private void btnShtoAutomjet_Click(object sender, EventArgs e)
        {
            Taxi.Automjeti.ShtoAutomjet shtoAutomjet = new ShtoAutomjet();
            shtoAutomjet.Show();
            btnShtoAutomjet.Visible = true;
        }

        private void btnEditoAutomjet_Click(object sender, EventArgs e)
        {
            Taxi.Automjeti.ShtoAutomjet shtoAutomjet = new ShtoAutomjet();
            shtoAutomjet.Show();
            btnEditoAutomjet.Visible = true;
        }
    }
}
