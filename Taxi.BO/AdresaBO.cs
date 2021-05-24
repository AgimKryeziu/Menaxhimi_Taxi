using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.BO
{
    public class AdresaBO : Base
    {
        public int AdresaId { get; set; }
        public string Shteti { get; set; }
        public string Qyteti { get; set; }
        public string Lagjja { get; set; }
        public string Rruga { get; set; }

        public AdresaBO()
        {

        }

        public AdresaBO(string shteti, string qyteti, string lagjja, string rruga)
        {
            Shteti = shteti;
            Qyteti = qyteti;
            Lagjja = lagjja;
            Rruga = rruga;
        }
    }
}
