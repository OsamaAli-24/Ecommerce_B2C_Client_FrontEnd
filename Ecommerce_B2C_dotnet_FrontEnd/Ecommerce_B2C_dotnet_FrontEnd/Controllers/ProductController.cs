using Ecommerce_B2C_dotnet_FrontEnd.Areas.Constants;
using Ecommerce_B2C_dotnet_FrontEnd.Dto;
using Ecommerce_B2C_dotnet_FrontEnd.Models;
using Ecommerce_B2C_dotnet_FrontEnd.ServiceResults;
using Ecommerce_B2C_dotnet_FrontEnd.Services.AccountService;
using Ecommerce_B2C_dotnet_FrontEnd.Services.ProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ecommerce_B2C_dotnet_FrontEnd.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : ApiController
    {
        ProductService _productService = new ProductService();
        AccountService _accountService = new AccountService();

        [Route("~/api/Product/GetProducts")]
        [Authorize]
        [HttpGet]
        public ProductResults GetProducts(Int64 id)
        {
            var productResults = new ProductResults();
            try
            {
                if (id != 0)
                {
                    //var data = _productService.GetProduct(id);
                    productResults.productsdata = _productService.GetProduct(id);
                    productResults.IsError = false;
                    productResults.Message = Message.Success;
                   
                }
            }
            catch (Exception ex)
            {
                productResults.Message = ex.Message;
                productResults.IsError = true;
            }

            return productResults;
        }

        [Route("~/api/Product/UpdateProducts")]
        [Authorize]
        [HttpPost]
        public EditProductResults UpdateProducts(ProductDto param)
        {
            var editProductResults = new EditProductResults();
            try
            {
                if (param != null)
                {
                    if (param.ProductImage != null)
                    {
                        var image = _accountService.ImgInBase64(param.ProductImage);
                        param.ProductImage = image;
                    }
                    var result = _productService.UpdateProduct(param);
                    if(result == true) { 
                    editProductResults.IsError = false;
                    editProductResults.Message = Message.Success;
                    }
                    else
                    {
                        editProductResults.IsError = true;
                        editProductResults.Message = Message.Error;
                    }
                }
            }
            catch (Exception ex)
            {
                editProductResults.Message = ex.Message;
                editProductResults.IsError = true;
            }

            return editProductResults;
        }
        [Route("~/api/Product/AddProduct")]
        [Authorize]
        [HttpPost]
        public EditProductResults AddProduct(Products param)
        {
            var editProductResults = new EditProductResults();
            try
            {
                if (param != null)
                {
                    if (param.ProductImage != null)
                    {
                        var image = _accountService.ImgInBase64(param.ProductImage);
                        param.ProductImage = image;
                    }
                    var result = _productService.AddProduct(param);
                    if (result == true)
                    {
                        editProductResults.IsError = false;
                        editProductResults.Message = Message.Success;
                    }
                    else
                    {
                        editProductResults.IsError = true;
                        editProductResults.Message = Message.Error;
                    }
                }
            }
            catch (Exception ex)
            {
                editProductResults.Message = ex.Message;
                editProductResults.IsError = true;
            }

            return editProductResults;
        }

        [Route("~/api/Product/DeleteProduct")]
        [Authorize]
        [HttpPost]
        public DeleteProductResult DeleteProduct(DeleteProductDto param)
        {
            var deleletProductResult = new DeleteProductResult();
            try
            {
                if (param != null)
                {
                    var result = _productService.DeleteProduct(param);
                    if (result == true)
                    {
                        deleletProductResult.IsError = false;
                        deleletProductResult.Message = Message.Success;
                    }
                    else
                    {
                        deleletProductResult.IsError = true;
                        deleletProductResult.Message = Message.Error;
                    }
                }
            }
            catch (Exception ex)
            {
                deleletProductResult.Message = ex.Message;
                deleletProductResult.IsError = true;
            }

            return deleletProductResult;
        }
    }
}
