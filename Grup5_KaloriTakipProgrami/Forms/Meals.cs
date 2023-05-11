using BLL;
using Entities;
using Entities.Enums;
using Grup5_KaloriTakipProgrami;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WndPL.Forms
{
    public partial class Meals : Form
    {
        public Meals()
        {
            InitializeComponent();
        }
        BusinessLogic bl;
        int foodID;
        int UserID = 2;

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AddNewFood addNewFood = new AddNewFood();
            addNewFood.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFood.SelectedItems.Count > 0)
            {
                ButtonActivity(true);
                int foodId = (int)lvFood.FocusedItem.Tag;
                Food food = bl.Foods.GetById(foodId);
                tbxFoodName.Text = food.Name;
                tbxFoodCalorie.Text = food.CalorieFor100Gram.ToString();
                foodID = (int)lvFood.FocusedItem.Tag;



            }
        }

        private void Meals_Load(object sender, EventArgs e)
        {
            bl = new BusinessLogic();
            List<Food> foods = bl.Foods.GetAll();
            ListViewFillFood(foods);
            cbxPortion.SelectedIndex = 0;






        }
        private void ListViewFillFood(List<Food> foods)
        {
            foreach (Food food in foods)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = food.Name;
                lvi.SubItems.Add(food.PortionGram.ToString());
                lvi.SubItems.Add(food.Category.ToString());
                lvi.SubItems.Add(food.CalorieFor100Gram.ToString());
                lvi.SubItems.Add(food.ProteinRateFor100Gram.ToString());
                lvi.SubItems.Add(food.FatRateFor100Gram.ToString());
                lvi.SubItems.Add(food.CarbonhydrateAmountFor100Gram.ToString());
                lvi.Tag = food.ID;
                lvFood.Items.Add(lvi);
            }



        }

        private void ButtonActivity(bool control)
        {
            if (control)
            {
                btnAddNewFood.Enabled = true;
                btnAddToMeal.Enabled = true;
            }
            else
            {
                btnAddNewFood.Enabled = true;
                btnAddToMeal.Enabled = true;
            }

        }

        private void btnAddToMeal_Click(object sender, EventArgs e)
        {
            ConsumedFood consumedFood = new ConsumedFood();
            consumedFood.FoodId = foodID;
            if (cbxPortion.SelectedItem.ToString() == "Full")
            {
                consumedFood.PortionType = PortionType.Full;
            }
            else if (cbxPortion.SelectedItem.ToString() == "Half")
            {
                consumedFood.PortionType = PortionType.Half;
            }
            else if (cbxPortion.SelectedItem.ToString() == "Quarter")
            {
                consumedFood.PortionType = PortionType.Quarter;
            }
            else
            {

            }


        }

        private void btnAddNewFood_Click(object sender, EventArgs e)
        {
            AddNewFood addNewFood = new AddNewFood();
            addNewFood.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBreakFeast_Click(object sender, EventArgs e)
        {
            Entities.User user = bl.Users.GetById(UserID);
            TimeSpan timePassed = DateTime.Now - user.CreationTime;
            int day = (int)timePassed.TotalDays + 1;
            List<ConsumedFood> consumedFoods = bl.ConsumedFoods.GetConsumedFoodsByDayAndMealType(day, MealType.Breakfast);
            foreach (ConsumedFood consumed in consumedFoods)
            {
                ListViewItem lvi = new ListViewItem();
                int id= ;
                lvi.Text = food.Name;
                lvi.SubItems.Add(food.PortionGram.ToString());
                lvi.SubItems.Add(food.Category.ToString());
                lvi.SubItems.Add(food.CalorieFor100Gram.ToString());
                lvi.SubItems.Add(food.ProteinRateFor100Gram.ToString());
                lvi.SubItems.Add(food.FatRateFor100Gram.ToString());
                lvi.SubItems.Add(food.CarbonhydrateAmountFor100Gram.ToString());
                lvi.Tag = food.ID;
                lvFood.Items.Add(lvi);
            }
        }
    }
}
