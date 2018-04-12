using System.Windows.Forms;

namespace ProjectSampleGUI
{
    partial class LoginPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPanel));
            this.topPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.demoWarn = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.adminUser = new MetroFramework.Controls.MetroTextBox();
            this.adminPass = new MetroFramework.Controls.MetroTextBox();
            this.login_error = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.loginMain = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Transparent;
            this.topPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topPanel.BackgroundImage")));
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.button1);
            this.topPanel.Controls.Add(this.minimize);
            this.topPanel.Controls.Add(this.close);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(324, 35);
            this.topPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(60, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Admin Login Panel";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 30);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize.BackgroundImage")));
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Location = new System.Drawing.Point(259, 3);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(25, 25);
            this.minimize.TabIndex = 2;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.Transparent;
            this.close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close.Location = new System.Drawing.Point(290, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(29, 27);
            this.close.TabIndex = 0;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.Transparent;
            this.bottomPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bottomPanel.BackgroundImage")));
            this.bottomPanel.Controls.Add(this.demoWarn);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 468);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(324, 36);
            this.bottomPanel.TabIndex = 1;
            // 
            // demoWarn
            // 
            this.demoWarn.AutoSize = true;
            this.demoWarn.BackColor = System.Drawing.Color.Transparent;
            this.demoWarn.Font = new System.Drawing.Font("Consolas", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demoWarn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.demoWarn.Location = new System.Drawing.Point(12, 9);
            this.demoWarn.Name = "demoWarn";
            this.demoWarn.Size = new System.Drawing.Size(157, 13);
            this.demoWarn.TabIndex = 0;
            this.demoWarn.Text = "** Demonstration Only! **";
            this.demoWarn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // adminUser
            // 
            // 
            // 
            // 
            this.adminUser.CustomButton.Image = null;
            this.adminUser.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.adminUser.CustomButton.Name = "";
            this.adminUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.adminUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.adminUser.CustomButton.TabIndex = 1;
            this.adminUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.adminUser.CustomButton.UseSelectable = true;
            this.adminUser.CustomButton.Visible = false;
            this.adminUser.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.adminUser.ForeColor = System.Drawing.Color.White;
            this.adminUser.Lines = new string[0];
            this.adminUser.Location = new System.Drawing.Point(52, 46);
            this.adminUser.MaxLength = 32767;
            this.adminUser.Name = "adminUser";
            this.adminUser.PasswordChar = '\0';
            this.adminUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.adminUser.SelectedText = "";
            this.adminUser.SelectionLength = 0;
            this.adminUser.SelectionStart = 0;
            this.adminUser.ShortcutsEnabled = true;
            this.adminUser.Size = new System.Drawing.Size(235, 23);
            this.adminUser.TabIndex = 4;
            this.adminUser.UseCustomBackColor = true;
            this.adminUser.UseCustomForeColor = true;
            this.adminUser.UseSelectable = true;
            this.adminUser.UseStyleColors = true;
            this.adminUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.adminUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // adminPass
            // 
            // 
            // 
            // 
            this.adminPass.CustomButton.Image = null;
            this.adminPass.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.adminPass.CustomButton.Name = "";
            this.adminPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.adminPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.adminPass.CustomButton.TabIndex = 1;
            this.adminPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.adminPass.CustomButton.UseSelectable = true;
            this.adminPass.CustomButton.Visible = false;
            this.adminPass.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.adminPass.ForeColor = System.Drawing.Color.Silver;
            this.adminPass.Lines = new string[0];
            this.adminPass.Location = new System.Drawing.Point(53, 84);
            this.adminPass.MaxLength = 32767;
            this.adminPass.Name = "adminPass";
            this.adminPass.PasswordChar = '*';
            this.adminPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.adminPass.SelectedText = "";
            this.adminPass.SelectionLength = 0;
            this.adminPass.SelectionStart = 0;
            this.adminPass.ShortcutsEnabled = true;
            this.adminPass.Size = new System.Drawing.Size(234, 23);
            this.adminPass.TabIndex = 5;
            this.adminPass.Theme = MetroFramework.MetroThemeStyle.Light;
            this.adminPass.UseCustomBackColor = true;
            this.adminPass.UseCustomForeColor = true;
            this.adminPass.UseSelectable = true;
            this.adminPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.adminPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // login_error
            // 
            this.login_error.AutoSize = true;
            this.login_error.BackColor = System.Drawing.Color.Transparent;
            this.login_error.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_error.ForeColor = System.Drawing.Color.Maroon;
            this.login_error.Location = new System.Drawing.Point(24, 120);
            this.login_error.Name = "login_error";
            this.login_error.Size = new System.Drawing.Size(211, 13);
            this.login_error.TabIndex = 11;
            this.login_error.Text = "Username or Password is incorrect.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Please Login to Continue to the Database";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(13, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(13, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 32);
            this.button3.TabIndex = 17;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.loginMain);
            this.panel1.Controls.Add(this.adminPass);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.login_error);
            this.panel1.Controls.Add(this.adminUser);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 276);
            this.panel1.TabIndex = 18;
            // 
            // back
            // 
            this.back.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.back.FlatAppearance.BorderSize = 2;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back.Location = new System.Drawing.Point(13, 205);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(132, 47);
            this.back.TabIndex = 19;
            this.back.Text = "    GO BACK";
            this.back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // loginMain
            // 
            this.loginMain.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.loginMain.FlatAppearance.BorderSize = 2;
            this.loginMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginMain.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.loginMain.Image = ((System.Drawing.Image)(resources.GetObject("loginMain.Image")));
            this.loginMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginMain.Location = new System.Drawing.Point(160, 205);
            this.loginMain.Name = "loginMain";
            this.loginMain.Size = new System.Drawing.Size(127, 47);
            this.loginMain.TabIndex = 18;
            this.loginMain.Text = "      LOGIN";
            this.loginMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loginMain.UseVisualStyleBackColor = true;
            this.loginMain.Click += new System.EventHandler(this.loginMain_Click);
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(324, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPanel";
            this.Load += new System.EventHandler(this.LoginPanel_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label demoWarn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button minimize;
        private MetroFramework.Controls.MetroTextBox adminUser;
        private MetroFramework.Controls.MetroTextBox adminPass;
        private Button button1;
        private Label login_error;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Button loginMain;
        private Button back;
    }
}