﻿using Serif.Northwind.Business.Abstract;
using Serif.Northwind.DataAccess.Abstract;
using Serif.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Serif.Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {

        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
             _productDal.Add(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(new Product { ProductId=productId});
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p=>p.CategoryId==categoryId);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
