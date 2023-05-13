using User;
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
        public List<Food> GetFoodsByWord(string text)
        {
            List<Food> foods = db.Foods.Where(x=>x.Name.Contains(text)).ToList();    
            return foods;
        }
        public int GetFoodIdByFoodName(string name)
        {
            Food food =db.Foods.Where(x=>x.Name == name).SingleOrDefault();
            int id = food.ID;
            return id;

        }
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
