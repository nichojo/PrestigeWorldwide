using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PrestigeWorldwide.Models;

namespace PrestigeWorldwide.ViewModels
{
    public class ItineraryIndexData
    {
        public Itinerary Itinerary { get; set; }
        public IEnumerable<ItineraryRoute> ItineraryRoutes { get; set; }

    }
}