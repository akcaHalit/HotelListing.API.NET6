namespace HotelListing.API.Data
{
    public class Country
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string shortName { get; set; }

        //one to many || a country may have many hotels.

        public virtual IList<Hotel> Hotels { get; set;}
        
    }
}