using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class Meal_FoodCFG : IEntityTypeConfiguration<Meal_Food>
    {
        public void Configure(EntityTypeBuilder<Meal_Food> builder)
        {
            builder.HasKey(ky => new { ky.MealId, ky.FoodId,ky.UserId });
        }
    }
}
