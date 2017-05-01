using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace PrestigeWorldwide.Models
{
    public class Airport
    {
        public int AirportId { get; set; }
        public string Ident { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Continent { get; set; }
        public string ISOCountry { get; set; }
        public string ISORegion { get; set; }
        public string GPSCode { get; set; }
        public string Municipality { get; set; }
        public string Serviced { get; set; }
        public string IATACode { get; set; }
        public string LocalCode { get; set; }

        [InverseProperty("From_Airport")]
        public ICollection<Itinerary> From_Itineraries { get; set; }

        [InverseProperty("To_Airport")]
        public ICollection<Itinerary> To_Itineraries { get; set; }
    }
}