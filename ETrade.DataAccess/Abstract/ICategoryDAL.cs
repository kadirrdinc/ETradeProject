﻿using ETrade.Core.DataAccess.EntityFramework;
using ETrade.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETrade.DataAccess.Abstract
{
    public interface ICategoryDAL : IEntityRepository<Category>
    {
    }
}
