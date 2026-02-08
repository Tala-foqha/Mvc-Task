using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace KASHOP.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(50)]

            
        public string Name { get; set; }

        public string Description { get; set; }
        [Range(0, 10000)]
        public decimal Price { get; set; }

        public double Rate { get; set; }

        public string? Image { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [ValidateNever]
        public Category Category { get; set; }

    }
}
