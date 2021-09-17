using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ecommerce_B2C_dotnet_FrontEnd.Models;

namespace Ecommerce_B2C_dotnet_FrontEnd.ServiceResults
{
    public class EditAccountResults : BaseResult
    {
        public IList<Accounts> accountsdata { get; set; }
    }
}