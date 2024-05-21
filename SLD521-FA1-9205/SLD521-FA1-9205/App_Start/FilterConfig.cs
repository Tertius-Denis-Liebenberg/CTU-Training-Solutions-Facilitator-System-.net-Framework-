using System.Web;
using System.Web.Mvc;

namespace SLD521_FA1_9205
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
