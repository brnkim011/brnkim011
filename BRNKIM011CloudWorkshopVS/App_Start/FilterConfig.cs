using System.Web;
using System.Web.Mvc;

namespace BRNKIM011CloudWorkshopVS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
