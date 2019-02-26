using System.Linq;
using Microsoft.AspNetCore.JsonPatch;

namespace Modas.Models
{
    public class EFEventRepository : IEventRepository
    {
        private ApplicationDbContext context;

        public EFEventRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Event> Events => context.Events;
        public IQueryable<Location> Locations => context.Locations;

        //method to add event
        public Event AddEvent(Event evt)
        {
            context.Add(evt);
            context.SaveChanges();
            return evt;
        }

        //method to update event
        public Event UpdateEvent(Event evt)
        {
            //look for specific event based on ID
            //FirstOrDefault returns 1 record or null (not error)
            Event Event = context.Events.FirstOrDefault(e => e.EventId == evt.EventId);
            Event.TimeStamp = evt.TimeStamp;
            Event.Flagged = evt.Flagged;
            Event.LocationId = evt.LocationId;
            context.SaveChanges();
            return Event;
        }

        //json with event id
        public void PatchEvent(int id, JsonPatchDocument<Event> patch)
        {
            Event evt = context.Events.FirstOrDefault(e => e.EventId == id);
            patch.ApplyTo(evt);
            context.SaveChanges();
        }

        //method to delete event
        public void DeleteEvent(int eventId)
        {
            //look for specific event based on ID
            Event evt = context.Events.FirstOrDefault(e => e.EventId == eventId);
            context.Events.Remove(evt);
            context.SaveChanges();
        }
    }
}