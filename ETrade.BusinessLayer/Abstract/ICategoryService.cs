﻿using ETrade.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETrade.BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
