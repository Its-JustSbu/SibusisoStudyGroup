using SibusisoStudyGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SibusisoStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Models.Student> students = new List<Models.Student>();

            students.Add(new Models.Student { studentNumber = "u22699032", Name = "Sibusiso", Surname = "Makhoba", emailAddress = "u22699032@tuks.co.za"});
            students.Add(new Models.Student { studentNumber = "", Name = "", Surname = "", emailAddress = "" });

            return View(students);
        }
    }
}