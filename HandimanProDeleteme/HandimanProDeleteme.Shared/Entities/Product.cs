﻿using System.ComponentModel.DataAnnotations;

namespace HandimanProDeleteme.Shared.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        public decimal Price { get; set; }
    }
}