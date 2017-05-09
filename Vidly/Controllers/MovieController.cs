using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            var customer = new List<Customer>
            {
                new Customer {Name="customer1" },
                new Customer { Name="customer2"}
            };
            
            var vieModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customer = customer
            };

            return  View(vieModel);
            // ViewData["Movie"] = movie;
            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model.
        }
        
        public ActionResult Edit(int movieId)
        {
            return Content("id" + movieId);
        } 

        public ActionResult Index(int ? pageIndex,string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0}&sortBy={1}",pageIndex,sortBy));
        }

       // [Route("movies/realeased/{year}/{month:regex(\\d{4}):range(1-4)}")]
        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(year + "/"+month);
        }
    }
}