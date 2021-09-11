using System;
using System.Reflection;

namespace Ecommerce_B2C_dotnet_FrontEnd.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}