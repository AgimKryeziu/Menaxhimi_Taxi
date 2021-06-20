using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.BO
{
    public class NderrimetBO : Base
    {
        public int NderrimiId { get; set; }
        public ShoferiBO Shoferi { get; set; } // Kompzcion
        public AutomjetiBO Automjeti { get; set; } // Kompzcion
        public DateTime FillimiINderrimit { get; set; }
        public DateTime MbarimiINDerrimit { get; set; }

        public NderrimetBO()
        {

        }

        //Add
        public NderrimetBO(ShoferiBO shoferi, AutomjetiBO automjeti, DateTime fillimiINderrimit, DateTime mbarimiINDerrimit, string insertBy, DateTime insertDate)
        {
            Shoferi = shoferi;
            Automjeti = automjeti;
            FillimiINderrimit = fillimiINderrimit;
            MbarimiINDerrimit = mbarimiINDerrimit;
            InsertBy = insertBy;
            InsertDate = insertDate;
        }

        public NderrimetBO(int nderrimiId, ShoferiBO shoferi, AutomjetiBO automjeti, DateTime fillimiINderrimit, DateTime mbarimiINDerrimit)
        {
            NderrimiId = nderrimiId;
            Shoferi = shoferi;
            Automjeti = automjeti;
            FillimiINderrimit = fillimiINderrimit;
            MbarimiINDerrimit = mbarimiINDerrimit;
        }
    }
}
