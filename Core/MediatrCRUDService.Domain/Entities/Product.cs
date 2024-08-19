using MediatrCRUDService.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Domain.Entities
{
    public class Product : EntityBase
    {
        public Product()
        {
            
        }
        public Product(string title, string description, int brandId, double price)
        {
            Title = title;
            Description = description;
            BrandId = brandId;
            Price = price;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
