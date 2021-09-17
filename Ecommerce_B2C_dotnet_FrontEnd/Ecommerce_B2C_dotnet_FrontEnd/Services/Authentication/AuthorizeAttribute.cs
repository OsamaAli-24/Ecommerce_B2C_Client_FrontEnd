using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce_B2C_dotnet_FrontEnd.Services.Authentication
{
    public class AuthorizeAttribute:Authentication
    {
       
        
        private readonly string[] allowedroles;
       public AuthorizeAttribute(params string[] Roles)
        {
            this.allowedroles = Roles;
        }



    }
}