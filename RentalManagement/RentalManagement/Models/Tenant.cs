using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RentalManagement.Models
{
    public class Tenant
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Balance { get; set; }
        [ForeignKey("Apartment")]
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }

    }
}