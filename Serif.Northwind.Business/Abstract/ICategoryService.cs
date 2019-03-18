using Serif.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Serif.Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
     
    }
}
