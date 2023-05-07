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
    public class FoodCFG : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.Property(a => a.Name).HasColumnType("varchar").HasMaxLength(100);
            builder.Property(a => a.Calorie).HasPrecision(5, 2);
            builder.Property(a => a.ProteinRate).HasPrecision(5, 2);
            builder.Property(a => a.FatRate).HasPrecision(5, 2);
            builder.Property(a => a.CarbonhydrateAmount).HasPrecision(5, 2);         

        }
    }
}
