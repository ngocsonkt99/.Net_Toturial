using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai3.Models;

namespace Bai3.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public List<Product> lstPro = new List<Product>();
        public ActionResult Index()
        {
            Product sp1 = new Product()
            {
                ProductID = 1,
                ProductName = "Laptop toshiba",
                Price = 550M,
                Description = "Very good"
            };
            Product sp2 = new Product()
            {
                ProductID = 2,
                ProductName = "Monitor acer",
                Price = 50M,
                Description = "good"
            };
            Product sp3 = new Product()
            {
                ProductID = 3,
                ProductName = "Fax panasonic",
                Price = 150M,
                Description = "Very good"
            };
            Product sp4 = new Product()
            {
                ProductID = 4,
                ProductName = "Printf HP",
                Price = 250M,
                Description = "Very good"
            };
            lstPro.Add(sp1);
            lstPro.Add(sp2);
            lstPro.Add(sp3);
            lstPro.Add(sp4);
            return View(lstPro);
        }
    }
}