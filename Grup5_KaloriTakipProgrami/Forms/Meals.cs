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
        public Meals()
        {
            InitializeComponent();
        }
        BusinessLogic bl;
        int foodID;
        int userID = 2;
        MealType mealType;
        int count;
        List<int> btnNumbers;
        int day;


        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AddNewFood addNewFood = new AddNewFood();
            addNewFood.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lviFood.SelectedItems.Count > 0)
            {
                ButtonActivity(true);
                int foodId = (int)lviFood.FocusedItem.Tag;
                Food food = bl.Foods.GetById(foodId);
                tbxFoodName.Text = food.Name;
                tbxFoodCalorie.Text = food.CalorieFor100Gram.ToString();
                foodID = (int)lviFood.FocusedItem.Tag;



            }
        }

        private void Meals_Load(object sender, EventArgs e)
        {
            bl = new BusinessLogic();
            List<Food> foods = bl.Foods.GetAll();
            ListViewFillFood(foods);
            cbxPortion.SelectedIndex = 0;
            btnNumbers = new();
            tbxFoodCalorie.Enabled = false;
            tbxFoodName.Enabled = false;
            Entities.User user = bl.Users.GetById(userID);
            TimeSpan timePassed = DateTime.Now - user.CreationTime;
            day = (int)timePassed.TotalDays + 1;


            count = 1;






        }
        private void ListViewFillFood(List<Food> foods)
        {
            lviFood.Items.Clear();
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
                lviFood.Items.Add(lvi);
            }



        }

        private void ButtonActivity(bool control)
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

        private void btnAddToMeal_Click(object sender, EventArgs e)
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
            ButtonActivity(false);
            //foreach (ConsumedFood consumed in consumedFoods)
            //{
            //    ListViewItem lvi = new ListViewItem();
            //    int foodId = consumed.FoodId;
            //    Food food = bl.Foods.GetById(foodId);
            //    lvi.Text = food.Name;//food name
            //    lvi.SubItems.Add(food.Category.ToString());//category
            //    if (consumed.PortionType == null)
            //    {
            //        lvi.SubItems.Add("100Gram");
            //        lvi.SubItems.Add(consumed.Quantity.ToString());
            //        lvi.SubItems.Add((100 * consumed.Quantity).ToString());
            //        lvi.SubItems.Add((food.CalorieFor100Gram * consumed.Quantity).ToString());
            //        lvi.SubItems.Add((food.ProteinRateFor100Gram * consumed.Quantity).ToString());
            //        lvi.SubItems.Add((food.FatRateFor100Gram * consumed.Quantity).ToString());
            //        lvi.SubItems.Add((food.CarbonhydrateAmountFor100Gram * consumed.Quantity).ToString());

            //    }
            //    else
            //    {
            //        decimal portionGramForType = food.PortionGram / (int)consumed.PortionType;
            //        lvi.SubItems.Add(consumed.PortionType.ToString());
            //        lvi.SubItems.Add(consumed.PortionCount.ToString());
            //        lvi.SubItems.Add(portionGramForType.ToString());
            //        lvi.SubItems.Add(((food.CalorieFor100Gram * portionGramForType) / 100).ToString());
            //        lvi.SubItems.Add(((food.ProteinRateFor100Gram * portionGramForType) / 100).ToString());
            //        lvi.SubItems.Add(((food.FatRateFor100Gram * portionGramForType) / 100).ToString());
            //        lvi.SubItems.Add(((food.CarbonhydrateAmountFor100Gram * portionGramForType) / 100).ToString());



            //    }


            //    lvi.Tag = consumed.ID;
            //    lviDailyConsumedFood.Items.Add(lvi);




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
            mealType = MealType.Breakfast;
            FillListViewConsumedFood(userID, mealType);
        }
        private void FillListViewConsumedFood(int id, MealType meal)
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
                if (consumed.PortionType == null)
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
                    decimal portionGramForType = food.PortionGram / (int)consumed.PortionType;
                    lvi.SubItems.Add(consumed.PortionType.ToString());
                    lvi.SubItems.Add(consumed.PortionCount.ToString());
                    lvi.SubItems.Add(portionGramForType.ToString());
                    lvi.SubItems.Add(((food.CalorieFor100Gram * portionGramForType) / 100).ToString());
                    lvi.SubItems.Add(((food.ProteinRateFor100Gram * portionGramForType) / 100).ToString());
                    lvi.SubItems.Add(((food.FatRateFor100Gram * portionGramForType) / 100).ToString());
                    lvi.SubItems.Add(((food.CarbonhydrateAmountFor100Gram * portionGramForType) / 100).ToString());



                }


                lvi.Tag = consumed.ID;
                lviDailyConsumedFood.Items.Add(lvi);



            }
        }

        private void FoodSearch_TextChanged(object sender, EventArgs e)
        {
            List<Food> foods = bl.Foods.GetFoodsByWord(tbxFoodSearch.Text);
            ListViewFillFood(foods);


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
            if (mealType.ToString() != "Breakfast" || mealType.ToString() != "Lunch" || mealType.ToString() != "Dinner")
            {
                foreach (Control control in flyo.Controls)
                {
                    if (control is Guna2Button)
                    {
                        Guna2Button btn = (Guna2Button)control;
                        string a = btn.Text[^1].ToString();
                        int number = Convert.ToInt32(a);
                        if (mealType.ToString() == btn.Text)
                        {
                            flyo.Controls.Remove(btn);
                            btnNumbers.Remove(number);
                            count--;
                        }


                    }
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
                    if (isRemoved)
                    {
                        MessageBox.Show($"{food.Name} deleted from your meal");
                    }
                    else
                    {
                        MessageBox.Show($"{food.Name} can't deleted from your meal something go wrong");
                    }

                }
            }
            lviDailyConsumedFood.Items.Clear();



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

                    Guna2Button btn = new Guna2Button();
                    btn.Text = $"Snack{1}";
                    btn.Width = 164;
                    btn.Height = 92;
                    btn.Click += new EventHandler(SnackClick1);
                    count++;
                    btnNumbers.Add(1);
                    flyo.Controls.Add(btn);
                }
                else if (!btnNumbers.Contains(2))
                {

                    Guna2Button btn = new Guna2Button();
                    btn.Text = $"Snack{2}";
                    btn.Width = 164;
                    btn.Height = 92;
                    btn.Click += new EventHandler(SnackClick2);
                    count++;
                    btnNumbers.Add(2);
                    flyo.Controls.Add(btn);
                }
                else if (!btnNumbers.Contains(3))
                {
                    Guna2Button btn = new Guna2Button();
                    btn.Text = $"Snack{3}";
                    btn.Width = 164;
                    btn.Height = 92;
                    btn.Click += new EventHandler(SnackClick3);
                    count++;
                    btnNumbers.Add(3);
                    flyo.Controls.Add(btn);

                }
                else if (!btnNumbers.Contains(4))
                {
                    Guna2Button btn = new Guna2Button();
                    btn.Text = $"Snack{4}";
                    btn.Width = 164;
                    btn.Height = 92;
                    btn.Click += new EventHandler(SnackClick4);
                    count++;
                    btnNumbers.Add(4);
                    flyo.Controls.Add(btn);
                }
                else if (!btnNumbers.Contains(5))
                {
                    Guna2Button btn = new Guna2Button();
                    btn.Text = $"Snack{count}";
                    btn.Width = 164;
                    btn.Height = 92;
                    btn.Click += new EventHandler(SnackClick5);
                    count++;
                    btnNumbers.Add(5);
                    flyo.Controls.Add(btn);
                }

            }
            else
            {
                MessageBox.Show("You can not add more than 5 Snack");
            }

        }
        private void SnackClick2(object sender, EventArgs e)
        {
            mealType = MealType.Snack2;
            FillListViewConsumedFood(userID, mealType);
        }
        private void SnackClick3(object sender, EventArgs e)
        {
            mealType = MealType.Snack3;
            FillListViewConsumedFood(userID, mealType);
        }
        private void SnackClick4(object sender, EventArgs e)
        {
            mealType = MealType.Snack4;
            FillListViewConsumedFood(userID, mealType);
        }
        private void SnackClick5(object sender, EventArgs e)
        {
            mealType = MealType.Snack5;
            FillListViewConsumedFood(userID, mealType);
        }

        private void SnackClick1(object sender, EventArgs e)
        {
            mealType = MealType.Snack1;
            FillListViewConsumedFood(userID, mealType);
        }

        private void nudAmount_ValueChanged(object sender, EventArgs e)
        {
            if (nudAmount.Value == 0)
            {
                ButtonActivity(false);
            }
            else
            {
                ButtonActivity(true);
            }
        }
    }
}
