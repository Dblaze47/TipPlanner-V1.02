namespace ProjectSampleGUI
{
    partial class CreateAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAdmin));
            this.username = new MetroFramework.Controls.MetroLabel();
            this.uname = new MetroFramework.Controls.MetroTextBox();
            this.password = new MetroFramework.Controls.MetroLabel();
            this.confirmpassword = new MetroFramework.Controls.MetroLabel();
            this.firstName = new MetroFramework.Controls.MetroLabel();
            this.lastName = new MetroFramework.Controls.MetroLabel();
            this.newPIN = new MetroFramework.Controls.MetroLabel();
            this.upass = new MetroFramework.Controls.MetroTextBox();
            this.ucpass = new MetroFramework.Controls.MetroTextBox();
            this.uFName = new MetroFramework.Controls.MetroTextBox();
            this.uLName = new MetroFramework.Controls.MetroTextBox();
            this.uPIN = new MetroFramework.Controls.MetroTextBox();
            this.adminPIN = new MetroFramework.Controls.MetroLabel();
            this.aPIN = new MetroFramework.Controls.MetroTextBox();
            this.help = new System.Windows.Forms.Button();
            this.createUser = new MetroFramework.Controls.MetroButton();
            this.error = new MetroFramework.Controls.MetroLabel();
            this.success = new MetroFramework.Controls.MetroLabel();
            this.unameCheck = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dobYear = new System.Windows.Forms.ComboBox();
            this.dobMonth = new System.Windows.Forms.ComboBox();
            this.dobDay = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.username.Location = new System.Drawing.Point(12, 60);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 19);
            this.username.TabIndex = 0;
            this.username.Text = "Username    : ";
            this.username.UseCustomBackColor = true;
            this.username.UseCustomForeColor = true;
            // 
            // uname
            // 
            this.uname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            this.uname.CustomButton.Image = null;
            this.uname.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.uname.CustomButton.Name = "";
            this.uname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uname.CustomButton.TabIndex = 1;
            this.uname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uname.CustomButton.UseSelectable = true;
            this.uname.CustomButton.Visible = false;
            this.uname.Lines = new string[0];
            this.uname.Location = new System.Drawing.Point(173, 60);
            this.uname.MaxLength = 32767;
            this.uname.Name = "uname";
            this.uname.PasswordChar = '\0';
            this.uname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uname.SelectedText = "";
            this.uname.SelectionLength = 0;
            this.uname.SelectionStart = 0;
            this.uname.ShortcutsEnabled = true;
            this.uname.Size = new System.Drawing.Size(258, 23);
            this.uname.TabIndex = 1;
            this.uname.UseCustomBackColor = true;
            this.uname.UseCustomForeColor = true;
            this.uname.UseSelectable = true;
            this.uname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.password.Location = new System.Drawing.Point(12, 171);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(173, 19);
            this.password.TabIndex = 2;
            this.password.Text = "Password (min 4 char)  : ";
            this.password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.password.UseCustomBackColor = true;
            this.password.UseCustomForeColor = true;
            // 
            // confirmpassword
            // 
            this.confirmpassword.AutoSize = true;
            this.confirmpassword.BackColor = System.Drawing.Color.Transparent;
            this.confirmpassword.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.confirmpassword.Location = new System.Drawing.Point(12, 205);
            this.confirmpassword.Name = "confirmpassword";
            this.confirmpassword.Size = new System.Drawing.Size(167, 19);
            this.confirmpassword.TabIndex = 3;
            this.confirmpassword.Text = "Confirm Password        :";
            this.confirmpassword.UseCustomBackColor = true;
            this.confirmpassword.UseCustomForeColor = true;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.BackColor = System.Drawing.Color.Transparent;
            this.firstName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.firstName.Location = new System.Drawing.Point(12, 96);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(101, 19);
            this.firstName.TabIndex = 4;
            this.firstName.Text = "First Name   : ";
            this.firstName.UseCustomBackColor = true;
            this.firstName.UseCustomForeColor = true;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.BackColor = System.Drawing.Color.Transparent;
            this.lastName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lastName.Location = new System.Drawing.Point(12, 134);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(99, 19);
            this.lastName.TabIndex = 5;
            this.lastName.Text = "Last Name   : ";
            this.lastName.UseCustomBackColor = true;
            this.lastName.UseCustomForeColor = true;
            // 
            // newPIN
            // 
            this.newPIN.AutoSize = true;
            this.newPIN.BackColor = System.Drawing.Color.Transparent;
            this.newPIN.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.newPIN.Location = new System.Drawing.Point(12, 242);
            this.newPIN.Name = "newPIN";
            this.newPIN.Size = new System.Drawing.Size(100, 19);
            this.newPIN.TabIndex = 6;
            this.newPIN.Text = "Your PIN      : ";
            this.newPIN.UseCustomBackColor = true;
            this.newPIN.UseCustomForeColor = true;
            // 
            // upass
            // 
            this.upass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            this.upass.CustomButton.Image = null;
            this.upass.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.upass.CustomButton.Name = "";
            this.upass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.upass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.upass.CustomButton.TabIndex = 1;
            this.upass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.upass.CustomButton.UseSelectable = true;
            this.upass.CustomButton.Visible = false;
            this.upass.Lines = new string[0];
            this.upass.Location = new System.Drawing.Point(203, 168);
            this.upass.MaxLength = 32767;
            this.upass.Name = "upass";
            this.upass.PasswordChar = '\0';
            this.upass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.upass.SelectedText = "";
            this.upass.SelectionLength = 0;
            this.upass.SelectionStart = 0;
            this.upass.ShortcutsEnabled = true;
            this.upass.Size = new System.Drawing.Size(228, 23);
            this.upass.TabIndex = 4;
            this.upass.UseCustomBackColor = true;
            this.upass.UseCustomForeColor = true;
            this.upass.UseSelectable = true;
            this.upass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.upass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ucpass
            // 
            this.ucpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            this.ucpass.CustomButton.Image = null;
            this.ucpass.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.ucpass.CustomButton.Name = "";
            this.ucpass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ucpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ucpass.CustomButton.TabIndex = 1;
            this.ucpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ucpass.CustomButton.UseSelectable = true;
            this.ucpass.CustomButton.Visible = false;
            this.ucpass.Lines = new string[0];
            this.ucpass.Location = new System.Drawing.Point(203, 204);
            this.ucpass.MaxLength = 32767;
            this.ucpass.Name = "ucpass";
            this.ucpass.PasswordChar = '\0';
            this.ucpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ucpass.SelectedText = "";
            this.ucpass.SelectionLength = 0;
            this.ucpass.SelectionStart = 0;
            this.ucpass.ShortcutsEnabled = true;
            this.ucpass.Size = new System.Drawing.Size(228, 23);
            this.ucpass.TabIndex = 5;
            this.ucpass.UseCustomBackColor = true;
            this.ucpass.UseCustomForeColor = true;
            this.ucpass.UseSelectable = true;
            this.ucpass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ucpass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uFName
            // 
            this.uFName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            this.uFName.CustomButton.Image = null;
            this.uFName.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.uFName.CustomButton.Name = "";
            this.uFName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uFName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uFName.CustomButton.TabIndex = 1;
            this.uFName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uFName.CustomButton.UseSelectable = true;
            this.uFName.CustomButton.Visible = false;
            this.uFName.Lines = new string[0];
            this.uFName.Location = new System.Drawing.Point(173, 96);
            this.uFName.MaxLength = 32767;
            this.uFName.Name = "uFName";
            this.uFName.PasswordChar = '\0';
            this.uFName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uFName.SelectedText = "";
            this.uFName.SelectionLength = 0;
            this.uFName.SelectionStart = 0;
            this.uFName.ShortcutsEnabled = true;
            this.uFName.Size = new System.Drawing.Size(258, 23);
            this.uFName.TabIndex = 2;
            this.uFName.UseCustomBackColor = true;
            this.uFName.UseCustomForeColor = true;
            this.uFName.UseSelectable = true;
            this.uFName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uFName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uLName
            // 
            this.uLName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            this.uLName.CustomButton.Image = null;
            this.uLName.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.uLName.CustomButton.Name = "";
            this.uLName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uLName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uLName.CustomButton.TabIndex = 1;
            this.uLName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uLName.CustomButton.UseSelectable = true;
            this.uLName.CustomButton.Visible = false;
            this.uLName.Lines = new string[0];
            this.uLName.Location = new System.Drawing.Point(173, 132);
            this.uLName.MaxLength = 32767;
            this.uLName.Name = "uLName";
            this.uLName.PasswordChar = '\0';
            this.uLName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uLName.SelectedText = "";
            this.uLName.SelectionLength = 0;
            this.uLName.SelectionStart = 0;
            this.uLName.ShortcutsEnabled = true;
            this.uLName.Size = new System.Drawing.Size(258, 23);
            this.uLName.TabIndex = 3;
            this.uLName.UseCustomBackColor = true;
            this.uLName.UseCustomForeColor = true;
            this.uLName.UseSelectable = true;
            this.uLName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uLName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uPIN
            // 
            this.uPIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            this.uPIN.CustomButton.Image = null;
            this.uPIN.CustomButton.Location = new System.Drawing.Point(69, 1);
            this.uPIN.CustomButton.Name = "";
            this.uPIN.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uPIN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uPIN.CustomButton.TabIndex = 1;
            this.uPIN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uPIN.CustomButton.UseSelectable = true;
            this.uPIN.CustomButton.Visible = false;
            this.uPIN.Lines = new string[0];
            this.uPIN.Location = new System.Drawing.Point(116, 238);
            this.uPIN.MaxLength = 32767;
            this.uPIN.Name = "uPIN";
            this.uPIN.PasswordChar = '\0';
            this.uPIN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uPIN.SelectedText = "";
            this.uPIN.SelectionLength = 0;
            this.uPIN.SelectionStart = 0;
            this.uPIN.ShortcutsEnabled = true;
            this.uPIN.Size = new System.Drawing.Size(91, 23);
            this.uPIN.TabIndex = 6;
            this.uPIN.UseCustomBackColor = true;
            this.uPIN.UseCustomForeColor = true;
            this.uPIN.UseSelectable = true;
            this.uPIN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uPIN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // adminPIN
            // 
            this.adminPIN.AutoSize = true;
            this.adminPIN.BackColor = System.Drawing.Color.Transparent;
            this.adminPIN.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.adminPIN.Location = new System.Drawing.Point(12, 280);
            this.adminPIN.Name = "adminPIN";
            this.adminPIN.Size = new System.Drawing.Size(101, 19);
            this.adminPIN.TabIndex = 12;
            this.adminPIN.Text = "Admin\'s PIN : ";
            this.adminPIN.UseCustomBackColor = true;
            this.adminPIN.UseCustomForeColor = true;
            // 
            // aPIN
            // 
            this.aPIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            this.aPIN.CustomButton.Image = null;
            this.aPIN.CustomButton.Location = new System.Drawing.Point(69, 1);
            this.aPIN.CustomButton.Name = "";
            this.aPIN.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.aPIN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.aPIN.CustomButton.TabIndex = 1;
            this.aPIN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.aPIN.CustomButton.UseSelectable = true;
            this.aPIN.CustomButton.Visible = false;
            this.aPIN.Lines = new string[0];
            this.aPIN.Location = new System.Drawing.Point(116, 276);
            this.aPIN.MaxLength = 32767;
            this.aPIN.Name = "aPIN";
            this.aPIN.PasswordChar = '\0';
            this.aPIN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aPIN.SelectedText = "";
            this.aPIN.SelectionLength = 0;
            this.aPIN.SelectionStart = 0;
            this.aPIN.ShortcutsEnabled = true;
            this.aPIN.Size = new System.Drawing.Size(91, 23);
            this.aPIN.TabIndex = 7;
            this.aPIN.UseCustomBackColor = true;
            this.aPIN.UseCustomForeColor = true;
            this.aPIN.UseSelectable = true;
            this.aPIN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.aPIN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // help
            // 
            this.help.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("help.BackgroundImage")));
            this.help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.help.Location = new System.Drawing.Point(213, 266);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(20, 23);
            this.help.TabIndex = 8;
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // createUser
            // 
            this.createUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.createUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.createUser.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.createUser.ForeColor = System.Drawing.Color.White;
            this.createUser.Location = new System.Drawing.Point(0, 339);
            this.createUser.Name = "createUser";
            this.createUser.Size = new System.Drawing.Size(648, 56);
            this.createUser.TabIndex = 12;
            this.createUser.Text = "Create New Admnistrator";
            this.createUser.UseCustomBackColor = true;
            this.createUser.UseCustomForeColor = true;
            this.createUser.UseSelectable = true;
            this.createUser.Click += new System.EventHandler(this.createUser_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.BackColor = System.Drawing.Color.Transparent;
            this.error.FontSize = MetroFramework.MetroLabelSize.Small;
            this.error.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(440, 209);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(141, 15);
            this.error.TabIndex = 17;
            this.error.Text = "Passwords Do not Match!";
            this.error.UseCustomBackColor = true;
            this.error.UseCustomForeColor = true;
            // 
            // success
            // 
            this.success.AutoSize = true;
            this.success.BackColor = System.Drawing.Color.Transparent;
            this.success.FontSize = MetroFramework.MetroLabelSize.Small;
            this.success.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.success.ForeColor = System.Drawing.Color.White;
            this.success.Location = new System.Drawing.Point(278, 321);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(87, 15);
            this.success.TabIndex = 18;
            this.success.Text = "Admin Created";
            this.success.UseCustomBackColor = true;
            this.success.UseCustomForeColor = true;
            // 
            // unameCheck
            // 
            this.unameCheck.AutoSize = true;
            this.unameCheck.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unameCheck.ForeColor = System.Drawing.Color.Red;
            this.unameCheck.Location = new System.Drawing.Point(437, 64);
            this.unameCheck.Name = "unameCheck";
            this.unameCheck.Size = new System.Drawing.Size(96, 15);
            this.unameCheck.TabIndex = 19;
            this.unameCheck.Text = "usernamecheck";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(531, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "    Go Back";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.dobYear);
            this.panel1.Controls.Add(this.dobMonth);
            this.panel1.Controls.Add(this.dobDay);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.aPIN);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.help);
            this.panel1.Controls.Add(this.unameCheck);
            this.panel1.Controls.Add(this.adminPIN);
            this.panel1.Controls.Add(this.uname);
            this.panel1.Controls.Add(this.upass);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.error);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.success);
            this.panel1.Controls.Add(this.ucpass);
            this.panel1.Controls.Add(this.uFName);
            this.panel1.Controls.Add(this.createUser);
            this.panel1.Controls.Add(this.confirmpassword);
            this.panel1.Controls.Add(this.firstName);
            this.panel1.Controls.Add(this.newPIN);
            this.panel1.Controls.Add(this.uPIN);
            this.panel1.Controls.Add(this.lastName);
            this.panel1.Controls.Add(this.uLName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 395);
            this.panel1.TabIndex = 0;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(14, 12);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(263, 25);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "Register a New Administrator";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // dobYear
            // 
            this.dobYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dobYear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobYear.ForeColor = System.Drawing.Color.White;
            this.dobYear.FormattingEnabled = true;
            this.dobYear.Location = new System.Drawing.Point(559, 238);
            this.dobYear.Name = "dobYear";
            this.dobYear.Size = new System.Drawing.Size(72, 25);
            this.dobYear.TabIndex = 11;
            // 
            // dobMonth
            // 
            this.dobMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dobMonth.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobMonth.ForeColor = System.Drawing.Color.White;
            this.dobMonth.FormattingEnabled = true;
            this.dobMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.dobMonth.Location = new System.Drawing.Point(492, 238);
            this.dobMonth.Name = "dobMonth";
            this.dobMonth.Size = new System.Drawing.Size(61, 25);
            this.dobMonth.TabIndex = 10;
            // 
            // dobDay
            // 
            this.dobDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dobDay.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobDay.ForeColor = System.Drawing.Color.White;
            this.dobDay.FormattingEnabled = true;
            this.dobDay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dobDay.Location = new System.Drawing.Point(427, 238);
            this.dobDay.Name = "dobDay";
            this.dobDay.Size = new System.Drawing.Size(59, 25);
            this.dobDay.TabIndex = 9;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(290, 242);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(141, 19);
            this.metroLabel1.TabIndex = 21;
            this.metroLabel1.Text = "Your Date of Birth : ";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // CreateAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(672, 419);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "CreateAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Administrator: ";
            this.Load += new System.EventHandler(this.Create_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private string pin;
        private Admin owner;
        private MetroFramework.Controls.MetroLabel username;
        private MetroFramework.Controls.MetroTextBox uname;
        private MetroFramework.Controls.MetroLabel password;
        private MetroFramework.Controls.MetroLabel confirmpassword;
        private MetroFramework.Controls.MetroLabel firstName;
        private MetroFramework.Controls.MetroLabel lastName;
        private MetroFramework.Controls.MetroLabel newPIN;
        private MetroFramework.Controls.MetroTextBox uFName;
        private MetroFramework.Controls.MetroTextBox uLName;
        private MetroFramework.Controls.MetroTextBox upass;
        private MetroFramework.Controls.MetroTextBox ucpass;
        private MetroFramework.Controls.MetroTextBox uPIN;
        private MetroFramework.Controls.MetroLabel adminPIN;
        private MetroFramework.Controls.MetroTextBox aPIN;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.ComboBox dobYear;
        private System.Windows.Forms.ComboBox dobMonth;
        private System.Windows.Forms.ComboBox dobDay;
        private MetroFramework.Controls.MetroButton createUser;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroLabel error;
        private MetroFramework.Controls.MetroLabel success;
        private System.Windows.Forms.Label unameCheck;
        private DataLoader data;
        private string prev;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}