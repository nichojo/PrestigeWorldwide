using Microsoft.AspNet.Identity;
using PrestigeWorldwide.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using PrestigeWorldwide.ViewModels;
using System.Collections.Generic;

namespace PrestigeWorldwide.Controllers
{
    public class ItineraryController : Controller
    {
        private AeroDbContext db = new AeroDbContext();

        // GET: Itineraries
        public ActionResult Index()
        {
            string user = User.Identity.GetUserName();
            return View(db.Itineraries.Where(i => i.User.Equals(user)).ToList());
        }

        // GET: Itineraries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var viewModel = new ItineraryIndexData();
            viewModel.Itinerary = db.Itineraries.Where(i => i.Id == id).First();
            viewModel.ItineraryRoutes = db.ItineraryRoutes.Where(i => i.ItineraryId == id);

            ViewBag.ItineraryName = viewModel.Itinerary.Name;

            return View(viewModel);
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
        public ActionResult Create([Bind(Include = "FromLocation,ToLocation,Description,Name")] Itinerary itinerary)
        {
            itinerary.User = User.Identity.GetUserName();
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
