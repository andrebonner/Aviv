using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aviv.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if ( Request.QueryString["redirect"] != "false") { 
                      
                Response.Redirect("/Account/Login");
            }
            return View();
        }

        
    }
}