using System;
using System.Collections.Generic;

namespace SchoolDesignBrief1.Models
{
    public interface IContactModel
    {
        //ICollection<ClassModel> ClassValue { get; }
        //DateTime DateOfBirth { get; }
        //int YearGroup { get; }
        string UserTypeValue { get; }
        string School { get; }
        string FirstName { get; }
        string Email { get; }
        bool HasSuccessMessage { get; }
        string SuccessMessage { get; }

        //ICollection<ContactModel> Contact { get; }
        //string ClassName { get; }
        //string ClassDescription { get; }
    }
}