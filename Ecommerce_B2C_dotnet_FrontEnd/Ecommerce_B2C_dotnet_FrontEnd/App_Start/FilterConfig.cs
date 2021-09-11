using System.Web;
using System.Web.Mvc;

namespace Ecommerce_B2C_dotnet_FrontEnd
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
