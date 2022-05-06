﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class SaleStatus
    {
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }



        // Koppling
        public ICollection<Property> Properties { get; set; } = new List<Property>();
    }
}
