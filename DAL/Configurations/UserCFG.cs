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
    public class UserCFG : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.FirstName).HasColumnType("nvarchar").HasMaxLength(30);
            builder.Property(x => x.LastName).HasColumnType("nvarchar").HasMaxLength(30);
            builder.Property(x => x.PhoneNumber).HasColumnType("varchar").HasMaxLength(10);
            builder.Property(x => x.DailyGoal).HasDefaultValue(0).HasMaxLength(90);
            builder.Property(x=>x.Age).HasMaxLength(120);


        }
    }
}
