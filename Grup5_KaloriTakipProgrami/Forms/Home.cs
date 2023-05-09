using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WndPL.Forms
{
    public partial class Home : Form
    {
        public Home(int id)
        {
            InitializeComponent();
            userId = id;
        }
        ConsumedFoodBLL cfBLL = new ConsumedFoodBLL();
        UserBLL userBLL = new UserBLL();
        FoodBLL FoodBLL = new FoodBLL();
        int userId;
        private void Home_Load(object sender, EventArgs e)
        {
            User user = userBLL.GetById(userId);

        }
    }
}
