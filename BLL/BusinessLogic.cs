using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BusinessLogic
    {
        public BusinessLogic()
        {
            Foods = new FoodBLL();
            Users = new UserBLL();
            ConsumedFoods = new ConsumedFoodBLL();
        }
        public FoodBLL Foods { get; set; }
        public UserBLL Users { get; set; }
        public ConsumedFoodBLL ConsumedFoods { get; set; }
    }
}
