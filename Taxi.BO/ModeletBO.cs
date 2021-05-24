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

        public ModeletBO(int modeliId, string emri, string pershkrimi)
        {
            ModeliId = modeliId;
            Emri = emri;
            Pershkrimi = pershkrimi;
        }
    }
}
