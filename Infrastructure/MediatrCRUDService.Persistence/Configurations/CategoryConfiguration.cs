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
                Name = "Moda"
            };

            Category category3 = new()
            {
                Id = 3,
                Name = "Ev"
            };

            Category category4 = new()
            {
                Id = 4,
                Name = "Ofis"
            };

            Category category5 = new()
            {
                Id = 5,
                Name = "Spor"
            };

            Category category6 = new()
            {
                Id = 6,
                Name = "Oyuncak"
            };

            Category category7 = new()
            {
                Id = 7,
                Name = "Kırtasiye"
            };

            Category category8 = new()
            {
                Id = 8,
                Name = "Kozmetik"
            };

            Category category9 = new()
            {
                Id = 9,
                Name = "Gıda"
            };

            builder.HasData(category1, category2, category3, category4, category5,
                category6, category7, category8, category9);
        }
    }
}
