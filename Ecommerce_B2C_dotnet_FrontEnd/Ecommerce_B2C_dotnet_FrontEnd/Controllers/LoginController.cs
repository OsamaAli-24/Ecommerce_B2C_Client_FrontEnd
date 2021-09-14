using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Security.Claims;
using Ecommerce_B2C_dotnet_FrontEnd.Dto;
using Ecommerce_B2C_dotnet_FrontEnd.Services;

namespace Ecommerce_B2C_dotnet_FrontEnd.Controllers
{
    public class LoginController : ApiController
    {
        
        /*private  ITokenService _userService;
        public LoginController(ITokenService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public Object GetName1(LoginDto param)
        {
            if (param != null)
            {
                
                return "Invalid";
            }
            else
            {
                object result = _userService.UserTokenService.GetToken();
                return new { data = _userService.UserTokenService.GetToken()};
            }
        }*/


        [HttpPost]
        public String GetName1()
        {
            if (User.Identity.IsAuthenticated)
            {
                var identity = User.Identity as ClaimsIdentity;
                if (identity != null)
                {
                    IEnumerable<Claim> claims = identity.Claims;
                }
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }


        [HttpGet]
        public String GetName2()
        {

            return "Hello";
        }



    }


}
