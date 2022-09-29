using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPX.BookingSystem.Data;

namespace SchoolDesignBrief1.Models
{
    public class Database
    {
        private readonly IServiceScope _serviceScope;
        private readonly ApplicationDbContext _context;

        public Database(IServiceProvider serviceProvider)
        {
            _serviceScope = serviceProvider.GetService<IServiceScopeFactory>().CreateScope();
            _context = _serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
        }

        public Task<List<ContactModel>> GetContactDbSets()
        {
            return Task.FromResult(_context.ContactDbSets.ToList());
        }

        public void AddContactDbSet(ContactModel ContactModel)
        {
            _context.Add(ContactModel);
            _context.SaveChangesAsync();
        }

        public void AddClassDbSet(ClassModel ClassModel)
        {
            _context.Add(ClassModel);
            _context.SaveChangesAsync();
        }

        public void AddStudentClassDbSet(StudentClassModel StudentClassModel)
        {
            _context.Add(StudentClassModel);
            _context.SaveChangesAsync();
        }









        //private readonly List<object> records
        //    = new List<object>();

        //public void Save(object record)
        //{
        //    records.Add(record);
        //}

        //public IReadOnlyList<object> Results => records.AsReadOnly();
    }
}