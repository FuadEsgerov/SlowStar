using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Basket : BaseEntity
    {
        [Required]
        public string Token { get; set; }
        
        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Count { get; set; }

        public Product Product { get; set; }
    }
}
