using System.Linq;
namespace Modas.Models
{
    public interface IEventRepository
    {
        IQueryable<Event> Events { get; }
        IQueryable<Location> Locations { get; }

        //method to add event
        Event AddEvent(Event evt);

        //method to update event
        Event UpdateEvent(Event evt);

        //method to delete event
        void DeleteEvent(int eventId);
    }
}
