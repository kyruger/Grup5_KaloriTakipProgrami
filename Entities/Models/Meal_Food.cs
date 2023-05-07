using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Meal_Food
    {
        public Meal_Food()
        {
            CreationTime = DateTime.Now;
        }
        public DateTime CreationTime { get; set; }
        public int MealId { get; set; }
        public int FoodId { get; set; }
        public Meal Meal { get; set; }
        public Food Food { get; set; }
        public int UserId{ get; set; }
        public User User { get; set; }

    }
}
