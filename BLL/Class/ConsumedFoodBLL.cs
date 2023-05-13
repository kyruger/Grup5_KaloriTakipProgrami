using Castle.DynamicProxy.Generators;
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

      
      
    public class ConsumedFoodBLL : BaseClass<ConsumedFood>
    {

        public void GetFoodConsumedPlaceByFoodId(int foodId, out int place, params MealType[] mealTypes)
        {
            place = 0;
            if (mealTypes.Count() == 1)
            {
                var list = db.ConsumedFoods.Where(cf => cf.MealType == mealTypes[0])
                                            .GroupBy(cf => cf.FoodId)
                                            .Select(group => new
                                            {
                                                FoodId = group.Key,
                                                TotalQuantityAndPortionCount = group.Sum(cf => cf.Quantity + cf.PortionCount)
                                            })
                                            .OrderByDescending(x => x.TotalQuantityAndPortionCount)
                                            .ToList();
                place = list.FindIndex(f => f.FoodId == foodId) + 1;
            }
            else if (mealTypes.Count() < 6)
            {
                var list = db.ConsumedFoods.Where(cf => cf.MealType != MealType.Breakfast && cf.MealType != MealType.Lunch && cf.MealType != MealType.Dinner)
                           .GroupBy(cf => cf.FoodId)
                           .Select(group => new
                           {
                               FoodId = group.Key,
                               TotalQuantityAndPortionCount = group.Sum(cf => cf.Quantity + cf.PortionCount)
                           })
                           .OrderByDescending(x => x.TotalQuantityAndPortionCount)
                           .ToList();
                place = list.FindIndex(f => f.FoodId == foodId) + 1;

            }
            else
            {
                var list = db.ConsumedFoods.GroupBy(cf => cf.FoodId)
                                            .Select(group => new
                                             {
                                                 FoodId = group.Key,
                                                 TotalQuantityAndPortionCount = group.Sum(cf => cf.Quantity + cf.PortionCount)
                                             })
                                             .OrderByDescending(x => x.TotalQuantityAndPortionCount)
                                             .ToList();
                place = list.FindIndex(f => f.FoodId == foodId)+1;
            }
        }

        
        public int GetFoodConsumedTotalQuantityByFoodId(int foodId, params MealType[] mealTypes)
        {
            int totalQuantity = 0;
            if (mealTypes.Count() == 1)
            {
                var list = db.ConsumedFoods.Where(cf => cf.FoodId == foodId &&  cf.MealType == mealTypes[0] && cf.Quantity>0).ToList();
                totalQuantity = list.Sum(cf => cf.Quantity);
            }
            else if (mealTypes.Count() < 6)
            {
                var list = db.ConsumedFoods.Where(cf => cf.FoodId == foodId && (cf.MealType != MealType.Breakfast && cf.MealType != MealType.Lunch && cf.MealType != MealType.Dinner) && cf.Quantity > 0).ToList();
                totalQuantity = list.Sum(cf => cf.Quantity);
            }
            else
            {
                var list = db.ConsumedFoods.Where(cf => cf.FoodId == foodId && cf.Quantity > 0).ToList();
                totalQuantity = list.Sum(cf => cf.Quantity);

            }
            return totalQuantity;
        }
        public int GetFoodConsumedTotalPortionCountByFoodId(int foodId, params MealType[] mealTypes)
        {
            int totalPortionCount = 0;
            if (mealTypes.Count() == 1)
            {
                var list = db.ConsumedFoods.Where(cf => cf.FoodId == foodId && cf.MealType == mealTypes[0] && cf.PortionCount > 0).ToList();
                totalPortionCount = list.Sum(cf => cf.PortionCount);
            }
            else if (mealTypes.Count() <6)
            {
                var list = db.ConsumedFoods.Where(cf => cf.FoodId == foodId && (cf.MealType != MealType.Breakfast && cf.MealType != MealType.Lunch && cf.MealType != MealType.Dinner) && cf.PortionCount > 0).ToList();
                totalPortionCount = list.Sum(cf=>cf.PortionCount);
            }
            else
            {
                var list = db.ConsumedFoods.Where(cf => cf.FoodId == foodId && cf.PortionCount > 0).ToList();
                totalPortionCount = list.Sum(cf => cf.PortionCount);

            }
            return totalPortionCount;
        }

        public int GetTotalDaysInConsumedFoods()
        {
            int totalDays = 0;
            var cflist = db.ConsumedFoods.GroupBy(cf => cf.Day);
            totalDays=cflist.Count();
            return totalDays;
        }
        
    }
}
