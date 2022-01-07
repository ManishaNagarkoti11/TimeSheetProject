using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheetProject.Models;

namespace TimeSheetProject.Repository.EmployeeRepository
{
    public interface IEmployeeRepo
    {
        void AddData(Employee employee);
        List<Employee> GetData();

    }
}
