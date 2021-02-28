using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data.interfaces;
using WebApplication.Data.Models;

namespace WebApplication.Data.Repository
{
    public class EventRepository : IEvents
    {
        private readonly ApplicContext appDBContent;

        public EventRepository(ApplicContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Event> Events => appDBContent.Event;

        public Event getObjectEvent(int eventId) => appDBContent.Event.FirstOrDefault(p => p.eventId == eventId);
    }
}
