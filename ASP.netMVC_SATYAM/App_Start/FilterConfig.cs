using System.Web;
using System.Web.Mvc;

namespace ASP.netMVC_SATYAM
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
