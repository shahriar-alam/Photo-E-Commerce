using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Commerce.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (Session["username"] == null)
            {
                //Response.Redirect("http://www.google.com/");
                Response.Redirect("http://localhost:1870/Login/Index");
            }
            base.OnActionExecuting(filterContext);
        }

        public System.Web.SessionState.HttpSessionState SharedSession
        {
            get
            {
                return System.Web.HttpContext.Current.Session;
            }
        }
    }
}