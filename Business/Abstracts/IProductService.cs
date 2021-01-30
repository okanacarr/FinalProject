using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    interface IProductService
    {
        List<Product> GetAll();
    }
}
