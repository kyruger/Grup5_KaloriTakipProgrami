using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        public int UserId { get; set; }

        public string Mail { get; set; }

        public string password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Weight { get; set; }
        public decimal GoalWeight { get; set; }
        public decimal DailyGoal { get; set; }
        public decimal Height { get; set; }
        public decimal BodyMassIndex { get; set; }

        public ICollection<Meal_Food> MealsAndFoods { get; set; }

    }
}
