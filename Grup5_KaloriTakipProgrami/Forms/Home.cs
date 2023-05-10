using BLL;
using Entities;
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
        //} 
        public Home()
        {
            InitializeComponent();

        }
        int userId = 1;
        BusinessLogic bl = new BusinessLogic();
        Entities.User user;
        private void Home_Load(object sender, EventArgs e)
        {
            user = bl.Users.GetById(userId);
            lblCurrentCalorie.Text = bl.Users.GetDailyCalorieById(userId).ToString();
            lblCalorie.Text = bl.Users.GetDailyCalorieById(userId).ToString();
            lblGoalCalorie.Text = user.DailyGoalCalorie.ToString();
            lblDayGoalValue.Text = user.DayGoal.ToString();
            txtCurrentWeight.Text = user.Weight.ToString();
            txtGoalWeight.Text = user.GoalWeight.ToString();
            TimeSpan timePassed = DateTime.Now - user.dayGoalCreationTime;
            int day = (int)timePassed.TotalDays + 1;
            int remainingDay = user.DayGoal - day;
            if (remainingDay > 0)
                txtDaysRemaining.Text = remainingDay.ToString();
            else
                txtDaysRemaining.Text = "0";
            if (txtDaysRemaining.Text != "0")
                txtDaysRemaining.Enabled = false;

        }

        private void txtHomeTexts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtCurrentWeight_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(txtCurrentWeight.Text, "^[0-9.]*$"))

            user = bl.Users.GetById(userId);
            if (txtCurrentWeight.Text.All(char.IsDigit) && txtCurrentWeight.Text.Contains("."))
                user.Weight = Convert.ToDecimal(txtCurrentWeight.Text);

        }

        private void txtDaysRemaining_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
