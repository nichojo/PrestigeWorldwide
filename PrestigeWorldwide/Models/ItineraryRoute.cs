using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrestigeWorldwide.Models
{
    public class ItineraryRoute
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string From_Airport { get; set; }

        [Required]
        [StringLength(50)]
        public string To_Airport { get; set; }

        // Foreign key 
        public int ItineraryId { get; set; }

        public int Distance { get; set; }

        // Navigation properties 
        public virtual Itinerary Itinerary { get; set; }

    }
}