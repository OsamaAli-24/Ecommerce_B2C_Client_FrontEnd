using Ecommerce_B2C_dotnet_FrontEnd.Dto;
using Ecommerce_B2C_dotnet_FrontEnd.Models;
using Ecommerce_B2C_dotnet_FrontEnd.ServiceResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce_B2C_dotnet_FrontEnd.Services.LoginService
{
    public class LoginService : ILoginService
    {
        EcommerceContext _EcommerceContext = new EcommerceContext();
        public LoginResults ValidateLoginCredentials(LoginDto param)
        {
            Accounts accounts = new Accounts();
             accounts = _EcommerceContext.Accounts.Where(x => x.Email == param.Email && x.Password == param.Password /*&& x.IsActive== true*/).SingleOrDefault();
            LoginResults loginResults = new LoginResults();
            loginResults.Id = accounts.Id;
            loginResults.FirstName = accounts.FirstName;
            loginResults.LastName = accounts.LastName;
            loginResults.Email = accounts.Email;
            loginResults.ImageName = accounts.ImageName;
            loginResults.IsActive = accounts.IsActive;
            loginResults.IsDelete = accounts.IsDelete;
            loginResults.Gender = accounts.Gender;
            loginResults.Role = accounts.Role;

            return loginResults;
        }

        

    }
}