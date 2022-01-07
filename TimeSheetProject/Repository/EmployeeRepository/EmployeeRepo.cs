using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheetProject.BogusData;
using TimeSheetProject.Data;
using TimeSheetProject.Models;

namespace TimeSheetProject.Repository.EmployeeRepository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly IBogusDataRepository bogusData;
        public EmployeeRepo(ApplicationDbContext context, IBogusDataRepository bogusData)
        {
            _context = context;
            this.bogusData = bogusData;
        }
        public void AddData(Employee employee)
        {
            bogusData.FakeData();
        }
        public List<Employee> GetData()
        {
            var result = _context.Employees.ToList();
            return result;
        }
    }
}
