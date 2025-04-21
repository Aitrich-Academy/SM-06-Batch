﻿using System.ComponentModel.DataAnnotations;

namespace Product_Crud_ebAPI.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? ProductName { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public int Price { get; set; }
        

    }
}
