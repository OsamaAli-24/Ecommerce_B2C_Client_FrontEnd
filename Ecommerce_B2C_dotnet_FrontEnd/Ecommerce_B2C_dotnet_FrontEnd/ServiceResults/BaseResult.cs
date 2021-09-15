using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce_B2C_dotnet_FrontEnd.ServiceResults
{
    public class BaseResult
    {
        public bool IsError { get; set; }
        public string Message { get; set; }
    }
}