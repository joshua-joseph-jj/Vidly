﻿using System;
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
        // GET: Movies/Random
        public ActionResult Random()
        {

            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };


            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };


            return View(viewModel);
        }



        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }



        // this index method demonstrates optional (nullable) input parameter
        //public  ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (string.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(string.Format("pageIndex = {0}&sortBy = {1}", pageIndex, sortBy));
        //}




        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie { Name = "Shrek", Id = 1},
                new Movie { Name = "Wall-e", Id = 2}
            };


            var viewModel = new RandomMovieViewModel
            {
                MovieList = movies
            };

            return View(viewModel);
        }





        // ByReleaseDate is utilized by custom route in 'RouteConfig.cs'
        // which uses a legacy implementation

        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}



        // custom route using Attribute Routing
        [Route("movies/released/{year}/{month:regex(\\{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }



        public ActionResult ViewMovie(int id)
        {
            var movieList = new List<Movie>
            {
                new Movie { Name = "Shrek", Id = 1},
                new Movie { Name = "Wall-e", Id = 2}
            };



            var viewModel = new RandomMovieViewModel
            {
                MovieList = movieList,
                Movie = movieList.Find(movlist => movlist.Id == id)
            };

            return View(viewModel);
        }
    }
}