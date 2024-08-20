using MediatrCRUDService.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Categories.Exceptions
{
    public class CategoryNameMustNotBeSameException : BaseExceptions
    {
        public CategoryNameMustNotBeSameException() : base("Kategori adı mevcut!")
        {

        }
    }
}
