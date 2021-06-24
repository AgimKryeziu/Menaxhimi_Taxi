using System;

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

        public AdresaBO(int adresaId, string shteti)
        {
            AdresaId = adresaId;
            Shteti = shteti;
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
