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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        Helper helper = new Helper();
        private void Main_Load(object sender, EventArgs e)
        {
            //Home homeForm = new Home();
            //helper.ShowPanel(homeForm, pnlMain);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //Home homeForm = new Home();
            //helper.ShowPanel(homeForm, pnlMain);
        }

        private void btnMeals_Click(object sender, EventArgs e)
        {
            Meals mealForm = new Meals();
            helper.ShowPanel(mealForm, pnlMain);
        }

        private void brnReports_Click(object sender, EventArgs e)
        {
            Reports reportsForm = new Reports();
            helper.ShowPanel(reportsForm, pnlMain);
        }
        private void btnUserSettings_Click(object sender, EventArgs e)
        {
            UserSettings userSettingsForm = new UserSettings();
            helper.ShowPanel(userSettingsForm, pnlMain);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
