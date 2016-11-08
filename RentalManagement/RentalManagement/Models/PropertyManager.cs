using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentalManagement.Models
{
    public class PropertyManager
    {
        [Key]
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public int PhoneNumber { get; set; }
        [Display(Name = "Property Manager Name")]
        public string Name { get; set; }
    }
}