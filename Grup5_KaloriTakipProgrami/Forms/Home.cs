using BLL;
using Castle.Core.Internal;
using Entities;
using Guna.Charts.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WndPL.Forms
{
    public partial class Home : Form
    {
        //public Home(int id)
        //{
        //    InitializeComponent();
        //    userId = id;
        //    user = bl.Users.GetById(userId);
        //}
        int userId = 2;
        BusinessLogic bl = new BusinessLogic();
        Entities.User user;
        decimal currentWeight = 0;

        public Home()
        {
            InitializeComponent();
            user = bl.Users.GetById(userId);
        }
        private void Home_Load(object sender, EventArgs e)
        {
            lblRemainingDay.Text = "0";
            lblCalorie.Text = bl.Users.GetDailyCalorieById(userId).ToString();
            lblGoalCalorie.Text = user.DailyGoalCalorie.ToString();
            int leftCalorie = (int)(Convert.ToDouble(lblGoalCalorie.Text) - Convert.ToDouble(lblCalorie.Text));
            if (leftCalorie >= 0)
                lblLeftCalorie.Text = "-" + leftCalorie.ToString();
            else
            {
                leftCalorie = leftCalorie * -1;
                lblLeftCalorie.Text = "+" + leftCalorie.ToString();
            }

            txtDayGoal.Text = user.DayGoal.ToString();
            txtCurrentWeight.Text = user.Weight.ToString();
            txtGoalWeight.Text = user.GoalWeight.ToString();
            int remainingDay = CalculateRemainingDay();
            if (remainingDay > 0)
                lblRemainingDay.Text = remainingDay.ToString();
            else
                lblRemainingDay.Text = "0";

            // fill DailyRemaining circle progress bar
            FillDaysRemainingProgressBar();

            // fill DailyClorie circle progress bar
            cpbDailyCalorie.Maximum = user.DailyGoalCalorie;
            cpbDailyCalorie.Value = (int)bl.Users.GetDailyCalorieById(userId);

            // fill nutrient doughnut chart
            bl.Users.GetDailyNutrientsPercentageById(userId, out double dailyProteinGram, out double dailyFatGram, out double dailyCarbohydrateGram);
            doughnutData.DataPoints.Clear();
            Guna.Charts.WinForms.LPoint lpProtein = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lpFat = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lpCarbohydrate = new Guna.Charts.WinForms.LPoint();
            lpProtein.Label = "Protein";
            lpProtein.Y = Math.Round(dailyProteinGram, 2);
            lpFat.Label = "Fat";
            lpFat.Y = Math.Round(dailyFatGram, 2);
            lpCarbohydrate.Label = "Carbohydrate";
            lpCarbohydrate.Y = Math.Round(dailyCarbohydrateGram, 2);
            doughnutData.DataPoints.AddRange(new Guna.Charts.WinForms.LPoint[] { lpProtein, lpFat, lpCarbohydrate });
            double totalGram = dailyProteinGram + dailyFatGram + dailyCarbohydrateGram;
            double ProteinPercentage = Math.Round((dailyProteinGram / totalGram) * 100, 2);
            double FatPercentage = Math.Round((dailyFatGram / totalGram) * 100, 2);
            double CarbohydratePercentage = Math.Round((dailyCarbohydrateGram / totalGram) * 100, 2);
            lblProteinPercentage.Text = $"%{ProteinPercentage}";
            lblFatPercentage.Text = $"%{FatPercentage}";
            lblCarbohydratePercentage.Text = $"%{CarbohydratePercentage}";


            // fill weekly calories bar chart
            barData.DataPoints.Clear();
            Guna.Charts.WinForms.LPoint lpDay1 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lpDay2 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lpDay3 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lpDay4 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lpDay5 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lpDay6 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lpDay7 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint[] lpDayPoints = new Guna.Charts.WinForms.LPoint[] { lpDay1, lpDay2, lpDay3, lpDay4, lpDay5, lpDay6, lpDay7 };
            lpDayPoints[6].Label = DateTime.Now.DayOfWeek.ToString();
            lpDayPoints[6].Y = Convert.ToDouble(lblCalorie.Text);
            for (int i = 0, k = 5; i < 6; i++)
            {
                DateTime day = DateTime.Today.AddDays(-(i + 1));
                lpDayPoints[k].Label = day.DayOfWeek.ToString();
                lpDayPoints[k].Y = bl.Users.GetSpesificDayCaloriesById(userId, (i + 1));
                k--;
            }
            barData.DataPoints.AddRange(lpDayPoints);

            // line for weekly calories bar chart
            Guna.Charts.WinForms.LPoint lpLinePoint1 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lpLinePoint2 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lpLinePoint3 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lpLinePoint4 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lpLinePoint5 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lpLinePoint6 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lpLinePoint7 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint[] lpLinePoints = new Guna.Charts.WinForms.LPoint[] { lpLinePoint1, lpLinePoint2, lpLinePoint3, lpLinePoint4, lpLinePoint5, lpLinePoint6, lpLinePoint7 };
            for (int i = 0; i < 7; i++)
            {
                lpLinePoints[i].Y = Convert.ToDouble(lblCalorie.Text);
            }
        }

        private void txtWeightTexts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }


        #region txtDayGoal
        private void txtDayGoal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtDayGoal_TextChanged(object sender, EventArgs e)
        {
            if (txtDayGoal.Text.All(char.IsDigit) && !txtDayGoal.Text.IsNullOrEmpty())
            {
                user.DayGoal = Convert.ToInt32(txtDayGoal.Text);
                bl.Users.Update(user);
            }

        }

        private void txtDayGoal_Leave(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Gün hedefi belirlemek istediğinize emin misiniz?\n\n Not: Eğer bu işlemi onaylarsanız home ekranında hedeflenen gün bitene kadar \"Hedef Kilo\" ve \"Hedef Gün\" kısmında değişiklik yapmayacaksınız. Değişim yapmak için kullanıcı bilgileri ekranını kullanabilirsiniz.  ", "Silme Onayı", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                FillDaysRemainingProgressBar();
            }
            else
                txtDayGoal.Text = "0";
        }
        #endregion

        #region txtCurrentWeight
        private void txtCurrentWeight_Enter(object sender, EventArgs e)
        {
            currentWeight = Convert.ToDecimal(txtCurrentWeight.Text);
        }

        private void txtCurrentWeight_Leave(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(txtCurrentWeight.Text, "^[0-9.]*$"))
            if (char.IsDigit(txtCurrentWeight.Text[0]) && char.IsDigit(txtCurrentWeight.Text[^1]))
            {
                user.Weight = Convert.ToDecimal(txtCurrentWeight.Text);
                txtCurrentWeight.Text = user.Weight.ToString();
                bl.Users.Update(user);
            }
            else
                txtCurrentWeight.Text = currentWeight.ToString();
        }
        #endregion


        #region Helper Methods
        public int CalculateRemainingDay()
        {
            TimeSpan timePassed = DateTime.Now - user.DayGoalCreationTime;
            int day = (int)timePassed.TotalDays + 1;
            int remainingDay = user.DayGoal - day;
            return remainingDay;
        }
        public void FillDaysRemainingProgressBar()
        {
            if (txtDayGoal.Text != "0")
            {
                int remainingDay = CalculateRemainingDay();
                txtDayGoal.Enabled = false;
                txtGoalWeight.Enabled = false;
                cpbDaysRemaining.Maximum = user.DayGoal;
                cpbDaysRemaining.Value = user.DayGoal - remainingDay;
                lblRemainingDay.Text = remainingDay.ToString();
            }

        }
        #endregion

        private void cpbDailyCalorie_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
