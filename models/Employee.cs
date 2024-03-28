using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace finalPOCService.models
{
    public class Employee
    {
        [Key]
        public int empid { get; set; }
        public string? empName { get; set; }
        public string? empDesig { get; set; }

        public int empPhoneNo { get; set; }
        public int empSal { get; set; }
    }
}