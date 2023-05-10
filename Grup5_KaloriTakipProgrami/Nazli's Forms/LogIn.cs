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
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool emptyControl = AreTextBoxesEmpty(this);
            if (emptyControl)
            {
                MessageBox.Show("Eksik bilgi girdiniz. \nLütfen tüm alanları doldurunuz.");
                return;
            }

            string password = txtPassword.Text;
            string hashedPassword = sha256_hash(password);

            bl = new BusinessLogic();
            var users = bl.Users.GetAll();
            users.SingleOrDefault(a => a.Mail == txtEmail.Text || a.Password == txtPassword.Text);
            if (users == null)
            {
                MessageBox.Show("Kullanıcı bulunamadı. \nKayıt olmak için lütfen 'Sign In' butonunu tıklayın.");
            }

            else if ()
        }


        public bool AreTextBoxesEmpty(Form form)
        {
            bool IsEmpty = false;
            foreach (var item in form.Controls)
                if (item is TextBox txt)
                    if (txt.Text == "")
                        IsEmpty = true;
            return IsEmpty;
        }

        private string sha256_hash(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())

            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
            }
        }

        public void HideAndShow(Form from1, Form form2)
        {
            from1.Hide();
            form2.ShowDialog();
            from1.Show();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

    }
}