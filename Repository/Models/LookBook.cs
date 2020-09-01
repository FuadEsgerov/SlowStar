using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
   public class LookBook:BaseEntity
    {
        public ICollection<LookBookPhoto> Photos { get; set; }
    }
}
