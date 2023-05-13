using BLL;
using User;
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
        User.User user = new User.User();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            LogIn login = new();
            helper.HideAndShow(this, login);
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (AreFieldsEmpty())
            {
                MessageBox.Show("Alanlar boş geçilemez. Lütfen eksik bilgilerinizi giriniz.");
            }

            if (ContainsNumeric(txtFirstName.Text) || ContainsNumeric(txtLastName.Text))
            {
                MessageBox.Show("İsim ve soyisimde nümerik değer giremezsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((txtFirstName.Text).Length < 2 || (txtLastName.Text).Length < 2)
            {
                MessageBox.Show("İsim ve soyisim en az 2 harf içermelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtMail.Text != txtMailRepeat.Text)
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
                return;
            }
            else
            {
                var users = bl.Users.GetAll();
                User.User user = users.SingleOrDefault(a => a.Mail == txtMail.Text);
                if (user != null)
                {
                    MessageBox.Show("Bu mail adresi sistemde mevcut. \nLütfen bilgilerinizi kontrol ediniz.");
                    return;
                }
                else
                {
                    MessageBox.Show("Sisteme başarıyla kayıt oldunuz.");
                    User.User _user = new User.User();
                    bl = new BusinessLogic();
                    bl.Users.Add(_user);
                    UserInformation userInfo = new();
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

        private bool AreFieldsEmpty()
        {
            if (string.IsNullOrWhiteSpace(txtMail.Text) ||
                string.IsNullOrWhiteSpace(txtMailRepeat.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtPasswordRepeat.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text)
               )

            {
                return true;
            }

            else
            {
                return false;
            }
        }


        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pnlPhoto_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
