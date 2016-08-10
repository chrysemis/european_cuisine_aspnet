using EuropeanFood.Data;
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
        private RecipesRepository _recipesRepository = null;
        
        public EuropeanFoodController()
        {
            //constructor
            _recipesRepository = new RecipesRepository();
        } 

        public ActionResult Index()
        {
            var recipes = _recipesRepository.GetRecipes();
            return View(recipes);
        }

        public ActionResult Recipe(int id)
        { 
            var recipe = _recipesRepository.GetRecipe(id);
            return View(recipe);
        }
    }
}