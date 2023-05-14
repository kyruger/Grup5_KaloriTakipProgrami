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
        public List<Food> GetFoodsByContainTextAndOwnerId(string text,int ownerId)
        {
            
            List<Food> searchedFoods = new List<Food>();
            var foods = db.Foods.Where(f => f.OwnerId == 0 || f.OwnerId == ownerId);
            foreach (var food in foods)
            {
                if (food.Category.ToString().ToLower().Contains(text.ToLower()) || food.Name.ToLower().Contains(text.ToLower()))
                    searchedFoods.Add(food);
            }
            return searchedFoods;
        }

        public bool IsFoodExist(string name)
        {
            return db.Foods.Any(f => f.Name == name);
        }


    }
}
