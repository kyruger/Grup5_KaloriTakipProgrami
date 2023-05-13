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
        private void FoodReports_Load(object sender, EventArgs e)
        {

        }

        #region txtFoodSearch
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
        #endregion
        private void lvSearchedFoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvSearchedFoods.Hide();
            if (lvSearchedFoods.SelectedItems.Count > 0)
            {
                lblFoodName.Text = lvSearchedFoods.SelectedItems[0].Text;
                foodId = (int)lvSearchedFoods.SelectedItems[0].Tag;
                Food selectedFood = bl.Foods.GetById(foodId);
                // fill food deatils
                txtCalorie.Text = selectedFood.CalorieFor100Gram.ToString();
                txtCategory.Text = selectedFood.Category.ToString();
                txtPortion.Text = selectedFood.PortionGram.ToString();
                txtProtein.Text = selectedFood.ProteinRateFor100Gram.ToString();
                txtFat.Text = selectedFood.FatRateFor100Gram.ToString();
                txtCarbohydrate.Text = selectedFood.CarbonhydrateAmountFor100Gram.ToString();
                //fill place and total
                FillPlaceAndTotal(MealType.Breakfast, MealType.Lunch, MealType.Dinner, MealType.Snack1, MealType.Snack2, MealType.Snack3, MealType.Snack4, MealType.Snack5);
                //fill Quantity and Count
                //fill FoodAvgDayConsume Pie chart 
                int dataPointCount = pieDataFoodAvgDayConsume.DataPointCount;
                pieDataFoodAvgDayConsume.DataPoints.Clear();
                List<ConsumedFood> consumedFoods = bl.ConsumedFoods.GetAll();
                int totalDay = bl.ConsumedFoods.GetTotalDaysInConsumedFoods();
                var food = bl.Foods.GetById(foodId);

                for (int i = 0; i < dataPointCount - 1; i++)
                {
                    Guna.Charts.WinForms.LPoint lPoint = new();
                    lPoint.Label = ((MealType)(i + 1)).ToString();
                    int totalQuantity1 = bl.ConsumedFoods.GetFoodConsumedTotalQuantityByFoodId(foodId, (MealType)(i + 1));
                    int totalPortionCount1 = bl.ConsumedFoods.GetFoodConsumedTotalPortionCountByFoodId(foodId, (MealType)(i + 1));
                    double dailyConsumeAmount = totalQuantity1  + totalPortionCount1 ;
                    lPoint.Y = Math.Round(dailyConsumeAmount / totalDay, 2);
                    pieDataFoodAvgDayConsume.DataPoints.Add(lPoint);
                }
                Guna.Charts.WinForms.LPoint lPointLast = new();
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



        #region Helper Methods
        public void FillPlaceAndTotal(params MealType[] mealTypes)
        {
            var allFoods = bl.Foods.GetAll();
            lblTotalFoodCount.Text = allFoods.Count.ToString();
            //txtTotal.Text = bl.ConsumedFoods.GetFoodConsumedQuantityByFoodId(foodId, mealTypes).ToString();
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
