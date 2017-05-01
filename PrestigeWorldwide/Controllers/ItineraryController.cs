using PrestigeWorldwide.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PrestigeWorldwide.Controllers
{
    public class ItineraryController : Controller
    {
        private AeroDbContext db = new AeroDbContext();

        // GET: Itineraries/user
        public ActionResult Index(string user)
        {
            if (String.IsNullOrEmpty(user))
                return View(db.Itineraries.ToList());
            else
            {
                return View(
                    db.Itineraries
                        .Where(i => i.User.Equals(user))
                        .ToList(
                        ));
            }
        }

        // GET: Itineraries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Itinerary itinerary = db.Itineraries.Find(id);
            if (itinerary == null)
            {
                return HttpNotFound();
            }
                       
            return View(itinerary);
        }

        // GET: Itineraries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Itineraries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "User,From_Airport,To_Airport,Description,Name")] Itinerary itinerary)
        {
            DistanceController distanceLogic = new DistanceController();

            Airport fromAirport = db.Airports
                        .Where(i => i.Ident.Equals(itinerary.From_Airport))
                        .First();

            Airport toAirport = db.Airports
                        .Where(i => i.Ident.Equals(itinerary.To_Airport))
                        .First();

            Position fromPosition = new Position(fromAirport.Latitude, fromAirport.Longitude);
            Position toPosition = new Position(toAirport.Latitude, toAirport.Longitude);

            itinerary.Distance = distanceLogic.CalcDistance(fromPosition, toPosition, "Miles");

            if (ModelState.IsValid)
            {
                db.Itineraries.Add(itinerary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(itinerary);
        }

        // GET: Itineraries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Itinerary itinerary = db.Itineraries.Find(id);
            if (itinerary == null)
            {
                return HttpNotFound();
            }
            return View(itinerary);
        }

        // POST: Itineraries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,User,From_Airport,To_Airport,Description,Name")] Itinerary itinerary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itinerary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(itinerary);
        }

        // GET: Itineraries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Itinerary itinerary = db.Itineraries.Find(id);
            if (itinerary == null)
            {
                return HttpNotFound();
            }
            return View(itinerary);
        }

        // POST: Itineraries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Itinerary itinerary = db.Itineraries.Find(id);
            db.Itineraries.Remove(itinerary);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
