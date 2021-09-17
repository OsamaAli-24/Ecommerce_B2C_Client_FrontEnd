using Ecommerce_B2C_dotnet_FrontEnd.Areas.Constants;
using Ecommerce_B2C_dotnet_FrontEnd.Dto;
using Ecommerce_B2C_dotnet_FrontEnd.Models;
using Ecommerce_B2C_dotnet_FrontEnd.ServiceResults;
using Ecommerce_B2C_dotnet_FrontEnd.Services.AccountService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ecommerce_B2C_dotnet_FrontEnd.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ApiController
    {
        AccountService _accountService = new AccountService();

        [Route("~/api/User/AddUser")]
        [Authorize]
        [HttpPost]
        public EditAccountResults AddUser(Accounts param)
        {
            var editAccountResults = new EditAccountResults();
            try
            {
                if (param != null)
                {
                    var result = _accountService.AddUser(param);
                    if (result == true)
                    {
                        editAccountResults.IsError = false;
                        editAccountResults.Message = Message.Success;
                    }
                    else
                    {
                        editAccountResults.IsError = true;
                        editAccountResults.Message = Message.Error;
                    }
                }
            }
            catch (Exception ex)
            {
                editAccountResults.Message = ex.Message;
                editAccountResults.IsError = true;
            }

            return editAccountResults;
        }


        [Route("~/api/User/EditUser")]
        [Authorize]
        [HttpPost]
        public EditAccountResults EditUser(AccountDto param)
        {
            var editAccountResults = new EditAccountResults();
            try
            {
                if (param != null)
                {
                    var result = _accountService.EditUser(param);
                    if (result == true)
                    {
                        editAccountResults.IsError = false;
                        editAccountResults.Message = Message.Success;
                    }
                    else
                    {
                        editAccountResults.IsError = true;
                        editAccountResults.Message = Message.Error;
                    }
                }
            }
            catch (Exception ex)
            {
                editAccountResults.Message = ex.Message;
                editAccountResults.IsError = true;
            }

            return editAccountResults;
        }

        [Route("~/api/User/DeleteUser")]
        [Authorize]
        [HttpPost]
        public DeleteUserResults DeleteUser(Int64 Id)
        {
            var deleteUserResults = new DeleteUserResults();
            try
            {
                if (Id != 0)
                {
                    var result = _accountService.DeleteUser(Id);
                    if (result == true)
                    {
                        deleteUserResults.IsError = false;
                        deleteUserResults.Message = Message.Success;
                    }
                    else
                    {
                        deleteUserResults.IsError = true;
                        deleteUserResults.Message = Message.Error;
                    }
                }
            }
            catch (Exception ex)
            {
                deleteUserResults.Message = ex.Message;
                deleteUserResults.IsError = true;
            }

            return deleteUserResults;
        }
    }

}
