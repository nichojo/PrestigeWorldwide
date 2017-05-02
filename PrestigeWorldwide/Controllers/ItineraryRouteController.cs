using Microsoft.AspNet.Identity;
using PrestigeWorldwide.Models;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace PrestigeWorldwide.Controllers
{
    public class ItineraryRouteController : Controller
    {
        private AeroDbContext db = new AeroDbContext();

        // GET: ItineraryRoutes
        public ActionResult Index()
        {
            string user = User.Identity.GetUserName(); 
            var itineraryRoutes = db.ItineraryRoutes.Include(i => i.Itinerary).Where(i => i.Itinerary.User.Equals(user));
            return View(itineraryRoutes.ToList());
        }

        // GET: ItineraryRoutes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItineraryRoute itineraryRoute = db.ItineraryRoutes.Find(id);
            if (itineraryRoute == null)
            {
                return HttpNotFound();
            }
            return View(itineraryRoute);
        }

        // GET: ItineraryRoutes/Create
        public ActionResult Create(int id)
        {
            ItineraryRoute itineraryRoute = new ItineraryRoute();
            itineraryRoute.ItineraryId = id;
            return View(itineraryRoute);
        }

        // POST: ItineraryRoutes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "From_Airport,To_Airport,ItineraryId")] ItineraryRoute itineraryRoute)
        {
            DistanceController distanceLogic = new DistanceController();

            Airport fromAirport = db.Airports
                        .Where(i => i.Ident.Equals(itineraryRoute.From_Airport))
                        .First();

            Airport toAirport = db.Airports
                        .Where(i => i.Ident.Equals(itineraryRoute.To_Airport))
                        .First();

            Position fromPosition = new Position(fromAirport.Latitude, fromAirport.Longitude);
            Position toPosition = new Position(toAirport.Latitude, toAirport.Longitude);

            itineraryRoute.Distance = distanceLogic.CalcDistance(fromPosition, toPosition, "Miles");
            itineraryRoute.Itinerary = db.Itineraries.Find(itineraryRoute.ItineraryId);

            if (ModelState.IsValid)
            {
                db.ItineraryRoutes.Add(itineraryRoute);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(itineraryRoute);
        }

        // GET: ItineraryRoutes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItineraryRoute itineraryRoute = db.ItineraryRoutes.Find(id);
            if (itineraryRoute == null)
            {
                return HttpNotFound();
            }
            ViewBag.ItineraryId = new SelectList(db.Itineraries, "Id", "Name", itineraryRoute.ItineraryId);
            return View(itineraryRoute);
        }

        // POST: ItineraryRoutes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,From_Airport,To_Airport,ItineraryId")] ItineraryRoute itineraryRoute)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itineraryRoute).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ItineraryId = new SelectList(db.Itineraries, "Id", "Name", itineraryRoute.ItineraryId);
            return View(itineraryRoute);
        }

        // GET: ItineraryRoutes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItineraryRoute itineraryRoute = db.ItineraryRoutes.Find(id);
            if (itineraryRoute == null)
            {
                return HttpNotFound();
            }
            return View(itineraryRoute);
        }

        // POST: ItineraryRoutes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ItineraryRoute itineraryRoute = db.ItineraryRoutes.Find(id);
            db.ItineraryRoutes.Remove(itineraryRoute);
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
