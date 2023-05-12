using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WndPL.Forms.ReportForms
{
    public partial class FoodReports : Form
    {
        public FoodReports()
        {
            InitializeComponent();
        }

        private void FoodReports_Load(object sender, EventArgs e)
        {
            lvSearchList.Hide();
        }
    }
}
