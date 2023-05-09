using Entities;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class ConsumedFoodCFG : IEntityTypeConfiguration<ConsumedFood>
    {
        public void Configure(EntityTypeBuilder<ConsumedFood> builder)
        {
            builder.Property(x => x.Quantity).HasDefaultValue(0);
            builder.Property(x => x.PortionCount).HasDefaultValue(0);
            builder.HasData(
                new ConsumedFood
                {
                    ID =1,
                    MealType = MealType.Dinner,
                    Day = 1,
                    UserId = 1,
                    FoodId = 1,
                },              
                new ConsumedFood
                {
                    ID =2,
                    MealType = MealType.Dinner,
                    Day = 1,
                    UserId = 1,
                    FoodId = 2,
                },
                new ConsumedFood
                {
                    ID =3,
                    MealType = MealType.Lunch,
                    Day = 1,
                    UserId = 1,
                    FoodId = 3,
                },
                new ConsumedFood
                {
                    ID =4,
                    MealType = MealType.Lunch,
                    Day = 2,
                    UserId = 1,
                    FoodId = 1,
                },
                new ConsumedFood
                {
                    ID =5,
                    MealType = MealType.Lunch,
                    Day = 2,
                    UserId = 1,
                    FoodId = 2,
                },
                new ConsumedFood
                {
                    ID =6,
                    MealType = MealType.Dinner,
                    Day = 2,
                    UserId = 1,
                    FoodId = 2,
                },
                new ConsumedFood
                {
                    ID =7,
                    MealType = MealType.Breakfast,
                    Day = 3,
                    UserId = 1,
                    FoodId = 1,
                },
                new ConsumedFood
                {
                    ID =8,
                    MealType = MealType.Breakfast,
                    Day = 3,
                    UserId = 1,
                    FoodId = 1,
                },
                new ConsumedFood
                {
                    ID =9,
                    MealType = MealType.Dinner,
                    Day = 5,
                    UserId = 1,
                    FoodId = 3,
                },
                new ConsumedFood
                {
                    ID =10,
                    MealType = MealType.Lunch,
                    Day = 1,
                    UserId = 2,
                    FoodId = 3,
                },
                new ConsumedFood
                {
                    ID =11,
                    MealType = MealType.Lunch,
                    Day = 2,
                    UserId = 2,
                    FoodId = 2,
                },
                new ConsumedFood
                {
                    ID =12,
                    MealType = MealType.Breakfast,
                    Day = 1,
                    UserId = 2,
                    FoodId = 3,
                },
                new ConsumedFood
                {
                    ID =13,
                    MealType = MealType.Dinner,
                    Day = 1,
                    UserId = 2,
                    FoodId = 1,
                },
                new ConsumedFood
                {
                    ID =14,
                    MealType = MealType.Lunch,
                    Day = 4,
                    UserId = 2,
                    FoodId = 3,
                },
                new ConsumedFood
                {
                    ID =15,
                    MealType = MealType.Lunch,
                    Day = 4,
                    UserId = 2,
                    FoodId = 2,
                },
                new ConsumedFood
                {
                    ID =16,
                    MealType = MealType.Breakfast,
                    Day = 4,
                    UserId = 2,
                    FoodId = 1,
                },
                new ConsumedFood
                {
                    ID =17,
                    MealType = MealType.Breakfast,
                    Day = 5,
                    UserId = 2,
                    FoodId = 1,
                }
                );
        }
    }
}
