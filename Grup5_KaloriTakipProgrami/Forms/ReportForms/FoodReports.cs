using BLL;
using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WndPL.Forms.ReportForms
{
    public partial class FoodReports : Form
    {
        public FoodReports()
        {
            InitializeComponent();
        }
        BusinessLogic bl = new BusinessLogic();
        Helper helper = new Helper();
        int foodId;
        private void FoodReports_Load(object sender, EventArgs e)
        {

        }

        private void txtFoodSearch_TextChanged(object sender, EventArgs e)
        {

            lvSearchedFoods.Items.Clear();
            List<Food> searchedFoods = bl.Foods.GetFoodsByContainText(txtFoodSearch.Text.Trim());
            foreach (var food in searchedFoods)
            {
                ListViewItem lv1 = new ListViewItem();
                lv1.Tag = food.ID;
                lv1.Text = food.Name;
                lv1.SubItems.Add(food.Category.ToString());
                lvSearchedFoods.Items.Add(lv1);
            }
            lvSearchedFoods.Show();
        }

        private void txtFoodSearch_Leave(object sender, EventArgs e)
        {
            lvSearchedFoods.Hide();
            if (lvSearchedFoods.SelectedItems.Count > 0)
            {
                lblFoodName.Text = lvSearchedFoods.SelectedItems[0].Text;
                foodId = (int)lvSearchedFoods.SelectedItems[0].Tag;
                Food selectedFood = bl.Foods.GetById(foodId);
                txtCalorie.Text = selectedFood.CalorieFor100Gram.ToString();
                txtCategory.Text = selectedFood.Category.ToString();
                txtPortion.Text = selectedFood.PortionGram.ToString();
                txtProtein.Text = selectedFood.ProteinRateFor100Gram.ToString();
                txtFat.Text = selectedFood.FatRateFor100Gram.ToString();
                txtCarbohydrate.Text = selectedFood.CarbonhydrateAmountFor100Gram.ToString();
                txtQuantity.Text = bl.ConsumedFoods.GetFoodConsumedQuantityByFoodId(foodId, MealType.Breakfast, MealType.Lunch, MealType.Dinner, MealType.Snack1, MealType.Snack2, MealType.Snack3, MealType.Snack4, MealType.Snack5).ToString();
                bl.ConsumedFoods.GetFoodConsumedPlaceAndTotalByFoodId(foodId, out int place, out int totalCount, MealType.Breakfast, MealType.Lunch, MealType.Dinner, MealType.Snack1, MealType.Snack2, MealType.Snack3, MealType.Snack4, MealType.Snack5);
                txtPlace.Text = place.ToString();
                lblTotalFoodCount.Text = totalCount.ToString();
            }
            lblFoodSearch.Show();

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = bl.ConsumedFoods.GetFoodConsumedQuantityByFoodId(foodId, MealType.Breakfast, MealType.Lunch, MealType.Dinner, MealType.Snack1, MealType.Snack2, MealType.Snack3, MealType.Snack4, MealType.Snack5).ToString();
            bl.ConsumedFoods.GetFoodConsumedPlaceAndTotalByFoodId(foodId, out int place, out int totalCount, MealType.Breakfast, MealType.Lunch, MealType.Dinner, MealType.Snack1, MealType.Snack2, MealType.Snack3, MealType.Snack4, MealType.Snack5);
            txtPlace.Text = place.ToString();
            lblTotalFoodCount.Text = totalCount.ToString();
            lblMealType.Text = "All";
        }

        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = bl.ConsumedFoods.GetFoodConsumedQuantityByFoodId(foodId, MealType.Breakfast).ToString();
            bl.ConsumedFoods.GetFoodConsumedPlaceAndTotalByFoodId(foodId, out int place, out int totalCount, MealType.Breakfast);
            txtPlace.Text = place.ToString();
            lblTotalFoodCount.Text = totalCount.ToString();
            lblMealType.Text = MealType.Breakfast.ToString();
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = bl.ConsumedFoods.GetFoodConsumedQuantityByFoodId(foodId, MealType.Lunch).ToString();
            bl.ConsumedFoods.GetFoodConsumedPlaceAndTotalByFoodId(foodId, out int place, out int totalCount, MealType.Lunch);
            txtPlace.Text = place.ToString();
            lblTotalFoodCount.Text = totalCount.ToString();
            lblMealType.Text = MealType.Lunch.ToString();
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = bl.ConsumedFoods.GetFoodConsumedQuantityByFoodId(foodId, MealType.Dinner).ToString();
            bl.ConsumedFoods.GetFoodConsumedPlaceAndTotalByFoodId(foodId, out int place, out int totalCount, MealType.Dinner);
            txtPlace.Text = place.ToString();
            lblTotalFoodCount.Text = totalCount.ToString();
            lblMealType.Text = MealType.Dinner.ToString();
        }

        private void btnOthers_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = bl.ConsumedFoods.GetFoodConsumedQuantityByFoodId(foodId, MealType.Snack1, MealType.Snack2, MealType.Snack3, MealType.Snack4, MealType.Snack5).ToString();
            bl.ConsumedFoods.GetFoodConsumedPlaceAndTotalByFoodId(foodId, out int place, out int totalCount, MealType.Snack1, MealType.Snack2, MealType.Snack3, MealType.Snack4, MealType.Snack5);
            txtPlace.Text = place.ToString();
            lblTotalFoodCount.Text = totalCount.ToString();
            lblMealType.Text = "Others";
        }

        private void lblFoodSearch_Click(object sender, EventArgs e)
        {
            lblFoodSearch.Hide();
            txtFoodSearch.Focus();
        }

        private void txtFoodSearch_Enter(object sender, EventArgs e)
        {
            lblFoodSearch.Hide();
        }

        /*public void FillPlaceAndQuantity(MealType[] mealTypes)
        {
            txtQuantity.Text = bl.ConsumedFoods.GetFoodConsumedQuantityByFoodId(foodId, mealTypes).ToString();
            bl.ConsumedFoods.GetFoodConsumedPlaceAndTotalByFoodId(foodId, out int place, out int totalCount, mealTypes);
            if(mealTypes.Count() == 1)
            {
                txtPlace.Text = place.ToString();
                lblTotalFoodCount.Text = totalCount.ToString();
                lblMealType.Text = mealTypes[0].ToString();
            }
            else if (mealTypes.Count() > 5)
            {
                txtPlace.Text = place.ToString();
                lblTotalFoodCount.Text = totalCount.ToString();
                lblMealType.Text = "All";
            }
            else
            {
                txtPlace.Text = place.ToString();
                lblTotalFoodCount.Text = totalCount.ToString();
                lblMealType.Text = "Others";
            }
        }
        */
    }
}
