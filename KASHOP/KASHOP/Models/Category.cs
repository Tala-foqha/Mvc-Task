using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KASHOP.Models
{
    public class Category
    {
        public int Id { get; set; }


        [Column("varchar(50)")]
        [Required]  
        [MaxLength(50)]
        [MinLength(3)]

        public string Name { get; set; }
        [ValidateNever]
        public List<Product> Products { get; set; }
    }
}
