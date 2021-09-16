using Ecommerce_B2C_dotnet_FrontEnd.Models;
using Ecommerce_B2C_dotnet_FrontEnd.ServiceResults;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ecommerce_B2C_dotnet_FrontEnd.Services.ProductService
{
    public class ProductService : IProductService
    {
        EcommerceContext _EcommerceContext = new EcommerceContext();

        public IList<Products> GetProduct(long Id)
        {
            //ProductResults
            return _EcommerceContext.Products.Where(x => x.UserId == Id  /*&& x.IsActive== true*/).ToList();
           
            
        }
    }
}