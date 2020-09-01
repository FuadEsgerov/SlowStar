using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class User:BaseEntity  
    { 


    [Required]
    [MaxLength(50)]
    public string Email { get; set; }

    [Required]
    [MaxLength(100)]
    public string Password { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    [Required]
    [MaxLength(50)]
    public string Surname { get; set; }


    [MaxLength(100)]
    public string Token { get; set; }

        
    }

}
