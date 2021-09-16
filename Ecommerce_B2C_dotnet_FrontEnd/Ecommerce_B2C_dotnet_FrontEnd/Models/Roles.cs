using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ecommerce_B2C_dotnet_FrontEnd.Models
{
    public class Roles
    {
        [Key]
        public Int64 Id { get; set; }
        public string RoleName { get; set; }
    }
}