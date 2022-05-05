using AdoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AdoMVC.DAL;


namespace AdoMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            CustomerDAL custDAL = new CustomerDAL();
            List<Customer> CustomerList = new List<Customer>();
            CustomerList = custDAL.GetAllCustomers();
            return View(CustomerList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [Route("Home/insert")]
        
        public IActionResult insert()
        {
            return View();
        }
        [Route("Home/NewCustomer")]
        public IActionResult NewCustomer(Customer cust)
        {
            CustomerDAL mobj = new CustomerDAL();
            int result = mobj.NewCustomer(cust);
            if (result == 1)
                return RedirectToAction("Index");
            else
                return View("Insert");
        }
        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Del(Customer c)
        {
            CustomerDAL cobj = new CustomerDAL();
            int result = cobj.DelCustomer(c);
            if (result == 1)
            {
                return RedirectToAction("Index");
            }
            else return RedirectToAction("Delete");
        }

        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Upd(Customer c)
        {
            CustomerDAL cobj = new CustomerDAL();
            int result = cobj.UpdCustomer(c);
            if (result == 1)
            {
                return RedirectToAction("Index");
            }
            else return RedirectToAction("Update");
        }
       [Route("Home/SC")]
        public IActionResult SearchCustomer(int CustomerID)
        {
            CustomerDAL custDAL = new CustomerDAL();
            List<Customer> CustomerList = new List<Customer>();
            CustomerList = custDAL.GetCustomerByID(CustomerID);
            return View(CustomerList);
        }
    }
}
