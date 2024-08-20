using MediatrCRUDService.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Domain.Entities
{
    public class Category : EntityBase
    {
        public Category()
        {
            
        }
        public Category(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
