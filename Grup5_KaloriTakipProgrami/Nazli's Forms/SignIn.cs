﻿using BLL;
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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        BusinessLogic bl = new BusinessLogic();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool emptyControl = AreTextControlEmpty(this);
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pnlPhoto_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
