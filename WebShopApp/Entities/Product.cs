using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopApp.Entities
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public string TypeOfProduct { get; set; }

        [Required]
        [Range(0.00, 100000)]
        public int NumberInStock { get; set; }

        public string ImageUrl { get; set; }

        [MaxLength(150)]
        public string Description { get; set; }
    }
}
