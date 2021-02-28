using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data.interfaces;
using WebApplication.Data.Models;

namespace WebApplication.Data.mocks
{
    public class MockEvents : IEvents
    {   
        public IEnumerable<Event> Events
        {
            get
            {
                return new List<Event>
                {
                    new Event {
                        subject = "Дело", 
                        description = "В этот день я буду занят", 
                        start = new DateTime(2021, 2, 28, 2, 0, 0), 
                        end = new DateTime(2021, 3, 1, 0, 0, 0), 
                        themeColor = "red", 
                        isFullDay = false}
                };
            }
        }

        public Event getObjectEvent(int eventId)
        {
            throw new NotImplementedException();
        }
    }
}
