using BLL;
using Castle.Core;
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

namespace WndPL.Forms
{
    public partial class AddNewFood : Form
    {
        public AddNewFood()
        {
            InitializeComponent();
        }
        BusinessLogic bl;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbxCalorie.Text!=null && tbxName.Text != null && tbxCategory.Text != null && tbxPortionGram.Text != null && tbxProtein.Text != null && tbxFat.Text != null && tbxCarbonhydrate.Text != null)
            {
                Food food = new Food();
                food.Name = tbxName.Text;
                bool isConverted = Enum.TryParse(tbxCategory.Text, out FoodCategory category);
                if (isConverted)
                {
                    food.Category = category;
                }
                else
                {
                    tbxCategory.Clear();
                    MessageBox.Show("Please enter one of the categories in parentheses to category section(Fruit,Vegetable,Dessert,Meat,Soup,Beverage,Dairy,Salad,BakedGood,Cereals,SeaFood,FastFood,Legume,Others)");
                }
                food.PortionGram = Convert.ToDecimal(tbxPortionGram.Text);
                food.CalorieFor100Gram = Convert.ToDecimal(tbxCalorie.Text);
                food.ProteinRateFor100Gram = Convert.ToDecimal(tbxProtein.Text);
                food.FatRateFor100Gram = Convert.ToDecimal(tbxFat.Text);
                food.CarbonhydrateAmountFor100Gram = Convert.ToDecimal(tbxCarbonhydrate.Text);
                bool isAdded = bl.Foods.Add(food);
                if (isAdded)
                {
                    MessageBox.Show("Food is added to database");
                }
                else
                {
                    MessageBox.Show("Somethings go wrong please restard your app or get help from our employees");
                }
                //helper.clear();
            }


        }

        private void AddNewFood_Load(object sender, EventArgs e)
        {
            bl = new BusinessLogic();
        }
    }
}
