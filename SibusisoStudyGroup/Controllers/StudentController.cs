﻿using SibusisoStudyGroup.Models;
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

            students.Add(new Models.Student { studentNumber = "u22699032", Name = "Sibusiso", Surname = "Makhoba", emailAddress = "u22699032@tuks.co.za", myLink = "Person1.html" });
            students.Add(new Models.Student { studentNumber = "u11111111", Name = "Graham", Surname = "Potter", emailAddress = "GP@chelsea.com", myLink = "Person2.html" });
            students.Add(new Models.Student { studentNumber = "u22222222", Name = "Mason", Surname = "Mount", emailAddress = "MM@chelsea.com", myLink = "Person3.html" });
            students.Add(new Models.Student { studentNumber = "u33333333", Name = "Reece", Surname = "James", emailAddress = "RJ@chelsea.com", myLink = "Person4.html" });
            students.Add(new Models.Student { studentNumber = "u44444444", Name = "Thiago", Surname = "Silva", emailAddress = "TS@chelsea.com", myLink = "Person5.html" });

            return View(students);
        }
    }
}