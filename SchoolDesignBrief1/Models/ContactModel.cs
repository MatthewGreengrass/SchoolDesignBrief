using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SchoolDesignBrief1.Models
{
    public record ContactModel : IContactModel
    {
        [Key]
        public int UserID { get; set; }

        //[Required, Display(Name = "Class")]
        //public ICollection<ClassModel> ClassValue { get; set; }

        //[Required, Display(Name = "Date Of Birth")]
        //public DateTime DateOfBirth { get; set; }

        //[Required, Range(1, 13), Display(Name = "Year Group")]
        //public int YearGroup { get; set; }

        [Required, Display(Name = "User Type")]
        public string UserTypeValue { get; set; }

        [Required, Display(Name = "School")]
        public string School { get; set; }

        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, Display(Name = "Email")]
        public string Email { get; set; }

        public bool HasSuccessMessage =>
            SuccessMessage is not null;

        public string SuccessMessage { get; init; }

        public static IEnumerable<SelectListItem> UserTypes { get; }
            = new List<SelectListItem> {
            new ("Please select a user type...", null, true, true),
            new ("Student", "Student"),
            new ("Teacher", "Teacher"),
        }.AsReadOnly();

        
    }
}
