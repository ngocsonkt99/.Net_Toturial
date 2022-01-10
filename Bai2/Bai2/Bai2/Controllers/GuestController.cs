using Bai2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai2.Controllers
{
    public class GuestController : Controller
    {
        // GET: Guest
        public ActionResult Index()
        {
            ViewBag.Today = "Today is " + DateTime.Today;
            return View();
        }
        public ActionResult Thanks()
        {
            return View();
        }
        [HttpGet]
        public ActionResult RvspForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RvspForm(GuestResponse guest)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", guest);
            }
            else
                return View();
        }
    }
}