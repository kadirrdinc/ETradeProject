using ETrade.BusinessLayer.Abstract;
using ETrade.DataAccess.Abstract;
using ETrade.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETrade.BusinessLayer.Concrete
{
   public class CategoryManager : ICategoryService
    {
        private ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public List<Category> GetAll()
        {
            return _categoryDAL.GetList();
        }
    }
}
