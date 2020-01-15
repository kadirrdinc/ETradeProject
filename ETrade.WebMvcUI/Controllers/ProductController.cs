using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETrade.BusinessLayer.Abstract;
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

        public IActionResult Index()
        {
            _productService.GetAll();
        }
    }
}