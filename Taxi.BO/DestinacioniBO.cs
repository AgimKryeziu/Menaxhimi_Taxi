using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.BO
{
    public class DestinacioniBO
    {

        public int DestinacioniId { get; set; }
        public AdresaBO Adresa { get; set; } // Kompzcion


        public DestinacioniBO()
        {
        }


        public DestinacioniBO(AdresaBO adresa)
        {
            Adresa = adresa;
        }
    }
}
