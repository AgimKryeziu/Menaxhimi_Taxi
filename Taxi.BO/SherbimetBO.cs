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
        public NdrrimetBO Ndrrimet { get; set; }
        public PjesemarresitBO Pjesemarresit { get; set; }
        public string KohaNisjes { get; set; }
        public string Vendtakimi { get; set; }
        public DestinacioniBO Destinacioni { get; set; }
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


        public double FaturaEENjeUdhetimi()
        {
            return tarifaFikse * Distanca;
        }
    }
}
