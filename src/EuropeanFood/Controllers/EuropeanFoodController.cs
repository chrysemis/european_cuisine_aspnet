﻿using System;
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
            ViewBag.RecipeName = "Just tomatoes";
            ViewBag.Description = "<p class=\"recipe - text\" id=\"meal - information\">Tomatoes holding the place until they are replaced by something made from tomatoes.</p>";
            ViewBag.Ingredients = new string[]
            {
                "1 kg tomatoes",
                "75 g plain flour",
                "1 tbsp breadcrumbs (optional)",
                "1 cloves of garlic, pressed",
                "Olive oil"
            };
             return View();
        }
    }
}