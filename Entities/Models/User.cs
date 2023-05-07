﻿using Entities.Enums;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User : BaseClass
    {
        public string Mail { get; set; }
        public string password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [NotMapped]
        public string FullName { get => FirstName +" "+LastName; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Weight { get; set; }
        public decimal GoalWeight { get; set; }
        public decimal DailyGoal { get; set; }
        public decimal Height { get; set; }

        [NotMapped]
        public decimal BodyMassIndex { get => Weight / (Height * Height); }

        public ICollection<Meal_Food> MealsAndFoods { get; set; }

    }
}