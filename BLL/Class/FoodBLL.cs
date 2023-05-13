using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FoodBLL:BaseClass<Food>
    {
        public List<Food> GetFoodsByContainText(string text)
        {
            
            List<Food> searchedFoods = new List<Food>();
            var allFoods = GetAll();
            foreach (var food in allFoods)
            {
                if (food.Category.ToString().ToLower().Contains(text.ToLower()) || food.Name.ToLower().Contains(text.ToLower()))
                    searchedFoods.Add(food);
            }
            return searchedFoods;
        }


    }
}
