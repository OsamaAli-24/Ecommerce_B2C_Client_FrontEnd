using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ecommerce_B2C_dotnet_FrontEnd.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}