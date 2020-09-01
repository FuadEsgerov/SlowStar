using Repository.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class Address
    {
        [Required]
        public CountryListing Country { get; set; }

        [Required]
        [MaxLength(100)]
        public string StreetAddress { get; set; }
        [Required]
        [MaxLength(100)]

        public string City { get; set; }
        [Required]
        [MaxLength(100)]
        public string State { get; set; }
        [Required]
        [MaxLength(100)]
        public string PostalCode { get; set; }
    }
}
