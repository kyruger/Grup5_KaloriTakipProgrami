using BLL;
using Entities;
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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        BusinessLogic bl = new BusinessLogic();
        Helper helper = new Helper();
        User user = new User();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool emptyControl = helper.AreTextBoxesEmpty(this);
            if (emptyControl)
            {
                MessageBox.Show("Eksik bilgi girdiniz. \nLütfen tüm alanları doldurunuz.");
                return;
            }
            if (txtMail.Text != txtMailRepeat.Text)
            {
                MessageBox.Show("Girdiğiniz mail adresleri uyuşmuyor.");
            }
            else if (!IsPasswordValid(txtPassword.Text))
            {
                MessageBox.Show("Şifreler uygun kriterlere sahip değil\n---Kriterler---\n•En az 8 karakter uzunluğunda olmalıdır.\n• En az 2 büyük harf içermelidir.\n• En az 3 küçük harf içermelidir.\n• ! (ünlem), : (iki nokta üst üste), +(artı), *(yıldız) karakterlerinden en az 2 tanesini içermelidir.");

            }
            else if (txtPassword.Text != txtPasswordRepeat.Text)
            {
                MessageBox.Show("Şifreler eşleşmiyor. \nLütfen şifreleri kontrol ediniz.");
                return;
            }
            else
            {
                var users = bl.Users.GetAll();
                User user = users.SingleOrDefault(a => a.Mail == txtMail.Text);
                if (user != null)
                {
                    MessageBox.Show("Bu mail adresi sistemde mevcut. \nLütfen bilgilerinizi kontrol ediniz.");
                    return;
                }
                else
                {
                    MessageBox.Show("Sisteme başarıyla kayıt oldunuz.");
                    return;
                }
            }


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

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserSetting userSetting = new UserSetting();
            helper.HideAndShow(this, userSetting);
        }
        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pnlPhoto_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
