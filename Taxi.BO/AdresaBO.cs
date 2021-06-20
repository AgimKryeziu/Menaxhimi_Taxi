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

        //Add
        public AdresaBO(string shteti, string qyteti, string lagjja, string rruga, string insertBy, DateTime insertDate)
        {
            Shteti = shteti;
            Qyteti = qyteti;
            Lagjja = lagjja;
            Rruga = rruga;
            InsertBy = insertBy;
            InsertDate = insertDate;
        }
    }
}
