using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {


            //İş kodları
            // kural bir iş sınıfı baska bir sınıfı new'lememeli
            //InMemoryProductDal ınMemoryProductDal = new InMemoryProductDal(); // hata, bağımlılık olur...

            // bu sekilde IProductDal implemente etmiş tüm class'lar 
            return _productDal.GetAll();
        }
    }
}
