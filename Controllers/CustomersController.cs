using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Veenca.Models;
using Veenca.ViewModels;
using System.Data.Entity;

namespace Veenca.Controllers
{

    public class CustomersController : Controller
    {
        private ApplicationDbContext _contex;
      
        public CustomersController()
        {
            _contex = new ApplicationDbContext();
           
        }
        protected override void Dispose(bool disposing)
        {
            _contex.Dispose();
         
        }
        // GET: Customers
        public ActionResult New() {
            //var membershipTypes = _contex.Customers.Include(l=> l.MembershipType).ToList();
            var tipiAbbonamenti = _contex.tipiAbbonamenti.ToList();
            var cliente = new Customer {id=0 };
            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = tipiAbbonamenti,
                Customer= cliente

            };
            return View("CustomerForm",viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
        

                if (!ModelState.IsValid) {

                var viewModel = new NewCustomerViewModel {
                    Customer = customer,
                    MembershipTypes = _contex.tipiAbbonamenti.ToList()
                };
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                var errorList = (from item in ModelState
                                 where item.Value.Errors.Any()
                                 select item.Value.Errors[0].ErrorMessage).ToList();
               // return Content(errorList[0]);
                return View("CustomerForm", viewModel);
            }
            if (customer.id == 0)
            {
                _contex.Customers.Add(customer);
                
            }
            else {
                var customerInDb = _contex.Customers.Single(c => c.id == customer.id);
                customerInDb.name = customer.name;
                customerInDb.Compleanno = customer.Compleanno;
                customerInDb.MembershipTypeid = customer.MembershipTypeid;
                customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
            }
            _contex.SaveChanges();
            return RedirectToAction("index", "Customers");
        }
      
        public ActionResult Index()
        {
          /*  var customers = _contex.Customers.Include(c => c.MembershipType).ToList();
           
            var clienti = new RandomMovieViewModel
            {
                Customers = customers
            };*/
            return View();
        }


        [Route("Customers/Details/{id:regex(\\d{1}):range(1,100)}")]
        public ActionResult Details(int? id)
        {



            if (!id.HasValue)
            {
                id = 1;
            }
            var cliente = _contex.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.id == id);
            
            if (cliente == null)
            {
                return HttpNotFound();
            }
            var customers = new List<Customer> {
                new Customer { id = cliente.id, name = cliente.name, Compleanno= cliente.Compleanno, MembershipTypeid= cliente.MembershipTypeid, MembershipType= cliente.MembershipType  }
            };
            var clienti = new RandomMovieViewModel
            {
                Customers = customers
            };

            return View(clienti);
        }
        public ActionResult Edit(int id) {
            //return Content("ciao");
            var customer = _contex.Customers.SingleOrDefault(c => c.id == id);
            if (customer == null) {
                return HttpNotFound();
            }
            var viewModel = new NewCustomerViewModel
            {

                Customer = customer,
                MembershipTypes = _contex.tipiAbbonamenti.ToList()
            };
            return View("CustomerForm", viewModel);
        }
    }
}