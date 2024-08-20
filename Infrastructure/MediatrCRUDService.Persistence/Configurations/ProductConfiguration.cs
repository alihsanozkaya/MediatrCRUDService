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
                BrandId = 4,
                Title = "Barcelona Kolej Buz Mavi Jean Pantolon",
                Description = "Mavi Nin Denim Koleksiyonundan Barcelona Kolej Buz Mavi Jean Pantolon",
                Price = 699.99
            };

            Product product3 = new()
            {
                Id = 3,
                BrandId = 9,
                Title = "Floral Slice Tek Kişilik Pike Takımı Yeşil",
                Description = "Floral Slice Pike Takımı 150x220 cm Yeşil",
                Price = 849.99
            };
            
            Product product4 = new()
            {
                Id = 4,
                BrandId = 10,
                Title = "Comfy Başlıklı Çalışma Koltuğu",
                Description = "Çalışma koltuğu",
                Price = 6776
            };
            
            Product product5 = new()
            {
                Id = 5,
                BrandId = 12,
                Title = "Tango Rosario El Dikişli Fifa Onaylı Deri Futbol Topu",
                Description = "BENZERSİZ BİR GEÇMİŞE SAHİP, EL DİKİŞLİ FUTBOL TOPU",
                Price = 819
            };
            
            Product product6 = new()
            {
                Id = 6,
                BrandId = 16,
                Title = "Fast & Furious Volkswagen Jetta",
                Description = "Hot Wheels Fast & Furious Volkswagen Jetta MK3 HRW44",
                Price = 259.50
            };
            
            Product product7 = new()
            {
                Id = 7,
                BrandId = 17,
                Title = "2022 Grip 1347 Versatil Kalem",
                Description = "2022 Grip 1347 Versatil Kalem 0.7 mm Petrol Yeşili",
                Price = 260
            };
            
            Product product8 = new()
            {
                Id = 8,
                BrandId = 21,
                Title = "Karma Ve Yağlı Ciltler Için Pure Menthe Prebiyotik Yüz Yıkama Jeli-390 ml",
                Description = "Gözenekleri derinlemesine arındıran yüz yıkama jeli, ferahlık veren organik nane ve jel dokusu sayesinde cildi kurutmadan temizler ve gözenekleri kirden arındırır.",
                Price = 450
            };

            Product product9 = new()
            {
                Id = 9,
                BrandId = 23,
                Title = "Lifalif Kuru Meyveli Yulaf Bar",
                Description = "Şeker ilavesiz. Doğal lif kaynağı.",
                Price = 17.50            
            };

            builder.HasData(product1, product2, product3, product4,
                product5, product6, product7, product8, product9);
        }
    }
}
