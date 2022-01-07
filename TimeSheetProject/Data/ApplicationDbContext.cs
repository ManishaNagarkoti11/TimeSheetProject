using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheetProject.Models;

namespace TimeSheetProject.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<TimeSheet> TimeSheets { get; set; }
        public DbSet<HourLog> HourLogs { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}
