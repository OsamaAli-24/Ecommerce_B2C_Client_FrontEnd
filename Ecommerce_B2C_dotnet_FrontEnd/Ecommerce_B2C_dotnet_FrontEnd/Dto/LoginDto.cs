using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce_B2C_dotnet_FrontEnd.Dto
{
    public class LoginDto
    {
        public Int64 Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ImageName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime? DateOfBirth { get; set; }
        //public GenderType? Gender { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }




    }
}