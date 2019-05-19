using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EventApplication.Models;

namespace EventApplication.Controllers
{
    public class EventController : Controller
    {
        private EventDB db = new EventDB();

        // GET: Event
        public ActionResult Index(string TitleOrType, string Location)
        {
            if (TitleOrType + Location == "" + "")
            {
                TempData["errorMessage"] = "No events found.";

                return View();
            }

            var events = db.Events
                .Where(@event => (@event.Title + @event.EventType.Name).Contains(TitleOrType))
                .Where(@event => @event.Location.Contains(Location))
            .ToList();

            if (events.Count < 1 || events == null)
            {
                TempData["errorMessage"] = "No events found.";

                return View();
            }

            TempData["errorMessage"] = null;

            return View(events);
        }

        // GET: Event/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Event @event = db.Events.Find(id);
            EventType eventType = db.EventTypes.SingleOrDefault(e => e.Id == @event.EventTypeId);
            ViewBag.EventType = eventType.Name;

            if (@event == null)
            {
                return HttpNotFound();
            }

            return View(@event);
        }

        [Authorize]
        public ActionResult Register(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            string errorMessage;
            if (TempData["errorMessage"] != null)
            {
                errorMessage = TempData["errorMessage"].ToString();
            }
            else
            {
                errorMessage = "";
            }

            ViewBag.ErrorMessage = errorMessage;

            Event EventSelected = db.Events.SingleOrDefault(@event => @event.Id == id);
            Order order = new Order() { EventSelected = EventSelected };

            return View(order);
        }

        // GET: Event/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.EventTypeId = new SelectList(db.EventTypes, "Id", "Name");

            return View();
        }

        // POST: Event/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,EventTypeId,Title,Description,StartDate,StartTime,EndDate,EndTime,Location,OrganizerName,OrganizerContact")] Event @event)
        {
            if (ModelState.IsValid)
            {
                db.Events.Add(@event);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.EventTypeId = new SelectList(db.EventTypes, "Id", "Name", @event.EventTypeId);

            return View(@event);
        }
    }
}
