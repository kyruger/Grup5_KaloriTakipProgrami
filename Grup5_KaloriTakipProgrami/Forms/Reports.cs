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
        public Reports()
        {
            InitializeComponent();

        }
        Helper helper = new Helper();

        private void Reports_Load(object sender, EventArgs e)
        {
            btnActivity.Enabled = false;
            MealsReports mealsReports = new MealsReports();
            helper.ShowPanel(mealsReports, pnlMain);
        }
        private void btnMeals_Click(object sender, EventArgs e)
        {
            MealsReports mealsReports = new MealsReports();
            helper.ShowPanel(mealsReports, pnlMain);


        }
        private void btnFoods_Click(object sender, EventArgs e)
        {
            FoodReports foodReports = new FoodReports();
            helper.ShowPanel(foodReports, pnlMain);
        }

    }
}
