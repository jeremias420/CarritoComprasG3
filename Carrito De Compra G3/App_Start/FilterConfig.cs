using System.Web;
using System.Web.Mvc;

namespace Carrito_De_Compra_G3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
