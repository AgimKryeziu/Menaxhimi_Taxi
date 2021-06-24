using System;

namespace Taxi.BO
{
    // Trashegimi
    public class AutomjetiBO : Base
    {
        public int AutomjetiId { get; set; }
        public ModeletBO Modelet { get; set; } //Kompozicon
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

        public AutomjetiBO(int automjetiId)
        {
            AutomjetiId = automjetiId;
        }

        public AutomjetiBO(int automjetiId, ModeletBO modeletBO)
        {
            AutomjetiId = automjetiId;
            Modelet = modeletBO;
        }

        // Add
        public AutomjetiBO(ModeletBO modelet, string targa, int vitiIProdhimit, bool aktiv, double km, string insertBy, DateTime insertDate)
        {
            Modelet = modelet;
            Targa = targa;
            VitiIProdhimit = vitiIProdhimit;
            Aktiv = aktiv;
            Km = km;
            InsertBy = insertBy;
            InsertDate = insertDate;
        }

        // Update
        public AutomjetiBO(int automjetiId, ModeletBO modelet, string targa, int vitiIProdhimit, bool aktiv, double km, string LUB, DateTime LUD, int LUN)
        {
            AutomjetiId = automjetiId;
            Modelet = modelet;
            Targa = targa;
            VitiIProdhimit = vitiIProdhimit;
            Aktiv = aktiv;
            Km = km;
            this.LUB = LUB;
            this.LUD = LUD;
            this.LUN = LUN + 1;
        }


        public AutomjetiBO(int automjetiId, ModeletBO modeletBO, string targa, int vitiIProdhimit, bool aktiv, double km)
        {
            AutomjetiId = automjetiId;
            Modelet = modeletBO;
            Targa = targa;
            VitiIProdhimit = vitiIProdhimit;
            Aktiv = aktiv;
            Km = km;
        }
    }
}
