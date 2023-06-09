using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstaFood.Models;

namespace InstaFood.Models
{
    public class Recipe
    {
        public User User { get; set; }

        public int ID { get; set; } 

        public string Name { get; set; }

        public string Description { get; set; }

        public string PreparingTime { get; set; }

        public string CookingTime { get; set; }

        public string TotalTime => PreparingTime + CookingTime;

        public RecipeSteps Steps { get; set; }

        public Ingriedents Ingriedent { get; set; }
    }
}
