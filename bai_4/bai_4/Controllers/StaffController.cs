using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bai_4.Models;

namespace bai_4.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(FormCollection f)
        {
            //lay thong tin tu input type = file
            var fhinh = Request.Files["myfileImage"];
            //save hinh ve server
            var pathhinh = Server.MapPath("~/Images/" + fhinh.FileName);
            fhinh.SaveAs(pathhinh);
            string path = Server.MapPath("~/Staffinfo.txt");
            string[] info = {f["txtID"], f["txtName"], f["txtDate"],
                f["txtSalary"], fhinh.FileName};
            //ghi file Staffinfo.txt
            System.IO.File.WriteAllLines(path, info);

            return View("Index");
        }
        public ActionResult Open()
        {
            //doc lai file tu server
            string path = Server.MapPath("~/Staffinfo.txt");
            string[] info = System.IO.File.ReadAllLines(path);
            Staff s = new Staff();
            s.StaffID = int.Parse(info[0]);
            s.StaffName = info[1];
            s.BirthOfDate = DateTime.Parse(info[2]);
            s.Salary = decimal.Parse(info[3]);
            s.StaffImage = info[4];
            //chuyen cac thong tin sang View tu cac bien ViewBag
            ViewBag.id = s.StaffID;
            ViewBag.name = s.StaffName;
            ViewBag.birthday = s.BirthOfDate.ToString("yyyy-MM-dd");
            ViewBag.salary = s.Salary;
            ViewBag.image = "../../Images/" + s.StaffImage;

            return View("Index");
        }
    }
}