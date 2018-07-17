using ECRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Commerce.Controllers
{
    public class BasicController : Controller
    {
        private UserRepository userrepo = new UserRepository();
        private StashRepository stashrepo = new StashRepository();
        private LoginRepository loginrepo = new LoginRepository();
        private TransactionRepository transactionrepo = new TransactionRepository();
        // GET: Basic
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Home2(string tags, string sort)
        {
            if(tags==null)
            {
                tags = "Nature";
            }

            ViewBag.tags = tags;
            //string str2 = Request.QueryString["sort"];
            if (sort == null)
                sort = "Best Sellers";
            //tag = "Anime";
            //return View(this.stashrepo.GetStashByTag(tags));
            return View(this.stashrepo.GetStashBySortTag(tags, sort));
            //return Content(str, str2);
        }
       
    }
}