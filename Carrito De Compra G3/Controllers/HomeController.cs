using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carrito_De_Compra_G3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }       
        public ActionResult Usuario()
        {
            return View();
        }      
        public ActionResult Productos()
        {
            return View();
        }
    }
}