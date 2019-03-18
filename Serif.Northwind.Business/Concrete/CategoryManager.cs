using Serif.Northwind.Business.Abstract;
using Serif.Northwind.DataAccess.Abstract;
using Serif.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Serif.Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
