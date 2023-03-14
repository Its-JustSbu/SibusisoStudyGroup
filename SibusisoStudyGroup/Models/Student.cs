using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SibusisoStudyGroup.Models
{
    public class Student
    {
        [Display(Name = "Student Number")]
        public string studentNumber { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Surname")]
        public string Surname { get; set; }
        [Display(Name = "Email Address")]
        public string emailAddress { get; set; }
        [Display(Name = "Link to Personal Page")]
        public string Link { get; set; }
    }
}