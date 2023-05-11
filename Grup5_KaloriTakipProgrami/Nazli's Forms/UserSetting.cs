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
    public partial class UserSetting : Form
    {
        public UserSetting()
        {
            InitializeComponent();
        }
        Helper helper = new Helper();
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            double lenght = Convert.ToDouble(txtLenght.Text);
            double weight = Convert.ToDouble(txtWeight.Text);

            double bodyMassIndex = weight / (lenght * lenght);

            Text = "Vücut Kitle İndeksi (BMI): " + bodyMassIndex.ToString("F2");
            Show(this);
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool emptyControl = helper.AreTextBoxesEmpty(this);
            if (emptyControl)
            {
                MessageBox.Show("Boy, kilo, hedef kilo, günlük kalori hedefi, gün hedefi ve yaş bilgilerini eksiksiz giriniz.");
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
                string filePath = openFileDialog.FileName;
                Image selectedImage = Image.FromFile(filePath);
                pbPhoto.Image = selectedImage;
            }


        }
    }

}

