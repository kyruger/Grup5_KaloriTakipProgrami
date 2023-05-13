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
        public int GetFoodConsumedQuantityByFoodId(int foodId, params MealType[] mealTypes)
        {

            int quantity = 0;
            foreach (var mealType in mealTypes)
            {
                var consumedFoods = db.ConsumedFoods.Where(cf => cf.FoodId == foodId && cf.MealType == mealType).ToList();
                foreach (var cf in consumedFoods)
                {
                    quantity += cf.Quantity;
                    quantity += cf.PortionCount;
                }
            }
            return quantity;
        }

        public void GetFoodConsumedPlaceAndTotalByFoodId(int foodId,out int place,out int totalCount, params MealType[] mealTypes)
        {
            place = 0;
            totalCount = 0;
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
                place = list.FindIndex(f => f.FoodId == foodId);
                totalCount = list.Count();
            }
            else if (mealTypes.Count() > 5)
            {
                var list = db.ConsumedFoods.GroupBy(cf => cf.FoodId)
                            .Select(group => new
                            {
                                FoodId = group.Key,
                                TotalQuantityAndPortionCount = group.Sum(cf => cf.Quantity + cf.PortionCount)
                            })
                            .OrderByDescending(x => x.TotalQuantityAndPortionCount)
                            .ToList();
                place = list.FindIndex(f => f.FoodId == foodId);
                totalCount = list.Count();
            }
            else
            {
                var list = db.ConsumedFoods.Where(cf => cf.MealType != mealTypes[0] || cf.MealType != mealTypes[1] || cf.MealType != mealTypes[2])
                            .GroupBy(cf => cf.FoodId)
                            .Select(group => new
                            {
                                FoodId = group.Key,
                                TotalQuantityAndPortionCount = group.Sum(cf => cf.Quantity + cf.PortionCount)
                            })
                            .OrderByDescending(x => x.TotalQuantityAndPortionCount)
                            .ToList();
                place = list.FindIndex(f => f.FoodId == foodId);
                totalCount = list.Count();
            }
        }

    }
}
