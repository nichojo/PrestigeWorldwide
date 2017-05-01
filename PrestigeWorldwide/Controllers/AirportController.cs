using PrestigeWorldwide.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;


namespace PrestigeWorldwide.Controllers
{
    public class AirportController : Controller
    {
        private AeroDbContext db = new AeroDbContext();

        // GET: Airport
        public ActionResult Index()
        {
            return View(db.Airports.ToList());
        }

        // GET: Prefixed Ident or Name
        public JsonResult Search(String Prefix)
        {
            var AirportName = db.Airports
                        .Where(i => i.Name.Contains(Prefix) || i.Ident.Contains(Prefix))
                        .Where(i => i.Serviced.Equals("Yes"))
                        .Select(i => new { i.Ident, i.Name })
                        .ToList();

            return Json(AirportName, JsonRequestBehavior.AllowGet);
        }

        // GET: Airport/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Airport airport = db.Airports.Find(id);
            if (airport == null)
            {
                return HttpNotFound();
            }
            return View(airport);
        }

        // GET: Airport/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Airport/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AirportId,Ident,Type,Name,Latitude,Longitude,Continent,ISOCountry,ISORegion,GPSCode,Municipality,Serviced,IATACode,LocalCode")] Airport airport)
        {
            if (ModelState.IsValid)
            {
                db.Airports.Add(airport);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(airport);
        }

        // GET: Airport/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Airport airport = db.Airports.Find(id);
            if (airport == null)
            {
                return HttpNotFound();
            }
            return View(airport);
        }

        // POST: Airport/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AirportId,Ident,Type,Name,Latitude,Longitude,Continent,ISOCountry,ISORegion,GPSCode,Municipality,Serviced,IATACode,LocalCode")] Airport airport)
        {
            if (ModelState.IsValid)
            {
                db.Entry(airport).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(airport);
        }

        // GET: Airport/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Airport airport = db.Airports.Find(id);
            if (airport == null)
            {
                return HttpNotFound();
            }
            return View(airport);
        }

        // POST: Airport/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Airport airport = db.Airports.Find(id);
            db.Airports.Remove(airport);
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
