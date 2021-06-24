using System;

namespace Taxi.BO
{
    public class RoletBO : Base
    {
        public int RoliId { get; set; }
        public string Pershkrimi { get; set; }

        public RoletBO()
        {

        }

        //Add
        public RoletBO(string pershkrimi, string insertBy, DateTime insertDate)
        {
            Pershkrimi = pershkrimi;
            InsertBy = insertBy;
            InsertDate = insertDate;
        }


        public RoletBO(int roliId, string pershkrimi)
        {
            RoliId = roliId;
            Pershkrimi = pershkrimi;
        }

        public RoletBO(int roliId)
        {
            RoliId = roliId;
        }
    }
}
