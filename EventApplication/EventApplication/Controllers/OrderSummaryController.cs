using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EventApplication.Models;
using Microsoft.AspNet.Identity;


namespace EventApplication.Controllers
{
    [Authorize]
    public class OrderSummaryController : Controller
    {
        EventDB db = new EventDB();

        // GET: Order
        public ActionResult Index()
        {
            var CurrentUser = HttpContext.User.Identity.GetUserName();
            var UserSelected = db.Users.SingleOrDefault(@user => @user.EmailID == CurrentUser);
            int UserId = UserSelected.Id;

            List<Order> order = db.Orders
                .Where(o => o.UserId == UserId)
                .Where(o => o.Status == 1)
            .ToList();

            foreach (var item in order)
            {
                Event EventSelected = db.Events.Find(item.EventId);
                item.EventSelected = EventSelected;
            }

            if (TempData["Message"] != null)
            {
                ViewBag.Message = TempData["Message"];
                TempData["Message"] = null;
            }

            return View(order.ToList());
        }

        // GET: /Order/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Order order = db.Orders.Find(id);
            Event EventSelected = db.Events.SingleOrDefault(@event => @event.Id == order.EventId);

            if (order == null)
            {
                return HttpNotFound();
            }

            return View(order);
        }

        // GET: /Order/AddOrder/5
        public ActionResult AddOrder(int id, int tickets)
        {
            Event EventSelected = db.Events.SingleOrDefault(@event => @event.Id == id);

            if (EventSelected.StartDate < DateTime.Now)
            {
                // Go back to Register and return error message
                TempData["errorMessage"] = "Event registration is in the past";
                return RedirectToAction("Register", "Event", new { id });
            }
            else if (EventSelected.Tickets == 0)
            {
                // Go back to Register and return error message
                TempData["errorMessage"] = "Event is full";
                return RedirectToAction("Register", "Event", new { id });
            }
            else if (tickets < 1)
            {
                // Go back to Register and return error message
                TempData["errorMessage"] = "At least 1 ticket is required to make an order";
                return RedirectToAction("Register", "Event", new { id });
            }
            else if (tickets > EventSelected.Tickets)
            {
                // Go back to Register and return error message
                TempData["errorMessage"] = "Your order exceeds available tickets";
                return RedirectToAction("Register", "Event", new { id });
            }

            OrderSummary order = OrderSummary.GetOrder(this.HttpContext);
            order.AddOrder(id, tickets, EventSelected);

            return RedirectToAction("Index");
        }

        // GET: /Order/CancelOrder/5
        public ActionResult CancelOrder(int id)
        {
            OrderSummary order = OrderSummary.GetOrder(this.HttpContext);
            order.CancelOrder(id);

            TempData["Message"] = "Your order has been cancelled";

            return RedirectToAction("Details", new { Id = id });
        }
    }
}