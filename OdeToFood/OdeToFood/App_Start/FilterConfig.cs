using System.Web;
using System.Web.Mvc;

namespace OdeToFood
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // detailed error message
            filters.Add(new HandleErrorAttribute());
        }
    }
}
