using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.BO
{
    public class ShoferiBO : Base
    {
        public int IdPunes { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public char Gjinia { get; set; }
        public DateTime Datelindja { get; set; }
        public string NrTelefonit { get; set; }
        
        public string NrPersonal { get; set; } //e validon masi ti bon CRUD-at
        
        public string Biografia { get; set; }
        public int VitiNisjesPunes { get; set; }


     

        public ShoferiBO(int shoferiId)
        {
            IdPunes = shoferiId;
        }

        public ShoferiBO(int idPunes, string emri)
        {
            IdPunes = idPunes;
            Emri = emri;
        }

        //Add
        public ShoferiBO(string emri, string mbiemri, char gjinia, string nrTelefonit, string nrPersonal, string biografia, int vitiNisjesPunes, string insertBy, DateTime insertDate)
        {
            Emri = emri;
            Mbiemri = mbiemri;
            Gjinia = gjinia;
            Datelindja = DateTime.Now.Date;
            NrTelefonit = nrTelefonit;
            NrPersonal = nrPersonal;
            Biografia = biografia;
            VitiNisjesPunes = vitiNisjesPunes;
            InsertBy = insertBy;
            InsertDate = insertDate;
        }

        //Update
        public ShoferiBO(int idPunes, string emri, string mbiemri,DateTime datlindja, char gjinia, string nrTelefonit, string nrPersonal, string biografia, int vitiNisjesPunes, string LUB, DateTime LUD, int LUN)
        {
            IdPunes = idPunes;
            Emri = emri;
            Mbiemri = mbiemri;
            Gjinia = gjinia;
            Datelindja = datlindja;
            NrTelefonit = nrTelefonit;
            NrPersonal = nrPersonal;
            Biografia = biografia;
            VitiNisjesPunes = vitiNisjesPunes;
            this.LUB = LUB;
            this.LUD = LUD;
            this.LUN = LUN + 1;
        }


        public ShoferiBO(int idPunes, string emri, string mbiemri, DateTime datlindja, char gjinia, string nrTelefonit, string nrPersonal, string biografia, int vitiNisjesPunes)
        {
            IdPunes = idPunes;
            Emri = emri;
            Mbiemri = mbiemri;
            Gjinia = gjinia;
            Datelindja = datlindja;
            NrTelefonit = nrTelefonit;
            NrPersonal = nrPersonal;
            Biografia = biografia;
            VitiNisjesPunes = vitiNisjesPunes;
        }
    }
}
