﻿using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WndPL.Forms
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        BusinessLogic bl = new BusinessLogic();
        User user = new User();
        Helper helper = new Helper();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            string pw = txtPassword.Text;

            if (cbShowPassword.Checked)
            {
                string hashedPassword = sha256_hash(pw);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool emptyControl = helper.AreTextBoxesEmpty(this);
            if (emptyControl)
            {
                MessageBox.Show("Eksik bilgi girdiniz. \nLütfen tüm alanları doldurunuz.");
                return;
            }
            User user = new User();
            bl = new BusinessLogic();
            var users = bl.Users.GetAll();
            users.SingleOrDefault(a => a.Mail == txtEmail.Text || a.Password == txtPassword.Text);
            if (users == null)
            {
                MessageBox.Show("Kullanıcı bulunamadı. \nKayıt olmak için lütfen 'Sign In' butonunu tıklayın.");
                this.Close();
            }

            else if (user.Mail != txtEmail.Text && user.Password != txtPassword.Text)
            {
                MessageBox.Show("Şifre ya da kullanıcı adı yanlış", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignUp signIn = new SignUp();
            helper.HideAndShow(this, signIn);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bizi ziyare ettiğiniz için teşekkürler. \nSağlıklı günler dileriz.");
            Application.Exit();
        }

        private string sha256_hash(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())

            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
