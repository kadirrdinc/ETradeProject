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
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index(int page = 1, int category = 0)
        {
            int pageSize = 10;
            var products = _productService.GetByCategory(category);
            ProductListViewModel model = new ProductListViewModel()
            {
                Products = products.Skip((page - 1) * pageSize).Take(pageSize).ToList()
            };

            return View(model);
        }
    }
}