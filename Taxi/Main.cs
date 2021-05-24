using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A = Taxi.Automjeti;
using Sh = Taxi.Sherbime;
using De = Taxi.Destinacione;
using Sho = Taxi.Shoferi;

namespace Taxi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        Sho.ShoferiList shoferi;
        Sh.Sherbimi sherbimi;
        De.Destinacioni destinacioni;
        A.Automjeti automjeti;

        private void btnMenaxhoShofer_Click(object sender, EventArgs e)
        {
            if (pnlContent.Contains(sherbimi))
            {
                sherbimi.Close();
            }

            shoferi = new Sho.ShoferiList();
            shoferi.TopLevel = false;
            shoferi.Parent = pnlContent;
            shoferi.Dock = DockStyle.Fill;
            shoferi.Show();
        }

        private void btnMenaxhoAutomjetin_Click(object sender, EventArgs e)
        {
            automjeti.Show();
        }

        private void btnMenaxhoRezervim_Click(object sender, EventArgs e)
        {
            sherbimi.Show();
        }

        private void btnDestinacionet_Click(object sender, EventArgs e)
        {
            destinacioni.Show();
        }

    }
}
