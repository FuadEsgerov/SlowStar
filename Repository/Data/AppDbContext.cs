using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<About> Abouts { get; set; }
        public DbSet<OurTeam> OurTeams { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<DeliveryInformation> DeliveryInformations { get; set; }
        public DbSet<LookBook> LookBooks { get; set; }
        public DbSet<LookBookPhoto> LookBookPhotos { get; set; }
        public DbSet<PrivacyPolicy> PrivacyPolicies { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDiscount> ProductDiscounts { get; set; }
        public DbSet<ProductOption> ProductOptions { get; set; }
        public DbSet<ProductOptionItem> ProductOptionItems { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
        public DbSet<ProductSpec> ProductSpecs { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<ShopCollection> ShopCollections { get; set; }
        public DbSet<SliderItem> SliderItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
