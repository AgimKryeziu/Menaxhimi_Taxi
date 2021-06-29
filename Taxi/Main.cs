using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Taxi.BO;

namespace Taxi
{
    public partial class Main : Form
    {
        bool albFlag = LogInForms.albFlag;

        public Main()
        {
            InitializeComponent();
        }

        List<Form> format = new List<Form>();
        Stafi.Admin ad;
        Shoferi.ShoferiList sho;
        Automjeti.Automjeti a;
        Nderrime.NderrimetList n;
        Sherbime.Sherbimi sh;
        Destinacione.Statistika q;

        private void Main_Load(object sender, EventArgs e)
        {
            btnHome_Click(sender, e);
        }

        private void btnAdminat_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnAdminat.Top;

            foreach (var item in format)
            {
                if (pnlContent.Contains(item))
                {
                    item.Close();
                }
            }

            ad = new Stafi.Admin();
            format.Add(ad);
            ad.TopLevel = false;
            ad.Parent = pnlContent;
            ad.Dock = DockStyle.Fill;
            
            if (albFlag)
            {
                var changeLang = new ChangeLang();
                changeLang.UpdateConfig("language", "sq");
                ad.Show();
            }
            else
            {
                var changeLang = new ChangeLang();
                changeLang.UpdateConfig("language", "en");
                ad.Show();
            }

        }

        private void btnShoferet_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnShoferet.Top;
            foreach (var item in format)
            {
                if (pnlContent.Contains(item))
                {
                    item.Close();
                }
            }

            sho = new Shoferi.ShoferiList();
            format.Add(sho);
            sho.TopLevel = false;
            sho.Parent = pnlContent;
            sho.Dock = DockStyle.Fill;

            if (albFlag)
            {
                var changeLang = new ChangeLang();
                changeLang.UpdateConfig("language", "sq");
                sho.Show();
            }
            else
            {
                var changeLang = new ChangeLang();
                changeLang.UpdateConfig("language", "en");
                sho.Show();

            }
        }

        private void btnAutomjetet_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnAutomjetet.Top;
            foreach (var item in format)
            {
                if (pnlContent.Contains(item))
                {
                    item.Close();
                }
            }

            a = new Automjeti.Automjeti();
            format.Add(a);
            a.TopLevel = false;
            a.Parent = pnlContent;
            a.Dock = DockStyle.Fill;
            if (albFlag)
            {
                var changeLang = new ChangeLang();
                changeLang.UpdateConfig("language", "sq");
                a.Show();
            }
            else
            {
                var changeLang = new ChangeLang();
                changeLang.UpdateConfig("language", "en");
                a.Show();
            }
            
        }

        private void btnNderrimet_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnNderrimet.Top;
            foreach (var item in format)
            {
                if (pnlContent.Contains(item))
                {
                    item.Close();

                }
            }

            n = new Nderrime.NderrimetList();
            format.Add(n);
            n.TopLevel = false;
            n.Parent = pnlContent;
            n.Dock = DockStyle.Fill;

            if (albFlag)
            {
                var changeLang = new ChangeLang();
                changeLang.UpdateConfig("language", "sq");
                n.Show();
            }
            else
            {
                var changeLang = new ChangeLang();
                changeLang.UpdateConfig("language", "en");
                n.Show();
            }
        }

        private void btnSherbimet_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnSherbimet.Top;
            foreach (var item in format)
            {
                if (pnlContent.Contains(item))
                {
                    item.Close();

                }
            }

            sh = new Sherbime.Sherbimi();
            format.Add(sh);
            sh.TopLevel = false;
            sh.Parent = pnlContent;
            sh.Dock = DockStyle.Fill;

            if (albFlag)
            {

                var changeLang = new ChangeLang();
                changeLang.UpdateConfig("language", "sq");
                sh.Show();
            }
            else
            {
                var changeLang = new ChangeLang();
                changeLang.UpdateConfig("language", "en");
                sh.Show();
            }
        }

        private void btnShkyçu_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnShkyçu.Top;

            this.Close();

            LogInForms logInForms = new LogInForms();
            logInForms.Visible = true;
        }

        private void btnCloseMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            LogInForms logInForms = new LogInForms();
            logInForms.Visible = true;
        }

        private void btnQyteti_Click(object sender, EventArgs e)
        {
            Destinacione.Statistika qytetet = new Destinacione.Statistika();
            qytetet.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnHome.Top;
            foreach (var item in format)
            {
                if (pnlContent.Contains(item))
                {
                    item.Close();
                }
            }

            q = new Destinacione.Statistika();
            format.Add(q);
            q.TopLevel = false;
            q.Parent = pnlContent;
            q.Dock = DockStyle.Fill;

            if (albFlag)
            {
                var changeLang = new ChangeLang();
                changeLang.UpdateConfig("language", "sq");
                q.Show();
            }
            else
            {
                var changeLang = new ChangeLang();
                changeLang.UpdateConfig("language", "sq");
                q.Show();
            }
            
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"E:\Agim_Kryeziu\Semestri 4\TI1\Projekti_TI1\Faza 4\Manual\Main Menu.htm");
        }

        private void btnHelp_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("1234567");
        }

        private void btnHelpMain_Click_1(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"E:\Agim_Kryeziu\Semestri 4\TI1\Projekti_TI1\Faza 4\Manual\Main Menu.htm");

        }
    }
}
