using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickUpEventsApp.Data.Model
{
    public class User
    {
      public string Name { get; set; }

      public string EmailAddress { get; set; }

      public string PhoneNumber { get; set; }

      public Location Location { get; set; }

      public IEnumerable<Group> Groups { get; set; }

      public IEnumerable<Event> RSVPdEvents { get; set; }

      public IEnumerable<Event> AttendedEvents { get; set; }

      public IEnumerable<Event> HostedEvents { get; set; }
    }
}
