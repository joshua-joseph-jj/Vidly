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
    public class CustomersController : Controller
    {


        // add DbContext object, allows app to pull from database
        private ApplicationDbContext _context;



        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }



        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }



        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = membershipTypes
            };


            return View(viewModel);
        }



        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            return View();
        }





        public  ActionResult Index()
        {

            // use '.include()' method to bring in MembershipType property from
            // customer class
            // requires importing 'using syste.data.entity' namespace

            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }



        public  ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
       

    }
}