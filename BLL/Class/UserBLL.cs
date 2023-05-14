using Castle.DynamicProxy.Generators;
using DAL;
using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BLL
{
    public class UserBLL : BaseClass<User>
    {
        public double GetDailyCalorieById(int id)
        {
            User? user = db.Users.Find(id);
            TimeSpan timePassed = DateTime.Now - user.CreationTime;
            int day = (int)timePassed.TotalDays + 1;
            var cfList = user.ConsumedFoods.Where(cf => cf.Day == day).ToList();
            double dailyCalorie = 0;

            foreach (var cf in cfList)
            {
                if (cf.Quantity > 0)
                    dailyCalorie += cf.Quantity * (double)cf.Food.CalorieFor100Gram;
                else if (cf.PortionCount > 0)
                {
                    if (cf.PortionType == PortionType.Full)
                        dailyCalorie += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.CalorieFor100Gram / (int)PortionType.Full;
                    else if (cf.PortionType == PortionType.Half)
                        dailyCalorie += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.CalorieFor100Gram / (int)PortionType.Half;
                    else if (cf.PortionType == PortionType.Quarter)
                        dailyCalorie += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.CalorieFor100Gram / (int)PortionType.Quarter;
                }
            }

            return dailyCalorie;
        }

        public double GetCaloriesForDaysById(int id, int howManyDaysBeforeToday, out int emptyDays, MealType[] mealTypes)
        {
            User? user = db.Users.Find(id);
            TimeSpan timePassed = DateTime.Now - user.CreationTime;
            double totalCalorie = 0;
            emptyDays = 0;
            if (mealTypes.Count() == 1)
            {
                for (int i = 0; i < howManyDaysBeforeToday; i++)
                {
                    int day = (int)timePassed.TotalDays - i + 1;
                    var cfList = user.ConsumedFoods.Where(cf => cf.Day == day && cf.MealType == mealTypes[0]).ToList();
                    if (cfList.Count == 0 && (int)timePassed.TotalDays >= howManyDaysBeforeToday)
                        emptyDays++;
                    foreach (var cf in cfList)
                    {
                        if (cf.Quantity > 0)
                            totalCalorie += cf.Quantity * (double)cf.Food.CalorieFor100Gram;
                        else if (cf.PortionCount > 0)
                        {
                            if (cf.PortionType == PortionType.Full)
                                totalCalorie += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.CalorieFor100Gram / (int)PortionType.Full;
                            else if (cf.PortionType == PortionType.Half)
                                totalCalorie += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.CalorieFor100Gram / (int)PortionType.Half;
                            else if (cf.PortionType == PortionType.Quarter)
                                totalCalorie += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.CalorieFor100Gram / (int)PortionType.Quarter;
                        }
                    }
                }
            }
            else if (mealTypes.Count() < 6 && mealTypes.Count()!=0)
            {
                for (int i = 0; i < howManyDaysBeforeToday; i++)
                {
                    int day = (int)timePassed.TotalDays - i + 1;
                    var cfList = user.ConsumedFoods.Where(cf => cf.Day == day && (cf.MealType != MealType.Breakfast && cf.MealType != MealType.Lunch && cf.MealType != MealType.Dinner)).ToList();
                    if (cfList.Count == 0 && (int)timePassed.TotalDays >= howManyDaysBeforeToday)
                        emptyDays++;
                    foreach (var cf in cfList)
                    {
                        if (cf.Quantity > 0)
                            totalCalorie += cf.Quantity * (double)cf.Food.CalorieFor100Gram;
                        else if (cf.PortionCount > 0)
                        {
                            if (cf.PortionType == PortionType.Full)
                                totalCalorie += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.CalorieFor100Gram / (int)PortionType.Full;
                            else if (cf.PortionType == PortionType.Half)
                                totalCalorie += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.CalorieFor100Gram / (int)PortionType.Half;
                            else if (cf.PortionType == PortionType.Quarter)
                                totalCalorie += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.CalorieFor100Gram / (int)PortionType.Quarter;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < howManyDaysBeforeToday; i++)
                {
                    int day = (int)timePassed.TotalDays - i + 1;
                    var cfList = user.ConsumedFoods.Where(cf => cf.Day == day).ToList();
                    if (cfList.Count == 0 && (int)timePassed.TotalDays >= howManyDaysBeforeToday)
                        emptyDays++;
                    foreach (var cf in cfList)
                    {
                        if (cf.Quantity > 0)
                            totalCalorie += cf.Quantity * (double)cf.Food.CalorieFor100Gram;
                        else if (cf.PortionCount > 0)
                        {
                            if (cf.PortionType == PortionType.Full)
                                totalCalorie += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.CalorieFor100Gram / (int)PortionType.Full;
                            else if (cf.PortionType == PortionType.Half)
                                totalCalorie += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.CalorieFor100Gram / (int)PortionType.Half;
                            else if (cf.PortionType == PortionType.Quarter)
                                totalCalorie += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.CalorieFor100Gram / (int)PortionType.Quarter;
                        }
                    }
                }

            }

            return totalCalorie;
        }

        public void GetDailyNutrientsPercentageById(int id, out double dailyProteinGram, out double dailyFatGram, out double dailyCarbohydrateGram)
        {
            dailyProteinGram = 0;
            dailyFatGram = 0;
            dailyCarbohydrateGram = 0;
            User? user = db.Users.Find(id);
            TimeSpan timePassed = DateTime.Now - user.CreationTime;
            int day = (int)timePassed.TotalDays + 1;
            var cfList = user.ConsumedFoods.Where(cf => cf.Day == day).ToList();

            foreach (var cf in cfList)
            {
                if (cf.Quantity > 0)
                {
                    dailyProteinGram += cf.Quantity * (double)cf.Food.ProteinRateFor100Gram;
                    dailyFatGram += cf.Quantity * (double)cf.Food.FatRateFor100Gram;
                    dailyCarbohydrateGram += cf.Quantity * (double)cf.Food.CarbonhydrateAmountFor100Gram;
                }
                else if (cf.PortionCount > 0)
                {
                    if (cf.PortionType == PortionType.Full)
                    {
                        dailyProteinGram += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.ProteinRateFor100Gram / (int)PortionType.Full;
                        dailyFatGram += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.FatRateFor100Gram / (int)PortionType.Full;
                        dailyCarbohydrateGram += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.CarbonhydrateAmountFor100Gram / (int)PortionType.Full;

                    }
                    else if (cf.PortionType == PortionType.Half)
                    {
                        dailyProteinGram += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.ProteinRateFor100Gram / (int)PortionType.Half;
                        dailyFatGram += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.FatRateFor100Gram / (int)PortionType.Half;
                        dailyCarbohydrateGram += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.CarbonhydrateAmountFor100Gram / (int)PortionType.Half;
                    }
                    else if (cf.PortionType == PortionType.Quarter)
                    {
                        dailyProteinGram += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.ProteinRateFor100Gram / (int)PortionType.Quarter;
                        dailyFatGram += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.FatRateFor100Gram / (int)PortionType.Quarter;
                        dailyCarbohydrateGram += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.CarbonhydrateAmountFor100Gram / (int)PortionType.Quarter;
                    }

                }
            }
        }

        public double GetSpesificDayCaloriesById(int id, int howManyDaysBeforeToday)
        {
            User? user = db.Users.Find(id);
            TimeSpan timePassed = DateTime.Now - user.CreationTime;
            int day = (int)timePassed.TotalDays - howManyDaysBeforeToday;
            var cfList = user.ConsumedFoods.Where(cf => cf.Day == day).ToList();
            double dayCalorie = 0;
            foreach (var cf in cfList)
            {
                if (cf.Quantity > 0)
                    dayCalorie += cf.Quantity * (double)cf.Food.CalorieFor100Gram;
                else if (cf.PortionCount > 0)
                {
                    if (cf.PortionType == PortionType.Full)
                        dayCalorie += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.CalorieFor100Gram / (int)PortionType.Full;
                    else if (cf.PortionType == PortionType.Half)
                        dayCalorie += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.CalorieFor100Gram / (int)PortionType.Half;
                    else if (cf.PortionType == PortionType.Quarter)
                        dayCalorie += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.CalorieFor100Gram / (int)PortionType.Quarter;
                }
            }

            return dayCalorie;
        }

        public int GetConsumedFoodsAmountForDaysById(int id, int howManyDaysBeforeToday, FoodCategory foodCategory, params MealType[] mealTypes)
        {
            User? user = db.Users.Find(id);
            TimeSpan timePassed = DateTime.Now - user.CreationTime;
            int totalAmount = 0;
            foreach (var mealType in mealTypes)
            {
                for (int i = 0; i < howManyDaysBeforeToday; i++)
                {
                    int day = (int)timePassed.TotalDays - i + 1;
                    var cfList = user.ConsumedFoods.Where(cf => cf.Day == day && cf.MealType == mealType && cf.Food.Category == foodCategory).ToList();

                    foreach (var cf in cfList)
                    {
                        totalAmount += cf.Quantity;
                        totalAmount += cf.PortionCount;
                    }

                }
            }
            return totalAmount;
        }
    }
}
