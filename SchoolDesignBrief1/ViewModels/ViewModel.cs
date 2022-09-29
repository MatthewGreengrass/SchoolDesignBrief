using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolDesignBrief1.Models;

namespace SchoolDesignBrief1.ViewModels
{
    public record ViewModel
    {
        public IEnumerable<ClassModel> Classes { get; set; }
        public IEnumerable<ContactModel> Contacts { get; set; }
    }
}
