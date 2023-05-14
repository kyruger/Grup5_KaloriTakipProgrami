using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WndPL.Forms;

namespace WndPL
{
    public class Helper
    {
        public void ShowPanel(Form form,Guna2Panel pnl)
        {
            pnl.Controls.Clear();
            form.TopLevel = false;
            pnl.Controls.Add(form);
            form.Show();
        }
        public void ClearTexts(Form form)
        {
            foreach (var item in form.Controls)
            {
                if (item is Guna2TextBox txt)
                    txt.Text = null;
            }
        }

        public void ClearTextsExceptOne(Form form,Guna2TextBox textBox)
        {
            foreach (var item in form.Controls)
            {
                if (item is Guna2TextBox txt && item != textBox)
                    txt.Text = null;
            }
        }

        public bool AreTextBoxesEmpty(Form form)
        {
            bool IsEmpty = false;
            foreach (var item in form.Controls)
            {

                if (item is Guna2TextBox txt)
                    if (string.IsNullOrWhiteSpace(txt.Text))

                        IsEmpty = true;
            }
            return IsEmpty;
        }
        public void HideAndShow(Form from1, Form form2)
        {
            from1.Hide();
            form2.ShowDialog();
            from1.Show();
        }
    }
}
