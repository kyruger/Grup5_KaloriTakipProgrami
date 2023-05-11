using DAL;
using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public void GetDailyNutrientsPercentageById(int id,out double dailyProteinPercentage, out double dailyFatPercentage, out double dailyCarbohydratePercentage)
        {
            dailyProteinPercentage = 0;
            dailyFatPercentage = 0;
            dailyCarbohydratePercentage = 0;
            User? user = db.Users.Find(id);
            TimeSpan timePassed = DateTime.Now - user.CreationTime;
            int day = (int)timePassed.TotalDays + 1;
            var cfList = user.ConsumedFoods.Where(cf => cf.Day == day).ToList();          
            foreach (var cf in cfList)
            {
                if (cf.Quantity > 0)
                {
                    dailyProteinPercentage += cf.Quantity * (double)cf.Food.ProteinRateFor100Gram;
                    dailyFatPercentage += cf.Quantity * (double)cf.Food.FatRateFor100Gram;
                    dailyCarbohydratePercentage += cf.Quantity * (double)cf.Food.CarbonhydrateAmountFor100Gram;
                }
                else if (cf.PortionCount > 0)
                {
                    if (cf.PortionType == PortionType.Full)
                    {
                        dailyProteinPercentage += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.ProteinRateFor100Gram / (int)PortionType.Full;
                        dailyFatPercentage += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.FatRateFor100Gram / (int)PortionType.Full;
                        dailyCarbohydratePercentage += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.CarbonhydrateAmountFor100Gram / (int)PortionType.Full;

                    }
                    else if (cf.PortionType == PortionType.Half)
                    {
                        dailyProteinPercentage += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.ProteinRateFor100Gram / (int)PortionType.Half;
                        dailyFatPercentage += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.FatRateFor100Gram / (int)PortionType.Half;
                        dailyCarbohydratePercentage += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.CarbonhydrateAmountFor100Gram / (int)PortionType.Half;
                    }                 
                    else if (cf.PortionType == PortionType.Quarter)
                    {
                        dailyProteinPercentage += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.ProteinRateFor100Gram / (int)PortionType.Quarter;
                        dailyFatPercentage += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.FatRateFor100Gram / (int)PortionType.Quarter;
                        dailyCarbohydratePercentage += cf.PortionCount * (double)(cf.Food.PortionGram / 100) * (double)cf.Food.CarbonhydrateAmountFor100Gram / (int)PortionType.Quarter;
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

    }
}
