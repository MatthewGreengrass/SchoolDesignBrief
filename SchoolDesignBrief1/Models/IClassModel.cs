using System;
using System.Collections.Generic;

namespace SchoolDesignBrief1.Models
{
    public interface IClassModel
    {
        //ICollection<ClassModel> Classes { get; }
        //DateTime DateOfBirth { get; }
        //int YearGroup { get; }

        //ICollection<ContactModel> ContactValue { get; }
        string ClassName { get; }
        string ClassDescription { get; }
    }
}