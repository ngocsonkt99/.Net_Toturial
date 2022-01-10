using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bai_7.Models;

namespace bai_7.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> lst = new List<Student>();
            //dung bien session de luu danh sach sinh vien 
            if (Session["dssv"] == null)
            {
                string[] ho = new string[6] {"Nguyễn", "Phan","Phạm","Hồng",
                    "Lê","Trần"};
                string[] holot = new string[6] {"Phương", "Trang thanh",
                    "Hoa","Thanh","Minh","Trúc"};
                string[] ten = new string[6] {"Minh", "Lan","Ngân","Mai",
                    "Lê","Châu"};
                //tao ngau nhien
                Random r = new Random();
                int day = 0;
                for(int i = 1; i <= 10; i++)
                {
                    Student s = new Student();
                    s.StudentID = i;
                    s.StudentName = ho[r.Next(6)] + " " + holot[r.Next(6)] +
                        " " + ten[r.Next(6)];
                    int year = r.Next(1990, 1999);
                    int month = r.Next(1, 12);
                    switch (month)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            day = r.Next(1, 31);
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            day = r.Next(1, 30);
                            break;
                        case 2:
                            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                                day = r.Next(1, 29);
                            else
                                day = r.Next(1, 28);
                            break;
                    }
                    s.BirthOfDate = new DateTime(year, month, day);
                    s.Address = "Address" + i;
                    s.Picture = "Pic" + i.ToString() + ".jpg";
                    lst.Add(s);
                }
            }
            else
            {
                lst = (List<Student>)Session["dssv"];
            }
            Session["dssv"] = lst;
            return View(lst);
        }
        //view create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {
            List<Student> lst = (List<Student>)Session["dssv"];
            if(s != null)
            {
                lst.Add(s);
                Session["dssv"] = lst;
                return RedirectToAction("Index");
            }
            return View(s);
        }
        //view edit
        public ActionResult Edit(int id)
        {
            List<Student> lstStudent = (List<Student>)Session["dssv"];

            Student s = lstStudent.Where(o => o.StudentID == id).FirstOrDefault();
            if (s == null)
                return HttpNotFound();
            return View(s);
        }
        [HttpPost]
        public ActionResult Edit (Student s)
        {
            List<Student> lstStudent = (List<Student>)Session["dssv"];
            if(s != null)
            {
                lstStudent[lstStudent.IndexOf(s)].StudentName = s.StudentName;
                lstStudent[lstStudent.IndexOf(s)].BirthOfDate = s.BirthOfDate;
                lstStudent[lstStudent.IndexOf(s)].Address = s.Address;
                lstStudent[lstStudent.IndexOf(s)].Picture = s.Picture;
                Session["dssv"] = lstStudent;
                return RedirectToAction("Index", lstStudent);
            }
            return View(s);
        }
        //view delete
        public ActionResult Delete(int id)
        {
            List<Student> lstStudent = (List<Student>)Session["dssv"];
            Student s = lstStudent.Where(o => o.StudentID == id).FirstOrDefault();
            if (s == null)
                return HttpNotFound();
            return View(s);
        }
        [HttpPost]
        public ActionResult DeleteConfirm(int id)
        {
            List<Student> lstStudent = (List<Student>)Session["dssv"];
            Student s = lstStudent.Where(o => o.StudentID == id).FirstOrDefault();
            lstStudent.Remove(s);
            Session["dssv"] = lstStudent;
            return RedirectToAction("Index");
        }
        //view details
        public ActionResult Details(int id)
        {
            List<Student> lstStudent = (List<Student>)Session["dssv"];
            Student s = lstStudent.Where(o => o.StudentID == id).FirstOrDefault();
            ViewBag.path = "../../Images/" + s.Picture;
            if (s == null)
                return HttpNotFound();
            return View(s);
        }
    }
}