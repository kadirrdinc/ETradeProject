using ETrade.BusinessLayer.Abstract;
using ETrade.WebMvcUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.WebMvcUI.ViewComponents
{
    public class CategoryListViewComponent : ViewComponent
    {
        private ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ViewViewComponentResult Invoke()
        {
            var categoryList = _categoryService.GetAll();

            CategoryListViewModel model = new CategoryListViewModel()
            {
                Categories = categoryList
            };
            return View(model);
        }
    }
}
