using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.BO
{
    public class ModeletBO : Base
    {
        public int ModeliId { get; set; }
        public string Emri { get; set; }
        public string Pershkrimi { get; set; }

        public ModeletBO()
        {

        }
        public ModeletBO(int modeliID, string emri)
        {
            ModeliId = modeliID;
            Emri = emri;
        }

        public ModeletBO(string emri, string pershkrimi, string insertBy, DateTime insertDate)
        {
            Emri = emri;
            Pershkrimi = pershkrimi;
            InsertBy = insertBy;
            InsertDate = insertDate;
        }
    }
}
