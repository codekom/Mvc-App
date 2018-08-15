using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyApp.Models;

namespace VidlyApp.Controllers
{
    public class CustomersController : Controller
    {
        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer {Id=1, Name="John Smith" },
                new Customer {Id=2,Name="Mary Williams" }
            };
        }
        // GET: Customers
        public ActionResult Index()
        {
            List<Customer> custList = GetCustomers().ToList();

            return View(custList);
        }

        public ActionResult Details(int Id)
        {
            List<Customer> custList = GetCustomers().ToList();
            var customer = custList.SingleOrDefault(ct => ct.Id == Id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }
    }
}