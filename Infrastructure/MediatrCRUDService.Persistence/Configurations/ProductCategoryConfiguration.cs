using MediatrCRUDService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Persistence.Configurations
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.CategoryId });

            builder.HasOne(p => p.Product).WithMany(pc => pc.ProductCategories)
                .HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Cascade);


            builder.HasOne(c => c.Category).WithMany(pc => pc.ProductCategories)
                .HasForeignKey(c => c.CategoryId).OnDelete(DeleteBehavior.Cascade);

            ProductCategory productCategory1 = new()
            {
                ProductId = 1,
                CategoryId = 1
            };

            ProductCategory productCategory2 = new()
            {
                ProductId = 2,
                CategoryId = 2
            };

            ProductCategory productCategory3 = new()
            {
                ProductId = 3,
                CategoryId = 3
            };

            ProductCategory productCategory4 = new()
            {
                ProductId = 4,
                CategoryId = 4
            };

            ProductCategory productCategory5 = new()
            {
                ProductId = 5,
                CategoryId = 5
            };

            ProductCategory productCategory6 = new()
            {
                ProductId = 6,
                CategoryId = 6
            };

            ProductCategory productCategory7 = new()
            {
                ProductId = 7,
                CategoryId = 7
            };

            ProductCategory productCategory8 = new()
            {
                ProductId = 8,
                CategoryId = 8
            };

            ProductCategory productCategory9 = new()
            {
                ProductId = 9,
                CategoryId = 9
            };

            builder.HasData(productCategory1, productCategory2, productCategory3, productCategory4,
                productCategory5, productCategory6, productCategory7, productCategory8, productCategory9);
        }
    }
}
