using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLand.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Product Name")]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Product Article")]
        public string Article { get; set; }

        [Required]
        [DisplayName("Product Description")]
        public string Description { get; set; }

        [Required]
        [DisplayName("Product Price")]
        [Range(1,500000)]
        public double Price { get; set; }


        [Range(0, 500000)]
        [DisplayName("Product Old Price")]
        [ValidateNever]
        public double OldPrice { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category_of_product { get; set; }

        [ValidateNever]
        public string ImageURL { get; set; }
    }
}
