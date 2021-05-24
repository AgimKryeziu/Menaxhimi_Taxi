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
        public RoletBO Rolet { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string NrTelefonit { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public PjesemarresitBO()
        {

        }


        public PjesemarresitBO(int pmId, RoletBO rolet, string emri, string mbiemri, string nrTelefonit, string email, string username, string password)
        {
            PmId = pmId;
            Rolet = rolet;
            Emri = emri;
            Mbiemri = mbiemri;
            NrTelefonit = nrTelefonit;
            Email = email;
            Username = username;
            Password = password;
        }
    }
}
