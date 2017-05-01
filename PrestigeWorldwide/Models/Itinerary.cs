using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PrestigeWorldwide.Models
{
    public class Itinerary
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string User { get; set; }

        /*
        public Airport From_Airport { get; set; }
        public Airport To_Airport { get; set; }
        */
        [Required]
        [StringLength(50)]
        public string From_Airport { get; set; }
        [Required]
        [StringLength(50)]
        public string To_Airport { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public int Distance { get; set; }
    }
}