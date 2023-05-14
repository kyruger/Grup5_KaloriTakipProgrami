﻿using BLL;
using DAL;
using Entities;
using Entities.Enums;
using Entities.Models;
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
        public UserInformation(Entities.User user)
        {
            InitializeComponent();
            this.user = user;
        }
        BusinessLogic bl = new BusinessLogic();
        Helper helper = new Helper();
        Entities.User user;
        private void UserInformation_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetNames(typeof(Gender)))
                cmbGender.Items.Add(item);
        }

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

            bool emptyControl = helper.AreTextBoxesEmpty(this);
            if (emptyControl)
            {
                MessageBox.Show("Alanlar boş geçilemez. Lütfen eksik bilgilerinizi giriniz.");
            }
            else
            {
                user.Height = Convert.ToDecimal(txtHeight.Text);
                user.Weight = Convert.ToDecimal(txtWeight.Text);
                user.GoalWeight = Convert.ToDecimal(txtTargetWeight.Text);
                user.DailyGoalCalorie = Convert.ToInt32(txtDailyTargetCalories.Text);
                user.Age = Convert.ToInt32(txtAge.Text);
                user.PhoneNumber = mtbTelephone.Text;
                user.Gender = (Gender)cmbGender.SelectedIndex + 1;

                bool result = bl.Users.Add(user);
                if (result)
                    MessageBox.Show("Ekleme başarılı.");
                else
                    MessageBox.Show("Ekleme başarısız.");

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

