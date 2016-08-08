using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EuropeanFood.Controllers
{
    public class EuropeanFoodController : Controller
    {
        public ActionResult Recipe()
        {
            return View();
        }
    }
}