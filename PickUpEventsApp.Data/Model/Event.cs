namespace PickUpEventsApp.Data.Model
{
    public class Event
    {
        public User Owner { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IEnumerable<User> Users { get; set; } 

        // This is a circular reference to this class.
        public IEnumerable<Event> Events { get; set; }

    }
}
