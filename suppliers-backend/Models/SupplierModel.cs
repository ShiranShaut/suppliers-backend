using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace suppliers_backend.Models
{
    public class SupplierModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string City { get; set; }
        
        [Required]
        public string State { get; set; }

        public string Recommendations { get; set; }

        public string Count { get; set; }
    }
}