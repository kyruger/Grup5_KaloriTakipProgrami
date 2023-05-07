using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    internal class Food
    {
        public int FoodID { get; set; }
        public string Name { get; set; }
        public decimal Calori { get; set; }
        public decimal ProteinRate { get; set; }
        public decimal VitaminRate { get; set; }
        public decimal FatRate { get; set; }
        public decimal CarbonhydrateAmount { get; set; }


        //Relations

        //public ICollection<Meal_Food> Meals { get; set; }

    }
}
