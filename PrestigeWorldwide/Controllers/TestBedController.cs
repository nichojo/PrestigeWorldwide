using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using PrestigeWorldwide.Models;
using System.Data;
using System.Data.Entity;

namespace PrestigeWorldwide.Controllers
{
    public class TestBedController : Controller
    {
        private AeroDbContext db = new AeroDbContext();

        public ActionResult Index(FormCollection collection)
        {
            try
            {
                if (collection.Count == 0)
                    return View();
                else
                {
                    DistanceController distanceLogic = new DistanceController();
                    string fromAirportStr = collection["fromAirport"];
                    string toAirportStr = collection["toAirport"];


                    Airport fromAirport = db.Airports
                                .Where(i => i.Ident.Equals(fromAirportStr))
                                .First();

                    Airport toAirport = db.Airports
                                .Where(i => i.Ident.Equals(toAirportStr))
                                .First();

                    Position fromPosition = new Position(fromAirport.Latitude, fromAirport.Longitude);
                    Position toPosition = new Position(toAirport.Latitude, toAirport.Longitude);

                    ViewBag.Distance = distanceLogic.CalcDistance(fromPosition, toPosition, "Miles"); ;
                    ViewBag.TimeDif = (Convert.ToDateTime(collection["TravelDate"]) - DateTime.Today).Days;


                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        //// GET: TestBed/Details/5
        //public ActionResult Details(string fromAiport, string toAirport)
        //{

        //    return View();
        //}

        //// GET: TestBed/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: TestBed/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
