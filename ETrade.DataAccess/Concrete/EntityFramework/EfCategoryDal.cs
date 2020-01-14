using ETrade.Core.DataAccess.EntityFramework;
using ETrade.DataAccess.Abstract;
using ETrade.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETrade.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, DatabaseContext>, ICategoryDAL
    {
    }
}
