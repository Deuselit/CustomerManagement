using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CustomerManagement.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string? CustomerName { get; set; }
        public string? CustomerFirstName { get; set; }
        public string? CustomerPhone { get; set; }
        public string? CustomerEmail { get; set; }

        public List<Address>? Address { get; set; }
    }
}