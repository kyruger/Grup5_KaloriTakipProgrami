using BLL;
using DAL;
using Entities;
using Entities.Enums;
using Entities.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WndPL.Forms
{
    public partial class UserSettings : Form
    {
        public UserSettings(int id)
        {
            InitializeComponent();
            userId = id;
            user = bl.Users.GetById(userId);
        }
        BusinessLogic bl = new BusinessLogic();
        Helper helper = new Helper();
        int userId;
        Entities.User user;
        private void UserSettings_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetNames(typeof(Gender)))
                cmbGender.Items.Add(item);
            txtEmail.Text = user.Mail;
            txtEmail.ReadOnly = true;
            txtFirstName.Text = user.FirstName.ToString();
            txtLastName.Text = user.LastName.ToString();
            txtAge.Text = user.Age.ToString();
            txtHeight.Text = user.Height.ToString();
            txtWeight.Text = user.Weight.ToString();
            txtDailyCaloriesGoal.Text = user.DailyGoalCalorie.ToString();
            txtWeightGoal.Text = user.GoalWeight.ToString();
            txtDayGoal.Text = user.DayGoal.ToString();
            cmbGender.SelectedIndex = (int)user.Gender - 1;
            if (user.PhoneNumber != null)
                mtbTelephone.Text = user.PhoneNumber.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            bool emptyControl = helper.AreTextBoxesEmpty(this);
            if (emptyControl)
            {
                MessageBox.Show("Alanlar boş geçilemez. Lütfen eksik bilgilerinizi giriniz.");
            }
            else if (ContainsNumeric(txtFirstName.Text) || ContainsNumeric(txtLastName.Text))
            {
                MessageBox.Show("Lütfen geçerli bir isim giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if ((txtFirstName.Text).Length < 2 || (txtLastName.Text).Length < 2)
            {
                MessageBox.Show("İsim ve soyisim en az 2 harf içermelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!IsPasswordValid(txtNewPassword.Text))
            {
                MessageBox.Show("Şifreler uygun kriterlere sahip değil\n---Kriterler---\n•En az 8 karakter uzunluğunda olmalıdır.\n• En az 2 büyük harf içermelidir.\n• En az 3 küçük harf içermelidir.\n• ! (ünlem), : (iki nokta üst üste), +(artı), *(yıldız) karakterlerinden en az 2 tanesini içermelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Şifreler eşleşmiyor. \nLütfen şifreleri kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (user.Password !=txtPassword.Text)
            {
                MessageBox.Show("Önceki Şifrenizi yanlış girdiniz. \nLütfen şifreleri kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            { 
                if (helper.StartAndEndWithDigit(this.pnlText))
                {

                    user.Password = txtNewPassword.Text;
                    user.FirstName = txtFirstName.Text;
                    user.LastName = txtLastName.Text;
                    user.Age = Convert.ToInt32(txtAge.Text);
                    user.Gender = (Gender)cmbGender.SelectedIndex + 1;
                    string phoneNumber = new string(mtbTelephone.Text.Where(char.IsDigit).ToArray());
                    user.PhoneNumber = phoneNumber;
                    user.Height = Convert.ToDecimal(txtHeight.Text);
                    user.Weight = Convert.ToDecimal(txtWeight.Text);
                    user.GoalWeight = Convert.ToDecimal(txtWeightGoal.Text);
                    user.DailyGoalCalorie = Convert.ToInt32(txtDailyCaloriesGoal.Text);
                    user.DayGoal = Convert.ToInt32(txtDayGoal.Text);

                    bool result = bl.Users.Add(user);
                    if (result)
                        MessageBox.Show("Güncelleme başarılı.");
                    else
                        MessageBox.Show("Güncelleme başarısız.");
                }
                else
                {
                    MessageBox.Show("Ölçülerini doğru girdiğinizden emin olun.");
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

        private void Texts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
