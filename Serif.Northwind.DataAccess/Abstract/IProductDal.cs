using Serif.Core.DataAccess;
using Serif.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Serif.Northwind.DataAccess.Abstract
{
   public interface IProductDal:IEntityRepository<Product>
    {
        //Custom Operations
    }
   
}
