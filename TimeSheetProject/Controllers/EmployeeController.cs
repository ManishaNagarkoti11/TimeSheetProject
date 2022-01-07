using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheetProject.BogusData;
using TimeSheetProject.Models;
using TimeSheetProject.Repository.EmployeeRepository;

namespace TimeSheetProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepo employeeRepo;
        public EmployeeController( IEmployeeRepo employeeRepo)
        {
            this.employeeRepo = employeeRepo;
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult AddEmployee(Employee employee)
        {
            employeeRepo.AddData(employee);
            return Ok();
        }

        [HttpGet]
        [Route("Show")]
        public IActionResult ShowEmployee()
        {
            var result =employeeRepo.GetData();
            return Ok(result);
        }

    }
}
