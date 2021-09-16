using Ecommerce_B2C_dotnet_FrontEnd.Dto;
using Ecommerce_B2C_dotnet_FrontEnd.Models;
using Ecommerce_B2C_dotnet_FrontEnd.ServiceResults;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ecommerce_B2C_dotnet_FrontEnd.Services.ProductService
{
    public class ProductService : IProductService
    {
        EcommerceContext _EcommerceContext = new EcommerceContext();

        public bool UpdateProduct(ProductDto param)
        {
            var product = _EcommerceContext.Products.FirstOrDefault(x=> x.Id == param.Id);
            if (param.ProductName != null){
                  product.ProductName = param.ProductName;
            }
            if (param.ProductDetail != null)
            {
                product.ProductDetail = param.ProductDetail;
            }
            if (product.ProductImage != null)
            {
                product.ProductImage = param.ProductImage;
            }
            if (product.ProductPrice != 0)
            {
                product.ProductPrice = param.ProductPrice;
            }
            if (product.ProductType != null)
            {
                product.ProductType = param.ProductType;
            }
            if (product.IsActive != null)
            {
                product.IsActive = param.IsActive;
            }
            if (product.IsDelete != null)
            {
                product.IsDelete = param.IsDelete;
            }
            if (product.UserId == 1)
            {
                product.UserId = param.UserId;
            }
            
            _EcommerceContext.SaveChanges();

            return true;
        }

        public IList<Products> GetProduct(long Id)
        {
            //ProductResults
            return _EcommerceContext.Products.Where(x => x.UserId == Id  /*&& x.IsActive== true*/).ToList();
           
            
        }

        public bool AddProduct(Products param)
        {
            //if (param.ProductName == null)
            //{
            //    param.ProductName = "";
            //}
            //if (param.ProductDetail == null)
            //{
            //    param.ProductDetail = "";
            //}
            //if (param.ProductImage == null)
            //{
            //    param.ProductImage = "";
            //}
            //if (param.ProductPrice == 0)
            //{
            //     param.ProductPrice = 0;
            //}
            //if (param.ProductType == null)
            //{
            //    param.ProductType = "";
            //}
            //if (param.IsActive == null)
            //{
            //    param.IsActive = true;
            //}
            //if (param.IsDelete == null)
            //{
            //    param.IsDelete = false;
            //}
            //if (param.UserId == 0)
            //{
            //    param.UserId = 1;
            //}
            _EcommerceContext.Products.Add(param);
            _EcommerceContext.SaveChanges();
            return true;

        }
    }
}