using Ecommerce_B2C_dotnet_FrontEnd.Dto;
using Ecommerce_B2C_dotnet_FrontEnd.Models;
using Ecommerce_B2C_dotnet_FrontEnd.ServiceResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_B2C_dotnet_FrontEnd.Services.ProductService
{
    public interface IProductService
    {
        IList<Products> GetProduct(Int64 Id);
        bool UpdateProduct(ProductDto param);
        bool AddProduct(Products param);
        bool DeleteProduct(DeleleteProductDto param);
    }
}
