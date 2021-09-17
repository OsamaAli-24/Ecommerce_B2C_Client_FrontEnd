using Ecommerce_B2C_dotnet_FrontEnd.Dto;
using Ecommerce_B2C_dotnet_FrontEnd.Models;
using Ecommerce_B2C_dotnet_FrontEnd.ServiceResults;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;

namespace Ecommerce_B2C_dotnet_FrontEnd.Services.AccountService
{
    public class AccountService : IAccountService
    {
        EcommerceContext _EcommerceContext = new EcommerceContext();

        public bool AddUser(Accounts param)
        {
            /*if (param.FirstName == null)
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
            }*/
            _EcommerceContext.Accounts.Add(param);
            _EcommerceContext.SaveChanges();
            return true;
        }

        public bool DeleteUser(long Id)
        {
            var account = _EcommerceContext.Accounts.FirstOrDefault(x => x.Id == Id);
            _EcommerceContext.Accounts.Remove(account);
            _EcommerceContext.SaveChanges();
            return true;
        }

        public bool UpdateUser(AccountDto param)
        {
            var account = _EcommerceContext.Accounts.FirstOrDefault(x => x.Id == param.Id);
            account.RegistrationDate = System.DateTime.Now;
            /*if (param.Email != null)
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
            }*/

            _EcommerceContext.SaveChanges();

            return true;
        }

        public IList<Accounts> GetUser(long id)
        {
            return _EcommerceContext.Accounts.Where(x=>x.Id !=id).ToList();
        }

        public string ImgInBase64(string base64img)
        {
            string path = HttpContext.Current.Server.MapPath("~/Images/");
           // string path = Path.Combine(_webHostEnviroment.WebRootPath, "Images");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            //string test = base64img.base64Img.GetBase64Data();
            var bytes = Convert.FromBase64String(base64img.GetBase64Data());
            string FileName = Guid.NewGuid().ToString() + "." + base64img.GetExtension();
            string file = Path.Combine(path, FileName);
            int maxContentSize = 1024 * 1024 * 1;
            IList<string> allowedExtension = new List<string> { "jpg", "jpeg", "png", "gif" };
            if (!allowedExtension.Contains(base64img.GetExtension()))
            {
                return "File formate is not supported";
            }
            if (base64img.Length > maxContentSize)
            {
                return "file size is greater then 1MB";
            }
            if (bytes.Length > 0)
            {
                using (var stream = new FileStream(file, FileMode.Create))
                {
                    stream.Write(bytes, 0, bytes.Length);
                    stream.Flush();
                    return FileName;
                    //return "Image is uploaded successfully";
                }
            }
            return "operation is successfull";
        }

    }
}