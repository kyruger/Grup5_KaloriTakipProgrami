using User;
using User.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class FoodCFG : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.Property(a => a.Name).HasColumnType("varchar").HasMaxLength(100);
            builder.Property(a => a.CalorieFor100Gram).HasPrecision(5, 2);
            builder.Property(a => a.ProteinRateFor100Gram).HasPrecision(5, 2);
            builder.Property(a => a.FatRateFor100Gram).HasPrecision(5, 2);
            builder.Property(a => a.CarbonhydrateAmountFor100Gram).HasPrecision(5, 2);


            builder.HasData(
                new Food
                {
                    ID = 1,
                    Name = "Hamburger",
                    Category = FoodCategory.FastFood,
                    PortionGram = 190,
                    CalorieFor100Gram = Convert.ToDecimal(300.1546),
                    ProteinRateFor100Gram = 17,
                    FatRateFor100Gram = 14,
                    CarbonhydrateAmountFor100Gram = 69,
                },
                new Food
                {
                    ID = 2,
                    Name = "Pizza",
                    Category = FoodCategory.FastFood,
                    PortionGram = 38,
                    CalorieFor100Gram = Convert.ToDecimal(186),
                    ProteinRateFor100Gram = Convert.ToDecimal(5.84),
                    FatRateFor100Gram = Convert.ToDecimal(4.33),
                    CarbonhydrateAmountFor100Gram = Convert.ToDecimal(30.51),
                },                
                new Food
                {
                    ID = 3,
                    Name = "Mantı",
                    Category = FoodCategory.BakedGood,
                    PortionGram = 190,
                    CalorieFor100Gram = Convert.ToDecimal(170),
                    ProteinRateFor100Gram = Convert.ToDecimal(4.12),
                    FatRateFor100Gram = Convert.ToDecimal(3.5),
                    CarbonhydrateAmountFor100Gram = Convert.ToDecimal(29.71),
                }
                );
        }
    }
}
