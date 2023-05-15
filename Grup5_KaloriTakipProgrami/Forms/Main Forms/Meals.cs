using BLL;
using Entities;
using Entities.Enums;
using Grup5_KaloriTakipProgrami;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WndPL.Forms
{
    public partial class Meals : Form
    {
        public Meals(int id)
        {
            InitializeComponent();
            userID = id;
        }
        BusinessLogic bl;
        int foodID;
        int userID;
        MealType mealType;
        int count;
        List<int> btnNumbers;
        int day;


        private void Meals_Load(object sender, EventArgs e)
        {
            bl = new BusinessLogic();
            List<Food> foods = bl.Foods.GetAll();
            cbxPortion.SelectedIndex = 0;
            btnNumbers = new();
            tbxFoodCalorie.Enabled = false;
            tbxFoodName.Enabled = false;
            Entities.User user = bl.Users.GetById(userID);
            TimeSpan timePassed = DateTime.Now - user.CreationTime;
            day = (int)timePassed.TotalDays + 1;
            btnAddToMeal.Enabled = false;

            double totalCalorie1 = bl.Users.GetCaloriesForDailyMeal(userID, MealType.Breakfast); ;
            cpbBreakfeastCalorie.Maximum = 9999;
            cpbBreakfeastCalorie.Value = (int)totalCalorie1;

            double totalCalorie2 = bl.Users.GetCaloriesForDailyMeal(userID, MealType.Lunch); ;
            cpbLunchCalorie.Maximum = 9999;
            cpbLunchCalorie.Value = (int)totalCalorie2;

            double totalCalorie3 = bl.Users.GetCaloriesForDailyMeal(userID, MealType.Dinner); ;
            cpbDinnerCalorie.Maximum = 9999;
            cpbDinnerCalorie.Value = (int)totalCalorie3;

         



            if (bl.ConsumedFoods.GetConsumedFoodsByUserID(userID, day, MealType.Snack1))
            {
                btnSnack.Enabled = true;
                btnSnack.Visible = true;
            }
            if (bl.ConsumedFoods.GetConsumedFoodsByUserID(userID, day, MealType.Snack2))
            {
                btnSnack2.Enabled = true;
                btnSnack2.Visible = true;
            }
            if (bl.ConsumedFoods.GetConsumedFoodsByUserID(userID, day, MealType.Snack3))
            {
                btnSnack3.Enabled = true;
                btnSnack3.Visible = true;
            }
            if (bl.ConsumedFoods.GetConsumedFoodsByUserID(userID, day, MealType.Snack4))
            {
                btnSnack4.Enabled = true;
                btnSnack4.Visible = true;
            }
            if (bl.ConsumedFoods.GetConsumedFoodsByUserID(userID, day, MealType.Snack5))
            {
                btnSnack5.Enabled = true;
                btnSnack5.Visible = true;
            }

            count = 1;


        }


        private void ButtonActivity(bool control)//changes the activity of the button according to the incoming value
        {
            if (control)
            {

                btnAddToMeal.Enabled = true;
            }
            else
            {

                btnAddToMeal.Enabled = false;
            }

        }

        private void btnAddToMeal_Click(object sender, EventArgs e)//Adds selected food to Meal
        {
            if (tbxFoodName != null || tbxFoodCalorie != null)
            {
                Food food = bl.Foods.GetById(foodID);
                ListViewItem lvi = new();
                lvi.Text = food.Name;
                lvi.SubItems.Add(food.Category.ToString());



                if (cbxPortion.SelectedIndex == 0 || cbxPortion.SelectedIndex == 1 || cbxPortion.SelectedIndex == 2)
                {
                    if (cbxPortion.SelectedIndex == 0)//Full
                    {
                        decimal portionGramForType = food.PortionGram / 1;
                        lvi.SubItems.Add("Full");
                        lvi.SubItems.Add(nudAmount.Value.ToString());
                        lvi.SubItems.Add(portionGramForType.ToString());
                        lvi.SubItems.Add(((food.CalorieFor100Gram * portionGramForType) / 100).ToString());
                        lvi.SubItems.Add(((food.ProteinRateFor100Gram * portionGramForType) / 100).ToString());
                        lvi.SubItems.Add(((food.FatRateFor100Gram * portionGramForType) / 100).ToString());
                        lvi.SubItems.Add(((food.CarbonhydrateAmountFor100Gram * portionGramForType) / 100).ToString());
                    }
                    else if (cbxPortion.SelectedIndex == 1)//Half 
                    {
                        decimal portionGramForType = food.PortionGram / 2;
                        lvi.SubItems.Add("Half");
                        lvi.SubItems.Add(nudAmount.Value.ToString());
                        lvi.SubItems.Add(portionGramForType.ToString());
                        lvi.SubItems.Add(((food.CalorieFor100Gram * portionGramForType) / 100).ToString());
                        lvi.SubItems.Add(((food.ProteinRateFor100Gram * portionGramForType) / 100).ToString());
                        lvi.SubItems.Add(((food.FatRateFor100Gram * portionGramForType) / 100).ToString());
                        lvi.SubItems.Add(((food.CarbonhydrateAmountFor100Gram * portionGramForType) / 100).ToString());
                    }
                    else if (cbxPortion.SelectedIndex == 2)//Quartar
                    {
                        decimal portionGramForType = food.PortionGram / 4;
                        lvi.SubItems.Add("Quarter");
                        lvi.SubItems.Add(nudAmount.Value.ToString());
                        lvi.SubItems.Add(portionGramForType.ToString());
                        lvi.SubItems.Add(((food.CalorieFor100Gram * portionGramForType) / 100).ToString());
                        lvi.SubItems.Add(((food.ProteinRateFor100Gram * portionGramForType) / 100).ToString());
                        lvi.SubItems.Add(((food.FatRateFor100Gram * portionGramForType) / 100).ToString());
                        lvi.SubItems.Add(((food.CarbonhydrateAmountFor100Gram * portionGramForType) / 100).ToString());
                    }

                }
                else if (cbxPortion.SelectedIndex == 3)//100Gram
                {
                    lvi.SubItems.Add("100Gram");
                    lvi.SubItems.Add(nudAmount.Value.ToString());
                    lvi.SubItems.Add((100 * nudAmount.Value).ToString());
                    lvi.SubItems.Add((food.CalorieFor100Gram * nudAmount.Value).ToString());
                    lvi.SubItems.Add((food.ProteinRateFor100Gram * nudAmount.Value).ToString());
                    lvi.SubItems.Add((food.FatRateFor100Gram * nudAmount.Value).ToString());
                    lvi.SubItems.Add((food.CarbonhydrateAmountFor100Gram * nudAmount.Value).ToString());

                }
                lviDailyConsumedFood.Items.Add(lvi);
                if (MealType.Breakfast == mealType)
                {
                    double totalCalorie = 0;
                    foreach (ListViewItem item in lviDailyConsumedFood.Items)
                    {
                        totalCalorie += Convert.ToDouble(item.SubItems[5].Text);

                    }
                    cpbBreakfeastCalorie.Value = (int)totalCalorie;
                }
                else if (MealType.Lunch == mealType)
                {
                    double totalCalorie = 0;
                    foreach (ListViewItem item in lviDailyConsumedFood.Items)
                    {
                        totalCalorie += Convert.ToDouble(item.SubItems[5].Text);

                    }
                    cpbLunchCalorie.Value = (int)totalCalorie;
                }
                else if (MealType.Dinner == mealType)
                {
                    double totalCalorie = 0;
                    foreach (ListViewItem item in lviDailyConsumedFood.Items)
                    {
                        totalCalorie += Convert.ToDouble(item.SubItems[5].Text);

                    }
                    cpbDinnerCalorie.Value = (int)totalCalorie;
                }
                ButtonActivity(false);

            }
            else
            {
                ButtonActivity(false);
            }


        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBreakFeast_Click(object sender, EventArgs e)//Fills the Meal listview for breakfeast and calculates the breakfeast calorie
        {
            mealType = MealType.Breakfast;
            FillListViewConsumedFood(userID, mealType);
           
        }
        private void FillListViewConsumedFood(int id, MealType meal)//Fills the consumedfood list view for incoming meal
        {

            lviDailyConsumedFood.Items.Clear();
            List<ConsumedFood> consumedFoods = bl.ConsumedFoods.GetConsumedFoodsByDayAndMealType(id, meal);
            foreach (ConsumedFood consumed in consumedFoods)
            {
                ListViewItem lvi = new ListViewItem();
                int foodId = consumed.FoodId;
                Food food = bl.Foods.GetById(foodId);
                lvi.Text = food.Name;//food name
                lvi.SubItems.Add(food.Category.ToString());//category
                if (consumed.Quantity > 0)
                {
                    lvi.SubItems.Add("100Gram");
                    lvi.SubItems.Add(consumed.Quantity.ToString());
                    lvi.SubItems.Add((100 * consumed.Quantity).ToString());
                    lvi.SubItems.Add((food.CalorieFor100Gram * consumed.Quantity).ToString());
                    lvi.SubItems.Add((food.ProteinRateFor100Gram * consumed.Quantity).ToString());
                    lvi.SubItems.Add((food.FatRateFor100Gram * consumed.Quantity).ToString());
                    lvi.SubItems.Add((food.CarbonhydrateAmountFor100Gram * consumed.Quantity).ToString());

                }
                else
                {
                    lvi.SubItems.Add(consumed.PortionType.ToString());
                    lvi.SubItems.Add(consumed.PortionCount.ToString());
                    double portionGramForType = 0;
                    double totalCalorie = 0;
                    if (consumed.PortionType == PortionType.Full)
                    {
                         totalCalorie = consumed.PortionCount * (double)(food.PortionGram / 100) * (double)food.CalorieFor100Gram / (int)PortionType.Full;
                         portionGramForType = (double)food.PortionGram / (int)PortionType.Full;


                    }
                    else if (consumed.PortionType == PortionType.Half)
                    {
                         totalCalorie = consumed.PortionCount * (double)(food.PortionGram / 100) * (double)food.CalorieFor100Gram / (int)PortionType.Half;
                         portionGramForType = (double)food.PortionGram / (int)PortionType.Half;

                    }
                    else if (consumed.PortionType == PortionType.Quarter)
                    {
                        totalCalorie = consumed.PortionCount * (double)(food.PortionGram / 100) * (double)food.CalorieFor100Gram / (int)PortionType.Quarter;
                         portionGramForType = (double)food.PortionGram / (int)PortionType.Quarter;

                    }

                    lvi.SubItems.Add(Math.Round(portionGramForType, 2).ToString());
                    lvi.SubItems.Add(Math.Round(totalCalorie, 2).ToString());
                    lvi.SubItems.Add(Math.Round((((double)food.ProteinRateFor100Gram * portionGramForType) / 100), 2).ToString());
                    lvi.SubItems.Add(Math.Round((((double)food.FatRateFor100Gram * portionGramForType) / 100), 2).ToString());
                    lvi.SubItems.Add(Math.Round((((double)food.CarbonhydrateAmountFor100Gram * portionGramForType) / 100), 2).ToString());

                }
                //if (.Quantity > 0)
                //    totalCalorie += cf.Quantity * (double)cf.Food.CalorieFor100Gram;
                //else if (cf.PortionCount > 0)
                //{

                //}

                lvi.Tag = consumed.ID;
                lviDailyConsumedFood.Items.Add(lvi);



            }
        }



        private void btnLunch_Click(object sender, EventArgs e)
        {
            mealType = MealType.Lunch;
            FillListViewConsumedFood(userID, mealType);
           


        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            mealType = MealType.Dinner;
            FillListViewConsumedFood(userID, mealType);
            
        }

        private void btnSaveSelectedMeal_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lviDailyConsumedFood.Items.Count; i++)
            {
                if (lviDailyConsumedFood.Items[i].Tag == null)//tag null olursa idsı olmayan bir yiyecek demek
                {
                    ConsumedFood consumed = new ConsumedFood();
                    consumed.MealType = mealType;


                    consumed.Day = day;
                    consumed.UserId = userID;
                    int foodId = bl.Foods.GetFoodIdByFoodName(lviDailyConsumedFood.Items[i].SubItems[0].Text);
                    consumed.FoodId = foodId;
                    if (lviDailyConsumedFood.Items[i].SubItems[2].Text == "100Gram")
                    {
                        consumed.Quantity = Convert.ToInt32(lviDailyConsumedFood.Items[i].SubItems[3].Text);
                    }
                    else
                    {

                        consumed.PortionType = (PortionType)Enum.Parse(typeof(PortionType), lviDailyConsumedFood.Items[i].SubItems[2].Text);
                        consumed.PortionCount = Convert.ToInt32(lviDailyConsumedFood.Items[i].SubItems[3].Text);
                    }
                    bool IsAdded = bl.ConsumedFoods.Add(consumed);
                    if (IsAdded)
                    {
                        MessageBox.Show("The meal is saved");
                    }
                    else
                    {
                        MessageBox.Show("The meal is not saved something go wrong");
                    }

                }


            }
        }

        private void btnDeleteSelectedMeal_Click(object sender, EventArgs e)
        {
            if (mealType == 0)
            {
                MessageBox.Show("Please select a meal before deleting");
            }
            else
            {
                if (mealType.ToString() != "Breakfast" || mealType.ToString() != "Lunch" || mealType.ToString() != "Dinner")
                {

                    if (mealType.ToString() == btnSnack.Text)
                    {
                        btnSnack.Visible = false;
                        btnSnack.Enabled = false;
                        count--;
                        btnNumbers.Remove(1);
                    }
                    else if (mealType.ToString() == btnSnack2.Text)
                    {
                        btnSnack2.Visible = false;
                        btnSnack2.Enabled = false;
                        count--;
                        btnNumbers.Remove(2);
                    }
                    else if (mealType.ToString() == btnSnack3.Text)
                    {
                        btnSnack3.Visible = false;
                        btnSnack3.Enabled = false;
                        count--;
                        btnNumbers.Remove(3);
                    }
                    else if (mealType.ToString() == btnSnack4.Text)
                    {
                        btnSnack4.Visible = false;
                        btnSnack4.Enabled = false;
                        count--;
                        btnNumbers.Remove(4);
                    }
                    else if (mealType.ToString() == btnSnack5.Text)
                    {
                        btnSnack5.Visible = false;
                        btnSnack5.Enabled = false;
                        count--;
                        btnNumbers.Remove(5);
                    }
              
                }


                for (int i = 0; i < lviDailyConsumedFood.Items.Count; i++)
                {
                    if (lviDailyConsumedFood.Items[i].Tag != null)
                    {
                        int id = (int)lviDailyConsumedFood.Items[i].Tag;
                        ConsumedFood consumed = bl.ConsumedFoods.GetById(id);
                        Food food = bl.Foods.GetById(consumed.FoodId);
                        bool isRemoved = bl.ConsumedFoods.Remove(id);


                    }
                }
                MessageBox.Show($"{mealType.ToString()} deleted from your meal");
                lviDailyConsumedFood.Items.Clear();



            }

        }

        private void btnSnack_Click(object sender, EventArgs e)
        {
            mealType = MealType.Snack1;
            FillListViewConsumedFood(userID, mealType);
        }

        private void btnAddSnack_Click(object sender, EventArgs e)
        {
            if (count <= 5)
            {
                if (!btnNumbers.Contains(1))
                {
                    btnSnack.Enabled = true;
                    btnSnack.Visible = true;
                    bool visible1 = true;
                    count++;
                    btnNumbers.Add(1);

                }
                else if (!btnNumbers.Contains(2))
                {

                    btnSnack2.Enabled = true;
                    btnSnack2.Visible = true;
                    bool visible2 = true;
                    count++;
                    btnNumbers.Add(2);

                }
                else if (!btnNumbers.Contains(3))
                {
                    btnSnack3.Enabled = true;
                    btnSnack3.Visible = true;
                    bool visible3 = true;
                    count++;
                    btnNumbers.Add(3);


                }
                else if (!btnNumbers.Contains(4))
                {
                    btnSnack4.Enabled = true;
                    btnSnack4.Visible = true;
                    bool visible4 = true;
                    count++;
                    btnNumbers.Add(4);

                }
                else if (!btnNumbers.Contains(5))
                {
                    btnSnack5.Enabled = true;
                    btnSnack5.Visible = true;
                    bool visible5 = true;
                    count++;
                    btnNumbers.Add(5);

                }

            }
            else
            {
                MessageBox.Show("You can not add more than 5 Snack");
            }

        }


        private void nudAmount_ValueChanged(object sender, EventArgs e)
        {
            if (nudAmount.Value == 0 || tbxFoodCalorie.Text == string.Empty || tbxFoodName.Text == string.Empty || mealType == 0)
            {
                ButtonActivity(false);
            }
            else
            {
                ButtonActivity(true);
            }
        }

        private void lblFoodSearch_Click(object sender, EventArgs e)
        {
            lblFoodSearch.Hide();
            txtFoodSearch.Focus();
        }

        private void txtFoodSearch_TextChanged(object sender, EventArgs e)
        {
            lvSearchedFoods.Items.Clear();
            List<Food> searchedFoods = bl.Foods.GetFoodsByContainTextAndOwnerId(txtFoodSearch.Text.Trim(), userID);
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

        private void txtFoodSearch_MouseEnter(object sender, EventArgs e)
        {
            lblFoodSearch.Hide();
        }

        private void txtFoodSearch_MouseLeave(object sender, EventArgs e)
        {
            lblFoodSearch.Show();
        }

        private void lvSearchedFoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvSearchedFoods.Hide();
            if (lvSearchedFoods.SelectedItems.Count > 0)
            {
                int foodId = (int)lvSearchedFoods.SelectedItems[0].Tag;
                Food food = bl.Foods.GetById(foodId);
                tbxFoodName.Text = food.Name;
                tbxFoodCalorie.Text = food.CalorieFor100Gram.ToString();
                foodID = (int)lvSearchedFoods.SelectedItems[0].Tag;
                if (nudAmount.Value > 0)
                {
                    ButtonActivity(true);
                }
            }

        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lviDailyConsumedFood.SelectedItems.Count > 0)
            {
                int consumedId = (int)lviDailyConsumedFood.SelectedItems[0].Tag;
                bl.ConsumedFoods.Remove(consumedId);
                FillListViewConsumedFood(userID, mealType);

            }
        }

        private void btnSnack_Click_1(object sender, EventArgs e)
        {
            mealType = MealType.Snack1;
            FillListViewConsumedFood(userID, mealType);
            double totalCalorie = 0;
            foreach (ListViewItem item in lviDailyConsumedFood.Items)
            {
                totalCalorie += Convert.ToDouble(item.SubItems[5].Text);

            }
            cpgTotalMealCalorie.Maximum = 9999;
            cpgTotalMealCalorie.Value = (int)totalCalorie;
        }

        private void btnSnack2_Click(object sender, EventArgs e)
        {
            mealType = MealType.Snack2;
            FillListViewConsumedFood(userID, mealType);
            double totalCalorie = 0;
            foreach (ListViewItem item in lviDailyConsumedFood.Items)
            {
                totalCalorie += Convert.ToDouble(item.SubItems[5].Text);

            }
            cpgTotalMealCalorie.Maximum = 9999;
            cpgTotalMealCalorie.Value = (int)totalCalorie;
        }

        private void btnSnack3_Click(object sender, EventArgs e)
        {
            mealType = MealType.Snack3;
            FillListViewConsumedFood(userID, mealType);
            double totalCalorie = 0;
            foreach (ListViewItem item in lviDailyConsumedFood.Items)
            {
                totalCalorie += Convert.ToDouble(item.SubItems[5].Text);

            }
            cpgTotalMealCalorie.Maximum = 9999;
            cpgTotalMealCalorie.Value = (int)totalCalorie;
        }

        private void btnSnack4_Click(object sender, EventArgs e)
        {
            mealType = MealType.Snack4;
            FillListViewConsumedFood(userID, mealType);
            double totalCalorie = 0;
            foreach (ListViewItem item in lviDailyConsumedFood.Items)
            {
                totalCalorie += Convert.ToDouble(item.SubItems[5].Text);

            }
            cpgTotalMealCalorie.Maximum = 9999;
            cpgTotalMealCalorie.Value = (int)totalCalorie;
        }

        private void btnSnack5_Click(object sender, EventArgs e)
        {
            mealType = MealType.Snack5;
            FillListViewConsumedFood(userID, mealType);
            double totalCalorie = 0;
            foreach (ListViewItem item in lviDailyConsumedFood.Items)
            {
                totalCalorie += Convert.ToDouble(item.SubItems[5].Text);

            }
            cpgTotalMealCalorie.Maximum = 9999;
            cpgTotalMealCalorie.Value = (int)totalCalorie;
        }
    }
}
