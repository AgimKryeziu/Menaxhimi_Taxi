using System;
using System.Windows.Forms;

namespace Taxi
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        Stafi.Admin ad = new Stafi.Admin();
        Shoferi.ShoferiList sho = new Shoferi.ShoferiList();
        Automjeti.Automjeti a = new Automjeti.Automjeti();
        Nderrime.NderrimetList n = new Nderrime.NderrimetList();
        Sherbime.Sherbimi sh = new Sherbime.Sherbimi();

        private void btnAdminat_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnAdminat.Top;

            ad.TopLevel = false;
            ad.Parent = pnlContent;
            ad.Dock = DockStyle.Fill;
            ad.Show();

            //  s.ShowDialog();
            //sho.Hide();
            //a.Hide();
            //n.Hide();
            //sh.Hide();
        }

        private void btnShoferet_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnShoferet.Top;
            sho.ShowDialog();
            //s.Hide();
            //a.Hide();
            //n.Hide();
            //sh.Hide();
        }

        private void btnAutomjetet_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnAutomjetet.Top;
            a.ShowDialog();
            //s.Hide();
            //sho.Hide();
            //n.Hide();
            //sh.Hide();
        }

        private void btnNderrimet_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnNderrimet.Top;
            n.ShowDialog();
            //sho.Hide();
            //a.Hide();
            //a.Hide();
            //sh.Hide();
        }

        private void btnSherbimet_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnSherbimet.Top;
            sh.ShowDialog();
            //s.Hide();
            //sho.Hide();
            //n.Hide();
            //a.Hide();
        }

        private void btnShkyçu_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnShkyçu.Top;

            this.Hide();
            ad.Close();
            sh.Close();
            a.Close();
            n.Hide();
            sho.Close();
            LogInForms logInForms = new LogInForms();
            logInForms.Visible = true;
        }

        private void btnCloseMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            LogInForms logInForms = new LogInForms();
            logInForms.Visible = true;
        }


    }
}
