using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.Data
{
    public class Hotel
    {
        public int Id { get; set; }     //Primary Key

        public string Name { get; set; }
        public string Adress { get; set; }
        public double Rating { get; set; }

        [ForeignKey (nameof(CountryId))]    // [ForeignKey("CountryId")] DO NOT WARN YOU! so||USE the NAMEOF||
        public int CountryId { get; set; }  //Foreign Key
        public Country Country { get; set; }

    }
}
