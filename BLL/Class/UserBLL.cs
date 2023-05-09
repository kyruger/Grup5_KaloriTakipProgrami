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
        public void GetDailyCalorieById(int id)
        {
            User? user = db.Users.Find(id);
            TimeSpan timePassed = DateTime.Now - user.CreationTime;
            int day = (int)timePassed.TotalDays + 1;
            var cfList = user.ConsumedFoods.Where(a => a.Day == day).ToList();
            double dailyCalorie = 0;
            foreach (var cf in cfList)
            {
                if (cf.Quantity > 0)
                    dailyCalorie += cf.Quantity * (double)cf.Food.CalorieFor100Gram;
                else if (cf.PortionCount > 0)
                {
                    if (cf.PortionType == PortionType.Full)
                        dailyCalorie += cf.PortionCount * (double)(cf.Food.PortionGram / cf.Food.CalorieFor100Gram) * (double)cf.Food.CalorieFor100Gram / (int)PortionType.Full;
                    else if (cf.PortionType == PortionType.Half)
                        dailyCalorie += cf.PortionCount * (double)(cf.Food.PortionGram / cf.Food.CalorieFor100Gram) * (double)cf.Food.CalorieFor100Gram / (int)PortionType.Half;
                    else if (cf.PortionType == PortionType.Quarter)
                        dailyCalorie += cf.PortionCount * (double)(cf.Food.PortionGram / cf.Food.CalorieFor100Gram) * (double)cf.Food.CalorieFor100Gram / (int)PortionType.Quarter;
                }
            }
        }
    }
}
