using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Movie> MovieList { get; set; }
        public List<Customer> Customers { get; set; }
        public Customer CustomerName { get; set; }
    }
}