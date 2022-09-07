using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCenter.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DisplayName("Display order")]
        [Range(1, 10, ErrorMessage = "Wrong value. Please input integer from 1 to 10")]
        public int DisplayOrder { get; set; }
    }
}
