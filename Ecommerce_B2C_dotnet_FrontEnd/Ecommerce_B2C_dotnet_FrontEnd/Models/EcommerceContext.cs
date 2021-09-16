using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ecommerce_B2C_dotnet_FrontEnd.Models
{
    public class EcommerceContext: DbContext
    {
        public EcommerceContext() : base("EcommerceDB")
        {
        }
        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}