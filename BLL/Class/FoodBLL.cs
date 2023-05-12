using Entities;
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
    }
}
