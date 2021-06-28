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
namespace Taxi.Destinacione
{
    public partial class Statistika : Form
    {
        DestinacionetBLL destinacionetBLL;
        ShoferiBLL shoferiBLL;
        public Statistika()
        {
            InitializeComponent();
            destinacionetBLL = new DestinacionetBLL();
            shoferiBLL = new ShoferiBLL();
        }

        private void Statistika_Load(object sender, EventArgs e)
        {
            Qyteti.Series["Qyteti"].XValueMember = "Qyteti";
            Qyteti.Series["Qyteti"].YValueMembers = "Total";
            Qyteti.DataSource = destinacionetBLL.DestinacioniReport();
            Qyteti.DataBind();

            Emri.Series["Emri"].XValueMember = "Emri";
            Emri.Series["Emri"].YValueMembers = "Total";
            Emri.DataSource = shoferiBLL.TopShoferi();
            Emri.DataBind();
        }
    }
}
