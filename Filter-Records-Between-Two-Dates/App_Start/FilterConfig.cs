using System.Web;
using System.Web.Mvc;

namespace Filter_Records_Between_Two_Dates
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
