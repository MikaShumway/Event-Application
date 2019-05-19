using EventApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventApplication.Controllers
{
    public class HomeController : Controller
    {
        private EventDB db = new EventDB();

        public ActionResult Index()
        {
            var events = GetLastMinuteEvents();
            return View(events);
        }

        private List<Event> GetLastMinuteEvents()
        {
            DateTime TwoDayFromNow = DateTime.Now.AddDays(2);

            return db.Events
                .Where(@event => @event.StartDate <= TwoDayFromNow)
                .Where(@event => @event.StartDate >= DateTime.Now)
            .ToList();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}