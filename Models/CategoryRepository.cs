using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyeShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories => new List<Category>
            {
                new Category{CategoryId=1, CategoryName="BTS Shop", CategoryDescription="ARMY and BTS"},
                new Category{CategoryId=2, CategoryName="EXO Shop", CategoryDescription="ACE and EXO"},
                new Category{CategoryId=3, CategoryName="BlackPink Shop", CategoryDescription="BLINK and BlackPink"},
                new Category{CategoryId=4, CategoryName="MonstaX Shop", CategoryDescription="MONBEBE and MonstaX"},
                new Category{CategoryId=5, CategoryName="Twice Shop", CategoryDescription="ONCE and Twice"}
            };
    }
}
