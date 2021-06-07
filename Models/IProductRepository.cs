using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyeShop.Models
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProduct { get; }
        public IEnumerable<Product> GetProductOnSale { get; }
        public Product GetProductById(int productId);
    }
}
