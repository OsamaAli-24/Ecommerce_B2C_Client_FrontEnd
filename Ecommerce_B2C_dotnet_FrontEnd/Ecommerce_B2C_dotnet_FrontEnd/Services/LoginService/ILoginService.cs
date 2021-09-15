using Ecommerce_B2C_dotnet_FrontEnd.Dto;
using Ecommerce_B2C_dotnet_FrontEnd.ServiceResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_B2C_dotnet_FrontEnd.Services.LoginService
{
    public interface ILoginService
    {
        LoginResults ValidateLoginCredentials(LoginDto param);
    }
}
