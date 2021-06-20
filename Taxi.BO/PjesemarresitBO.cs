using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.BO
{
    public class PjesemarresitBO : Base
    {
        public int PmId { get; set; }
        // Kompzcion
        public RoletBO RoletBO { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string NrTelefonit { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public PjesemarresitBO()
        {

        }

        //Add 
        public PjesemarresitBO(RoletBO roletBO, string emri, string mbiemri, string nrTelefonit, string email, string username, string password, string insertBy, DateTime insertDate)
        {
            RoletBO = roletBO;
            Emri = emri;
            Mbiemri = mbiemri;
            NrTelefonit = nrTelefonit;
            Email = email;
            Username = username;
            Password = password;
            InsertBy = insertBy;
            InsertDate = insertDate;
        }

        public PjesemarresitBO(int pmId, RoletBO roletBO, string emri, string mbiemri, string nrTelefonit, string email, string username, string password)
        {
            PmId = pmId;
            RoletBO = roletBO;
            Emri = emri;
            Mbiemri = mbiemri;
            NrTelefonit = nrTelefonit;
            Email = email;
            Username = username;
            Password = password;
        }

        //Update
        public PjesemarresitBO(int pmId, RoletBO roletBO, string emri, string mbiemri, string nrTelefonit, string email, string username, string password, string LUB, DateTime LUD, int LUN)
        {
            PmId = pmId;
            RoletBO = roletBO;
            Emri = emri;
            Mbiemri = mbiemri;
            NrTelefonit = nrTelefonit;
            Email = email;
            Username = username;
            Password = password;
            this.LUB = LUB;
            this.LUD = LUD;
            this.LUN = LUN + 1;
        }
    }
}
