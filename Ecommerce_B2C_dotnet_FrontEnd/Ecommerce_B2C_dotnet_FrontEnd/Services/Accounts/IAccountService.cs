using Ecommerce_B2C_dotnet_FrontEnd.Dto;
using Ecommerce_B2C_dotnet_FrontEnd.Models;
using Ecommerce_B2C_dotnet_FrontEnd.ServiceResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_B2C_dotnet_FrontEnd.Services.AccountService
{
    public interface IAccountService
    {
        bool EditUser(AccountDto param);
        bool AddUser(Accounts param);
        bool DeleteUser(Int64 Id);
    }
}