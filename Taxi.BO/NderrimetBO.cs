using System;

namespace Taxi.BO
{
    public class NderrimetBO : Base
    {
        public int NderrimiId { get; set; }
        public ShoferiBO Shoferi { get; set; } // Kompozicon
        public AutomjetiBO Automjeti { get; set; } // Kompozicon
        public DateTime FillimiINderrimit { get; set; }
        public DateTime MbarimiINDerrimit { get; set; }

        public NderrimetBO()
        {

        }

        public NderrimetBO(int nderrimiId)
        {
            NderrimiId = nderrimiId;
        }

        public NderrimetBO(int nderrimiId, ShoferiBO shoferi)
        {
            NderrimiId = nderrimiId;
            Shoferi = shoferi;
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
        
        // Update
        public NderrimetBO(int nderrimiId, ShoferiBO shoferi, AutomjetiBO automjeti, DateTime fillimiINderrimit, DateTime mbarimiINDerrimit, string LUB, DateTime LUD, int LUN)
        {
            NderrimiId = nderrimiId;
            Shoferi = shoferi;
            Automjeti = automjeti;
            FillimiINderrimit = fillimiINderrimit;
            MbarimiINDerrimit = mbarimiINDerrimit;
            this.LUB = LUB;
            this.LUD = LUD;
            this.LUN = LUN + 1;
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
