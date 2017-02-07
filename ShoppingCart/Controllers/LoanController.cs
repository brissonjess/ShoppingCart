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
        // GET: Loan
        public ActionResult Index()
        {
            
            return View(db.Items.ToList());
        }
    }
}