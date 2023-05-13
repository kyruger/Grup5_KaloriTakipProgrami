using BLL;
using Entities.Enums;
using FluentFTP.Helpers;
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
        Helper helper = new Helper();
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtLength.Text) || string.IsNullOrWhiteSpace(txtWeight.Text))
            {
                MessageBox.Show("Boy ve kilo bilgilerini girmeden bu işlem gerçekleştirilemez.");
            }
            else
            {
                double lenght = Convert.ToDouble(txtLength.Text) / 100.0;
            double weight = Convert.ToDouble(txtWeight.Text);

            double bodyMassIndex = weight / (lenght * lenght);

            txtBodyMassIndex.Text = bodyMassIndex.ToString("0.00");
                

            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //bool emptyControl = helper.AreTextBoxesEmpty(this);
            //if (emptyControl)
            //{
            //    MessageBox.Show("Boy, kilo, hedef kilo, günlük kalori hedefi, gün hedefi ve yaş bilgilerini eksiksiz giriniz.");
            //}
            if(string.IsNullOrWhiteSpace(txtLength.Text) || string.IsNullOrWhiteSpace(txtWeight.Text) || string.IsNullOrWhiteSpace(txtDailyTargetCalories.Text) || string.IsNullOrWhiteSpace(txtDayTarget.Text) || string.IsNullOrWhiteSpace(txtAge.Text) || string.IsNullOrWhiteSpace(mtbTelephone.Text) || cmbGender.SelectedItem == null)
            {
                MessageBox.Show("Alanlar boş geçilemez. Lütfen eksik bilgilerinizi giriniz.");
            }
            else
            {

                string length = txtLength.Text;
                string Weight = txtWeight.Text;
                string TargetWeight = txtTargetWeight.Text;
                string DailyTargetCalories = txtDailyTargetCalories.Text;
                string Age = txtAge.Text;
                string phoneNumber = mtbTelephone.Text;
                //string gender = Enums.Gender.Female.ToString();

            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            helper.HideAndShow(this, signUp);
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
    }

}

