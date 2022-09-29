using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SchoolDesignBrief1.Models
{
    public record ClassModel : IClassModel
    {
        [Key]
        public int ClassID { get; set; }

        //[Required, Display(Name = "Contact")]
        //public ICollection<ContactModel> ContactValue { get; set; }

        //[Required, Display(Name = "Date Of Birth")]
        //public DateTime DateOfBirth { get; set; }

        //[Required, Range(1, 13), Display(Name = "Year Group")]
        //public int YearGroup { get; set; }

        [Required, Display(Name = "Class Name")]
        public string ClassName { get; set; }

        [Required, Display(Name = "Class Description")]
        public string ClassDescription { get; set; }

        public bool HasSuccessMessage =>
            SuccessMessage is not null;

        public string SuccessMessage { get; init; }

        public static IEnumerable<SelectListItem> Classes { get; }
            = new List<SelectListItem> {
            new ("Please select a class...", null, true, true),
            new ("Class1", "Class1"),
            new ("Class2", "Class2"),
        }.AsReadOnly();
    }
}
