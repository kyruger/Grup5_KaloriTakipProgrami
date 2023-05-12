using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ConsumedFoodBLL : BaseClass<ConsumedFood>
    {
       
        public List<ConsumedFood> GetConsumedFoodsByDayAndMealType(int userId, MealType meal)
        {
            User user = db.Users.Find(userId);
            TimeSpan timePassed = DateTime.Now - user.CreationTime;
            int day = (int)timePassed.TotalDays + 1;
            List<ConsumedFood> consumedFoods = db.ConsumedFoods.Where(x => x.Day == day && x.MealType == meal).ToList();

            return consumedFoods;
        }

      
      
    }
}
