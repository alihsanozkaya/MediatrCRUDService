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
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(100);

            Brand brand1 = new()
            {
                Id = 1,
                Name = "Samsung"
            };

            Brand brand2 = new()
            {
                Id = 2,
                Name = "Mavi"
            };

            Brand brand3 = new()
            {
                Id = 3,
                Name = "Eti"
            };

            builder.HasData(brand1, brand2, brand3);
        }
    }
}
