using Microsoft.EntityFrameworkCore;
using SchoolDesignBrief1.Models;
using System;

namespace TPX.BookingSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ContactModel> ContactDbSets { get; set; }

        public DbSet<ClassModel> ClassDbSets { get; set; }

        //public DbSet<StudentClassModel> StudentDbSets { get; set; }
    }
}