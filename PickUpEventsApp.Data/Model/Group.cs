using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickUpEventsApp.Data.Model
{
    public class Group
    {
        public User Owner { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IEnumerable<User> Users { get; set; }

        public IEnumerable<Event> Events { get; set; }
    }
}
