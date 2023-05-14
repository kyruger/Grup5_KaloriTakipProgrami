namespace WndPL.Nazli_s_Forms
{
    partial class frmSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignIn));
            this.pnlPhoto = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pbContactScreen = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMailRepeat = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPasswordRepeat = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.pbInterface = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtYour = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBody = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAboutWater = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDrink = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtWater = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContactScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInterface)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPhoto
            // 
            this.pnlPhoto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlPhoto.Controls.Add(this.txtWater);
            this.pnlPhoto.Controls.Add(this.txtDrink);
            this.pnlPhoto.Controls.Add(this.txtAboutWater);
            this.pnlPhoto.Controls.Add(this.txtBody);
            this.pnlPhoto.Controls.Add(this.txtYour);
            this.pnlPhoto.Controls.Add(this.pbInterface);
            this.pnlPhoto.Location = new System.Drawing.Point(274, -3);
            this.pnlPhoto.Name = "pnlPhoto";
            this.pnlPhoto.Size = new System.Drawing.Size(308, 465);
            this.pnlPhoto.TabIndex = 0;
            this.pnlPhoto.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPhoto_Paint);
            // 
            // pbContactScreen
            // 
            this.pbContactScreen.Image = ((System.Drawing.Image)(resources.GetObject("pbContactScreen.Image")));
            this.pbContactScreen.ImageRotate = 0F;
            this.pbContactScreen.Location = new System.Drawing.Point(2, -3);
            this.pbContactScreen.Name = "pbContactScreen";
            this.pbContactScreen.Size = new System.Drawing.Size(281, 477);
            this.pbContactScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbContactScreen.TabIndex = 10;
            this.pbContactScreen.TabStop = false;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.White;
            this.txtMail.BorderRadius = 20;
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.DefaultText = "";
            this.txtMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.Location = new System.Drawing.Point(25, 62);
            this.txtMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.PlaceholderText = "Email";
            this.txtMail.SelectedText = "";
            this.txtMail.Size = new System.Drawing.Size(226, 39);
            this.txtMail.TabIndex = 18;
            // 
            // txtMailRepeat
            // 
            this.txtMailRepeat.BackColor = System.Drawing.Color.White;
            this.txtMailRepeat.BorderRadius = 20;
            this.txtMailRepeat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMailRepeat.DefaultText = "";
            this.txtMailRepeat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMailRepeat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMailRepeat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMailRepeat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMailRepeat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMailRepeat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMailRepeat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMailRepeat.Location = new System.Drawing.Point(25, 109);
            this.txtMailRepeat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMailRepeat.Name = "txtMailRepeat";
            this.txtMailRepeat.PasswordChar = '\0';
            this.txtMailRepeat.PlaceholderText = "Reenter Email ";
            this.txtMailRepeat.SelectedText = "";
            this.txtMailRepeat.Size = new System.Drawing.Size(226, 40);
            this.txtMailRepeat.TabIndex = 19;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderRadius = 20;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(25, 167);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(226, 38);
            this.txtPassword.TabIndex = 20;
            // 
            // txtPasswordRepeat
            // 
            this.txtPasswordRepeat.BackColor = System.Drawing.Color.White;
            this.txtPasswordRepeat.BorderRadius = 20;
            this.txtPasswordRepeat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordRepeat.DefaultText = "";
            this.txtPasswordRepeat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPasswordRepeat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPasswordRepeat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordRepeat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordRepeat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordRepeat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPasswordRepeat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordRepeat.Location = new System.Drawing.Point(25, 224);
            this.txtPasswordRepeat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPasswordRepeat.Name = "txtPasswordRepeat";
            this.txtPasswordRepeat.PasswordChar = '\0';
            this.txtPasswordRepeat.PlaceholderText = "Reenter Password";
            this.txtPasswordRepeat.SelectedText = "";
            this.txtPasswordRepeat.Size = new System.Drawing.Size(226, 40);
            this.txtPasswordRepeat.TabIndex = 21;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.BorderRadius = 20;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Location = new System.Drawing.Point(25, 282);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderText = "Fist Name";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(226, 36);
            this.txtFirstName.TabIndex = 22;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.BorderRadius = 20;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Location = new System.Drawing.Point(25, 335);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderText = "Last Name";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(226, 33);
            this.txtLastName.TabIndex = 23;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Beige;
            this.btnBack.BorderRadius = 20;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 386);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 35);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Beige;
            this.btnConfirm.BorderRadius = 20;
            this.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirm.FillColor = System.Drawing.Color.DarkOliveGreen;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(145, 386);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(126, 35);
            this.btnConfirm.TabIndex = 25;
            this.btnConfirm.Text = "Confirm";
            // 
            // pbInterface
            // 
            this.pbInterface.Image = ((System.Drawing.Image)(resources.GetObject("pbInterface.Image")));
            this.pbInterface.ImageRotate = 0F;
            this.pbInterface.Location = new System.Drawing.Point(3, 3);
            this.pbInterface.Name = "pbInterface";
            this.pbInterface.Size = new System.Drawing.Size(305, 474);
            this.pbInterface.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInterface.TabIndex = 9;
            this.pbInterface.TabStop = false;
            // 
            // txtYour
            // 
            this.txtYour.BorderColor = System.Drawing.Color.Black;
            this.txtYour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYour.DefaultText = "YOUR";
            this.txtYour.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtYour.DisabledState.FillColor = System.Drawing.Color.LightGray;
            this.txtYour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYour.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYour.Enabled = false;
            this.txtYour.FillColor = System.Drawing.Color.LightGray;
            this.txtYour.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYour.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYour.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYour.Location = new System.Drawing.Point(24, 57);
            this.txtYour.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtYour.Multiline = true;
            this.txtYour.Name = "txtYour";
            this.txtYour.PasswordChar = '\0';
            this.txtYour.PlaceholderText = "";
            this.txtYour.SelectedText = "";
            this.txtYour.Size = new System.Drawing.Size(117, 60);
            this.txtYour.TabIndex = 10;
            // 
            // txtBody
            // 
            this.txtBody.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBody.DefaultText = "b o d y  i s";
            this.txtBody.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBody.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtBody.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBody.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBody.Enabled = false;
            this.txtBody.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBody.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBody.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBody.Location = new System.Drawing.Point(122, 101);
            this.txtBody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBody.Name = "txtBody";
            this.txtBody.PasswordChar = '\0';
            this.txtBody.PlaceholderText = "";
            this.txtBody.SelectedText = "";
            this.txtBody.Size = new System.Drawing.Size(172, 31);
            this.txtBody.TabIndex = 11;
            // 
            // txtAboutWater
            // 
            this.txtAboutWater.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAboutWater.DefaultText = "about 70% water.";
            this.txtAboutWater.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAboutWater.DisabledState.FillColor = System.Drawing.Color.Beige;
            this.txtAboutWater.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAboutWater.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAboutWater.Enabled = false;
            this.txtAboutWater.FillColor = System.Drawing.Color.Beige;
            this.txtAboutWater.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAboutWater.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAboutWater.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAboutWater.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAboutWater.Location = new System.Drawing.Point(34, 140);
            this.txtAboutWater.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAboutWater.Multiline = true;
            this.txtAboutWater.Name = "txtAboutWater";
            this.txtAboutWater.PasswordChar = '\0';
            this.txtAboutWater.PlaceholderText = "";
            this.txtAboutWater.SelectedText = "";
            this.txtAboutWater.Size = new System.Drawing.Size(151, 39);
            this.txtAboutWater.TabIndex = 12;
            // 
            // txtDrink
            // 
            this.txtDrink.BorderColor = System.Drawing.Color.Black;
            this.txtDrink.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDrink.DefaultText = "DRINK";
            this.txtDrink.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDrink.DisabledState.FillColor = System.Drawing.Color.LightGray;
            this.txtDrink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDrink.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDrink.Enabled = false;
            this.txtDrink.FillColor = System.Drawing.Color.LightGray;
            this.txtDrink.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDrink.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrink.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDrink.Location = new System.Drawing.Point(17, 337);
            this.txtDrink.Margin = new System.Windows.Forms.Padding(5);
            this.txtDrink.Multiline = true;
            this.txtDrink.Name = "txtDrink";
            this.txtDrink.PasswordChar = '\0';
            this.txtDrink.PlaceholderText = "";
            this.txtDrink.SelectedText = "";
            this.txtDrink.Size = new System.Drawing.Size(117, 60);
            this.txtDrink.TabIndex = 13;
            // 
            // txtWater
            // 
            this.txtWater.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWater.DefaultText = "w a t e r";
            this.txtWater.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWater.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtWater.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWater.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWater.Enabled = false;
            this.txtWater.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWater.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWater.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWater.Location = new System.Drawing.Point(111, 389);
            this.txtWater.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWater.Name = "txtWater";
            this.txtWater.PasswordChar = '\0';
            this.txtWater.PlaceholderText = "";
            this.txtWater.SelectedText = "";
            this.txtWater.Size = new System.Drawing.Size(118, 31);
            this.txtWater.TabIndex = 14;
            // 
            // frmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 466);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtPasswordRepeat);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtMailRepeat);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.pbContactScreen);
            this.Controls.Add(this.pnlPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSignIn";
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbContactScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInterface)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlPhoto;
        private Guna.UI2.WinForms.Guna2PictureBox pbInterface;
        private Guna.UI2.WinForms.Guna2PictureBox pbContactScreen;
        private Guna.UI2.WinForms.Guna2TextBox txtMail;
        private Guna.UI2.WinForms.Guna2TextBox txtMailRepeat;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPasswordRepeat;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2TextBox txtDrink;
        private Guna.UI2.WinForms.Guna2TextBox txtAboutWater;
        private Guna.UI2.WinForms.Guna2TextBox txtBody;
        private Guna.UI2.WinForms.Guna2TextBox txtYour;
        private Guna.UI2.WinForms.Guna2TextBox txtWater;
    }
}

