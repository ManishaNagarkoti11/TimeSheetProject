using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetProject.Models
{
    [Table("HourLogs")]
    public class HourLog:TimeSheet
    {
        public decimal TotalHours { get; set; }
        public DateTime DateTime { get; set; }
    }
}
