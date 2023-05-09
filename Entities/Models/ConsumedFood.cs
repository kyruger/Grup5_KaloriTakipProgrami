using Entities.Enums;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ConsumedFood : BaseClass
    {
        public MealType MealType { get; set; }
        public int Day { get; set; }
        public int PortionCount { get; set; } = 0;
        public PortionType? PortionType { get; set; }
        public int Quantity { get; set; } = 0;
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int FoodId { get; set; }
        public virtual Food Food { get; set; }

    }
}
