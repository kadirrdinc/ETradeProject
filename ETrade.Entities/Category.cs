﻿using ETrade.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETrade.Entities
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
