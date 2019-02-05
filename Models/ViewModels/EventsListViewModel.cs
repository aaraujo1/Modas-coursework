using System.Collections.Generic;
using System;

namespace Modas.Models.ViewModels
{
    public class EventsListViewModel
    {
        public IEnumerable<Event> Events { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}

//Excerpt From: Adam Freeman. “Pro ASP.NET Core MVC 2.” Apple Books. 

