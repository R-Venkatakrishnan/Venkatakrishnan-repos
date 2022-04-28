using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EntityFcore.Models;

namespace EntityFcore.Controllers
{
    public class ProdController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(prod m)
        {
            if (ModelState.IsValid)
            {
                prodDBContext dBContext = new prodDBContext();
                dBContext.Add(m);
                dBContext.SaveChanges();
                return Content("ALL THE BEST NANBA");
                
            }
            return View("Index");
        }
    }
}
