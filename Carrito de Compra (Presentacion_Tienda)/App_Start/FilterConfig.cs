﻿using System.Web;
using System.Web.Mvc;

namespace Carrito_de_Compra__Presentacion_Tienda_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
