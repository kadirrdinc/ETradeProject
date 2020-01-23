using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETrade.BusinessLayer.Abstract;
using ETrade.WebMvcUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.WebMvcUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;

        public HomeController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var products = _productService.GetAll();
            var categories = _categoryService.GetAll();
            ProductListViewModel model = new ProductListViewModel()
            {
                Products = products,
                Categories=categories
            };

            return View(model);
        }
    }
}