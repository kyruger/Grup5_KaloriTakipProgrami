using BLL;
using Entities;
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

            }
        }

        private void Meals_Load(object sender, EventArgs e)
        {
            bl = new BusinessLogic();
            List<Food> foods = bl.Foods.GetAll();
            ListViewFill(foods);
            cbxPortion.SelectedIndex = 0;





        }
        private void ListViewFill(List<Food> foods)
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
                lvi.SubItems.Add(food.CarbonhydrateRateFor100Gram.ToString());
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

        }

        private void btnAddNewFood_Click(object sender, EventArgs e)
        {
            AddNewFood addNewFood = new AddNewFood();
            addNewFood.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
