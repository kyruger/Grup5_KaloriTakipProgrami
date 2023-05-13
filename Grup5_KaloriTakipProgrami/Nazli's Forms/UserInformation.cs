using BLL;
using DAL;
using User;
using User.Enums;
using User.Models;
using FluentFTP.Helpers;
using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WndPL.Forms
{
    public partial class UserInformation : Form
    {
        public UserInformation()
        {
            InitializeComponent();
        }
        User.User user = new User.User();
        BusinessLogic bl = new BusinessLogic();
        Helper helper = new Helper();

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHeight.Text) || string.IsNullOrWhiteSpace(txtWeight.Text))
            {
                MessageBox.Show("Boy ve kilo bilgilerini girmeden bu işlem gerçekleştirilemez.");
            }
            else
            {

                double height = Convert.ToDouble(txtHeight.Text) / 100.0;
                double weight = Convert.ToDouble(txtHeight.Text);
                double bodyMassIndex = weight / (height * height);
                txtBodyMassIndex.Text = bodyMassIndex.ToString("0.00");

            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if (AreFieldsEmpty())
            {
                MessageBox.Show("Alanlar boş geçilemez. Lütfen eksik bilgilerinizi giriniz.");
            }

            else
            {
                decimal height = Convert.ToDecimal(txtHeight.Text);
                decimal weight = Convert.ToDecimal(txtWeight.Text);
                decimal goalWeight = Convert.ToDecimal(txtTargetWeight.Text);
                int dailyTargetCalories = Convert.ToInt32(txtDailyTargetCalories.Text);
                int age = Convert.ToInt32(txtAge.Text);
                string? phoneNumber = mtbTelephone.Text;
                Gender gender = (Gender)cmbGender.SelectedItem;

                using (var dbContext = new CalorieTrackingDbContext())
                {

                    BusinessLogic bl = new BusinessLogic();

                    User.User user = new User.User()
                    {
                        Height = height,
                        Weight = weight,
                        GoalWeight = goalWeight,
                        DailyGoalCalorie = dailyTargetCalories,
                        Age = age,
                        PhoneNumber = phoneNumber,
                        Gender = gender
                    };


                    bool result = bl.Users.Add(user);

                    if (result)
                    {

                        MessageBox.Show("Ekleme başarılı.");

                    }

                    else
                    {

                        MessageBox.Show("Ekleme başarısız.");

                    }

                }
            }


        }
        private void btnAddPhoto_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog.Title = "Fotoğraf Seç";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                Image originalImage = Image.FromFile(imagePath);
                int maxWidth = 100;
                int maxHeight = 100;

                int newWidth, newHeight;
                if (originalImage.Width > originalImage.Height)
                {
                    newWidth = maxWidth;
                    newHeight = (int)(originalImage.Height * (float)newWidth / originalImage.Width);
                }
                else
                {
                    newHeight = maxHeight;
                    newWidth = (int)(originalImage.Width * (float)newHeight / originalImage.Height);
                }

                Image resizedImage = new Bitmap(originalImage, newWidth, newHeight);
                pbPhoto.Image = resizedImage;
                pbPhoto.SizeMode = PictureBoxSizeMode.CenterImage;

            }

        }

        private void btnSkip_Click(object sender, EventArgs e)
        {

            SignUp signUp = new SignUp();
            helper.HideAndShow(this, signUp);

        }

        private bool AreFieldsEmpty()
        {
            if (string.IsNullOrWhiteSpace(txtHeight.Text) ||
                string.IsNullOrWhiteSpace(txtWeight.Text) ||
                string.IsNullOrWhiteSpace(txtDailyTargetCalories.Text) ||
                string.IsNullOrWhiteSpace(txtDayTarget.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(mtbTelephone.Text) ||
                cmbGender.SelectedItem == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}

