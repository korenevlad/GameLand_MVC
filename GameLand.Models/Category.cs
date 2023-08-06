using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLand.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [MaxLength(50)]
        [DisplayName("Category Code")]
        public string Code { get; set; }

        [DisplayName("Category Description")]
        public string Description { get; set; }
    }
}
