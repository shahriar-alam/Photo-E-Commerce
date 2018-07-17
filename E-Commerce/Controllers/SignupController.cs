using ECEntity;
using ECRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Commerce.Controllers
{
    public class SignupController : Controller
    {
        private UserRepository userrepo = new UserRepository();
        private LoginRepository loginrepo = new LoginRepository();
        // GET: Signup
        [HttpGet]
        public ActionResult Index1()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Index1(User user)
        {
            this.userrepo.Insert(user);
            //return RedirectToAction("Index");
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user, FormCollection Form)
        {
            if (ModelState.IsValid)
            {
                string password = Form["Password"];
                if (password == null)
                    return Content("Invalid password");
                Login login = new Login { UserName = user.UserName, Password = password };
                this.userrepo.Insert(user);
                this.loginrepo.Insert(login);
                return RedirectToAction("Index", "Login");
            }
            else
            {
                user.Email = "";
                return View(user);
            }
        }



    }
}