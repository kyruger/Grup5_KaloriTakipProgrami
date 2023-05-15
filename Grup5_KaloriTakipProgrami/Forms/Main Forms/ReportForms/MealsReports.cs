using BLL;
using Castle.DynamicProxy.Generators;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WndPL.Forms.ReportForms
{
    public partial class MealsReports : Form
    {
        public MealsReports(int id)
        {
            InitializeComponent();
            userId = id;
        }
        BusinessLogic bl = new BusinessLogic();
        int userId;

        private void MealsReports_Load(object sender, EventArgs e)
        {

            // fill FoodCategoryDatas for bar chart -- "7" for weekly ,"30" for monthly
            FillFoodCategoryDatas(7, MealType.Breakfast, MealType.Lunch, MealType.Dinner, MealType.Snack1, MealType.Snack2, MealType.Snack3, MealType.Snack4, MealType.Snack5);
            // fill CalorieDatas for bar chart -- "7" for weekly ,"30" for monthly
            FillCalorieData(7);
            lblMealType.Text = "All";
        }

        private void tsWeekMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (!tsWeekMonth.Checked)
            {
                //for data load
                FillCalorieData(7);
                if (lblMealType.Text == MealType.Breakfast.ToString())
                    FillFoodCategoryDatas(7, MealType.Breakfast);
                else if (lblMealType.Text == MealType.Lunch.ToString())
                    FillFoodCategoryDatas(7, MealType.Lunch);
                else if (lblMealType.Text == MealType.Dinner.ToString())
                    FillFoodCategoryDatas(7, MealType.Dinner);
                else
                    FillFoodCategoryDatas(7, MealType.Snack1, MealType.Snack2, MealType.Snack3, MealType.Snack4, MealType.Snack5);
                //For colors switch
                lblMealType.ForeColor = Color.Teal;
                btnAll.FillColor = Color.Teal;
                btnBreakfast.FillColor = Color.Teal;
                btnDinner.FillColor = Color.Teal;
                btnLunch.FillColor = Color.Teal;
                btnOthers.FillColor = Color.Teal;
                pnlStick.FillColor = Color.Teal;
                pnlStick.FillColor2 = Color.Teal;
                chartCalorie.Title.ForeColor = Color.Teal;

            }
            else
            {
                FillCalorieData(30);
                if (lblMealType.Text == MealType.Breakfast.ToString())
                    FillFoodCategoryDatas(30, MealType.Breakfast);
                else if (lblMealType.Text == MealType.Lunch.ToString())
                    FillFoodCategoryDatas(30, MealType.Lunch);
                else if (lblMealType.Text == MealType.Dinner.ToString())
                    FillFoodCategoryDatas(30, MealType.Dinner);
                else
                    FillFoodCategoryDatas(30, MealType.Snack1, MealType.Snack2, MealType.Snack3, MealType.Snack4, MealType.Snack5);

                lblMealType.ForeColor = Color.MediumPurple;
                btnAll.FillColor = Color.MediumPurple;
                btnBreakfast.FillColor = Color.MediumPurple;
                btnDinner.FillColor = Color.MediumPurple;
                btnLunch.FillColor = Color.MediumPurple;
                btnOthers.FillColor = Color.MediumPurple;
                pnlStick.FillColor = Color.MediumPurple;
                pnlStick.FillColor2 = Color.MediumPurple;
                chartCalorie.Title.ForeColor = Color.MediumPurple;

            }
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            lblMealType.Text = "All";
            if (!tsWeekMonth.Checked)
            {
                FillFoodCategoryDatas(7, MealType.Breakfast, MealType.Lunch, MealType.Dinner, MealType.Snack1, MealType.Snack2, MealType.Snack3, MealType.Snack4, MealType.Snack5);
                FillCalorieData(7);
            }
            else
            {
                FillFoodCategoryDatas(30, MealType.Breakfast,MealType.Lunch,MealType.Dinner, MealType.Snack1, MealType.Snack2, MealType.Snack3, MealType.Snack4, MealType.Snack5);
                FillCalorieData(30);
            }
        }
        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            lblMealType.Text = MealType.Breakfast.ToString();
            if (!tsWeekMonth.Checked)
            {
                FillFoodCategoryDatas(7, MealType.Breakfast);
                FillCalorieData(7, MealType.Breakfast);
            }
            else
            {
                FillFoodCategoryDatas(30, MealType.Breakfast);
                FillCalorieData(30, MealType.Breakfast);
            }
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            lblMealType.Text = MealType.Lunch.ToString();
            if (!tsWeekMonth.Checked)
            {
                FillFoodCategoryDatas(7, MealType.Lunch);
                FillCalorieData(7, MealType.Lunch);
            }
            else
            {
                FillFoodCategoryDatas(30, MealType.Lunch);
                FillCalorieData(30, MealType.Lunch);
            }
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            lblMealType.Text = MealType.Dinner.ToString();
            if (!tsWeekMonth.Checked)
            {
                FillFoodCategoryDatas(7, MealType.Dinner);
                FillCalorieData(7, MealType.Dinner);
            }
            else
            {
                FillFoodCategoryDatas(30, MealType.Dinner);
                FillCalorieData(30, MealType.Dinner);
            }
        }

        private void btnOthers_Click(object sender, EventArgs e)
        {
            lblMealType.Text = "Others";
            if (!tsWeekMonth.Checked)
            {
                FillFoodCategoryDatas(7, MealType.Snack1, MealType.Snack2, MealType.Snack3, MealType.Snack4, MealType.Snack5);
                FillCalorieData(7, MealType.Snack1, MealType.Snack2, MealType.Snack3, MealType.Snack4, MealType.Snack5);
            }

            else
            {
                FillFoodCategoryDatas(30, MealType.Snack1, MealType.Snack2, MealType.Snack3, MealType.Snack4, MealType.Snack5);
                FillCalorieData(30, MealType.Snack1, MealType.Snack2, MealType.Snack3, MealType.Snack4, MealType.Snack5);
            }
        }


        #region Helper Methods
        public void FillFoodCategoryDatas(int day, params MealType[] mealTypes)
        {
            //Data1
            barDataFoodCategoryMy1.DataPoints.Clear();
            for (int i = 0; i < Enum.GetValues(typeof(FoodCategory)).Length / 2; i++)
            {
                LPoint lPoint = new LPoint();
                lPoint.Label = ((FoodCategory)(i + 1)).ToString();
                lPoint.Y = bl.Users.GetConsumedFoodsAmountForDaysById(userId, day, (FoodCategory)(i + 1), mealTypes);
                barDataFoodCategoryMy1.DataPoints.Add(lPoint);
            }

            barDataFoodCategoryUsers1.DataPoints.Clear();
            for (int i = 0; i < Enum.GetValues(typeof(FoodCategory)).Length / 2; i++)
            {
                LPoint lPoint = new LPoint();
                lPoint.Label = ((FoodCategory)(i + 1)).ToString();
                var users = bl.Users.GetAll();
                int usersTotal = 0;
                foreach (var user in users)
                {
                    usersTotal += bl.Users.GetConsumedFoodsAmountForDaysById(user.ID, day, (FoodCategory)(i + 1), mealTypes);
                }
                lPoint.Y = usersTotal / users.Count;
                barDataFoodCategoryUsers1.DataPoints.Add(lPoint);
            }

            //Data2
            barDataFoodCategoryMy2.DataPoints.Clear();
            for (int i = 0; i < Enum.GetValues(typeof(FoodCategory)).Length / 2; i++)
            {
                LPoint lPoint = new LPoint();
                lPoint.Label = ((FoodCategory)((Enum.GetValues(typeof(FoodCategory)).Length / 2) + i + 1)).ToString();
                lPoint.Y = bl.Users.GetConsumedFoodsAmountForDaysById(userId, day, (FoodCategory)((Enum.GetValues(typeof(FoodCategory)).Length / 2) + i + 1), mealTypes);
                barDataFoodCategoryMy2.DataPoints.Add(lPoint);
            }

            barDataFoodCategoryUsers2.DataPoints.Clear();
            for (int i = 0; i < Enum.GetValues(typeof(FoodCategory)).Length / 2; i++)
            {
                LPoint lPoint = new LPoint();
                lPoint.Label = ((FoodCategory)((Enum.GetValues(typeof(FoodCategory)).Length / 2) + i + 1)).ToString();
                var users = bl.Users.GetAll();
                int usersTotal = 0;
                foreach (var user in users)
                {
                    usersTotal += bl.Users.GetConsumedFoodsAmountForDaysById(user.ID, day, (FoodCategory)((Enum.GetValues(typeof(FoodCategory)).Length / 2) + i + 1), mealTypes);

                }
                lPoint.Y = usersTotal / users.Count;
                barDataFoodCategoryUsers2.DataPoints.Add(lPoint);
            }
        }

        public void FillCalorieData(int day, params MealType[] mealTypes)
        {
            LPoint lpMyAvgCalorie = new LPoint();
            LPoint lpUsersAvgCalorie = new LPoint();
            //Data1
            barDataCalories1.DataPoints.Clear();
            double totalMyCalorieForDays = bl.Users.GetCaloriesForDaysById(userId, day, out int emptyDays1, mealTypes);
            lpMyAvgCalorie.Y = Math.Round(totalMyCalorieForDays / (day - emptyDays1), 2);
            barDataCalories1.DataPoints.Add(lpMyAvgCalorie);

            //Data2
            barDataCalories2.DataPoints.Clear();
            double totalUsersCalorieForDays = 0;
            var users = bl.Users.GetAll();
            int userCount = users.Count;
            int emptyusersDays = 0;
            foreach (var user in users)
            {
                totalUsersCalorieForDays += bl.Users.GetCaloriesForDaysById(user.ID, day, out int emptyDays2, mealTypes);
                emptyusersDays += emptyDays2;
            }
            lpUsersAvgCalorie.Y = Math.Round(totalUsersCalorieForDays / (day - emptyusersDays/userCount) / userCount, 2);
            barDataCalories2.DataPoints.Add(lpUsersAvgCalorie);
        }
        #endregion


    }
}
