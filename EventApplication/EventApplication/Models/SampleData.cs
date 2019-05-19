using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<EventDB>
    {
        protected override void Seed(EventDB context)
        {
            IList<EventType> eventTypes = new List<EventType>
            {
                new EventType { Name = "Arts" },
                new EventType { Name = "Business" },
                new EventType { Name = "Classes" },
                new EventType { Name = "Food & Drink" },
                new EventType { Name = "Music" },
                new EventType { Name = "Parties" },
                new EventType { Name = "Sports" },
                new EventType { Name = "Holiday" },
                new EventType { Name = "Natural Phenomena" },
                new EventType { Name = "Other" }
            };

            List<Event> events = new List<Event>
            {
                new Event {
                    Title = "Solar Eclipse",
                    Description = "The Moon will block the Sun",
                    Location = "North America, Earth",
                    StartDate = DateTime.Parse("4/8/2024"),
                    StartTime = DateTime.Parse("12:00 AM"),
                    EndDate =  DateTime.Parse("4/9/2024"),
                    EndTime = DateTime.Parse("12:00 PM"),
                    OrganizerName = "NASA",
                    OrganizerContact = "NASA@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Natural Phenomena"),
                    Tickets = 100
                },
                new Event {
                    Title = "Boom",
                    Description = "Well everybody, this is it.  The human race had a nice run, but now the race is over.  The Moon is going to colide with the Sun.",
                    Location = "Earth",
                    StartDate = DateTime.Parse("4/8/2019"),
                    StartTime = DateTime.Parse("1:00 AM"),
                    EndDate =  DateTime.Parse("4/9/2019"),
                    EndTime = DateTime.Parse("1:00 PM"),
                    OrganizerName = "Fox News",
                    OrganizerContact = "DeceptiveFox@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Business"),
                    Tickets = 50
                },
                new Event {
                    Title = "Billy's Birthday Party",
                    Description = "It's Billy's Birthday Party.",
                    Location = "Billy's House",
                    StartDate = DateTime.Parse("4/8/2017"),
                    StartTime = DateTime.Parse("3:00 PM"),
                    EndDate =  DateTime.Parse("4/8/2017"),
                    EndTime = DateTime.Parse("5:00 PM"),
                    OrganizerName = "Billy's Mom",
                    OrganizerContact = "BillysMother@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Parties"),
                    Tickets = 11
                },
                new Event {
                    Title = "Mars Christmas Festival of 2017",
                    Description = "Christmas on Mars",
                    Location = "Styx, Mars",
                    StartDate = DateTime.Parse("12/25/2017"),
                    StartTime = DateTime.Parse("5:00 AM"),
                    EndDate =  DateTime.Parse("12/25/2017"),
                    EndTime = DateTime.Parse("11:00 PM"),
                    OrganizerName = "Mr. Alien",
                    OrganizerContact = "Alien@mars.net",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Holiday"),
                    Tickets = 100
                },
                new Event {
                    Title = "Luner Eclipse",
                    Description = "The Earth will block the Sun light from reaching the Moon",
                    Location = "North America, Earth",
                    StartDate = DateTime.Parse("4/8/2017"),
                    StartTime = DateTime.Parse("12:00 AM"),
                    EndDate =  DateTime.Parse("4/8/2017"),
                    EndTime = DateTime.Parse("12:00 PM"),
                    OrganizerName = "NASA",
                    OrganizerContact = "NASA@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Natural Phenomena"),
                    Tickets = 100
                },
                new Event {
                    Title = "IT-2030 ASP.NET Web Programming",
                    Description = "Create server-side, database-driven websites using the ASP.NET framework in combination with markup, style sheets and client-side scripting.",
                    Location = "East Campus, Cuyahoga Community College",
                    StartDate = DateTime.Parse("1/14/2018"),
                    StartTime = DateTime.Parse("1:00 AM"),
                    EndDate =  DateTime.Parse("10/7/2018"),
                    EndTime = DateTime.Parse("11:59 PM"),
                    OrganizerName = "Manjula Chandirasekaran",
                    OrganizerContact = "manjula.chandirasekaran@tri-c.edu",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Classes"),
                    Tickets = 30
                },
                new Event {
                    Title = "Solar Eclipse",
                    Description = "The Moon will block the Sun",
                    Location = "North America, Earth",
                    StartDate = DateTime.Parse("4/8/2024"),
                    StartTime = DateTime.Parse("12:00 AM"),
                    EndDate =  DateTime.Parse("4/8/2024"),
                    EndTime = DateTime.Parse("12:00 PM"),
                    OrganizerName = "NASA",
                    OrganizerContact = "NASA@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Natural Phenomena"),
                    Tickets = 100
                },
                new Event {
                    Title = "2018 Hunt For Bigfoot",
                    Description = "He's out there somewhere.  Maybe.",
                    Location = "Spoopy Woods, Bigfoot Island",
                    StartDate = DateTime.Parse("3/4/2009"),
                    StartTime = DateTime.Parse("12:00 AM"),
                    EndDate =  DateTime.Parse("3/5/2009"),
                    EndTime = DateTime.Parse("12:00 AM"),
                    OrganizerName = "Some Guy",
                    OrganizerContact = "SomeGuy@spoopy.org",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Other"),
                    Tickets = 100
                },
                new Event {
                    Title = "Event 8",
                    Description = "Something is going to happen.",
                    Location = "Somewhere",
                    StartDate = DateTime.Now.AddDays(2),
                    StartTime = DateTime.Parse("1:00 AM"),
                    EndDate =  DateTime.Now.AddDays(2),
                    EndTime = DateTime.Parse("1:00 PM"),
                    OrganizerName = "Someone",
                    OrganizerContact = "Someone@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Arts"),
                    Tickets = 50
                },
                new Event {
                    Title = "Event 9",
                    Description = "Something is going to happen.",
                    Location = "Somewhere",
                    StartDate = DateTime.Now.AddDays(2),
                    StartTime = DateTime.Parse("1:00 AM"),
                    EndDate =  DateTime.Now.AddDays(2),
                    EndTime = DateTime.Parse("1:00 PM"),
                    OrganizerName = "Someone",
                    OrganizerContact = "Someone@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Business"),
                    Tickets = 50
                },
                new Event {
                    Title = "Event 10",
                    Description = "Something is going to happen.",
                    Location = "Somewhere",
                    StartDate = DateTime.Now.AddDays(2),
                    StartTime = DateTime.Parse("1:00 AM"),
                    EndDate =  DateTime.Now.AddDays(2),
                    EndTime = DateTime.Parse("1:00 PM"),
                    OrganizerName = "Someone",
                    OrganizerContact = "Someone@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Classes"),
                    Tickets = 50
                },
                new Event {
                    Title = "Event 11",
                    Description = "Something is going to happen.",
                    Location = "Somewhere",
                    StartDate = DateTime.Now.AddDays(2),
                    StartTime = DateTime.Parse("1:00 AM"),
                    EndDate =  DateTime.Now.AddDays(2),
                    EndTime = DateTime.Parse("1:00 PM"),
                    OrganizerName = "Someone",
                    OrganizerContact = "Someone@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Food & Drink"),
                    Tickets = 50
                },
                new Event {
                    Title = "Event 12",
                    Description = "Something is going to happen.",
                    Location = "Somewhere",
                    StartDate = DateTime.Now.AddDays(2),
                    StartTime = DateTime.Parse("1:00 AM"),
                    EndDate =  DateTime.Now.AddDays(2),
                    EndTime = DateTime.Parse("1:00 PM"),
                    OrganizerName = "Someone",
                    OrganizerContact = "Someone@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Music"),
                    Tickets = 50
                },
                new Event {
                    Title = "Event 13",
                    Description = "Something is going to happen.",
                    Location = "Somewhere",
                    StartDate = DateTime.Parse("1/1/9000"),
                    StartTime = DateTime.Parse("1:00 AM"),
                    EndDate =  DateTime.Parse("1/1/9000"),
                    EndTime = DateTime.Parse("1:00 PM"),
                    OrganizerName = "Someone",
                    OrganizerContact = "Someone@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Parties"),
                    Tickets = 50
                },
                new Event {
                    Title = "Event 14",
                    Description = "Something is going to happen.",
                    Location = "Somewhere",
                    StartDate = DateTime.Parse("1/1/9000"),
                    StartTime = DateTime.Parse("1:00 AM"),
                    EndDate =  DateTime.Parse("1/1/9000"),
                    EndTime = DateTime.Parse("1:00 PM"),
                    OrganizerName = "Someone",
                    OrganizerContact = "Someone@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Sports"),
                    Tickets = 50
                },
                new Event {
                    Title = "Event 15",
                    Description = "Something is going to happen.",
                    Location = "Somewhere",
                    StartDate = DateTime.Parse("1/1/9000"),
                    StartTime = DateTime.Parse("1:00 AM"),
                    EndDate =  DateTime.Parse("1/1/9000"),
                    EndTime = DateTime.Parse("1:00 PM"),
                    OrganizerName = "Someone",
                    OrganizerContact = "Someone@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Holiday"),
                    Tickets = 50
                },
                new Event {
                    Title = "Event 16",
                    Description = "Something is going to happen.",
                    Location = "Somewhere",
                    StartDate = DateTime.Parse("1/1/9000"),
                    StartTime = DateTime.Parse("1:00 AM"),
                    EndDate =  DateTime.Parse("1/1/9000"),
                    EndTime = DateTime.Parse("1:00 PM"),
                    OrganizerName = "Someone",
                    OrganizerContact = "Someone@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Natural Phenomena"),
                    Tickets = 50
                },
                new Event {
                    Title = "Event 17",
                    Description = "Something is going to happen.",
                    Location = "Somewhere",
                    StartDate = DateTime.Parse("1/1/9000"),
                    StartTime = DateTime.Parse("1:00 AM"),
                    EndDate =  DateTime.Parse("1/1/9000"),
                    EndTime = DateTime.Parse("1:00 PM"),
                    OrganizerName = "Someone",
                    OrganizerContact = "Someone@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Other"),
                    Tickets = 50
                },
                new Event {
                    Title = "Event 18",
                    Description = "Something is going to happen.",
                    Location = "Somewhere",
                    StartDate = DateTime.Parse("1/1/9000"),
                    StartTime = DateTime.Parse("1:00 AM"),
                    EndDate =  DateTime.Parse("1/1/9000"),
                    EndTime = DateTime.Parse("1:00 PM"),
                    OrganizerName = "Someone",
                    OrganizerContact = "Someone@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Arts"),
                    Tickets = 50
                },
                new Event {
                    Title = "Event 19",
                    Description = "Something is going to happen.",
                    Location = "Somewhere",
                    StartDate = DateTime.Parse("1/1/9000"),
                    StartTime = DateTime.Parse("1:00 AM"),
                    EndDate =  DateTime.Parse("1/1/9000"),
                    EndTime = DateTime.Parse("1:00 PM"),
                    OrganizerName = "Someone",
                    OrganizerContact = "Someone@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Business"),
                    Tickets = 50
                },
                new Event {
                    Title = "Event 20",
                    Description = "Something is going to happen.",
                    Location = "Somewhere",
                    StartDate = DateTime.Parse("1/1/9000"),
                    StartTime = DateTime.Parse("1:00 AM"),
                    EndDate =  DateTime.Parse("1/1/9000"),
                    EndTime = DateTime.Parse("1:00 PM"),
                    OrganizerName = "Someone",
                    OrganizerContact = "Someone@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Classes"),
                    Tickets = 50
                },
                new Event {
                    Title = "Event 21",
                    Description = "Something is going to happen.",
                    Location = "Somewhere",
                    StartDate = DateTime.Parse("1/1/9000"),
                    StartTime = DateTime.Parse("1:00 AM"),
                    EndDate =  DateTime.Parse("1/1/9000"),
                    EndTime = DateTime.Parse("1:00 PM"),
                    OrganizerName = "Someone",
                    OrganizerContact = "Someone@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Food & Drink"),
                    Tickets = 50
                },
                new Event {
                    Title = "Event 22",
                    Description = "Something is going to happen.",
                    Location = "Somewhere",
                    StartDate = DateTime.Parse("1/1/9000"),
                    StartTime = DateTime.Parse("1:00 AM"),
                    EndDate =  DateTime.Parse("1/1/9000"),
                    EndTime = DateTime.Parse("1:00 PM"),
                    OrganizerName = "Someone",
                    OrganizerContact = "Someone@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Music"),
                    Tickets = 50
                },
                new Event {
                    Title = "Event 23",
                    Description = "Something is going to happen.",
                    Location = "Somewhere",
                    StartDate = DateTime.Parse("1/1/9000"),
                    StartTime = DateTime.Parse("1:00 AM"),
                    EndDate =  DateTime.Parse("1/1/9000"),
                    EndTime = DateTime.Parse("1:00 PM"),
                    OrganizerName = "Someone",
                    OrganizerContact = "Someone@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Parties"),
                    Tickets = 50
                },
                new Event {
                    Title = "Event 24",
                    Description = "Something is going to happen.",
                    Location = "Somewhere",
                    StartDate = DateTime.Parse("1/1/9000"),
                    StartTime = DateTime.Parse("1:00 AM"),
                    EndDate =  DateTime.Parse("1/1/9000"),
                    EndTime = DateTime.Parse("1:00 PM"),
                    OrganizerName = "Someone",
                    OrganizerContact = "Someone@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Sports"),
                    Tickets = 50
                },
                new Event {
                    Title = "Event 25",
                    Description = "Something is going to happen.",
                    Location = "Somewhere",
                    StartDate = DateTime.Parse("1/1/9000"),
                    StartTime = DateTime.Parse("1:00 AM"),
                    EndDate =  DateTime.Parse("1/1/9000"),
                    EndTime = DateTime.Parse("1:00 PM"),
                    OrganizerName = "Someone",
                    OrganizerContact = "Someone@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Holiday"),
                    Tickets = 50
                },
                new Event {
                    Title = "Event 26",
                    Description = "Something is going to happen.",
                    Location = "Somewhere",
                    StartDate = DateTime.Parse("1/1/9000"),
                    StartTime = DateTime.Parse("1:00 AM"),
                    EndDate =  DateTime.Parse("1/1/9000"),
                    EndTime = DateTime.Parse("1:00 PM"),
                    OrganizerName = "Someone",
                    OrganizerContact = "Someone@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Natural Phenomena"),
                    Tickets = 50
                },
                new Event {
                    Title = "Event 27",
                    Description = "Something is going to happen.",
                    Location = "Somewhere",
                    StartDate = DateTime.Parse("1/1/9000"),
                    StartTime = DateTime.Parse("1:00 AM"),
                    EndDate =  DateTime.Parse("1/1/9000"),
                    EndTime = DateTime.Parse("1:00 PM"),
                    OrganizerName = "Someone",
                    OrganizerContact = "Someone@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Other"),
                    Tickets = 50
                },
                new Event {
                    Title = "Event 28",
                    Description = "Something is going to happen.",
                    Location = "Somewhere",
                    StartDate = DateTime.Parse("1/1/9000"),
                    StartTime = DateTime.Parse("1:00 AM"),
                    EndDate =  DateTime.Parse("1/1/9000"),
                    EndTime = DateTime.Parse("1:00 PM"),
                    OrganizerName = "Someone",
                    OrganizerContact = "Someone@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Food & Drink"),
                    Tickets = 50
                },
                new Event {
                    Title = "Event 29",
                    Description = "Something is going to happen.",
                    Location = "Somewhere",
                    StartDate = DateTime.Parse("1/1/9000"),
                    StartTime = DateTime.Parse("1:00 AM"),
                    EndDate =  DateTime.Parse("1/1/9000"),
                    EndTime = DateTime.Parse("1:00 PM"),
                    OrganizerName = "Someone",
                    OrganizerContact = "Someone@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Food & Drink"),
                    Tickets = 50
                },
                new Event {
                    Title = "Event 30",
                    Description = "Something is going to happen.",
                    Location = "Somewhere",
                    StartDate = DateTime.Parse("1/1/9000"),
                    StartTime = DateTime.Parse("1:00 AM"),
                    EndDate =  DateTime.Parse("1/1/9000"),
                    EndTime = DateTime.Parse("1:00 PM"),
                    OrganizerName = "Someone",
                    OrganizerContact = "Someone@email.com",
                    EventType = eventTypes.Single(@eventType => @eventType.Name == "Food & Drink"),
                    Tickets = 50
                }
            };

            context.EventTypes.AddRange(eventTypes);
            context.Events.AddRange(events);
            base.Seed(context);
        }
    }
}