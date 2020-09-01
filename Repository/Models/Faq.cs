using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public  class Faq:BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string Question { get; set; }
        [Required]
        [MaxLength(700)]
        public string Answer { get; set; }
    }
}
