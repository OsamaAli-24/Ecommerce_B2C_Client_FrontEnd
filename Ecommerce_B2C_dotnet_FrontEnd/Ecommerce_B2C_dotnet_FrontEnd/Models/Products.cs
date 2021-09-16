using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ecommerce_B2C_dotnet_FrontEnd.Models
{
    public class Products
    {
        [Key]
        public Int64 Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDetail { get; set; }
        public string ProductType { get; set; }
        public string ProductImage { get; set; }
        public DateTime AddingDate { get; set; }
        public Int64 AvailableStock { get; set; }
        public decimal ProductPrice { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
    }
}