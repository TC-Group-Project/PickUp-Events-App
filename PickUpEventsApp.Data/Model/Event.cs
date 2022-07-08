using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickUpEventsApp.Data.Model
{
    public class Event
    {
        public User Owner { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public IEnumerable<User> Users { get; set; }
        
        public Location Location { get; set; }

        public DateTime StartTime { get; set; }
    }
}
