﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyApp.Models;
using VidlyApp.ViewModels;

namespace VidlyApp.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1" },
                new Customer {Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);

            //return Content("Hello");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home",new { page = 1, sortBy = "name" });
        }
        public ActionResult Edit(int Id)
        {
            return Content("Id=" + Id);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                 new Movie {Id=1, Name="Shrek!" },
                 new Movie {Id=2,Name="Wall-e" }
            };
        }
        public ActionResult Index()
        {
            List<Movie> mv = GetMovies().ToList();
            
            return View(mv);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }
}
