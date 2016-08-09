using EuropeanFood.Models;
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
           var recipe = new Recipe()
            {
                RecipeName = "Just Tomatoes",
                Description = "Tomatoes holding the place until they are replaced by something made from tomatoes.",
                Ingredients = new string[]
                {
                    "1 kg tomatoes",
                "75 g plain flour",
                "1 tbsp breadcrumbs (optional)",
                "1 cloves of garlic, pressed",
                "Olive oil"
                },
                MethodSteps = new string[]
                {
                    "Chop tomatoes.",
                    "Mix tomatoes with all else.",
                    "Cook tomatoes.",
                    "Serve tomatoes."
                }
    };

          
             return View(recipe);
        }
    }
}