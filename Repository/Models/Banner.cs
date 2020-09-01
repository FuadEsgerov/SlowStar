using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class Banner :BaseEntity
    {
        public int OrderBy { get; set; }
        [Required]
        [MaxLength(100)]
        public string Image { get; set; }
        [Required]
        [MaxLength(100)]
        public string EndPoint { get; set; }
    }
}
