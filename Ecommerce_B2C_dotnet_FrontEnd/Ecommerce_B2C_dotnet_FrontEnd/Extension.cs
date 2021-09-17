using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce_B2C_dotnet_FrontEnd
{
    public static class Extension
    {

        //geting file data without extension
        public static string GetBase64Data(this string base64img)
        {
            return base64img.Split(',')[1];
        }

        //get file extension
        public static string GetExtension(this string base64img)
        {
            var extentionData = base64img.Split(',')[0];
            extentionData = base64img.Split('/')[1];
            extentionData = base64img.Split(';')[0];
            extentionData = extentionData.Split('/')[1];
            return extentionData;
        }
    }
}