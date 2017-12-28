using ModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelBinding.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(Employee emp)
        {
            return View (emp);
        }
        [HttpPost]
        public ActionResult Redirects(Employee emp)
        {
            TempData["Emp"] = emp;
            return Redirect("/Home/Details");
        }
        public ActionResult Details()
        {
            Employee emp = TempData["Emp"] as Employee;
            return View(emp);
        }

    }
}