using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WndPL.Forms
{
    internal class Helper
    {
        public bool AreTextBoxesEmpty(Form form)
        {
            bool IsEmpty = false;
            foreach (var item in form.Controls)
            {

                if (item is TextBox txt)
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
