using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrestigeWorldwide.Models
{
    public class Itinerary
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(50)]
        public string User { get; set; }

        /*
        public Airport From_Airport { get; set; }
        public Airport To_Airport { get; set; }
        */
        [Required]
        [StringLength(50)]
        public string FromLocation { get; set; }

        [Required]
        [StringLength(50)]
        public string ToLocation { get; set; }

        // Navigation property 
        public virtual ICollection<ItineraryRoute> ItineraryRoute { get; set; }
    }
}