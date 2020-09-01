using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class DeliveryInformation:BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string Image { get; set; }
        [Required]
        [MaxLength(800)]
        public string Text { get; set; }

    }
}
