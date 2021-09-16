using Ecommerce_B2C_dotnet_FrontEnd.Areas.Constants;
using Ecommerce_B2C_dotnet_FrontEnd.Dto;
using Ecommerce_B2C_dotnet_FrontEnd.ServiceResults;
using Ecommerce_B2C_dotnet_FrontEnd.Services.ProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ecommerce_B2C_dotnet_FrontEnd.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : ApiController
    {
        ProductService _productService = new ProductService();

        [Route("~/api/Product/GetProducts")]
        [Authorize]
        [HttpGet]
        public ProductResults GetProducts(Int64 id)
        {
            var productResults = new ProductResults();
            try
            {
                if (id != 0)
                {
                    //var data = _productService.GetProduct(id);
                    productResults.productsdata = _productService.GetProduct(id);
                    productResults.IsError = false;
                    productResults.Message = Message.Success;
                   
                }
            }
            catch (Exception ex)
            {
                productResults.Message = ex.Message;
                productResults.IsError = true;
            }

            return productResults;
        }

    }
}
