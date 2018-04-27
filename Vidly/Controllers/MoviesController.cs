using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie{Id=1, Name="Shrek!"},
                new Movie{Id=2, Name="Iron Man!"}
            };
        }


        // GET: Movies/Random
        public ActionResult Random()
        {
            Movie movie = new Movie { Name = "Shrek"};
            var customers = new List<Customer>
            {
                new Customer
                {
                    Name = "Customer 1"
                },
                new Customer
                {
                    Name = "Customer 2"
                }
            };

            var viewModel = new RandomModelViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        //Parameter embedded in URL
        public ActionResult Edit(int id)
        {
            return Content($"id = {id}");
        }

        //Optional Parameter
        // Make parameters nullable
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if(!pageIndex.HasValue)
        //    {
        //        pageIndex = 1;
        //    }

        //    if(string.IsNullOrWhiteSpace(sortBy))
        //    {
        //        sortBy = "Name";
        //    }

        //    return Content($"Page Index = {pageIndex} and Sort By = {sortBy}");
        //}

        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        //public ActionResult ByReleaseDate(int? year, byte? month)
        //{
        //    return Content(year+"/"+month);
        //}

        


    }
}