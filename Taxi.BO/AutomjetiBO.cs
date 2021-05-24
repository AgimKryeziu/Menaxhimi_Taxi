using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.BO
{
    public class AutomjetiBO : Base 
    {
        public int AutomjetiId { get; set; }
        public ModeletBO Modelet { get; set; }
        public string Targa { get; set; }
        public int VitiIProdhimit { get; set; }
        public bool Aktiv { get; set; }

        private double _km;
        public double Km
        {
            get { return _km; }
            set
            {
                if (value > 0)
                {
                    _km = value;
                }
            }
        }

        public AutomjetiBO()
        {
        }

        public AutomjetiBO(int automjetiId, ModeletBO modelet, string targa, int vitiIProdhimit, bool aktiv, double km)
        {
            AutomjetiId = automjetiId;
            Modelet = modelet;
            Targa = targa;
            VitiIProdhimit = vitiIProdhimit;
            Aktiv = aktiv;
            Km = km;
        }
    }
}
