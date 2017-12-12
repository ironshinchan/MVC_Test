using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Test.Models;

namespace MVC_Test.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetProducts()
        {
            JsonResult result = new JsonResult();

            dataProductsDataContext dcProducts = new dataProductsDataContext();

            result.Data = new { results = dcProducts.spc_GetProducts() };
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;

            return result;
        }
    }
}
