using BLL;
using Entities;
using Entities.Enums;
using Guna.Charts.WinForms;
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
        int userId = 2;
        private void FoodReports_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetNames(typeof(FoodCategory)))
            {
                cbCategory.Items.Add(item);
            }
        }



        #region Food Search
        private void txtFoodSearch_TextChanged(object sender, EventArgs e)
        {

            lvSearchedFoods.Items.Clear();
            List<Food> searchedFoods = bl.Foods.GetFoodsByContainTextAndOwnerId(txtFoodSearch.Text.Trim(), userId);
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
            lblFoodSearch.Show();

        }
        private void txtFoodSearch_Enter(object sender, EventArgs e)
        {
            lblFoodSearch.Hide();
        }
        private void lblFoodSearch_Click(object sender, EventArgs e)
        {
            lblFoodSearch.Hide();
            txtFoodSearch.Focus();
        }
        private void FoodReports_Click(object sender, EventArgs e)
        {
            lvSearchedFoods.Hide();
            lblFoodSearch.Show();
            lblFat.Focus();
        }
        #endregion

        private void lvSearchedFoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvSearchedFoods.Hide();
            if (lvSearchedFoods.SelectedItems.Count > 0)
            {
                txtFoodName.Text = lvSearchedFoods.SelectedItems[0].Text;
                foodId = (int)lvSearchedFoods.SelectedItems[0].Tag;
                Food selectedFood = bl.Foods.GetById(foodId);

                // fill food deatils
                txtCalorie.Text = selectedFood.CalorieFor100Gram.ToString();
                cbCategory.SelectedIndex = (int)selectedFood.Category - 1;
                txtPortion.Text = selectedFood.PortionGram.ToString();
                txtProtein.Text = selectedFood.ProteinRateFor100Gram.ToString();
                txtFat.Text = selectedFood.FatRateFor100Gram.ToString();
                txtCarbohydrate.Text = selectedFood.CarbonhydrateAmountFor100Gram.ToString();
                if (selectedFood.OwnerId == 0)
                {
                    txtFoodName.ReadOnly = true;
                    txtCalorie.ReadOnly = true;
                    txtPortion.ReadOnly = true;
                    txtProtein.ReadOnly = true;
                    txtFat.ReadOnly = true;
                    txtCarbohydrate.ReadOnly = true;
                    cbCategory.Enabled = false;
                    btnSave.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                {
                    txtFoodName.ReadOnly = false;
                    txtCalorie.ReadOnly = false;
                    txtPortion.ReadOnly = false;
                    txtProtein.ReadOnly = false;
                    txtFat.ReadOnly = false;
                    txtCarbohydrate.ReadOnly = false;
                    cbCategory.Enabled = true;
                    btnSave.Enabled = true;
                    btnDelete.Enabled = true;
                }

                //fill place and total and Quantity and Count
                FillPlaceAndTotal(MealType.Breakfast, MealType.Lunch, MealType.Dinner, MealType.Snack1, MealType.Snack2, MealType.Snack3, MealType.Snack4, MealType.Snack5);

                //fill FoodAvgDayConsume Pie chart 
                int dataPointCount = pieDataFoodAvgDayConsume.DataPointCount;
                pieDataFoodAvgDayConsume.DataPoints.Clear();
                List<ConsumedFood> consumedFoods = bl.ConsumedFoods.GetAll();
                int totalDay = bl.ConsumedFoods.GetTotalDaysInConsumedFoods();

                for (int i = 0; i < dataPointCount - 1; i++)
                {
                    LPoint lPoint = new();
                    lPoint.Label = ((MealType)(i + 1)).ToString();
                    int totalQuantity1 = bl.ConsumedFoods.GetFoodConsumedTotalQuantityByFoodId(foodId, (MealType)(i + 1));
                    int totalPortionCount1 = bl.ConsumedFoods.GetFoodConsumedTotalPortionCountByFoodId(foodId, (MealType)(i + 1));
                    double dailyConsumeAmount = totalQuantity1 + totalPortionCount1;
                    lPoint.Y = Math.Round(dailyConsumeAmount / totalDay, 2);
                    pieDataFoodAvgDayConsume.DataPoints.Add(lPoint);
                }
                LPoint lPointLast = new();
                lPointLast.Label = "Others";
                int totalQuantity = bl.ConsumedFoods.GetFoodConsumedTotalQuantityByFoodId(foodId, MealType.Snack1, MealType.Snack2, MealType.Snack3, MealType.Snack4, MealType.Snack5);
                int totalPortionCount = bl.ConsumedFoods.GetFoodConsumedTotalPortionCountByFoodId(foodId, MealType.Snack1, MealType.Snack2, MealType.Snack3, MealType.Snack4, MealType.Snack5);
                double dailyConsumeAmount1 = totalQuantity + totalPortionCount;
                lPointLast.Y = Math.Round(dailyConsumeAmount1 / totalDay, 2);
                pieDataFoodAvgDayConsume.DataPoints.Add(lPointLast);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            FillPlaceAndTotal(MealType.Breakfast, MealType.Lunch, MealType.Dinner, MealType.Snack1, MealType.Snack2, MealType.Snack3, MealType.Snack4, MealType.Snack5);
        }

        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            FillPlaceAndTotal(MealType.Breakfast);
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            FillPlaceAndTotal(MealType.Lunch);
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            FillPlaceAndTotal(MealType.Dinner);
        }

        private void btnOthers_Click(object sender, EventArgs e)
        {
            FillPlaceAndTotal(MealType.Snack1, MealType.Snack2, MealType.Snack3, MealType.Snack4, MealType.Snack5);
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to delete this food?  ", "Delete", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                bl.Foods.Remove(foodId);
                helper.ClearTextsExceptOne(this, txtFoodSearch);
                foodId = 0;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            helper.ClearTextsExceptOne(this, txtFoodSearch);
            foodId = 0;
            txtFoodName.ReadOnly = false;
            txtCalorie.ReadOnly = false;
            txtPortion.ReadOnly = false;
            txtProtein.ReadOnly = false;
            txtFat.ReadOnly = false;
            txtCarbohydrate.ReadOnly = false;
            cbCategory.Text = "";
            cbCategory.SelectedIndex = -1;
            cbCategory.Enabled = true;
            btnSave.Enabled = true;
            txtFoodName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Food food = bl.Foods.GetById(foodId);
            if (food != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update this food?  ", "Update", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    food.Name = txtFoodName.Text;
                    food.CalorieFor100Gram = Convert.ToInt32(txtCalorie.Text);
                    food.Category = (FoodCategory)(cbCategory.SelectedIndex + 1);
                    food.PortionGram = Convert.ToInt32(txtPortion.Text);
                    food.ProteinRateFor100Gram = Convert.ToInt32(txtProtein.Text);
                    food.FatRateFor100Gram = Convert.ToInt32(txtFat.Text);
                    food.CarbonhydrateAmountFor100Gram = Convert.ToInt32(txtCarbohydrate.Text);
                    food.OwnerId = userId;
                    bl.Foods.Update(food);
                }
            }
            else if (!bl.Foods.IsFoodExist(txtFoodName.Text))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to add this food?  ", "Add", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    Food newFood = new Food();
                    newFood.Name = txtFoodName.Text;
                    newFood.CalorieFor100Gram = Convert.ToInt32(txtCalorie.Text);
                    newFood.Category = (FoodCategory)(cbCategory.SelectedIndex + 1);
                    newFood.PortionGram = Convert.ToInt32(txtPortion.Text);
                    newFood.ProteinRateFor100Gram = Convert.ToInt32(txtProtein.Text);
                    newFood.FatRateFor100Gram = Convert.ToInt32(txtFat.Text);
                    newFood.CarbonhydrateAmountFor100Gram = Convert.ToInt32(txtCarbohydrate.Text);
                    newFood.OwnerId = userId;
                    bl.Foods.Add(newFood);
                    foodId = newFood.ID;
                }
            }

        }


        #region Helper Methods
        public void FillPlaceAndTotal(params MealType[] mealTypes)
        {
            var allFoods = bl.Foods.GetAll();
            lblTotalFoodCount.Text = allFoods.Count.ToString();
            int totalQuantity = bl.ConsumedFoods.GetFoodConsumedTotalQuantityByFoodId(foodId, mealTypes);
            int totalPortionCount = bl.ConsumedFoods.GetFoodConsumedTotalPortionCountByFoodId(foodId, mealTypes);
            int totalCount = totalQuantity + totalPortionCount;
            bl.ConsumedFoods.GetFoodConsumedPlaceByFoodId(foodId, out int place, mealTypes);
            if (mealTypes.Count() == 1)
            {
                txtPlace.Text = place.ToString();
                txtQuantity.Text = totalQuantity.ToString();
                txtPortionCount.Text = totalPortionCount.ToString();
                txtTotal.Text = totalCount.ToString();
                lblMealType.Text = mealTypes[0].ToString();
            }
            else if (mealTypes.Count() < 6)
            {
                txtPlace.Text = place.ToString();
                txtQuantity.Text = totalQuantity.ToString();
                txtPortionCount.Text = totalPortionCount.ToString();
                txtTotal.Text = totalCount.ToString();
                lblMealType.Text = "Others";
            }
            else
            {
                txtPlace.Text = place.ToString();
                txtQuantity.Text = totalQuantity.ToString();
                txtPortionCount.Text = totalPortionCount.ToString();
                txtTotal.Text = totalCount.ToString();
                lblMealType.Text = "All";
            }
        }
        #endregion
    }
}
