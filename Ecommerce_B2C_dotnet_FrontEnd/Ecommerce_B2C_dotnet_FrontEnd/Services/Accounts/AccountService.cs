using Ecommerce_B2C_dotnet_FrontEnd.Dto;
using Ecommerce_B2C_dotnet_FrontEnd.Models;
using Ecommerce_B2C_dotnet_FrontEnd.ServiceResults;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ecommerce_B2C_dotnet_FrontEnd.Services.AccountService
{
    public class AccountService : IAccountService
    {
        EcommerceContext _EcommerceContext = new EcommerceContext();

        public bool AddUser(Accounts param)
        {
            if (param.FirstName == null)
            {
                param.FirstName = "";
            }
            if (param.Email == null)
            {
                param.Email = "";
            }
            if (param.Password == null)
            {
                param.Password = "";
            }
            if (param.PhoneNumber == null)
            {
                param.PhoneNumber = "";
            }
            if (param.Role == null)
            {
                param.Role = "Admin";
            }
            if (param.IsActive == null)
            {
                param.IsActive = true;
            }
            if (param.IsDelete == null)
            {
                param.IsDelete = false;
            }
            if (param.City == null)
            {
                param.City = null;
            }
            _EcommerceContext.Accounts.Add(param);
            _EcommerceContext.SaveChanges();
            return true;
        }

        public bool EditUser(AccountDto param)
        {
            var account = _EcommerceContext.Accounts.FirstOrDefault(x => x.Id == param.Id);
            if (param.FirstName != null)
            {
                account.FirstName = param.FirstName;
            }
            if (param.Email != null)
            {
                account.Email = param.Email;
            }
            if (account.Password != null)
            {
                account.Password = param.Password;
            }
            if (account.PhoneNumber != null)
            {
                account.PhoneNumber = param.PhoneNumber;
            }
            if (account.Role != null)
            {
                account.Role = param.Role;
            }
            if (account.IsActive != null)
            {
                account.IsActive = param.IsActive;
            }
            if (account.IsDelete != null)
            {
                account.IsDelete = param.IsDelete;
            }
            if (account.Id == 1)
            {
                account.Id = param.Id;
            }

            _EcommerceContext.SaveChanges();

            return true;
        }
    }
}