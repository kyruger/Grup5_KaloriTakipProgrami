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

            count = 2;





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

                    Entities.User user = bl.Users.GetById(userID);
                    TimeSpan timePassed = DateTime.Now - user.CreationTime;
                    int day = (int)timePassed.TotalDays + 1;
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

            foreach (Control control in flyo.Controls)
            {
                if(control is Guna2Button)
                {
                    Guna2Button btn = (Guna2Button)control;
                    if (mealType.ToString()==btn.Text)
                    {
                        flyo.Controls.Remove(btn);
                    }
               
                }
            }                           
            for (int i = 0; i < lviDailyConsumedFood.Items.Count; i++)
            {
                if (lviDailyConsumedFood.Items[i].Tag != null)
                {
                    int id = (int)lviDailyConsumedFood.Items[i].Tag;
                    bool isRemoved = bl.ConsumedFoods.Remove(id);
                    ConsumedFood consumed = bl.ConsumedFoods.GetById(id);
                    Food food = bl.Foods.GetById(consumed.FoodId);
                    if (isRemoved)
                    {
                        MessageBox.Show($"{food.Name} deleted from your meal");
                    }
                    else
                    {
                        MessageBox.Show($"{food.Name} can't deleted from your meal something go wrong");
                    }

                }
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
            if (count<=5)
            {
                if (count==2)
                {
                    Guna2Button btn = new Guna2Button();
                    btn.Text = $"Snack{count}";
                    btn.Width = 164;
                    btn.Height = 92;
                    btn.Click += new EventHandler(SnackClick2);
                    count++;
                    flyo.Controls.Add(btn);
                }
                else if (count == 3)
                {
                    Guna2Button btn = new Guna2Button();
                    btn.Text = $"Snack{count}";
                    btn.Width = 164;
                    btn.Height = 92;
                    btn.Click += new EventHandler(SnackClick3);
                    count++;
                    flyo.Controls.Add(btn);

                }
                else if (count == 4)
                {
                    Guna2Button btn = new Guna2Button();
                    btn.Text = $"Snack{count}";
                    btn.Width = 164;
                    btn.Height = 92;
                    btn.Click += new EventHandler(SnackClick4);
                    count++;
                    flyo.Controls.Add(btn);
                }
                else if (count == 5)
                {
                    Guna2Button btn = new Guna2Button();
                    btn.Text = $"Snack{count}";
                    btn.Width = 164;
                    btn.Height = 92;
                    btn.Click += new EventHandler(SnackClick5);
                    count++;
                    flyo.Controls.Add(btn);
                }

            }
            else
            {
                MessageBox.Show("You can not add more than 5 Snack");
            }

        }
        private void SnackClick2(object sender,EventArgs e)
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
        
    }
}
