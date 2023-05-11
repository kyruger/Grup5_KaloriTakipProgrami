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
    public class UserCFG : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.FirstName).HasColumnType("nvarchar").HasMaxLength(30);
            builder.Property(x => x.LastName).HasColumnType("nvarchar").HasMaxLength(30);
            builder.Property(x => x.PhoneNumber).HasColumnType("varchar").HasMaxLength(10);
            builder.Property(x => x.DayGoal).HasDefaultValue(0).HasMaxLength(90);
            builder.Property(x=>x.Age).HasMaxLength(120);
            builder.Ignore(p => p.dayGoal);
            builder.Ignore(p => p.DayGoalCreationTime);
            builder.Ignore(p => p.FullName);
            builder.Ignore(p => p.BodyMassIndex);

            builder.HasData(
                new User
                {
                    ID =1,
                    Mail = "eneskurt@bilgeadam.com",
                    Password = "12345",
                    FirstName = "Enes",
                    LastName = "Kurt",
                    Gender = Gender.Male,
                    Age = 27,
                    DailyGoalCalorie = 3000,
                    PhoneNumber = "5434168",
                    Weight = Convert.ToDecimal(66.5),
                    GoalWeight = 72,
                    Height =170,
                },
                new User
                {
                    ID =2,
                    Mail = "baranoguz@bilgeadam.com",
                    Password = "12345",
                    FirstName = "Baran",
                    LastName = "Oğuz",
                    Gender = Gender.Male,
                    Age = 24,
                    DayGoal =30,
                    DailyGoalCalorie = 3500,
                    PhoneNumber = "11111",
                    Weight = Convert.ToDecimal(73),
                    GoalWeight = 80,
                    Height =185,
                }
                ); 
        }
    }
}
