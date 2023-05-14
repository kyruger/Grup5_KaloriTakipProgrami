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
                    CreationTime = new DateTime(2023, 4, 18, 14, 30, 0),
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
                    CreationTime = new DateTime(2023, 4, 18, 14, 30, 0),
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
                },
                new User
                {
                    ID =3,
                    CreationTime = new DateTime(2023, 4, 18, 14, 30, 0),
                    Mail = "nazlikoc@bilgeadam.com",
                    Password = "12345",
                    FirstName = "Nazli",
                    LastName = "Koc",
                    Gender = Gender.Female,
                    Age = 30,
                    DayGoal =0,
                    DailyGoalCalorie = 2500,
                    PhoneNumber = "22222",
                    Weight = Convert.ToDecimal(47),
                    GoalWeight = 45,
                    Height =165,
                },
                new User
                {
                    ID =4,
                    CreationTime = new DateTime(2023, 4, 18, 14, 30, 0),
                    Mail = "erdincdincer@bilgeadam.com",
                    Password = "12345",
                    FirstName = "Erdinç",
                    LastName = "Dincer",
                    Gender = Gender.Male,
                    Age = 35,
                    DayGoal =60,
                    DailyGoalCalorie = 3200,
                    PhoneNumber = "3333333",
                    Weight = Convert.ToDecimal(85),
                    GoalWeight = 80,
                    Height =180,
                },
                new User
                {
                    ID =5,
                    CreationTime = new DateTime(2023, 4, 18, 14, 30, 0),
                    Mail = "yilmazuslu@bilgeadam.com",
                    Password = "12345",
                    FirstName = "Yılmaz",
                    LastName = "Uslu",
                    Gender = Gender.Male,
                    Age = 45,
                    DayGoal =0,
                    DailyGoalCalorie = 2800,
                    PhoneNumber = "22222",
                    Weight = Convert.ToDecimal(75),
                    GoalWeight = 65,
                    Height =175,
                }
                ); 
        }
    }
}
