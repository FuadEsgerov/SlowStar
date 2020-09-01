using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
  public  class About :BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        public string Ceo { get; set; }

        [Required]
        [MaxLength(200)]
        public string TextTitle { get; set; }

        [Required]
        [MaxLength(500)]
        public string Text { get; set; }

        [Required]
        [MaxLength(500)]
        public string FirstImage { get; set; }

        [Required]
        [MaxLength(500)]
        public string SecondImage { get; set; }
    }
}
