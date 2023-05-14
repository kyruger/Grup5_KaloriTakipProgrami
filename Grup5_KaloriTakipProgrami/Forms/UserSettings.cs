using BLL;
using DAL;
using User;
using User.Enums;
using User.Models;
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
    public partial class UserSettings : Form
    {
        public UserSettings()
        {
            InitializeComponent();
        }
        BusinessLogic bl = new BusinessLogic();
        User.User user = new User.User();
        private void UserSettings_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (AreFieldsEmpty())
            {
                MessageBox.Show("Alanlar boş geçilemez. Lütfen eksik bilgilerinizi giriniz.");
            }


            if (ContainsNumeric(txtFirstName.Text) || ContainsNumeric(txtLastName.Text))
            {
                MessageBox.Show("Lütfen geçerli bir isim giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((txtFirstName.Text).Length < 2 || (txtLastName.Text).Length < 2)
            {
                MessageBox.Show("İsim ve soyisim en az 2 harf içermelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsPasswordValid(txtPassword.Text))
            {
                MessageBox.Show("Şifreler uygun kriterlere sahip değil\n---Kriterler---\n•En az 8 karakter uzunluğunda olmalıdır.\n• En az 2 büyük harf içermelidir.\n• En az 3 küçük harf içermelidir.\n• ! (ünlem), : (iki nokta üst üste), +(artı), *(yıldız) karakterlerinden en az 2 tanesini içermelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Şifreler eşleşmiyor. \nLütfen şifreleri kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string mail = txtEmail.Text;
                string password = txtPassword.Text;
                string confirmPassword = txtConfirmPassword.Text;
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                int age = Convert.ToInt32(txtAge.Text);
                Gender gender = (Gender)cmbGender.SelectedItem;
                string? phoneNumber = mtbTelephone.Text;
                decimal height = Convert.ToDecimal(txtHeight.Text);
                decimal weight = Convert.ToDecimal(txtWeight.Text);
                decimal goalWeight = Convert.ToDecimal(txtWeightGoal.Text);
                int dailyTargetCalories = Convert.ToInt32(txtDailyCaloriesGoal.Text);
                int dayGoal = Convert.ToInt32(txtDayGoal.Text);

                using (var dbContext = new CalorieTrackingDbContext())
                {
                    BusinessLogic bl = new BusinessLogic();

                    User.User user = new User.User()
                    {
                        Mail = mail,
                        Password = password,
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Gender = gender,
                        PhoneNumber = phoneNumber,
                        Height = height,
                        Weight = weight,
                        GoalWeight = goalWeight,
                        DailyGoalCalorie = dailyTargetCalories,
                        DayGoal = dayGoal

                    };

                    bool result = bl.Users.Add(user);

                    if (result)
                    {

                        MessageBox.Show("Güncelleme başarılı.");
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme başarısız.");
                    }
                }
            }
        }

        private void btnChangeUserPicture_Click(object sender, EventArgs e)
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
                pbChangePicture.Image = resizedImage;
                pbChangePicture.SizeMode = PictureBoxSizeMode.CenterImage;

            }
        }
        private bool AreFieldsEmpty()
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(mtbTelephone.Text) ||
                cmbGender.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtHeight.Text) ||
                string.IsNullOrWhiteSpace(txtWeight.Text) ||
                string.IsNullOrWhiteSpace(txtDailyCaloriesGoal.Text) ||
                string.IsNullOrWhiteSpace(txtWeightGoal.Text) ||
                string.IsNullOrWhiteSpace(txtDayGoal.Text)
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ContainsNumeric(string text)
        {
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                    return true;
            }
            return false;
        }

        private bool IsPasswordValid(string password)
        {
            int minLength = 8; int minUpperCase = 2; int minLowerCase = 3; int minSpecialChars = 2;
            if (password.Length < minLength) { return false; }
            if (password.Count(char.IsUpper) < minUpperCase) { return false; }
            if (password.Count(char.IsLower) < minLowerCase) { return false; }
            if (password.Count(c => "!:+*".Contains(c)) < minSpecialChars) { return false; }
            return true;
        }


    }
}
