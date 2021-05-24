using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.BO
{
    public class DestinacionetBO
    {

        public int DestinacioniId { get; set; }
        public AdresaBO Adresa { get; set; }

        private int _vizituar;
        public int Vizituar
        {
            get { return _vizituar; }
            set
            {
                _vizituar = value;
            }
        }

        public DestinacionetBO()
        {
        }

        public DestinacionetBO(AdresaBO adresa)
        {
            Adresa = adresa;
            Vizituar = 0;
        }
    }
}
