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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Product product1 = new()
            {
                Id = 1,
                BrandId = 1,
                Title = "Galaxy S24 Ultra",
                Description = "Kullanıcı dostu kullanım özelliğiyle dikkatleri üzerine çeken Samsung Galaxy S24 Ultra 256 GB 12 GB Ram Kumtaşı tasarımıyla da adından sıklıkla söz ettiriyor.",
                Price = 58999.99
            };

            Product product2 = new()
            {
                Id = 2,
                BrandId = 2,
                Title = "Baskılı Siyah Tişört",
                Description = "Mavi Nin Erkek Koleksiyonundan Baskılı Siyah Tişört. Loose Fit / Bol Rahat Kesim Kısa Kol",
                Price = 369.99
            };
            
            Product product3 = new()
            {
                Id = 3,
                BrandId = 3,
                Title = "Lifalif Kuru Meyveli Yulaf Bar",
                Description = "Şeker ilavesiz. Doğal lif kaynağı.",
                Price = 17.50            
            };

            builder.HasData(product1, product2, product3);
        }
    }
}
