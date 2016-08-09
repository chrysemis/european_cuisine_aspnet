using EuropeanFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EuropeanFood.Data
{
    public class RecipesRepository
    {
        private static Recipe[] _recipes = new Recipe[]
        {
            new Recipe()
            {   Id = 1,
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
            },
            new Recipe()
            {
                Id = 2,
                RecipeName = "Bart Simpson Salad",
                Description = "Salad in Bart Simpson kitchenware.",
                Ingredients = new string[]
                {
                    "Lettuce",
                "Bart Simpson bowl",
                "Croutons",
                "1 cloves of garlic, pressed",
                "Olive oil",
                "Salt and pepper"
                },
                MethodSteps = new string[]
                {
                    "Wash salad.",
                    "Mix with all else.",
                    "Serve."
                }
            },
            new Recipe()
            {
                Id = 3,
                RecipeName = "Hot Chocolate",
                Description = "Best hot chocolate from the real chocolate.",
                Ingredients = new string[]
                {
                    "A bar of plain chocolate",
                "2 cups of milk",
                "Brown sugar by taste",
                "Cardamom",
                "Chilli",
                "Whipped cream"
                },
                MethodSteps = new string[]
                {
                    "Boil milk with spices.",
                    "Stir in chocolate until dissolved.",
                    "Serve with cream.",
                }
            },

    };

        public Recipe GetRecipe(int id)
        {
            Recipe recipeToReturn = null;

            foreach (var recipe in _recipes)
            {
                if (recipe.Id == id)
                {
                    recipeToReturn = recipe;
                    break;
                }
            }
          return recipeToReturn;
        }
    }
}