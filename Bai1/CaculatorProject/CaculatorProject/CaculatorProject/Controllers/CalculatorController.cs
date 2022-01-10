using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaculatorProject.Models;

namespace CaculatorProject.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Calculation cal)
        {
            switch (cal.op)
            {
                case "+":
                    ViewBag.KetQua = cal.num1 + cal.num2;break;
                case "-":
                    ViewBag.KetQua = cal.num1 - cal.num2; break;
                case "*":
                    ViewBag.KetQua = cal.num1 * cal.num2; break;
                case "/":
                    if (cal.num2 == 0) ViewBag.KetQua = "Không chia được cho 0";
                    else ViewBag.KetQua = cal.num1 / cal.num2;
                    break;
            }
            return View();
        }
    }
}