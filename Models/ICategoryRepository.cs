using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyeShop.Models
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories { get; }

    }
}
