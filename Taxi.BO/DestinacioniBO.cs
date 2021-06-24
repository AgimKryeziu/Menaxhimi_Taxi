namespace Taxi.BO
{
    public class DestinacioniBO
    {

        public int DestinacioniId { get; set; }
        public AdresaBO Adresa { get; set; } // Kompozicon


        public DestinacioniBO()
        {
        }

        public DestinacioniBO(int destinacioniId, AdresaBO adresa) : this(destinacioniId)
        {
            Adresa = adresa;
        }
        public DestinacioniBO(int destinacioniId)
        {
            DestinacioniId = destinacioniId;
        }

        //Add
        public DestinacioniBO(AdresaBO adresa)
        {
            Adresa = adresa;
        }
    }
}
