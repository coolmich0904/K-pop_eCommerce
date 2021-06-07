using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyeShop.Models;
using MyeShop.ViewModel;

namespace MyeShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        // Injection
        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            // ViewBag.CurrentCategory = "Bestsellers";
            // return View(_productRepository.GetAllProduct);

            var productListViewModel = new ProductListViewModel();
            productListViewModel.Products = _productRepository.GetAllProduct;
            productListViewModel.CurrentCategory = "Bestsellers";
            return View(productListViewModel);
        }

    }
}
