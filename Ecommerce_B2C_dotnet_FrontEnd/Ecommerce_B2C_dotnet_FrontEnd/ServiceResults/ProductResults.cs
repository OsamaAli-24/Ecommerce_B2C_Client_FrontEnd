using Ecommerce_B2C_dotnet_FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce_B2C_dotnet_FrontEnd.ServiceResults
{
    public class ProductResults : BaseResult
    { 
        public IList<Products> productsdata { get; set; }
    }
}