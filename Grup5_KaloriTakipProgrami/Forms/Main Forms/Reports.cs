using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WndPL.Forms;
using WndPL.Forms.ReportForms;

namespace WndPL.Forms
{
    public partial class Reports : Form
    {
        public Reports(int id)
        {
            InitializeComponent();
            userId = id;

        }
        Helper helper = new Helper();
        int userId;
        private void Reports_Load(object sender, EventArgs e)
        {
            btnActivity.Enabled = false;
            FoodReports foodReports = new FoodReports(userId);
            helper.ShowPanel(foodReports, pnlMain);
        }
        private void btnMeals_Click(object sender, EventArgs e)
        {
            MealsReports mealsReports = new MealsReports(userId);
            helper.ShowPanel(mealsReports, pnlMain);
        }
        private void btnFoods_Click(object sender, EventArgs e)
        {
            FoodReports foodReports = new FoodReports(userId);
            helper.ShowPanel(foodReports, pnlMain);
        }

    }
}
