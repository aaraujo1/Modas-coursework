using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modas.Models;
using System.Linq;
using Modas.Models.ViewModels;

namespace Modas.Controllers
{
    public class HomeController : Controller
    {
        //adding pagination
        //could be in app setting
        private readonly int PageSize = 20;

        private IEventRepository repository;
        public HomeController(IEventRepository repo)
        {
            repository = repo;
        }

        //public ViewResult Index() => View(repository.Events);

        //get location and order them
        /*public ViewResult Index() => View(
                repository.Events.Include(e => e.Location).OrderBy(e => e.TimeStamp));*/

        //display page 
        /*public ViewResult Index(int page = 1) => View(
        repository.Events.Include(e => e.Location)
            .OrderBy(e => e.TimeStamp)
            //number of records to skip
            .Skip((page - 1) * PageSize)
            //number of records to get
            .Take(PageSize));*/

        public ViewResult Index(int page = 1) => View(new EventsListViewModel {
            Events = repository.Events.Include(e => e.Location)
            .OrderBy(e => e.TimeStamp)
            //number of records to skip
            .Skip((page - 1) * PageSize)
            //number of records to get
            .Take(PageSize),

            PagingInfo = new PagingInfo
            {
                CurrentPage = page,
                ItemsPerPage = PageSize,
                TotalItems = repository.Events.Count()
            }
        });

    }
}
