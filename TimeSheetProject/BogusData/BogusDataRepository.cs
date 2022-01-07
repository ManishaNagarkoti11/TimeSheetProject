using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheetProject.Data;
using TimeSheetProject.Models;

namespace TimeSheetProject.BogusData
{
    public class BogusDataRepository : IBogusDataRepository
    {
        private readonly ApplicationDbContext _context;
        public BogusDataRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool FakeData()
        {
            try
            {
                var data = _context.Employees.Count();
                if (data == 0)
                {
                    var fakeEmployee = new Faker<Employee>()
               .RuleFor(e => e.FirstName, f => f.Person.FirstName)
               .RuleFor(e => e.LastName, f => f.Person.LastName);
                    var Employees = fakeEmployee.Generate(20);
                    _context.Employees.AddRange(Employees);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
