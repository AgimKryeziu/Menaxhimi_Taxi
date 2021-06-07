using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxi
{
    public partial class MainMenu : Form
    {
        //CultureInfo current = Thread.CurrentThread.CurrentUICulture;
        //Assembly a = Assembly.Load("Taxi");

        public MainMenu()
        {
            InitializeComponent();

            //ResourceManager rm = new ResourceManager("Taxi.Lang.langRes", a);
        }


        Stafi.Admin s = new Stafi.Admin();
        Shoferi.ShoferiList sho = new Shoferi.ShoferiList();
        Automjeti.Automjeti a = new Automjeti.Automjeti();
        Destinacione.Destinacioni d = new Destinacione.Destinacioni();
        Sherbime.Sherbimi sh  = new Sherbime.Sherbimi();

        private void btnAdminat_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnAdminat.Top;
            s.Show();
            sho.Hide();
            a.Hide();
            d.Hide();
            sh.Hide();
        }

        private void btnShoferet_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnShoferet.Top;
            sho.Show();
            s.Hide();
            a.Hide();
            d.Hide();
            sh.Hide();
        }

        private void btnAutomjetet_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnAutomjetet.Top;
            a.Show();
            s.Hide();
            sho.Hide();
            d.Hide();
            sh.Hide();
        }

        private void btnDestinacionet_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnDestinacionet.Top;
            d.Show();
            s.Hide();
            sho.Hide();
            a.Hide();
            sh.Hide();
        }

        private void btnSherbimet_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnSherbimet.Top;
            sh.Show();
            s.Hide();
            sho.Hide();
            a.Hide();
            d.Hide();
        }

        private void btnShkyçu_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnShkyçu.Top;

            this.Hide();
            s.Close();
            sh.Close();
            a.Close();
            d.Close();
            sho.Close();
            LogInForms logInForms = new LogInForms();
            logInForms.Closed += (s, args) => this.Close();
            logInForms.Show();
        }
    }
}
