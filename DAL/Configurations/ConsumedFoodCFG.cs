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
            builder.HasData(RandomData());

        }

        public List<ConsumedFood> RandomData()
        {
            Random rand = new Random();
            var consumedFoods = new List<ConsumedFood>();
            for (int i = 1; i <= 1500; i++)
            {
                consumedFoods.Add(new ConsumedFood
                {
                    ID = i,
                    MealType = (MealType)rand.Next(1, 6),
                    Quantity = rand.Next(1, 5),
                    Day = rand.Next(1, 46),
                    UserId = rand.Next(1, 6),
                    FoodId = rand.Next(1, 29),
                });
            }
            for (int i = 1501; i <= 3000; i++)
            {
                consumedFoods.Add(new ConsumedFood
                {
                    ID = i,
                    MealType = (MealType)rand.Next(1, 6),
                    PortionCount = rand.Next(1, 5),
                    PortionType = (PortionType)rand.Next(1, 4),
                    Day = rand.Next(1, 46),
                    UserId = rand.Next(1, 6),
                    FoodId = rand.Next(1, 29),
                });
            }
            return consumedFoods;
        }        
    }
}
