using System;

namespace Taxi.BO
{
    public class ModeletBO : Base
    {
        public int ModeliId { get; set; }
        public string Emri { get; set; }
        public string Pershkrimi { get; set; }

        public ModeletBO(int modeliID)
        {
            ModeliId = modeliID;
        }
        public ModeletBO(int modeliID, string emri)
        {
            ModeliId = modeliID;
            Emri = emri;
        }

        //Add
        public ModeletBO(string emri, string pershkrimi, string insertBy, DateTime insertDate)
        {
            Emri = emri;
            Pershkrimi = pershkrimi;
            InsertBy = insertBy;
            InsertDate = insertDate;
        }
    }
}
