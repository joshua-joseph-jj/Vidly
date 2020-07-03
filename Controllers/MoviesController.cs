using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        // add DbContext object, allows app to pull from database
        private ApplicationDbContext _context;




        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }



        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }





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



        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}




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
            var movies = _context.Movies.ToList();
            {
                
                return View(movies);

            };
        }



        public ActionResult Details(int id)
        {
            //var movies = _context.Movies.SingleOrDefault(m => m.Id == id);
            var movies = _context.Movies.Single( m => m.Id == id);


            if (movies == null)
                return HttpNotFound();

            return View(movies);
        }





        /* ByReleaseDate is utilized by custom route in 'RouteConfig.cs'
         which uses a legacy implementation 
         */


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




        public ActionResult New(int? id)
        {
            var movies = _context.Movies.SingleOrDefault(m => m.Id == id);
            var viewModel = new MovieFormViewModel()
            {
                
                Genres = _context.Genres.ToList()
            };


            return View("New", viewModel);
        }




        public ActionResult Edit(int? id)
        {

            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
            {
                var view = new MovieFormViewModel() { Genres = _context.Genres.ToList()  };
                return View("Edit", view);
            }
                //return HttpNotFound();



            var viewModel = new MovieFormViewModel(movie)
            {
                Movie = movie,
                Genres = _context.Genres.ToList()
            };

            return View("Edit", viewModel);
        }








        [HttpPost]
        public ActionResult Save(Movie movie)
        {


            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel(movie)
                {
                    Genres = _context.Genres.ToList()
                };

                return View("MovieForm", viewModel);
            }


            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            

            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.DateAdded = movie.DateAdded;
                movieInDb.NumberInStock = movie.NumberInStock;
            }


            _context.SaveChanges();



            return RedirectToAction("Index", "Movies");
        }


    }
}