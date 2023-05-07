using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Meal
    {
        public int MealId { get; set; }
        public MealType MealType { get; set; }
        public int Day { get; set; }
        public ICollection<Meal_Food> Foods { get; set; }
    }
}
