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
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool emptyControl = helper.AreTextBoxesEmpty(this);
            if (emptyControl)
            {
                MessageBox.Show("Alanlar boş geçilemez. Lütfen eksik bilgilerinizi giriniz.");
                return;
            }

            else if (ContainsNumeric(txtFirstName.Text) || ContainsNumeric(txtLastName.Text))
            {
                MessageBox.Show("Lütfen geçerli bir isim giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if ((txtFirstName.Text).Length < 2 || (txtLastName.Text).Length < 2)
            {
                MessageBox.Show("İsim ve soyisim en az 2 harf içermelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (txtMail.Text != txtMailRepeat.Text)
            {
                MessageBox.Show("Girdiğiniz mail adresleri uyuşmuyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!IsPasswordValid(txtPassword.Text))
            {
                MessageBox.Show("Şifreler uygun kriterlere sahip değil\n---Kriterler---\n•En az 8 karakter uzunluğunda olmalıdır.\n• En az 2 büyük harf içermelidir.\n• En az 3 küçük harf içermelidir.\n• ! (ünlem), : (iki nokta üst üste), +(artı), *(yıldız) karakterlerinden en az 2 tanesini içermelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtPassword.Text != txtPasswordRepeat.Text)
            {
                MessageBox.Show("Şifreler eşleşmiyor. \nLütfen şifreleri kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                var users = bl.Users.GetAll();
                User user = users.SingleOrDefault(u=>u.Mail == txtMail.Text);
                if (user != null)
                {
                    MessageBox.Show("Bu mail adresi sistemde mevcut. \nLütfen bilgilerinizi kontrol ediniz.");

                }
                else
                {
                    MessageBox.Show("Sisteme başarıyla kayıt oldunuz.");
                    User newUser = new User()
                    {
                        Mail = txtMail.Text,
                        Password = txtPassword.Text,
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text
                    };
                    UserInformation userInfo = new(newUser);
                    helper.HideAndShow(this, userInfo);

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

        private bool ContainsNumeric(string text)
        {
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                    return true;
            }
            return false;
        }


    }
}
