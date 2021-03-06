﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal
        : EfEntityRepositoryBase<Category, NorthwindContext>
        , ICategoryDal
    {
        public Category Get(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
