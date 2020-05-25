using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {

            var customers = new List<Customer>
            {
                new Customer { Name = "John Smith", Id = 1},
                new Customer { Name = "Mary Williams", Id = 2}
            };



            var viewModel = new RandomMovieViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }


        public ActionResult ViewCustomer(int id)
        {
            var Id = id;

            var customers = new List<Customer>
            {
                new Customer { Name = "John Smith", Id = 1},
                new Customer { Name = "Mary Williams", Id = 2}
            };



            var viewModel = new RandomMovieViewModel
            {
                CustomerName = customers
                .Find(cust => cust.Id == id)
            };

            return View(viewModel);
        }
    }
}