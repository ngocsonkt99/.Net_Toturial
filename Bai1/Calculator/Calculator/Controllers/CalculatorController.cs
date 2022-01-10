using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {

        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(double a, double b, string op="+")
        {
            switch(op)
            {
                case "+":
                    ViewBag.KetQua = a + b; break;
                case "-":
                    ViewBag.KetQua = a - b; break;
                case "*":
                    ViewBag.KetQua = a * b; break;
                case "/":
                    if (b == 0) ViewBag.KetQua = "khong chia duoc cho 0";
                    else ViewBag.KetQua = a / b;
                    break;
            }
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(double a, double b, string op = "+")
        {
            switch (op)
            {
                case "+":
                    ViewBag.KetQua = a + b; break;
                case "-":
                    ViewBag.KetQua = a - b; break;
                case "*":
                    ViewBag.KetQua = a * b; break;
                case "/":
                    if (b == 0) ViewBag.KetQua = "khong chia duoc cho 0";
                    else ViewBag.KetQua = a / b;
                    break;
            }
            return View();
        }
    }
}