using Entities.Enums;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Meal :BaseClass
    {
        public MealType MealType { get; set; }
        public int Day { get; set; }
        public ICollection<Meal_Food> Foods { get; set; }
    }
}
