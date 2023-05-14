using BLL;
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
        Helper helper = new Helper();
        private void LogIn_Load(object sender, EventArgs e)
        {
            helper.ClearTexts(this);
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
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

            var users = bl.Users.GetAll();
            User user = users.SingleOrDefault(a => a.Mail == txtEmail.Text);

            if (user == null)
            {

                MessageBox.Show("Kullanıcı bulunamadı. \nKayıt olmak için lütfen 'Sign Up' butonunu tıklayın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

            }
            else if (user != null && (user.Mail != txtEmail.Text || user.Password != txtPassword.Text))
            {
                MessageBox.Show("kullanıcı adı ya da şifre yanlış", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

            }
            else
            {
                Main main = new(user.ID);
                helper.HideAndShow(this, main);
            }
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            helper.HideAndShow(this, signUp);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bizi ziyaret ettiğiniz için teşekkürler. \nSağlıklı günler dileriz.");
            Application.Exit();
        }


    }
}
