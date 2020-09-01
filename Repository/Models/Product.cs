using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
    public class Product : BaseEntity
    {
        public int SubCategoryId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string SKU { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        [Column(TypeName="ntext")]
        public string Text { get; set; }

        [Required]
        public decimal Price { get; set; }

        public int? LabelId { get; set; }

        [Required]
        public bool IsTopSelling { get; set; }

        [Required]
        public bool IsFeatured { get; set; }

        public double StarCount { get; set; }

        public SubCategory SubCategory { get; set; }
        public Label Label { get; set; }
        public ICollection<ProductPhoto> Photos { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public ICollection<ProductReview> Reviews { get; set; }
        public ICollection<ProductOption> Options { get; set; }
        public ICollection<ProductDiscount> Discounts { get; set; }
        public ICollection<ProductSpec> ProductSpecs { get; set; }
        public ICollection<Favorite> Favorites { get; set; }
        public ICollection<Basket> Baskets { get; set; }
    }
}
