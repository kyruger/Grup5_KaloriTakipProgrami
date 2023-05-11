using BLL;
using Castle.DynamicProxy.Generators;
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
    public partial class MealsReports : Form
    {
        public MealsReports()
        {
            InitializeComponent();
        }
        Helper helper = new Helper();
        BusinessLogic bl = new BusinessLogic();
        int userId = 2;

        // object for charts
        #region ObjectForCharts
        Guna.Charts.WinForms.LPoint lpMyFurit = new Guna.Charts.WinForms.LPoint();
        Guna.Charts.WinForms.LPoint lpMyVegetable = new Guna.Charts.WinForms.LPoint();
        Guna.Charts.WinForms.LPoint lpMyDessert = new Guna.Charts.WinForms.LPoint();
        Guna.Charts.WinForms.LPoint lpMyMeat = new Guna.Charts.WinForms.LPoint();
        Guna.Charts.WinForms.LPoint lpMySoup = new Guna.Charts.WinForms.LPoint();
        Guna.Charts.WinForms.LPoint lpMyBeverage = new Guna.Charts.WinForms.LPoint();
        Guna.Charts.WinForms.LPoint lpMyDairy = new Guna.Charts.WinForms.LPoint();

        Guna.Charts.WinForms.LPoint lpUsersFurit = new Guna.Charts.WinForms.LPoint();
        Guna.Charts.WinForms.LPoint lpUsersVegetable = new Guna.Charts.WinForms.LPoint();
        Guna.Charts.WinForms.LPoint lpUsersDessert = new Guna.Charts.WinForms.LPoint();
        Guna.Charts.WinForms.LPoint lpUsersMeat = new Guna.Charts.WinForms.LPoint();
        Guna.Charts.WinForms.LPoint lpUsersSoup = new Guna.Charts.WinForms.LPoint();
        Guna.Charts.WinForms.LPoint lpUsersBeverage = new Guna.Charts.WinForms.LPoint();
        Guna.Charts.WinForms.LPoint lpUsersDairy = new Guna.Charts.WinForms.LPoint();

        Guna.Charts.WinForms.LPoint lpMySalad = new Guna.Charts.WinForms.LPoint();
        Guna.Charts.WinForms.LPoint lpMyBakedGood = new Guna.Charts.WinForms.LPoint();
        Guna.Charts.WinForms.LPoint lpMyCereals = new Guna.Charts.WinForms.LPoint();
        Guna.Charts.WinForms.LPoint lpMySeaFood = new Guna.Charts.WinForms.LPoint();
        Guna.Charts.WinForms.LPoint lpMyFastFood = new Guna.Charts.WinForms.LPoint();
        Guna.Charts.WinForms.LPoint lpMyLegume = new Guna.Charts.WinForms.LPoint();
        Guna.Charts.WinForms.LPoint lpMyOthers = new Guna.Charts.WinForms.LPoint();

        Guna.Charts.WinForms.LPoint lpUsersSalad = new Guna.Charts.WinForms.LPoint();
        Guna.Charts.WinForms.LPoint lpUsersBakedGood = new Guna.Charts.WinForms.LPoint();
        Guna.Charts.WinForms.LPoint lpUsersCereals = new Guna.Charts.WinForms.LPoint();
        Guna.Charts.WinForms.LPoint lpUsersSeaFood = new Guna.Charts.WinForms.LPoint();
        Guna.Charts.WinForms.LPoint lpUsersFastFood = new Guna.Charts.WinForms.LPoint();
        Guna.Charts.WinForms.LPoint lpUsersLegume = new Guna.Charts.WinForms.LPoint();
        Guna.Charts.WinForms.LPoint lpUsersOthers = new Guna.Charts.WinForms.LPoint();

        Guna.Charts.WinForms.LPoint lpMyAvgCalorie = new Guna.Charts.WinForms.LPoint();
        Guna.Charts.WinForms.LPoint lpUsersAvgCalorie = new Guna.Charts.WinForms.LPoint();
        #endregion
        private void MealsReports_Load(object sender, EventArgs e)
        {
            // fill FoodCategoryDatas for bar chart -- "7" for weekly ,"30" for monthly
            FillFoodCategoryDatas(MealType.Breakfast, 7);
            // fill CalorieDatas for bar chart -- "7" for weekly ,"30" for monthly
            FillCalorieData(7);

            lblMealType.Text = MealType.Breakfast.ToString();
        }
        private void tsWeekMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (!tsWeekMonth.Checked)
            {
                //for data load
                FillCalorieData(7);
                if (lblMealType.Text == MealType.Breakfast.ToString())
                    FillFoodCategoryDatas(MealType.Breakfast, 7);
                else if (lblMealType.Text == MealType.Lunch.ToString())
                    FillFoodCategoryDatas(MealType.Lunch, 7);
                else if (lblMealType.Text == MealType.Dinner.ToString())
                    FillFoodCategoryDatas(MealType.Dinner, 7);
                else
                    FillFoodCategoryDatas(7, MealType.Snack1, MealType.Snack2, MealType.Snack3, MealType.Snack4, MealType.Snack5, MealType.Snack6, MealType.Snack7);
                //For colors switch
                lblMealType.ForeColor = Color.Teal;
                btnBreakfast.FillColor = Color.Teal;
                btnDinner.FillColor = Color.Teal;
                btnLunch.FillColor = Color.Teal;
                btnOthers.FillColor = Color.Teal;
                pnlStick.FillColor = Color.Teal;
                pnlStick.FillColor2 = Color.Teal;
            }
            else
            {
                FillCalorieData(30);
                if (lblMealType.Text == MealType.Breakfast.ToString())
                    FillFoodCategoryDatas(MealType.Breakfast, 30);
                else if (lblMealType.Text == MealType.Lunch.ToString())
                    FillFoodCategoryDatas(MealType.Lunch, 30);
                else if (lblMealType.Text == MealType.Dinner.ToString())
                    FillFoodCategoryDatas(MealType.Dinner, 30);
                else
                    FillFoodCategoryDatas(30, MealType.Snack1, MealType.Snack2, MealType.Snack3, MealType.Snack4, MealType.Snack5, MealType.Snack6, MealType.Snack7);

                lblMealType.ForeColor = Color.MediumPurple;
                btnBreakfast.FillColor = Color.MediumPurple;
                btnDinner.FillColor = Color.MediumPurple;
                btnLunch.FillColor = Color.MediumPurple;
                btnOthers.FillColor = Color.MediumPurple;
                pnlStick.FillColor = Color.MediumPurple;
                pnlStick.FillColor2 = Color.MediumPurple;

            }
        }

        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            lblMealType.Text = MealType.Breakfast.ToString();
            if (!tsWeekMonth.Checked)
                FillFoodCategoryDatas(MealType.Breakfast, 7);
            else
                FillFoodCategoryDatas(MealType.Breakfast, 30);
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            lblMealType.Text = MealType.Lunch.ToString();
            if (!tsWeekMonth.Checked)
                FillFoodCategoryDatas(MealType.Lunch, 7);
            else
                FillFoodCategoryDatas(MealType.Lunch, 30);
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            lblMealType.Text = MealType.Dinner.ToString();
            if (!tsWeekMonth.Checked)
                FillFoodCategoryDatas(MealType.Dinner, 7);
            else
                FillFoodCategoryDatas(MealType.Dinner, 30);
        }

        private void btnOthers_Click(object sender, EventArgs e)
        {
            lblMealType.Text = "Others";
            if (!tsWeekMonth.Checked)
                FillFoodCategoryDatas(7, MealType.Snack1, MealType.Snack2, MealType.Snack3, MealType.Snack4, MealType.Snack5, MealType.Snack6, MealType.Snack7);
            else
                FillFoodCategoryDatas(30, MealType.Snack1, MealType.Snack2, MealType.Snack3, MealType.Snack4, MealType.Snack5, MealType.Snack6, MealType.Snack7);
        }

        #region Helper Methods
        public void FillFoodCategoryDatas(int day, params MealType[] mealTypes)
        {
            //Data1
            barDataFoodCategoryMy1.DataPoints.Clear();
            Guna.Charts.WinForms.LPoint[] lpMyCategoryPoints = new Guna.Charts.WinForms.LPoint[] { lpMyFurit, lpMyVegetable, lpMyDessert, lpMyMeat, lpMySoup, lpMyBeverage, lpMyDairy };
            for (int i = 0; i < lpMyCategoryPoints.Length; i++)
            {
                lpMyCategoryPoints[i].Label = ((FoodCategory)(i + 1)).ToString();
                lpMyCategoryPoints[i].Y = bl.Users.GetConsumedFoodsAmountForDaysById(userId, day, (FoodCategory)(i + 1), mealTypes);
            }
            barDataFoodCategoryMy1.DataPoints.AddRange(lpMyCategoryPoints);

            barDataFoodCategoryUsers1.DataPoints.Clear();
            Guna.Charts.WinForms.LPoint[] lpUsersCategoryPoints = new Guna.Charts.WinForms.LPoint[] { lpUsersFurit, lpUsersVegetable, lpUsersDessert, lpUsersMeat, lpUsersSoup, lpUsersBeverage, lpUsersDairy };
            for (int i = 0; i < lpUsersCategoryPoints.Length; i++)
            {
                lpUsersCategoryPoints[i].Label = ((FoodCategory)(i + 1)).ToString();
                var users = bl.Users.GetAll();
                int usersTotal = 0;
                foreach (var user in users)
                {
                    usersTotal += bl.Users.GetConsumedFoodsAmountForDaysById(userId, day, (FoodCategory)(i + 1), mealTypes);
                }
                lpUsersCategoryPoints[i].Y = usersTotal;
            }
            barDataFoodCategoryUsers1.DataPoints.AddRange(lpUsersCategoryPoints);

            //Data2
            barDataFoodCategoryMy2.DataPoints.Clear();
            Guna.Charts.WinForms.LPoint[] lpMyCategoryPoints2 = new Guna.Charts.WinForms.LPoint[] { lpMySalad, lpMyBakedGood, lpMyCereals, lpMySeaFood, lpMyFastFood, lpMyLegume, lpMyOthers };
            for (int i = 0; i < lpMyCategoryPoints2.Length; i++)
            {
                lpMyCategoryPoints2[i].Label = ((FoodCategory)(lpMyCategoryPoints.Length + i + 1)).ToString();
                lpMyCategoryPoints2[i].Y = bl.Users.GetConsumedFoodsAmountForDaysById(userId, day, (FoodCategory)(lpMyCategoryPoints.Length + i + 1), mealTypes);
            }
            barDataFoodCategoryMy2.DataPoints.AddRange(lpMyCategoryPoints2);

            barDataFoodCategoryUsers2.DataPoints.Clear();
            Guna.Charts.WinForms.LPoint[] lpUsersCategoryPoints2 = new Guna.Charts.WinForms.LPoint[] { lpUsersSalad, lpUsersBakedGood, lpUsersCereals, lpUsersSeaFood, lpUsersFastFood, lpUsersLegume, lpUsersOthers };
            for (int i = 0; i < lpUsersCategoryPoints2.Length; i++)
            {
                lpUsersCategoryPoints2[i].Label = ((FoodCategory)(lpUsersCategoryPoints.Length + i + 1)).ToString();
                var users = bl.Users.GetAll();
                int usersTotal = 0;
                foreach (var user in users)
                {
                    usersTotal += bl.Users.GetConsumedFoodsAmountForDaysById(userId, day, (FoodCategory)(lpUsersCategoryPoints.Length + i + 1), mealTypes);

                }
                lpUsersCategoryPoints2[i].Y = usersTotal;
            }
            barDataFoodCategoryUsers2.DataPoints.AddRange(lpUsersCategoryPoints2);
        }
        public void FillFoodCategoryDatas(MealType mealType, int day)
        {
            //Data1
            barDataFoodCategoryMy1.DataPoints.Clear();
            Guna.Charts.WinForms.LPoint[] lpMyCategoryPoints = new Guna.Charts.WinForms.LPoint[] { lpMyFurit, lpMyVegetable, lpMyDessert, lpMyMeat, lpMySoup, lpMyBeverage, lpMyDairy };
            for (int i = 0; i < lpMyCategoryPoints.Length; i++)
            {
                lpMyCategoryPoints[i].Label = ((FoodCategory)(i + 1)).ToString();
                lpMyCategoryPoints[i].Y = bl.Users.GetConsumedFoodsAmountForDaysById(userId, day, mealType, (FoodCategory)(i + 1));
            }
            barDataFoodCategoryMy1.DataPoints.AddRange(lpMyCategoryPoints);

            barDataFoodCategoryUsers1.DataPoints.Clear();
            Guna.Charts.WinForms.LPoint[] lpUsersCategoryPoints = new Guna.Charts.WinForms.LPoint[] { lpUsersFurit, lpUsersVegetable, lpUsersDessert, lpUsersMeat, lpUsersSoup, lpUsersBeverage, lpUsersDairy };
            for (int i = 0; i < lpUsersCategoryPoints.Length; i++)
            {
                lpUsersCategoryPoints[i].Label = ((FoodCategory)(i + 1)).ToString();
                var users = bl.Users.GetAll();
                int usersTotal = 0;
                foreach (var user in users)
                {
                    usersTotal += bl.Users.GetConsumedFoodsAmountForDaysById(user.ID, day, mealType, (FoodCategory)(i + 1));
                }
                lpUsersCategoryPoints[i].Y = usersTotal;
            }
            barDataFoodCategoryUsers1.DataPoints.AddRange(lpUsersCategoryPoints);

            //Data2
            barDataFoodCategoryMy2.DataPoints.Clear();
            Guna.Charts.WinForms.LPoint[] lpMyCategoryPoints2 = new Guna.Charts.WinForms.LPoint[] { lpMySalad, lpMyBakedGood, lpMyCereals, lpMySeaFood, lpMyFastFood, lpMyLegume, lpMyOthers };
            for (int i = 0; i < lpMyCategoryPoints2.Length; i++)
            {
                lpMyCategoryPoints2[i].Label = ((FoodCategory)(lpMyCategoryPoints.Length + i + 1)).ToString();
                lpMyCategoryPoints2[i].Y = bl.Users.GetConsumedFoodsAmountForDaysById(userId, day, mealType, (FoodCategory)(lpMyCategoryPoints.Length + i + 1));
            }
            barDataFoodCategoryMy2.DataPoints.AddRange(lpMyCategoryPoints2);

            barDataFoodCategoryUsers2.DataPoints.Clear();
            Guna.Charts.WinForms.LPoint[] lpUsersCategoryPoints2 = new Guna.Charts.WinForms.LPoint[] { lpUsersSalad, lpUsersBakedGood, lpUsersCereals, lpUsersSeaFood, lpUsersFastFood, lpUsersLegume, lpUsersOthers };
            for (int i = 0; i < lpUsersCategoryPoints2.Length; i++)
            {
                lpUsersCategoryPoints2[i].Label = ((FoodCategory)(lpUsersCategoryPoints.Length + i + 1)).ToString();
                var users = bl.Users.GetAll();
                int usersTotal = 0;
                foreach (var user in users)
                {
                    usersTotal += bl.Users.GetConsumedFoodsAmountForDaysById(user.ID, day, mealType, (FoodCategory)(lpUsersCategoryPoints.Length + i + 1));

                }
                lpUsersCategoryPoints2[i].Y = usersTotal;
            }
            barDataFoodCategoryUsers2.DataPoints.AddRange(lpUsersCategoryPoints2);
        }

        public void FillCalorieData(int day)
        {
            //Data1
            barDataCalories1.DataPoints.Clear();
            double totalMyCalorieForDays = bl.Users.GetCaloriesForDaysById(userId, day, out int emptyDays1);
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
                totalUsersCalorieForDays += bl.Users.GetCaloriesForDaysById(user.ID, day, out int emptyDays2);
                emptyusersDays += emptyDays2;
            }
            lpUsersAvgCalorie.Y = Math.Round(totalUsersCalorieForDays / (day - emptyusersDays) / userCount, 2);
            barDataCalories2.DataPoints.Add(lpUsersAvgCalorie);
        } 
        #endregion

        /* private void MealsReports_Load(object sender, EventArgs e)
         {
             // fill DataFoodCaregory1 bar chart
             barDataFoodCategoryMy1.DataPoints.Clear();
             Guna.Charts.WinForms.LPoint lpMyFurit = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint lpMyVegetable = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint lpMyDessert = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint lpMyMeat = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint lpMySoup = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint lpMyBeverage = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint lpMyDairy = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint[] lpMyCategoryPoints = new Guna.Charts.WinForms.LPoint[] { lpMyFurit, lpMyVegetable, lpMyDessert, lpMyMeat, lpMySoup, lpMyBeverage, lpMyDairy };
             for (int i = 0; i < lpMyCategoryPoints.Length; i++)
             {
                 lpMyCategoryPoints[i].Label = ((FoodCategory)(i + 1)).ToString();
                 lpMyCategoryPoints[i].Y = bl.Users.GetConsumedFoodsAmountForDaysById(userId, 7, MealType.Breakfast, (FoodCategory)(i + 1));
             }
             barDataFoodCategoryMy1.DataPoints.AddRange(lpMyCategoryPoints);

             barDataFoodCategoryUsers1.DataPoints.Clear();
             Guna.Charts.WinForms.LPoint lpUsersFurit = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint lpUsersVegetable = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint lpUsersDessert = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint lpUsersMeat = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint lpUsersSoup = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint lpUsersBeverage = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint lpUsersDairy = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint[] lpUsersCategoryPoints = new Guna.Charts.WinForms.LPoint[] { lpUsersFurit, lpUsersVegetable, lpUsersDessert, lpUsersMeat, lpUsersSoup, lpUsersBeverage, lpUsersDairy };

             for (int i = 0; i < lpUsersCategoryPoints.Length; i++)
             {
                 lpUsersCategoryPoints[i].Label = ((FoodCategory)(i + 1)).ToString();
                 var users = bl.Users.GetAll();
                 int usersTotal = 0;
                 foreach (var user in users)
                 {
                     usersTotal += bl.Users.GetConsumedFoodsAmountForDaysById(user.ID, 7, MealType.Breakfast, (FoodCategory)(i + 1));
                 }
                 lpUsersCategoryPoints[i].Y = usersTotal;
             }
             barDataFoodCategoryUsers1.DataPoints.AddRange(lpUsersCategoryPoints);

             // fill DataFoodCaregory2 bar chart
             barDataFoodCategoryMy2.DataPoints.Clear();
             Guna.Charts.WinForms.LPoint lpMySalad = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint lpMyBakedGood = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint lpMyCereals = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint lpMySeaFood = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint lpMyFastFood = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint lpMyLegume = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint lpMyOthers = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint[] lpMyCategoryPoints2 = new Guna.Charts.WinForms.LPoint[] { lpMySalad, lpMyBakedGood, lpMyCereals, lpMySeaFood, lpMyFastFood, lpMyLegume, lpMyOthers };
             for (int i = 0; i < lpMyCategoryPoints2.Length; i++)
             {
                 lpMyCategoryPoints2[i].Label = ((FoodCategory)(lpMyCategoryPoints.Length + i + 1)).ToString();
                 lpMyCategoryPoints2[i].Y = bl.Users.GetConsumedFoodsAmountForDaysById(userId, 7, MealType.Breakfast, (FoodCategory)(lpMyCategoryPoints.Length + i + 1));
             }
             barDataFoodCategoryMy2.DataPoints.AddRange(lpMyCategoryPoints2);

             barDataFoodCategoryUsers2.DataPoints.Clear();
             Guna.Charts.WinForms.LPoint lpUsersSalad = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint lpUsersBakedGood = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint lpUsersCereals = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint lpUsersSeaFood = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint lpUsersFastFood = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint lpUsersLegume = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint lpUsersOthers = new Guna.Charts.WinForms.LPoint();
             Guna.Charts.WinForms.LPoint[] lpUsersCategoryPoints2 = new Guna.Charts.WinForms.LPoint[] { lpUsersSalad, lpUsersBakedGood, lpUsersCereals, lpUsersSeaFood, lpUsersFastFood, lpUsersLegume, lpUsersOthers };
             for (int i = 0; i < lpUsersCategoryPoints2.Length; i++)
             {
                 lpUsersCategoryPoints2[i].Label = ((FoodCategory)(lpUsersCategoryPoints.Length + i + 1)).ToString();
                 var users = bl.Users.GetAll();
                 int usersTotal = 0;
                 foreach (var user in users)
                 {
                     usersTotal += bl.Users.GetConsumedFoodsAmountForDaysById(user.ID, 7, MealType.Breakfast, (FoodCategory)(lpUsersCategoryPoints.Length + i + 1));

                 }
                 lpUsersCategoryPoints2[i].Y = usersTotal;
             }
             barDataFoodCategoryUsers2.DataPoints.AddRange(lpUsersCategoryPoints2);

         }
        */
    }
}
