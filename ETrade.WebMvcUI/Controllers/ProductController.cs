using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETrade.BusinessLayer.Abstract;
using ETrade.WebMvcUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.WebMvcUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            var result = _productService.GetAll();

            ProductListViewModel model = new ProductListViewModel
            {
                Products = result
            };

            return View(model);
        }
    }
}