using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class LookBookPhoto:BaseEntity
    {
        public int LookBookId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Image { get; set; }

        public LookBook ProLookBookduct { get; set; }
    }
}
