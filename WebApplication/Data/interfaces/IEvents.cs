using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data.Models;

namespace WebApplication.Data.interfaces
{
    public interface IEvents
    {

        IEnumerable<Event> Events { get; }
        Event getObjectEvent(int carId);

    }
}
