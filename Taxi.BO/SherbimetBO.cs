using System;

namespace Taxi.BO
{
    public class SherbimetBO : Base
    {
        public int SherbimiId { get; set; }
        public NderrimetBO Ndrrimet { get; set; } // Kompozicon
        // public PjesemarresitBO Pjesemarresit { get; set; } // Kompozicon
        public DateTime KohaNisjes { get; set; }
        public string Vendtakimi { get; set; }
        public DestinacioniBO Destinacioni { get; set; } // Kompozicon
        public DateTime KohaEMberritjes { get; set; }
        public bool Anulohet { get; set; }

        private double _distanca;
        public double Distanca
        {
            get { return _distanca; }
            set
            {
                if (value > 0)
                {
                    _distanca = value;
                }
            }
        }

        public SherbimetBO()
        {

        }

        public SherbimetBO(int sherbimiId, NderrimetBO ndrrimet, DateTime kohaNisjes, string vendtakimi, DestinacioniBO destinacioni, DateTime kohaEMberritjes, double distanca, bool anulohet)
        {
            SherbimiId = sherbimiId;
            Ndrrimet = ndrrimet;
            KohaNisjes = kohaNisjes;
            Vendtakimi = vendtakimi;
            Destinacioni = destinacioni;
            KohaEMberritjes = kohaEMberritjes;
            Distanca = distanca;
            Anulohet = anulohet;
        }

        //Add
        public SherbimetBO(NderrimetBO ndrrimet, DateTime kohaNisjes, string vendtakimi, DestinacioniBO destinacioni, DateTime kohaEMberritjes, double distanca, bool anulohet, string insertBy, DateTime insertDate)
        {
            Ndrrimet = ndrrimet;
            KohaNisjes = kohaNisjes;
            Vendtakimi = vendtakimi;
            Destinacioni = destinacioni;
            KohaEMberritjes = kohaEMberritjes;
            Anulohet = anulohet;
            Distanca = distanca;
            this.InsertBy = insertBy;
            this.InsertDate = insertDate;
        }

        public SherbimetBO(int sherbimiId, NderrimetBO ndrrimet, DateTime kohaNisjes, string vendtakimi, DestinacioniBO destinacioni, DateTime kohaEMberritjes, double distanca, bool anulohet, string LUB, DateTime LUD, int LUN)
        {
            SherbimiId = sherbimiId;
            Ndrrimet = ndrrimet;
            KohaNisjes = kohaNisjes;
            Vendtakimi = vendtakimi;
            Destinacioni = destinacioni;
            KohaEMberritjes = kohaEMberritjes;
            Anulohet = anulohet;
            Distanca = distanca;
            this.LUB = LUB;
            this.LUD = LUD;
            this.LUN = LUN + 1;
        }
    }
}
