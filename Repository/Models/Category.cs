using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Category : BaseEntity
    {
        [Required]
        public int DepartmentId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

     
        [MaxLength(100)]
        public string CoverImage { get; set; }
        public Department Department { get; set; }
    }
}
