using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Get_ICS.Models;
using iCalendarSharp.Calendars;
using Newtonsoft.Json;
using RestSharp;

namespace Get_ICS
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new DataModel(new Uri("https://speakers.codemash.org/api/"));
            var output = args.FirstOrDefault() ?? "codemash.ics";
            var calendar = new iCalendar();

            foreach (var session in model.Sessions)
            {
                var thisEvent = new iEvent
                {
                    Description = $"Speakers: {session.Speakers.Select(s=> s.FirstName + ' ' + s.LastName).ToString()}\n\n{session.Abstract}",
                    End = session.SessionEndTime,
                    Location = session.Rooms.ToString(),
                    Start = session.SessionStartTime,
                    Summary = session.Title
                };
                calendar.Events.Add(thisEvent);
            }

        }
    }
}
