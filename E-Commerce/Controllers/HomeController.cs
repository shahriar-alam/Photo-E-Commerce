using ECEntity;
using ECRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Commerce.Controllers
{
    public class HomeController : BaseController
    {
        private UserRepository userrepo = new UserRepository();
        private StashRepository stashrepo = new StashRepository();
        private LoginRepository loginrepo = new LoginRepository();
        private TransactionRepository transactionrepo = new TransactionRepository();

        public ActionResult insert_ini()
        {

            Stash stash7 = new Stash { SellerId = 2, Sold = 0, Price = 5, StashName = "Tokyo", Tags = "Anime", Created = DateTime.Today.ToShortDateString() };

            Stash stash8 = new Stash { SellerId = 2, Sold = 0, Price = 8, StashName = "Shigatsu", Tags = "Anime", Created = DateTime.Today.ToShortDateString() };

            Stash stash9 = new Stash { SellerId = 2, Sold = 0, Price = 10, StashName = "Sword", Tags = "Anime", Created = DateTime.Today.ToShortDateString() };

            Stash stash10 = new Stash { SellerId = 2, Sold = 0, Price = 8, StashName = "Sky", Tags = "Anime", Created = DateTime.Today.ToShortDateString() };

            Stash stash11 = new Stash { SellerId = 2, Sold = 0, Price = 6, StashName = "Dragon", Tags = "Anime", Created = DateTime.Today.ToShortDateString() };

            Stash stash12 = new Stash { SellerId = 2, Sold = 0, Price = 14, StashName = "DaffyDuck", Tags = "Cartoon", Created = DateTime.Today.ToShortDateString() };

            Stash stash13 = new Stash { SellerId = 2, Sold = 0, Price = 10, StashName = "Pinky", Tags = "Cartoon", Created = DateTime.Today.ToShortDateString() };

            Stash stash14 = new Stash { SellerId = 2, Sold = 0, Price = 12, StashName = "FatAlbert", Tags = "Cartoon", Created = DateTime.Today.ToShortDateString() };

            Stash stash15 = new Stash { SellerId = 2, Sold = 0, Price = 6, StashName = "MarioBrothers", Tags = "Cartoon", Created = DateTime.Today.ToShortDateString() };

            Stash stash16 = new Stash { SellerId = 2, Sold = 0, Price = 4, StashName = "SpongeBob", Tags = "Cartoon", Created = DateTime.Today.ToShortDateString() };

            Stash stash17 = new Stash { SellerId = 2, Sold = 0, Price = 12, StashName = "BitterTears", Tags = "Film & Animation", Created = DateTime.Today.ToShortDateString() };

            Stash stash18 = new Stash { SellerId = 2, Sold = 0, Price = 2, StashName = "Memento", Tags = "Film & Animation", Created = DateTime.Today.ToShortDateString() };

            Stash stash19 = new Stash { SellerId = 2, Sold = 0, Price = 4, StashName = "SilenceLamb", Tags = "Film & Animation", Created = DateTime.Today.ToShortDateString() };

            Stash stash20 = new Stash { SellerId = 2, Sold = 0, Price = 3, StashName = "Pinocchio", Tags = "Film & Animation", Created = DateTime.Today.ToShortDateString() };

            Stash stash21 = new Stash { SellerId = 2, Sold = 0, Price = 2, StashName = "Dumbo", Tags = "Film & Animation", Created = DateTime.Today.ToShortDateString() };

            Stash stash22 = new Stash { SellerId = 2, Sold = 0, Price = 11, StashName = "Interlace", Tags = "Design", Created = DateTime.Today.ToShortDateString() };

            Stash stash23 = new Stash { SellerId = 2, Sold = 0, Price = 7, StashName = "CCTV", Tags = "Design", Created = DateTime.Today.ToShortDateString() };

            Stash stash24 = new Stash { SellerId = 2, Sold = 0, Price = 8, StashName = "Duo", Tags = "Design", Created = DateTime.Today.ToShortDateString() };

            Stash stash25 = new Stash { SellerId = 2, Sold = 0, Price = 6, StashName = "Bilbao", Tags = "Design", Created = DateTime.Today.ToShortDateString() };

            Stash stash26 = new Stash { SellerId = 2, Sold = 0, Price = 18, StashName = "Disney", Tags = "Design", Created = DateTime.Today.ToShortDateString() };

            Stash stash27 = new Stash { SellerId = 2, Sold = 0, Price = 8, StashName = "Verbren", Tags = "DigitalArt", Created = DateTime.Today.ToShortDateString() };

            Stash stash28 = new Stash { SellerId = 2, Sold = 0, Price = 9, StashName = "LonelyMountain", Tags = "DigitalArt", Created = DateTime.Today.ToShortDateString() };

            Stash stash29 = new Stash { SellerId = 2, Sold = 0, Price = 11, StashName = "OldWays", Tags = "DigitalArt", Created = DateTime.Today.ToShortDateString() };

            Stash stash30 = new Stash { SellerId = 3, Sold = 0, Price = 14, StashName = "PillersofCreation", Tags = "DigitalArt", Created = DateTime.Today.ToShortDateString() };

            Stash stash31 = new Stash { SellerId = 3, Sold = 0, Price = 16, StashName = "Spectre", Tags = "DigitalArt", Created = DateTime.Today.ToShortDateString() };

            Stash stash32 = new Stash { SellerId = 3, Sold = 0, Price = 20, StashName = "StarrySky", Tags = "Nature", Created = DateTime.Today.ToShortDateString() };

            Stash stash33 = new Stash { SellerId = 3, Sold = 0, Price = 18, StashName = "Pier", Tags = "Nature", Created = DateTime.Today.ToShortDateString() };

            Stash stash34 = new Stash { SellerId = 3, Sold = 0, Price = 16, StashName = "Mountains", Tags = "Nature", Created = DateTime.Today.ToShortDateString() };

            Stash stash35 = new Stash { SellerId = 3, Sold = 0, Price = 14, StashName = "Road", Tags = "Nature", Created = DateTime.Today.ToShortDateString() };

            Stash stash36 = new Stash { SellerId = 3, Sold = 0, Price = 12, StashName = "Tree", Tags = "Nature", Created = DateTime.Today.ToShortDateString() };

            this.stashrepo.Insert(stash7);
            this.stashrepo.Insert(stash8);
            this.stashrepo.Insert(stash9);
            this.stashrepo.Insert(stash10);
            this.stashrepo.Insert(stash11);
            this.stashrepo.Insert(stash12);
            this.stashrepo.Insert(stash13);
            this.stashrepo.Insert(stash14);
            this.stashrepo.Insert(stash15);
            this.stashrepo.Insert(stash16);
            this.stashrepo.Insert(stash17);
            this.stashrepo.Insert(stash18);
            this.stashrepo.Insert(stash19);
            this.stashrepo.Insert(stash20);
            this.stashrepo.Insert(stash21);
            this.stashrepo.Insert(stash22);
            this.stashrepo.Insert(stash23);
            this.stashrepo.Insert(stash24);
            this.stashrepo.Insert(stash25);
            this.stashrepo.Insert(stash26);
            this.stashrepo.Insert(stash27);
            this.stashrepo.Insert(stash28);
            this.stashrepo.Insert(stash29);
            this.stashrepo.Insert(stash30);
            this.stashrepo.Insert(stash31);
            this.stashrepo.Insert(stash32);
            this.stashrepo.Insert(stash33);
            this.stashrepo.Insert(stash34);
            this.stashrepo.Insert(stash35);
            this.stashrepo.Insert(stash36);
            return RedirectToAction("UploadedItem", "Dashboard");

        }
        public ActionResult Index()
        {
            return View(this.userrepo.GetAll());
        }

        public ActionResult Show()
        {
            int id = Convert.ToInt32(System.Web.HttpContext.Current.Session["userid"]);
            return View(this.stashrepo.GetStashBySellerId(id));
        }

        public ActionResult Details(User user)
        {
            return View();
        }
 
        public ActionResult Home()
        {
            return View(this.stashrepo.GetAll());
        }

        
        [HttpGet]
        public ActionResult Home2(string tags, string sort)
        {
            ViewBag.tags = tags;
            //string str2 = Request.QueryString["sort"];
            if (sort == null)
                sort = "Best Sellers";
            //tag = "Anime";
            //return View(this.stashrepo.GetStashByTag(tags));
            return View(this.stashrepo.GetStashBySortTag(tags,sort));
            //return Content(str, str2);
        }

        [HttpPost]
        public ActionResult Home2(Stash stash)
        {
            int buyerid = Convert.ToInt32(System.Web.HttpContext.Current.Session["userid"]);

            //Stash stash = this.stashrepo.Get(id);
            User buyer = this.userrepo.Get(buyerid);
            User seller = this.userrepo.Get(stash.SellerId);
            Transaction trans = new Transaction();

            /*
            if (buyer.Balance < stash.Price)
            {
                return Content("Not Enough Balance");
            }

            else if (buyer.UserId == stash.SellerId)
            {
                return Content("Not Allowed");
            }

            else if (this.transactionrepo.Match(buyer, stash) == false)
            {
                return Content("Already Bought the item");
            }
            */

            //else
            //{
                Transaction transaction = new Transaction { sellerId = stash.SellerId, buyerId = buyerid, ItemPrice = stash.Price, ItemId = stash.StashId, TransactionDate = DateTime.Today.ToShortDateString() };
                this.transactionrepo.Insert(transaction);

                this.userrepo.AddBalance(seller, stash.Price);
                this.userrepo.RemoveBalance(buyer, stash.Price);

                return RedirectToAction("DownloadHistory", "Dashboard");
           // }
        }

        
        [HttpGet]
        public ActionResult BuyItem(int id, int id2)
        {
            int buyerid = Convert.ToInt32(System.Web.HttpContext.Current.Session["userid"]);

            Stash stash = this.stashrepo.Get(id);
            User buyer = this.userrepo.Get(buyerid);
            User admin = this.userrepo.Get(1);
            User seller = this.userrepo.Get(id2);
            Transaction trans = new Transaction();
            
            if(buyer.Balance<stash.Price)
            {
                return Content("Not Enough Balance");
            }

            else if(buyer.UserId==stash.SellerId)
            {
                return Content("Not Allowed");
            }

            else if(this.transactionrepo.Match(buyer, stash)==false)
            {
                return Content("Already Bought the item");
            }

            else
            {
                Transaction transaction = new Transaction { sellerId = id2, buyerId = buyerid, ItemPrice = stash.Price, ItemId = id, TransactionDate = DateTime.Today.ToShortDateString() };
                this.transactionrepo.Insert(transaction);

                int admincomission = stash.Price - 1;

                this.stashrepo.AddSold(stash);
                this.userrepo.AddBalance(seller, admincomission+1);
                this.userrepo.AddBalance(admin, admincomission);
                this.userrepo.RemoveBalance(buyer, stash.Price);

                return RedirectToAction("DownloadHistory", "Dashboard");
            }

            
        }
        
        /*
        [HttpPost]
        public ActionResult BuyItem(Stash stash)
        {
            //return Content(stash.SellerId.ToString(), stash.StashId.ToString());

            int buyerid = Convert.ToInt32(System.Web.HttpContext.Current.Session["userid"]);

            //Stash stash = this.stashrepo.Get(id);
            User buyer = this.userrepo.Get(buyerid);
            User seller = this.userrepo.Get(stash.SellerId);
            Transaction trans = new Transaction();

            if (buyer.Balance < stash.Price)
            {
                return Content("Not Enough Balance");
            }

            else if (buyer.UserId == stash.SellerId)
            {
                return Content("Not Allowed");
            }

            else if (this.transactionrepo.Match(buyer, stash) == false)
            {
                return Content("Already Bought the item");
            }

            else
            {
                Transaction transaction = new Transaction { sellerId = stash.SellerId, buyerId = buyerid, ItemPrice = stash.Price, ItemId = stash.StashId, TransactionDate = DateTime.Today.ToShortDateString() };
                this.transactionrepo.Insert(transaction);

                this.userrepo.AddBalance(seller, stash.Price);
                this.userrepo.RemoveBalance(buyer, stash.Price);

                return RedirectToAction("DownloadHistory", "Dashboard");
            }


        }

        */

        /*

        public ActionResult Home2(string model)
        {
            //tag = "Anime";
            return View(this.stashrepo.GetStashByTag(model));
        }
        */
    }
}