using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Security.Claims;
using Ecommerce_B2C_dotnet_FrontEnd.Dto;
using Ecommerce_B2C_dotnet_FrontEnd.Services;
using Microsoft.AspNetCore.Mvc;
using Ecommerce_B2C_dotnet_FrontEnd.Services.LoginService;
using Ecommerce_B2C_dotnet_FrontEnd.Areas.Constants;
using Ecommerce_B2C_dotnet_FrontEnd.ServiceResults;

namespace Ecommerce_B2C_dotnet_FrontEnd.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : ApiController
    {
        UserTokenService _userTokenService = new UserTokenService();
        LoginService _loginService = new LoginService();

        [Route("~/api/Login/LoginUser")]
        [AllowAnonymous]
        [HttpGet]
        public LoginResults LoginUser(LoginDto param)
        {
            LoginResults loginResults = new LoginResults();
            try
            {
                if (param != null)
                {
                    var data = _loginService.ValidateLoginCredentials(param);
                    var result = _userTokenService.GetToken(data);
                    data.Token = result.ToString();
                    data.IsError = false;
                    data.Message = Message.Success;
                    loginResults = data;
                }
            }
            catch (Exception ex)
            {
                loginResults.Message = ex.Message;
                loginResults.IsError = true;
            }
           
            return loginResults; 
        }

        [Route("~/api/Login/GetUser")]
        [Authorize]
        [HttpPost]
        public String GetUser()
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

    }


}
