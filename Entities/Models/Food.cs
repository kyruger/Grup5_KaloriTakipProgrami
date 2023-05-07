using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Food
    {
        public int FoodId { get; set; }
        public string Name { get; set; }
        public decimal Calorie { get; set; }
        public decimal ProteinRate { get; set; }
        public decimal FatRate { get; set; }
        public decimal CarbonhydrateAmount { get; set; }
        public ICollection<Meal_Food> Meals { get; set; }

    }
}
