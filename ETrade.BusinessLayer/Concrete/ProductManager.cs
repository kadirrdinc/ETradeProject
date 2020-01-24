using ETrade.BusinessLayer.Abstract;
using ETrade.DataAccess.Abstract;
using ETrade.DataAccess.Concrete.EntityFramework;
using ETrade.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETrade.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public void Add(Product product)
        {
            _productDAL.Add(product);
        }

        public void Delete(int productId)
        {
            _productDAL.Delete(new Product { ProductId = productId });
        }

        public List<Product> GetAll()
        {
            return _productDAL.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDAL.GetList(c => c.CategoryId == categoryId || categoryId == 0);
        }

        public void Update(Product product)
        {
            _productDAL.Update(product);
        }
    }
}
