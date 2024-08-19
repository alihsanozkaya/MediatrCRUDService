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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category1 = new()
            {
                Id = 1,
                Name = "Elektronik"
            };

            Category category2 = new()
            {
                Id = 2,
                Name = "Giyim"
            };

            Category category3 = new()
            {
                Id = 3,
                Name = "Yiyecek"
            };

            builder.HasData(category1, category2, category3);
        }
    }
}
