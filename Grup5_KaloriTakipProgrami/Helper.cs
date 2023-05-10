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
    }
}
