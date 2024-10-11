using System.Web;
using System.Web.Mvc;

namespace NguyenThanhPhat_KtrFE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
