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
        User user = new User();
        Helper helper = new Helper();
        //Food food = new Food();
        //food.ImageResource = File.ReadAllBytes("image.jpg");
        private void Form1_Load(object sender, EventArgs e)
        {

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
            User user = new User();
            bl = new BusinessLogic();
            var users = bl.Users.GetAll();
            user = users.SingleOrDefault(a => a.Mail == txtEmail.Text || a.Password == txtPassword.Text);
            if (user == null)
            {
                MessageBox.Show("Kullanıcı bulunamadı. \nKayıt olmak için lütfen 'Sign In' butonunu tıklayın.");
                this.Close();
            }

            else if (user != null && (user.Mail != txtEmail.Text) && (user.Password != txtPassword.Text))
            {
                MessageBox.Show("Şifre ya da kullanıcı adı yanlış", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SignUp signUp = new SignUp();
                helper.HideAndShow(this, signUp);
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


        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
