using System.Web;
using System.Web.Mvc;

namespace Layout_ViewEngine_DataPassing
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
