using ECEntity;
using ECRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Commerce.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        private LoginRepository repo = new LoginRepository();
        private UserRepository userrepo = new UserRepository();
        private LoginRepository loginrepo = new LoginRepository();
        private StashRepository stashrepo = new StashRepository();
        private TransactionRepository transactionrepo = new TransactionRepository();


        /*
        public ActionResult Login()
        {
            User user = new User { UserName = "admin", FullName = "ADMIN", Age = 25, Balance = 1000, Email = "admin@admin.com" };
            User user2 = new User { UserName = "admin2", FullName = "ADMIN2", Age = 255, Balance = 2000, Email = "admin2@admin.com" };
            Login login = new Login { UserName = "admin", Password = "admin" };
            Login login2 = new Login { UserName = "admin2", Password = "admin2" };
            Stash stash = new Stash { SellerId = 1, Sold = 5, Price = 20, StashName = "nature", Tags = "Nature", Created=DateTime.Today.ToShortDateString() };
            Stash stash2 = new Stash { SellerId = 2, Sold = 10, Price = 5, StashName = "Anime", Tags = "Anime", Created = DateTime.Today.ToShortDateString() };
            Stash stash3 = new Stash { SellerId = 1, Sold = 2, Price = 25, StashName = "nature", Tags = "Nature", Created = DateTime.Today.ToShortDateString() };
            Transaction transaction = new Transaction { sellerId = 1, buyerId = 2, ItemPrice = 20, ItemId = 1, TransactionDate=DateTime.Today.ToShortDateString() };
            Transaction transaction2 = new Transaction { sellerId = 1, buyerId = 2, ItemPrice = 25, ItemId = 3, TransactionDate = DateTime.Today.ToShortDateString() }; 
            //DateTime date = DateTime.Today;
            
            this.userrepo.Insert(user);
            this.userrepo.Insert(user2);
            this.loginrepo.Insert(login);
            this.loginrepo.Insert(login2);
            this.stashrepo.Insert(stash);
            this.stashrepo.Insert(stash2);
            this.stashrepo.Insert(stash3);
            this.transactionrepo.Insert(transaction);
            this.transactionrepo.Insert(transaction2);
            return RedirectToAction("Index", "Login");

        }
       
        */

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index1()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(Login user)
        {
            bool valid = repo.Validate(user);
            if (valid)
            {
                /*this.SharedSession["USERNAME"] = user.UserName;
                this.SharedSession["USERID"] = user.UserId;
                TempData["username"] = user.UserName;
                TempData["userid"] = user.UserId;
                */
                User users = this.userrepo.GetByName(user.UserName);
                int id = this.loginrepo.GetId(user.UserName);

                System.Web.HttpContext.Current.Session["username"] = user.UserName;
                System.Web.HttpContext.Current.Session["userid"] = id;


                //return Content(Session["username"].ToString());
                return RedirectToAction("ViewProfile", "DashBoard");
                //return RedirectToAction("Show", "Home");
                //return Content(user.UserId.ToString());
            }

            else
            {
                //Response.Write("<script language=javascript>alert('Invalid Info')</script>");
                return Content("Invalid username or password");
                //return RedirectToAction("Create");
            }
        }
    }
}