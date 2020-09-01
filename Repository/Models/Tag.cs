using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class Tag :BaseEntity
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public Product Product { get; set; }
    }
}
