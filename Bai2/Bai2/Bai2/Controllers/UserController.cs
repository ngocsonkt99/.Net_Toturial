using Bai2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai2.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Dangnhap(User us)
        {

            if(us.Username=="abc"&& us.Password=="123456")
            {
                Session["Thanhvien"] = us;

                return RedirectToAction("Thongtin");
            }
            return View("Index");
        }
        public ActionResult Thongtin()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session.Remove("Thanhvien");
            return View("Index");
        }
    }
}