using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EuropeanFood.Models
{
    public class Recipe
    {
        public string RecipeName { get; set; }
        public string Description { get; set; }
        public string RecipeImageUrl { get; set;  }
        public string[] Ingredients { get; set; }
        public string[] Method { get; set;  }
    }
}