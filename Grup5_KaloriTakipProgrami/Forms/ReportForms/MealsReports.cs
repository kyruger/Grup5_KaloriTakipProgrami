using BLL;
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
        private void MealsReports_Load(object sender, EventArgs e)
        {
            // fill DataFoodCaregory1 bar chart
            barDataFoodCategoryMy1.DataPoints.Clear();
            Guna.Charts.WinForms.LPoint[] lpMyCategoryPoints = new Guna.Charts.WinForms.LPoint[] { lpMyFurit, lpMyVegetable, lpMyDessert, lpMyMeat, lpMySoup, lpMyBeverage, lpMyDairy };
            for (int i = 0; i < lpMyCategoryPoints.Length; i++)
            {
                lpMyCategoryPoints[i].Label = ((FoodCategory)(i + 1)).ToString();
                lpMyCategoryPoints[i].Y = bl.Users.GetConsumedFoodsAmountForDaysById(userId, 7, MealType.Breakfast, (FoodCategory)(i + 1));
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
                    usersTotal += bl.Users.GetConsumedFoodsAmountForDaysById(user.ID, 7, MealType.Breakfast, (FoodCategory)(i + 1));
                }
                lpUsersCategoryPoints[i].Y = usersTotal;
            }
            barDataFoodCategoryUsers1.DataPoints.AddRange(lpUsersCategoryPoints);

            // fill DataFoodCaregory2 bar chart
            barDataFoodCategoryMy2.DataPoints.Clear();
            Guna.Charts.WinForms.LPoint[] lpMyCategoryPoints2 = new Guna.Charts.WinForms.LPoint[] { lpMySalad, lpMyBakedGood, lpMyCereals, lpMySeaFood, lpMyFastFood, lpMyLegume, lpMyOthers };
            for (int i = 0; i < lpMyCategoryPoints2.Length; i++)
            {
                lpMyCategoryPoints2[i].Label = ((FoodCategory)(lpMyCategoryPoints.Length + i + 1)).ToString();
                lpMyCategoryPoints2[i].Y = bl.Users.GetConsumedFoodsAmountForDaysById(userId, 7, MealType.Breakfast, (FoodCategory)(lpMyCategoryPoints.Length + i + 1));
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
                    usersTotal += bl.Users.GetConsumedFoodsAmountForDaysById(user.ID, 7, MealType.Breakfast, (FoodCategory)(lpUsersCategoryPoints.Length + i + 1));

                }
                lpUsersCategoryPoints2[i].Y = usersTotal;
            }
            barDataFoodCategoryUsers2.DataPoints.AddRange(lpUsersCategoryPoints2);

        }


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
