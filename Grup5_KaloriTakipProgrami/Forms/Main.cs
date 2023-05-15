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

namespace WndPL.Forms
{
    public partial class Main : Form
    {
        public Main(int id)
        {
            InitializeComponent();
            userId = id;
        }
        BusinessLogic bl = new BusinessLogic();
        Helper helper = new Helper();
        int userId;
        private void Main_Load(object sender, EventArgs e)
        {
            Home homeForm = new Home(userId);
            Entities.User user = bl.Users.GetById(userId);
            lblName.Text = user.FullName;
            lblMail.Text = user.Mail;
            if (user.Image != null) 
            {
            byte[] imageData = user.Image;
            MemoryStream ms = new MemoryStream(imageData);
            var image = Image.FromStream(ms);
            picboxProfile.Image = image;
            }
            helper.ShowPanel(homeForm, pnlMain);
            btnActivity.Enabled = false;
            btnDiets.Enabled = false;

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home(userId);
            helper.ShowPanel(homeForm, pnlMain);
        }

        private void btnMeals_Click(object sender, EventArgs e)
        {
            Meals mealForm = new Meals(userId);
            helper.ShowPanel(mealForm, pnlMain);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports reportsForm = new Reports(userId);
            helper.ShowPanel(reportsForm, pnlMain);
        }


        private void btnUserSettings_Click(object sender, EventArgs e)
        {
            UserSettings userSettingsForm = new UserSettings(userId);
            helper.ShowPanel(userSettingsForm, pnlMain);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
