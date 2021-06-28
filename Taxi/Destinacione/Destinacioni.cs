﻿using System;
using System.Windows.Forms;
using Taxi.BLL;
using Taxi.BO;

namespace Taxi.Destinacione
{
    public partial class Destinacioni : Form
    {
        DestinacionetBLL destinacionetBLL;
        public Destinacioni()
        {
            InitializeComponent();
            destinacionetBLL = new DestinacionetBLL();
        }
        private void btnRuaj_Click(object sender, EventArgs e)
        {
            AdresaBO adresaBO = new AdresaBO(txtShteti.Text, txtQyteti.Text, txtLagjja.Text, txtRruga.Text, Base.SaveUsername, DateTime.Now);
            DestinacioniBO destinacioniBO = new DestinacioniBO(adresaBO);

            bool inserted = destinacionetBLL.CreateDestinacion(destinacioniBO);
            if (inserted)
            {
                MessageBox.Show("Te dhenat u shtuan me sukses.");
            }
            else
            {
                MessageBox.Show("Regjistrimi deshtoi.");
            }
        }
    }
}
