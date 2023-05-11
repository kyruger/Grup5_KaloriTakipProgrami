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
        private List<ConsumedFood> GetConsumedFoodsByDayAndMealType(int day, MealType meal)
        {
            List<ConsumedFood> consumedFoods = db.ConsumedFoods.Where(x => x.Day == day && x.MealType == meal).ToList();

            return consumedFoods;
        }
    }
}
