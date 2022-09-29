using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SchoolDesignBrief1.Models
{
    public record StudentClassModel
    {
        //[Key]
        //public int UserID { get; set; }

        //public ContactModel User { get; set; }

        //[ForeignKey("Class")]
        //public int ClassID { get; set; }

        //public ClassModel Class { get; set; }

        //[Required, Display(Name = "Date Of Birth")]
        //public DateTime DateOfBirth { get; set; }

        //[Required, Range(1, 13), Display(Name = "Year Group")]
        //public int YearGroup { get; set; }

        //[Required, Display(Name = "Class Name")]
        //public string ClassName { get; set; }

        //[Required, Display(Name = "Class Description")]
        //public string ClassDescription { get; set; }

        //public static IEnumerable<SelectListItem> UserTypes { get; }
        //    = new List<SelectListItem> {
        //    new ("Please select a user type...", null, true, true),
        //    new ("Student", "Student"),
        //    new ("Teacher", "Teacher"),
        //}.AsReadOnly();
    }
}
