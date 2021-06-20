using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.BO
{
    public class SherbimetBO : Base
    {
        public int SherbimiId { get; set; }
        public NderrimetBO Ndrrimet { get; set; } // Kompzcion
        public PjesemarresitBO Pjesemarresit { get; set; } // Kompzcion
        public string KohaNisjes { get; set; }
        public string Vendtakimi { get; set; }
        public DestinacioniBO Destinacioni { get; set; } // Kompzcion
        public DateTime KohaEMberritjes { get; set; }
        public bool Anulohet { get; set; }
       
        public const double tarifaFikse = 1.5;

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

        public SherbimetBO(int sherbimiId, NderrimetBO ndrrimet, PjesemarresitBO pjesemarresit, string kohaNisjes, string vendtakimi, DestinacioniBO destinacioni, DateTime kohaEMberritjes, bool anulohet, double distanca)
        {
            SherbimiId = sherbimiId;
            Ndrrimet = ndrrimet;
            Pjesemarresit = pjesemarresit;
            KohaNisjes = kohaNisjes;
            Vendtakimi = vendtakimi;
            Destinacioni = destinacioni;
            KohaEMberritjes = kohaEMberritjes;
            Anulohet = anulohet;
            Distanca = distanca;
        }

        public double FaturaEENjeUdhetimi()
        {
            return tarifaFikse * Distanca;
        }
    }
}
