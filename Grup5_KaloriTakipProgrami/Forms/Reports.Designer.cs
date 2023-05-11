namespace WndPL.Forms
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnFoods = new Guna.UI2.WinForms.Guna2Button();
            btnMeals = new Guna.UI2.WinForms.Guna2Button();
            btnActivity = new Guna.UI2.WinForms.Guna2Button();
            pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            pnlTop = new Guna.UI2.WinForms.Guna2GradientPanel();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // btnFoods
            // 
            btnFoods.CustomizableEdges = customizableEdges11;
            btnFoods.DisabledState.BorderColor = Color.DarkGray;
            btnFoods.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFoods.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFoods.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFoods.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFoods.ForeColor = Color.White;
            btnFoods.Location = new Point(35, 28);
            btnFoods.Name = "btnFoods";
            btnFoods.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnFoods.Size = new Size(180, 45);
            btnFoods.TabIndex = 0;
            btnFoods.Text = "Foods";
            // 
            // btnMeals
            // 
            btnMeals.CustomizableEdges = customizableEdges13;
            btnMeals.DisabledState.BorderColor = Color.DarkGray;
            btnMeals.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMeals.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMeals.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMeals.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnMeals.ForeColor = Color.White;
            btnMeals.Location = new Point(315, 28);
            btnMeals.Name = "btnMeals";
            btnMeals.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnMeals.Size = new Size(180, 45);
            btnMeals.TabIndex = 1;
            btnMeals.Text = "Meals";
            btnMeals.Click += btnMeals_Click;
            // 
            // btnActivity
            // 
            btnActivity.CustomizableEdges = customizableEdges15;
            btnActivity.DisabledState.BorderColor = Color.DarkGray;
            btnActivity.DisabledState.CustomBorderColor = Color.DarkGray;
            btnActivity.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnActivity.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnActivity.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnActivity.ForeColor = Color.White;
            btnActivity.Location = new Point(595, 28);
            btnActivity.Name = "btnActivity";
            btnActivity.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnActivity.Size = new Size(180, 45);
            btnActivity.TabIndex = 2;
            btnActivity.Text = "Activity";
            // 
            // pnlMain
            // 
            pnlMain.CustomizableEdges = customizableEdges17;
            pnlMain.Dock = DockStyle.Bottom;
            pnlMain.Location = new Point(0, 120);
            pnlMain.Name = "pnlMain";
            pnlMain.ShadowDecoration.CustomizableEdges = customizableEdges18;
            pnlMain.Size = new Size(1000, 580);
            pnlMain.TabIndex = 1;
            // 
            // pnlTop
            // 
            pnlTop.BorderColor = Color.White;
            pnlTop.BorderRadius = 25;
            pnlTop.Controls.Add(btnActivity);
            pnlTop.Controls.Add(btnMeals);
            pnlTop.Controls.Add(btnFoods);
            pnlTop.CustomizableEdges = customizableEdges19;
            pnlTop.FillColor = Color.Teal;
            pnlTop.FillColor2 = Color.MediumPurple;
            pnlTop.Location = new Point(100, 10);
            pnlTop.Name = "pnlTop";
            pnlTop.ShadowDecoration.CustomizableEdges = customizableEdges20;
            pnlTop.Size = new Size(800, 100);
            pnlTop.TabIndex = 2;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 700);
            Controls.Add(pnlTop);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reports";
            Text = "Reports";
            pnlTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnFoods;
        private Guna.UI2.WinForms.Guna2Button btnMeals;
        private Guna.UI2.WinForms.Guna2Button btnActivity;
        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlTop;
    }
}