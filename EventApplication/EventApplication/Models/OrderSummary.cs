using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EventApplication.Models
{
    public class OrderSummary
    {
        public string Id;
        private const string SessionKey = "OrderId";

        private EventDB db = new EventDB();

        public static OrderSummary GetOrder(HttpContextBase context)
        {
            OrderSummary order = new OrderSummary();
            order.Id = order.GetOrderId(context);
            return order;
        }

        public string GetOrderId(HttpContextBase context)
        {
            string orderId;

            if (context.Session[SessionKey] == null)
            {
                //Create a order id and add it to the session variable
                orderId = Guid.NewGuid().ToString();
                context.Session[SessionKey] = orderId;
            }
            else
            {
                //Retrieve order id
                orderId = context.Session[SessionKey].ToString();
            }

            return orderId;
        }

        public List<Order> GetOrderItems()
        {
            return db.Orders
                .Where(@order => @order.Key == Id)
                .Where(@order => @order.Status == 1)
            .ToList();
        }

        public void AddOrder(int id, int tickets, Event EventSelected)
        {
            Order orderItem = db.Orders.SingleOrDefault(@order => @order.Key == Id && @order.EventId == id);

            var CurrentUser = HttpContext.Current.User.Identity.GetUserName();
            var UserSelected = db.Users.SingleOrDefault(@user => @user.EmailID == CurrentUser);
            int UserId = UserSelected.Id;

            if (orderItem == null) // orderItem doesn't exists in db =? add orderItem to database
            {

                orderItem = new Order()
                {
                    Key = Id,
                    EventId = id,
                    UserId = UserId,
                    Number = new Random().Next(100000, 999999),
                    Tickets = tickets,
                    OrderDate = DateTime.Now,
                    UserSelected = UserSelected,
                    Status = 1
                };

                EventSelected.Tickets -= tickets;

                db.Orders.Add(orderItem);
                db.Events.Attach(EventSelected);
            }
            else // OrderItem already exists in db => Update count
            {
                orderItem.Tickets += tickets;
            }

            db.SaveChanges();
        }

        public void CancelOrder(int id)
        {
            Order orderItem = db.Orders.SingleOrDefault(@order => @order.Id == id);
            Event SelectedEvent = db.Events.SingleOrDefault(@event => @event.Id == orderItem.EventId);

            if (orderItem != null)
            {
                if (orderItem.Status == 1)
                {
                    orderItem.Status = 0;
                    SelectedEvent.Tickets += orderItem.Tickets;
                }
                db.SaveChanges();
            }
        }
    }
}