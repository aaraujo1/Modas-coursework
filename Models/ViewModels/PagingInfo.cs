using System;
namespace Modas.Models.ViewModels
{
    public class PagingInfo
    {

            public int TotalItems { get; set; }
            public int ItemsPerPage { get; set; }
            public int CurrentPage { get; set; }
            public int TotalPages =>
                (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
        }

//Excerpt From: Adam Freeman. “Pro ASP.NET Core MVC 2.” Apple Books. 
    }
