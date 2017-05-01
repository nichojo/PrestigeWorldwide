using PrestigeWorldwide.Models;
using System;
using System.Data;
using System.Linq;
using System.Web.Http;


namespace PrestigeWorldwide.Controllers
{
    public class DistanceController : ApiController
    {
        private AeroDbContext db = new AeroDbContext();

        public IHttpActionResult Get()
        {
            return Ok("pass");
        }

        public IHttpActionResult Get(string fromAirport, string toAirport)
        { 
            Airport fromAirportDb = db.Airports.Where(a => a.Ident.Equals(fromAirport)).First();
            Airport toAirportDb = db.Airports.Where(a => a.Ident.Equals(toAirport)).First();
            int distance;

            if (fromAirportDb == null || toAirportDb == null)
            {
                return NotFound();
            }

            Position fromPosition = new Position(fromAirportDb.Latitude, fromAirportDb.Longitude);
            Position toPosition = new Position(toAirportDb.Latitude, toAirportDb.Longitude);

            distance = CalcDistance(fromPosition, toPosition, "Miles");

            return Ok(distance);
        }

        private double ToRadian(double val)
        {
            return (Math.PI / 180) * val;
        }

        private int CalcDistance(Position pos1, Position pos2, String DistanceType)
        {
            double R = (DistanceType.Equals("Miles")) ? 3960 : 6371;

            double dLat = ToRadian(pos2.Latitude - pos1.Latitude);
            double dLon = ToRadian(pos2.Longitude - pos1.Longitude);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                Math.Cos(this.ToRadian(pos1.Latitude)) * Math.Cos(this.ToRadian(pos2.Latitude)) *
                Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double d = R * c;

            return (int)d;
        }
    }
}