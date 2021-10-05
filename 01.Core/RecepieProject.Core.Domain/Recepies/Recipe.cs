using AshpazbashiBackoffice.Core.Domain.Recipes;
using AshpazbashiBackoffice.Core.Domain.Tags;
using RecepieProject.Core.Domain.Common;
using System.Collections.Generic;

namespace RecepieProject.Core.Domain.Recepies
{
    public class Recipe : Entity
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Detail { get; set; }
        public RecipeImage ReceipImage { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
