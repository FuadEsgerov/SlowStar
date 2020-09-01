using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class ProductPhoto : BaseEntity
    {
        public int OrderBy { get; set; }

        public int ProductId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Image { get; set; }

        public Product Product { get; set; }
    }
}
