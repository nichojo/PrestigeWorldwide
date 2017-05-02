using System.Data.Entity;

namespace PrestigeWorldwide.Models
{ 
    public class AeroDbContext : DbContext
    {
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Itinerary> Itineraries { get; set; }
        public DbSet<ItineraryRoute> ItineraryRoutes { get; set; }
    }
}