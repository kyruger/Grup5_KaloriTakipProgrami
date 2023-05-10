namespace WndPL.Nazli_s_Forms
{
    partial class frmPersonalInformation
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSkip = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.txtDayTarget = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDailyTargetCalories = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTargetWeight = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtWeight = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLenght = new Guna.UI2.WinForms.Guna2TextBox();
            this.pbPhoto = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAddPhoto = new Guna.UI2.WinForms.Guna2Button();
            this.cmbGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.mtbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.txtAge = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCalculate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.guna2Panel1.Location = new System.Drawing.Point(-2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(226, 619);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btnCalculate);
            this.guna2Panel2.Controls.Add(this.guna2TextBox1);
            this.guna2Panel2.Controls.Add(this.txtAge);
            this.guna2Panel2.Controls.Add(this.mtbTelephone);
            this.guna2Panel2.Controls.Add(this.cmbGender);
            this.guna2Panel2.Controls.Add(this.btnAddPhoto);
            this.guna2Panel2.Controls.Add(this.pbPhoto);
            this.guna2Panel2.Controls.Add(this.btnSkip);
            this.guna2Panel2.Controls.Add(this.btnConfirm);
            this.guna2Panel2.Controls.Add(this.txtDayTarget);
            this.guna2Panel2.Controls.Add(this.txtDailyTargetCalories);
            this.guna2Panel2.Controls.Add(this.txtTargetWeight);
            this.guna2Panel2.Controls.Add(this.txtWeight);
            this.guna2Panel2.Controls.Add(this.txtLenght);
            this.guna2Panel2.Location = new System.Drawing.Point(212, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(469, 619);
            this.guna2Panel2.TabIndex = 1;
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.Beige;
            this.btnSkip.BorderRadius = 20;
            this.btnSkip.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSkip.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSkip.DisabledState.FillColor = System.Drawing.Color.SandyBrown;
            this.btnSkip.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSkip.FillColor = System.Drawing.Color.SandyBrown;
            this.btnSkip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSkip.ForeColor = System.Drawing.Color.White;
            this.btnSkip.Location = new System.Drawing.Point(18, 546);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(126, 49);
            this.btnSkip.TabIndex = 33;
            this.btnSkip.Text = "Skip";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Beige;
            this.btnConfirm.BorderRadius = 20;
            this.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.FillColor = System.Drawing.Color.SandyBrown;
            this.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirm.FillColor = System.Drawing.Color.SandyBrown;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(324, 546);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(127, 49);
            this.btnConfirm.TabIndex = 32;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtDayTarget
            // 
            this.txtDayTarget.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDayTarget.BorderRadius = 20;
            this.txtDayTarget.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDayTarget.DefaultText = "";
            this.txtDayTarget.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDayTarget.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDayTarget.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDayTarget.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDayTarget.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDayTarget.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDayTarget.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDayTarget.Location = new System.Drawing.Point(30, 291);
            this.txtDayTarget.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDayTarget.Name = "txtDayTarget";
            this.txtDayTarget.PasswordChar = '\0';
            this.txtDayTarget.PlaceholderText = "Day Target";
            this.txtDayTarget.SelectedText = "";
            this.txtDayTarget.Size = new System.Drawing.Size(226, 36);
            this.txtDayTarget.TabIndex = 30;
            // 
            // txtDailyTargetCalories
            // 
            this.txtDailyTargetCalories.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDailyTargetCalories.BorderRadius = 20;
            this.txtDailyTargetCalories.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDailyTargetCalories.DefaultText = "";
            this.txtDailyTargetCalories.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDailyTargetCalories.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDailyTargetCalories.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDailyTargetCalories.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDailyTargetCalories.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDailyTargetCalories.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDailyTargetCalories.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDailyTargetCalories.Location = new System.Drawing.Point(30, 233);
            this.txtDailyTargetCalories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDailyTargetCalories.Name = "txtDailyTargetCalories";
            this.txtDailyTargetCalories.PasswordChar = '\0';
            this.txtDailyTargetCalories.PlaceholderText = "Daily Target Calories";
            this.txtDailyTargetCalories.SelectedText = "";
            this.txtDailyTargetCalories.Size = new System.Drawing.Size(226, 40);
            this.txtDailyTargetCalories.TabIndex = 29;
            // 
            // txtTargetWeight
            // 
            this.txtTargetWeight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTargetWeight.BorderRadius = 20;
            this.txtTargetWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTargetWeight.DefaultText = "";
            this.txtTargetWeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTargetWeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTargetWeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTargetWeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTargetWeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTargetWeight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTargetWeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTargetWeight.Location = new System.Drawing.Point(30, 176);
            this.txtTargetWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTargetWeight.Name = "txtTargetWeight";
            this.txtTargetWeight.PasswordChar = '\0';
            this.txtTargetWeight.PlaceholderText = "Target Weight";
            this.txtTargetWeight.SelectedText = "";
            this.txtTargetWeight.Size = new System.Drawing.Size(226, 38);
            this.txtTargetWeight.TabIndex = 28;
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtWeight.BorderRadius = 20;
            this.txtWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWeight.DefaultText = "";
            this.txtWeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtWeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWeight.Location = new System.Drawing.Point(30, 118);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.PasswordChar = '\0';
            this.txtWeight.PlaceholderText = "Weight";
            this.txtWeight.SelectedText = "";
            this.txtWeight.Size = new System.Drawing.Size(226, 40);
            this.txtWeight.TabIndex = 27;
            // 
            // txtLenght
            // 
            this.txtLenght.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLenght.BorderRadius = 20;
            this.txtLenght.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLenght.DefaultText = "";
            this.txtLenght.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLenght.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLenght.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLenght.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLenght.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLenght.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLenght.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLenght.Location = new System.Drawing.Point(30, 71);
            this.txtLenght.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLenght.Name = "txtLenght";
            this.txtLenght.PasswordChar = '\0';
            this.txtLenght.PlaceholderText = "Lenght";
            this.txtLenght.SelectedText = "";
            this.txtLenght.Size = new System.Drawing.Size(226, 39);
            this.txtLenght.TabIndex = 26;
            // 
            // pbPhoto
            // 
            this.pbPhoto.ImageRotate = 0F;
            this.pbPhoto.Location = new System.Drawing.Point(299, 20);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(139, 90);
            this.pbPhoto.TabIndex = 34;
            this.pbPhoto.TabStop = false;
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.BorderRadius = 10;
            this.btnAddPhoto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPhoto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPhoto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddPhoto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPhoto.FillColor = System.Drawing.Color.SandyBrown;
            this.btnAddPhoto.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F);
            this.btnAddPhoto.ForeColor = System.Drawing.Color.White;
            this.btnAddPhoto.Location = new System.Drawing.Point(299, 136);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(152, 45);
            this.btnAddPhoto.TabIndex = 35;
            this.btnAddPhoto.Text = "Add Photo";
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.Transparent;
            this.cmbGender.BorderRadius = 15;
            this.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbGender.ItemHeight = 30;
            this.cmbGender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Others"});
            this.cmbGender.Location = new System.Drawing.Point(30, 442);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(226, 36);
            this.cmbGender.TabIndex = 36;
            // 
            // mtbTelephone
            // 
            this.mtbTelephone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbTelephone.Location = new System.Drawing.Point(30, 411);
            this.mtbTelephone.Mask = "(999) 000-0000";
            this.mtbTelephone.Name = "mtbTelephone";
            this.mtbTelephone.Size = new System.Drawing.Size(226, 15);
            this.mtbTelephone.TabIndex = 38;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAge.BorderRadius = 20;
            this.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAge.DefaultText = "";
            this.txtAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAge.Location = new System.Drawing.Point(30, 344);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAge.Name = "txtAge";
            this.txtAge.PasswordChar = '\0';
            this.txtAge.PlaceholderText = "Age";
            this.txtAge.SelectedText = "";
            this.txtAge.Size = new System.Drawing.Size(226, 36);
            this.txtAge.TabIndex = 39;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2TextBox1.BorderRadius = 20;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(30, 503);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Body Mass Index";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(149, 36);
            this.guna2TextBox1.TabIndex = 40;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Beige;
            this.btnCalculate.BorderRadius = 20;
            this.btnCalculate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculate.DisabledState.FillColor = System.Drawing.Color.SandyBrown;
            this.btnCalculate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCalculate.FillColor = System.Drawing.Color.SandyBrown;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(185, 504);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(96, 35);
            this.btnCalculate.TabIndex = 41;
            this.btnCalculate.Text = "Calculate";
            // 
            // frmPersonalInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 623);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonalInformation";
            this.Text = "PersonalInformation";
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox pbPhoto;
        private Guna.UI2.WinForms.Guna2Button btnSkip;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2TextBox txtDayTarget;
        private Guna.UI2.WinForms.Guna2TextBox txtDailyTargetCalories;
        private Guna.UI2.WinForms.Guna2TextBox txtTargetWeight;
        private Guna.UI2.WinForms.Guna2TextBox txtWeight;
        private Guna.UI2.WinForms.Guna2TextBox txtLenght;
        private Guna.UI2.WinForms.Guna2Button btnAddPhoto;
        private Guna.UI2.WinForms.Guna2TextBox txtAge;
        private System.Windows.Forms.MaskedTextBox mtbTelephone;
        private Guna.UI2.WinForms.Guna2ComboBox cmbGender;
        private Guna.UI2.WinForms.Guna2Button btnCalculate;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}

