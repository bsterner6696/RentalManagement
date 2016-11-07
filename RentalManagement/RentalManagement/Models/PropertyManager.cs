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
    }
}