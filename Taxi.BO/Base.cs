using System;

namespace Taxi.BO
{
    public class Base
    {
        public static string SaveUsername { get; set; }

        public string InsertBy { get; set; } // ruhet emri i perdoruesit qe e shton rreshtin
        public DateTime InsertDate { get; set; } // ruhet data kur eshte krijuar rekordi i ri
        public string LUB { get; set; } // Last update by - ruhet emri i perdoruesit qe e ka edituar rekordin
        public DateTime LUD { get; set; } // Last update date - ruhet data e fundit kur eshte bo update rekordi
        public int LUN { get; set; } // Last update number - ruhet numri i editimeve te rekordit
    }
}
