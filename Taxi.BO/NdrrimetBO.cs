using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.BO
{
    public class NdrrimetBO : Base
    {
        public int NderrimiId { get; set; }
        public ShoferiBO Shoferi { get; set; }
        public AutomjetiBO Automjeti { get; set; }
        public DateTime FillimiINderrimit { get; set; }
        public DateTime MbarimiINDerrimit { get; set; }
        public DateTime KohaEHyrjes { get; set; }
        public DateTime KohaEDaljes { get; set; }

        public NdrrimetBO()
        {

        }

        public NdrrimetBO(int nderrimiId, ShoferiBO shoferi, AutomjetiBO automjeti, DateTime fillimiINderrimit, DateTime mbarimiINDerrimit, DateTime kohaEHyrjes, DateTime kohaEDaljes)
        {
            NderrimiId = nderrimiId;
            Shoferi = shoferi;
            Automjeti = automjeti;
            FillimiINderrimit = fillimiINderrimit;
            MbarimiINDerrimit = mbarimiINDerrimit;
            KohaEHyrjes = kohaEHyrjes;
            KohaEDaljes = kohaEDaljes;
        }

    }
}
