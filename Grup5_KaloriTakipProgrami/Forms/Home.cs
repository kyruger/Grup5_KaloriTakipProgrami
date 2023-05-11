using BLL;
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

            //lblLeftCalorie.Text = bl.Users.GetDailyCalorieById(userId).ToString();
            txtDayGoal.Text = user.DayGoal.ToString();
            txtCurrentWeight.Text = user.Weight.ToString();
            txtGoalWeight.Text = user.GoalWeight.ToString();
            int remainingDay = CalculateRemainingDay();
            if (remainingDay > 0)
                lblRemainingDay.Text = remainingDay.ToString();
            //else
            //    lblRemainingDay.Text = "0";

            // fill DailyRemaining circle progress bar
            FillDaysRemainingProgressBar();

            // fill DailyClorie circle progress bar
            cpbDailyCalorie.Maximum = user.DailyGoalCalorie;
            cpbDailyCalorie.Value = (int)bl.Users.GetDailyCalorieById(userId);

            // fill nutrient doughnut chart
            bl.Users.GetDailyNutrientsPercentageById(userId, out double dailyProteinPercentage, out double dailyFatPercentage, out double dailyCarbohydratePercentage);
            doughnutData.DataPoints.Clear();
            Guna.Charts.WinForms.LPoint lpProtein = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lpFat = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lpCarbohydrate = new Guna.Charts.WinForms.LPoint();
            lpProtein.Label = "Protein";
            lpProtein.Y = Math.Round(dailyProteinPercentage, 2);
            lpFat.Label = "Fat";
            lpFat.Y = Math.Round(dailyFatPercentage, 2);
            lpCarbohydrate.Label = "Carbohydrate";
            lpCarbohydrate.Y = Math.Round(dailyCarbohydratePercentage, 2);
            doughnutData.DataPoints.AddRange(new Guna.Charts.WinForms.LPoint[] { lpProtein, lpFat, lpCarbohydrate });
            lblProteinPercentage.Text = $"%{lpProtein.Y}";
            lblFatPercentage.Text = $"%{lpFat.Y}";
            lblCarbohydratePercentage.Text = $"%{lpCarbohydrate.Y}";


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

        private void txtDaysRemaining_TextChanged(object sender, EventArgs e)
        {
            if (txtDayGoal.Text.All(char.IsDigit))
            {
                user.DayGoal = Convert.ToInt32(txtDayGoal.Text);
                bl.Users.Update(user);
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
            if (lblRemainingDay.Text != "0")
            {
                int remainingDay = CalculateRemainingDay();
                txtDayGoal.Enabled = false;
                txtGoalWeight.Enabled = false;
                cpbDaysRemaining.Maximum = user.DayGoal;
                cpbDaysRemaining.Value = user.DayGoal - remainingDay;
            }
        }
        #endregion
    }
}
