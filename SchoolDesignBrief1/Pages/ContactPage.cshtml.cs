using System.ComponentModel.DataAnnotations;
using SchoolDesignBrief1.Models;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace SchoolDesignBrief1.Pages
{
    public class ContactPage : PageModel, IContactModel, IClassModel
    {
        private readonly ILogger<ContactPage> logger;

        public ContactPage(ILogger<ContactPage> logger)
        {
            this.logger = logger;
        }
        
        [UsedImplicitly]
        public IActionResult OnPost([FromServices] Database database)
        {
            if (ModelState.IsValid)
            {
                ContactModel ContactModel = new()
                {
                    FirstName = FirstName,
                    Email = Email,
                    UserTypeValue = UserTypeValue,
                    School = School,
                };

                ClassModel ClassModel = new()
                {
                    ClassName = ClassName,
                    ClassDescription = ClassDescription,
                };

                database.AddClassDbSet(ClassModel);
                System.Threading.Thread.Sleep(1000);
                database.AddContactDbSet(ContactModel);

                SuccessMessage = "Thank you for contacting us!";

                logger.LogInformation("Contact message submitted: {Message}", ContactModel);

                return RedirectToPage(nameof(ContactPage));
            }
            return Page();
        }

        [BindProperty, Required, Display(Name = "Class")]
        public ICollection<ClassModel> ClassValue { get; init; }
        [BindProperty, Required, Display(Name = "First Name")]
        public string FirstName { get; init; }
        [BindProperty, Required, Display(Name = "User Type")]
        public string Email { get; init; }
        [BindProperty, Required, Display(Name = "Email")]
        public string UserTypeValue { get; init; }
        [BindProperty, Required, Display(Name = "School")]
        public string School { get; init; }


        //[BindProperty, Required, Display(Name = "Contact")]
        //public ICollection<ContactModel> ContactValue { get; set; }

        [BindProperty, Required, Display(Name = "Class Name")]
        public string ClassName { get; set; }

        [BindProperty, Required, Display(Name = "Class Description")]
        public string ClassDescription { get; set; }





        public bool HasSuccessMessage => SuccessMessage is not null;
        
        [TempData]
        public string SuccessMessage { get; set; }
    }
}