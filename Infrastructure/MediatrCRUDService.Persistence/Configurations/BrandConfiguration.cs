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
            builder.Property(x => x.Name).HasMaxLength(200);

            Brand brand1 = new()
            {
                Id = 1,
                Name = "Samsung"
            };

            Brand brand2 = new()
            {
                Id = 2,
                Name = "Apple"
            };

            Brand brand3 = new()
            {
                Id = 3,
                Name = "Asus"
            };

            Brand brand4 = new()
            {
                Id = 4,
                Name = "Mavi"
            };

            Brand brand5 = new()
            {
                Id = 5,
                Name = "Koton"
            };

            Brand brand6 = new()
            {
                Id = 6,
                Name = "Zara"
            };
            Brand brand7 = new()
            {
                Id = 7,
                Name = "Karaca"
            };

            Brand brand8 = new()
            {
                Id = 8,
                Name = "Yataş"
            };

            Brand brand9 = new()
            {
                Id = 9,
                Name = "English Home"
            };

            Brand brand10 = new()
            {
                Id = 10,
                Name = "Bürotime"
            };

            Brand brand11 = new()
            {
                Id = 11,
                Name = "Bürosit"
            }; 
            
            Brand brand12 = new()
            {
                Id = 12,
                Name = "Adidas"
            };

            Brand brand13 = new()
            {
                Id = 13,
                Name = "Nike"
            };

            Brand brand14 = new()
            {
                Id = 14,
                Name = "Decathlon"
            };

            Brand brand15 = new()
            {
                Id = 15,
                Name = "LEGO"
            };

            Brand brand16 = new()
            {
                Id = 16,
                Name = "Hot Wheels"
            };

            Brand brand17 = new()
            {
                Id = 17,
                Name = "Faber Castell"
            };
            Brand brand18 = new()
            {
                Id = 18,
                Name = "Gıpta"
            };

            Brand brand19 = new()
            {
                Id = 19,
                Name = "Scrikss"
            };

            Brand brand20 = new()
            {
                Id = 20,
                Name = "Avon"
            };

            Brand brand21 = new()
            {
                Id = 21,
                Name = "Yves Rocher"
            };

            Brand brand22 = new()
            {
                Id = 22,
                Name = "Nivea"
            };

            Brand brand23 = new()
            {
                Id = 23,
                Name = "Eti"
            };

            Brand brand24 = new()
            {
                Id = 24,
                Name = "Sütaş"
            };

            Brand brand25 = new()
            {
                Id = 25,
                Name = "Çaykur"
            };

            builder.HasData(brand1, brand2, brand3, brand4, brand5, 
                brand6, brand7, brand8, brand9, brand10,
                brand11, brand12, brand13, brand14, brand15,
                brand16, brand17, brand18, brand19, brand20,
                brand21, brand22, brand23, brand24, brand25);
        }
    }
}
