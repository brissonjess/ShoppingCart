using ShoppingCart.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCart.Controllers
{
    public class LoanController : Controller
    {
        private ShoppingDbContext db = new ShoppingDbContext();

        ////////////////////////////////////////////////
        ///////////////  View Methods   ////////////////
        ////////////////////////////////////////////////
        // GET: Loan
        public ActionResult Index()
        {
            return View(Get_Available_Items());
        }
        public ActionResult Edit()
        {
            return View();
        }
        ////////////////////////////////////////////////
        ///////////////  CRUD Methods   ////////////////
        ////////////////////////////////////////////////
        public List<Item> Get_Available_Items()
        {
            using (var context = db)
            {
                var results = from x in context.Items
                              where x.availableToLoan.Equals(true)
                              orderby x.item_name ascending
                              select x;
                return results.ToList();
            }
        }
        ////////////////////////////////////////////////
        ///////////////  Cart Methods   ////////////////
        ////////////////////////////////////////////////
        [HttpPost]
        public ActionResult AddToCart(int quantity, int itemid)
        {
            
            ViewBag.Test = "Quantity is: " + quantity + "<br>" + "Item ID is: " + itemid;
            return View("~/Views/Loan/Index.cshtml");
        }

    }
}