using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CustomerManagement.Models
{
    public class Address
    {
        public int AddressId { get; set; }

        public string? Country { get; set; }
        public string? Region { get; set; }
        public string? ZipCode { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public string? EmployeeFullName { get; set; }

        public int CustomerId { get; set; }

        public int? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}