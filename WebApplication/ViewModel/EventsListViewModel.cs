using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data.Models;

namespace WebApplication.ViewModel
{
    public class EventsListViewModel
    {
        public IEnumerable<Event> getAllEvents { get; set; }

    }
}
