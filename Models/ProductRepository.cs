using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyeShop.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
        public IEnumerable<Product> GetAllProduct => new List<Product>
        {
            new Product {ProductId=1, Name="Shoes", Price=38.00M, Description="BANGTAN BOYS BTS JUNGKOOK JIMIN JIN V SUGA HIGH CANVAS SHOES", Category=_categoryRepository.GetAllCategories.ToList()[0], ImageUrl="./Images/Shoes1.jpg", IsInStock=true, IsOnSale=true, ImageThumbnailUrl="./Images/Thumnails/TH_Shoes1.jpg" },

            new Product{ProductId=2, Name="Hoodies", Price=12.00M, Description="Boys and Girls Hoodies Sweatshirt Tops Pullovers Kpop Fans Clothes Oversized Solid Cotton Harajuku Kawaii Tops", Category=_categoryRepository.GetAllCategories.ToList()[1], ImageUrl="./Images/Hoodies1.jpg", IsInStock=true, IsOnSale=true, ImageThumbnailUrl="./Images/Thumnails/TH_Hoodies1.jpg"  },

            new Product{ProductId=3, Name="Pants", Price=98.00M, Description="Dance pracetice trousers / Elastic waustband and several pockets/ Unisex, cool and comfortable style/ Color: Black", Category=_categoryRepository.GetAllCategories.ToList()[2], ImageUrl="./Images/Pants1.jpg", IsInStock=true, IsOnSale=true, ImageThumbnailUrl="./Images/Thumnails/TH_Pants1.jpg" },

            new Product{ProductId=4, Name="Accesorries", Price=28.00M, Description="Kpop 12 stars birthday Ring Necklace Titanium steel/ The Ring would be packed in the gift box", Category=_categoryRepository.GetAllCategories.ToList()[3], ImageUrl="./Images/Acc1.jpg", IsInStock=true, IsOnSale=false, ImageThumbnailUrl="./Images/Thumnails/TH_Acc1.jpg" },

            new Product{ProductId=5, Name="Stationeries", Price=35.00M, Description="Kpop stars stationery for the fan club/ The item would be packed in the gift box", Category=_categoryRepository.GetAllCategories.ToList()[4], ImageUrl="./Images/Stationery1.jpg", IsInStock=true, IsOnSale=false, ImageThumbnailUrl="./Images/Thumnails/TH_Stationery1.jpg" }
        };
        public IEnumerable<Product> GetProductOnSale => throw new NotImplementedException();
        public Product GetProductById(int productId) 
        {
            return GetAllProduct.FirstOrDefault(c => c.ProductId == productId);
        }
    }
}
