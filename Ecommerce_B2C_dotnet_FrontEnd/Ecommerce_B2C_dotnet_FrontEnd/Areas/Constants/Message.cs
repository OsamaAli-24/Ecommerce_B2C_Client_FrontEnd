using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce_B2C_dotnet_FrontEnd.Areas.Constants
{
    public class Message
    {
        internal const string Success = "Success";
        internal const string TokenIssuer = "https://test.com";
        internal const string TokenAudience = "https://test.com";
        internal const string SecurityKey = "28EDC39862124CD7331ADEF9ED8E2";

        internal const string Error = "An error occured while processing";
        internal const string ErrorFile = "An error occured while file processing";

        internal const string InvalidPassword = "Invalid Password!";
        internal const string UnAuthorized = "you are not authorized to process this request!";
    }
}