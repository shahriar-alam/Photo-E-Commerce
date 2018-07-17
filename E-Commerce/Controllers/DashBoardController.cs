using ECEntity;
using ECRepository;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace E_Commerce.Controllers
{
    public class DashBoardController : BaseController
    {
        private UserRepository userrepo = new UserRepository();
        private StashRepository stashrepo = new StashRepository();
        private TransactionRepository transactionrepo= new TransactionRepository();

        public DashBoardController()
        {
            if (System.Web.HttpContext.Current.Session["username"] == null)
            {
                 RedirectToAction("http://localhost:1870/Login/Index");
            }
        }

        // GET: DashBoard
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewProfile()
        {
            if (System.Web.HttpContext.Current.Session["username"] == null)
            {
                return RedirectToAction("localhost/Login/Index");
            }

            string name = System.Web.HttpContext.Current.Session["username"].ToString();
            int id = Convert.ToInt32(System.Web.HttpContext.Current.Session["userid"]);

            ViewBag.user = this.userrepo.GetUser(id);
            User users = this.userrepo.GetByName(name);
            
            return View(users);
        }
        
        /*
        public class ViewModel
        {
            public User users { get; set; }
            public List<Stash> stashes{ get; set; }
        }
        */
        public ActionResult UploadHistory()
        {
            if (System.Web.HttpContext.Current.Session["username"] == null)
            {
                return RedirectToAction("localhost/Login/Index");
            }
            /*
            dynamic mymodel = new ExpandoObject();
            mymodel.stashes  = this.stashrepo.GetStashBySellerId(id);
            mymodel.users = this.userrepo.GetUser(id);
            //mymodel.Students = this.stashrepo.GetStashBy(id);
            */
            int id = Convert.ToInt32(System.Web.HttpContext.Current.Session["userid"]);
            
            ViewBag.user = this.userrepo.GetUser(id);
            //ViewBag.stash = this.stashrepo.GetStashBySellerId(id);
            //List<Stash> stashes = this.stashrepo.GetStashBySellerId(id);
            /*
             ViewModel mymodel = new ViewModel();
             mymodel.users = this.userrepo.GetUser(id);
             mymodel.stashes = this.stashrepo.GetStashBySellerId(id);
             return View(mymodel);
             */
            //return View();
            /*
            var tupleModel = new Tuple<User, List<Stash>>(this.userrepo.GetUser(id), this.stashrepo.GetStashBySellerId(id));
            return View(tupleModel);
            */
            /*
            var multimodel = new UserStashData();
            multimodel.users = this.userrepo.GetUser(id);
            multimodel.stashes = this.stashrepo.GetStashBySellerId(id);
            */
            //return View(multimodel);
            return View(this.stashrepo.GetStashBySellerId(id));
        }

        public ActionResult UploadHistory2()
        {
            if (System.Web.HttpContext.Current.Session["username"] == null)
            {
                return RedirectToAction("localhost/Login/Index");
            }
            int id = Convert.ToInt32(System.Web.HttpContext.Current.Session["userid"]);

            ViewBag.user = this.userrepo.GetUser(id);

            //return Content(id.ToString());
            return View(this.stashrepo.GetStashBySellerId(id));
            
        }

        public ActionResult DownloadHistory()
        {
            if (System.Web.HttpContext.Current.Session["username"] == null)
            {
                return RedirectToAction("localhost/Login/Index");
            }

            int id = Convert.ToInt32(System.Web.HttpContext.Current.Session["userid"]);

            ViewBag.user = this.userrepo.GetUser(id);

            return View(this.transactionrepo.GetBuyerbyId(id));
        }

        [HttpGet]
        public ActionResult EditProfile()
        {
            if (System.Web.HttpContext.Current.Session["username"] == null)
            {
                return RedirectToAction("localhost/Login/Index");
            }

            int id = Convert.ToInt32(System.Web.HttpContext.Current.Session["userid"]);

            ViewBag.user = this.userrepo.GetUser(id);
            User p = this.userrepo.Get(id);
            return View(p);
        }

      
        [HttpPost]
        public ActionResult EditProfile(User user)
        {
            if (System.Web.HttpContext.Current.Session["username"] == null)
            {
                return RedirectToAction("localhost/Login/Index");
            }

            int id = Convert.ToInt32(System.Web.HttpContext.Current.Session["userid"]);

            User u = this.userrepo.Get(id);
            if(user.Email==null)
            {
                user.Email = u.Email;
            }

            if (user.FullName == null)
            {
                user.FullName = u.FullName;
            }


            ViewBag.user = this.userrepo.GetUser(id);
            this.userrepo.Update(user);
            return RedirectToAction("ViewProfile");
        }

        [HttpGet]
        public ActionResult EditPassword()
        {
            if (System.Web.HttpContext.Current.Session["username"] == null)
            {
                return RedirectToAction("localhost/Login/Index");
            }

            int id = Convert.ToInt32(System.Web.HttpContext.Current.Session["userid"]);

            ViewBag.user = this.userrepo.GetUser(id);
            User p = this.userrepo.Get(id);
            return View(p);
        }

        [HttpPost]
        public ActionResult EditPassword(User user)
        {
            if (System.Web.HttpContext.Current.Session["username"] == null)
            {
                return RedirectToAction("localhost/Login/Index");
            }

            int id = Convert.ToInt32(System.Web.HttpContext.Current.Session["userid"]);

            ViewBag.user = this.userrepo.GetUser(id);
            this.userrepo.Update(user);
            return RedirectToAction("ViewProfile");
        }


        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index","Login");
        }

        /*
        public ActionResult Delete_Item(int id)
        {
            int uid = Convert.ToInt32(System.Web.HttpContext.Current.Session["userid"]);

            return RedirectToAction("UploadHistory");
        }
        */

        [HttpGet]
        public ActionResult Add_Item()
        {
            if (System.Web.HttpContext.Current.Session["username"] == null)
            {
                return RedirectToAction("localhost/Login/Index");
            }

            return View();
        }

        [HttpPost]
        public ActionResult Add_Item(Stash stash)
        {
            if (System.Web.HttpContext.Current.Session["username"] == null)
            {
                return RedirectToAction("localhost/Login/Index");
            }

            if (ModelState.IsValid)
            {
                int uid = Convert.ToInt32(System.Web.HttpContext.Current.Session["userid"]);
                stash.SellerId = uid;
                stash.Created = DateTime.Today.ToShortDateString();
                this.stashrepo.Insert(stash);
                return RedirectToAction("UploadHistory");
            }
            else
            {
                //stash.Created = "";
                //return Content("Not Valid");
                return RedirectToAction("ViewProfile");
            }
        }

        [HttpGet]
        public ActionResult Delete_Item(int id)
        {
            //Stash stash = this.stashrepo.Get(id);
            this.stashrepo.Delete(id);
            return RedirectToAction("UploadHistory");
            //return View(stash);
        }

        /*
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            this.repo.Delete(id);
            return RedirectToAction("Index");
        }
        */

        /*
        public ActionResult Test()
        {

            //int id =Convert.ToInt32(this.SharedSession["USERID"]);
            string name = System.Web.HttpContext.Current.Session["username"].ToString();
            User user = this.userrepo.GetByName(name);
            
           // if(user.UserId==1)
                return View(user);
        }
        */
        [HttpGet]
        public ActionResult Add_Item2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add_Item2(Stash stash, HttpPostedFileBase file)
        {
            if (System.Web.HttpContext.Current.Session["username"] == null)
            {
                return RedirectToAction("localhost/Login/Index");
            }

            if (ModelState.IsValid)
            {
                
                
                int uid = Convert.ToInt32(System.Web.HttpContext.Current.Session["userid"]);
                stash.SellerId = uid;
                stash.Created = DateTime.Today.ToShortDateString();
                this.stashrepo.Insert(stash);

                

                if (file.ContentLength > 0)
                {
                    int x = this.stashrepo.GetLatestStash();
                    var fileName = stash.StashId;
                    var path = Path.Combine(Server.MapPath("~/Images"), fileName.ToString()+".jpg");
                    var path2 = Path.Combine(Server.MapPath("~/ImagesFake"), fileName.ToString() + ".jpg");
                    file.SaveAs(path);

                    WebImage img = new WebImage(file.InputStream);
                    img.Resize(200, 200);
                    img.Save(path2);
                }

                else
                {
                    return Content("File Not Uploaded");
                }

                return RedirectToAction("UploadHistory");
            }
            else
            {
                //stash.Created = "";
                //return Content("Not Valid");
                return RedirectToAction("ViewProfile");
            }
        }

        public ActionResult Download_Item(string filename)
        {
            string fullpath = Path.Combine(Server.MapPath("~/Images/"), filename);
            return File(fullpath, "Images/jpg",filename);
        }

        [HttpGet]
        public ActionResult UpdateBalance()
        {
            int id = Convert.ToInt32(System.Web.HttpContext.Current.Session["userid"]);
            User p = this.userrepo.Get(id);
            return View(p);
        }

        [HttpPost]
        public ActionResult UpdateBalance(User user)
        {
            this.userrepo.UpdateBalance(user);
            return RedirectToAction("ViewProfile");
        }

        [HttpGet]
        public ActionResult Recharge()
        {
            if (System.Web.HttpContext.Current.Session["username"] == null)
            {
                return RedirectToAction("localhost/Login/Index");
            }

            string name = System.Web.HttpContext.Current.Session["username"].ToString();
            int id = Convert.ToInt32(System.Web.HttpContext.Current.Session["userid"]);

            ViewBag.user = this.userrepo.GetUser(id);
            User users = this.userrepo.GetByName(name);

            return View(users);
        }

        [HttpPost]
        public ActionResult Recharge(User user, FormCollection Form)
        {
            int balance = Convert.ToInt32(Form["Balance"]);

            this.userrepo.AddBalance(user, balance);
            
            return RedirectToAction("ViewProfile", "Dashboard");
        }

       
        public ActionResult up()
        {
            int id = Convert.ToInt32(System.Web.HttpContext.Current.Session["userid"]);
            User user = this.userrepo.Get(id);

            return View(user);
        }

        [HttpGet]
        public ActionResult Chart(string sort)
        {
            int id = Convert.ToInt32(System.Web.HttpContext.Current.Session["userid"]);
            
            if (id != 1)
            {
                if(id!=2)
                      return Content("You Are Not Authorized");
            }
            //List<Transaction> trans = this.transactionrepo.GetAll();
            if (sort == null)
                sort = "All";
            //tag = "Anime";
            //return View(this.stashrepo.GetStashByTag(tags));
            return View(this.transactionrepo.GetTransactionByReport(sort));
            //return Content(str, str2);
            //return View(trans);
        }

        [HttpPost]
        public ActionResult Chart(Transaction trans)
        {
            int id = Convert.ToInt32(System.Web.HttpContext.Current.Session["userid"]);

            if (id != 1)
            {
                if (id != 2)
                    return Content("You Are Not Authorized");
            }

            return View(trans);
        }
    }
}