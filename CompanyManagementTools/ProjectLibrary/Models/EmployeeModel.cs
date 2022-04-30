using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectLibrary.Models
{
    public class EmployeeModel
    {
        [Key]
        public int EmployeeId { get; set; }
        public int CompanyId { get; set; }
        public string EmpFirst { get; set; }
        public string EmpLast { get; set; }
        public int EmpSalary { get; set; }
        public DateTime EmpStart { get; set; }
    }
}
