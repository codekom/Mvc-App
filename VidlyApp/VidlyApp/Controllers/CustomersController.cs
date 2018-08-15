using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using VidlyApp.Models;

namespace VidlyApp.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            List<Customer> custList = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(custList);
        }

        public ActionResult Details(int Id)
        {
            List<Customer> custList = _context.Customers.Include(c => c.MembershipType).ToList();
            var customer = custList.SingleOrDefault(ct => ct.Id == Id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }
    }
}