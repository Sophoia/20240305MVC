using _20240305.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20240305.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Student s1 = new Student() {
            Id = 411023057, 
            Name = "蕭亦真",
            Department = "資傳系"
            };

            ViewData["student"] = s1;
            return View();
        }
    }
}