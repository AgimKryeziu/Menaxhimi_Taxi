﻿using System;
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
    public partial class Sherbimi : Form
    {
        public Sherbimi()
        {
            InitializeComponent();
        }

        private void bntShto_Click(object sender, EventArgs e)
        {
            Sherbime.ShtoSherbim shtoSherbim = new ShtoSherbim();
            shtoSherbim.ShowDialog();
        }
    }
}
