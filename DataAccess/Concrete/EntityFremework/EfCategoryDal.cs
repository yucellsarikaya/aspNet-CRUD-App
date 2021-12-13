using Core.DataAccess.EntityFramawork;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFremework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFremework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}
