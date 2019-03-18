using Serif.Core.DataAccess.EntityFramework;
using Serif.Northwind.DataAccess.Abstract;
using Serif.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Serif.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal :EfEntityRepsitoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}
