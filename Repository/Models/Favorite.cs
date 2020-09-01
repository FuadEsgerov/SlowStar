using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class Favorite : BaseEntity
    {
        public int ProductId { get; set; }

        public int UserId { get; set; }

        public Product Product { get; set; }

        public User User { get; set; }
    }
}
