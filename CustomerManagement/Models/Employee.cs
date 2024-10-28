using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CustomerManagement.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string? EmployeeName { get; set; }
        public string? EmployeeFirstName { get; set; }
        public string? EmployeePhone { get; set; }
        public string? EmployeeEmail { get; set; }

        public string EmployeeFullName => $"{EmployeeFirstName} {EmployeeName}";
    }
}