using System;

namespace ProjectSampleGUI
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.mySlidingPanel = new System.Windows.Forms.Panel();
            this.slideButton = new System.Windows.Forms.Button();
            this.updateAll = new System.Windows.Forms.Button();
            this.delRoute = new System.Windows.Forms.Button();
            this.addAdmin = new System.Windows.Forms.Button();
            this.addNewRoute = new System.Windows.Forms.Button();
            this.greeting = new MetroFramework.Controls.MetroLabel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.dateOfBirth = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.regDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.proPic = new MetroFramework.Controls.MetroPanel();
            this.changes = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mySlidingPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mySlidingPanel
            // 
            this.mySlidingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.mySlidingPanel.Controls.Add(this.slideButton);
            this.mySlidingPanel.Controls.Add(this.updateAll);
            this.mySlidingPanel.Controls.Add(this.delRoute);
            this.mySlidingPanel.Controls.Add(this.addAdmin);
            this.mySlidingPanel.Controls.Add(this.addNewRoute);
            this.mySlidingPanel.Location = new System.Drawing.Point(2, 85);
            this.mySlidingPanel.Name = "mySlidingPanel";
            this.mySlidingPanel.Size = new System.Drawing.Size(232, 324);
            this.mySlidingPanel.TabIndex = 16;
            // 
            // slideButton
            // 
            this.slideButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.slideButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slideButton.BackgroundImage")));
            this.slideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.slideButton.FlatAppearance.BorderSize = 0;
            this.slideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slideButton.Location = new System.Drawing.Point(0, 0);
            this.slideButton.Name = "slideButton";
            this.slideButton.Size = new System.Drawing.Size(41, 45);
            this.slideButton.TabIndex = 16;
            this.slideButton.UseVisualStyleBackColor = false;
            this.slideButton.Click += new System.EventHandler(this.slideButton_Click);
            // 
            // updateAll
            // 
            this.updateAll.BackColor = System.Drawing.Color.Transparent;
            this.updateAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.updateAll.FlatAppearance.BorderSize = 0;
            this.updateAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateAll.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.updateAll.Image = ((System.Drawing.Image)(resources.GetObject("updateAll.Image")));
            this.updateAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateAll.Location = new System.Drawing.Point(0, 250);
            this.updateAll.Name = "updateAll";
            this.updateAll.Size = new System.Drawing.Size(229, 46);
            this.updateAll.TabIndex = 13;
            this.updateAll.Text = "     Update Database For Changes";
            this.updateAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateAll.UseVisualStyleBackColor = false;
            this.updateAll.Click += new System.EventHandler(this.updateAll_Click);
            this.updateAll.MouseLeave += new System.EventHandler(this.updateAll_MouseLeave);
            this.updateAll.MouseHover += new System.EventHandler(this.updateAll_MouseHover);
            // 
            // delRoute
            // 
            this.delRoute.BackColor = System.Drawing.Color.Transparent;
            this.delRoute.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.delRoute.FlatAppearance.BorderSize = 0;
            this.delRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delRoute.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delRoute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.delRoute.Image = ((System.Drawing.Image)(resources.GetObject("delRoute.Image")));
            this.delRoute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delRoute.Location = new System.Drawing.Point(0, 193);
            this.delRoute.Name = "delRoute";
            this.delRoute.Size = new System.Drawing.Size(229, 46);
            this.delRoute.TabIndex = 15;
            this.delRoute.Text = "     Delete an Exisiting Route";
            this.delRoute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delRoute.UseVisualStyleBackColor = false;
            this.delRoute.Click += new System.EventHandler(this.delRoute_Click);
            this.delRoute.MouseLeave += new System.EventHandler(this.delRoute_MouseLeave);
            this.delRoute.MouseHover += new System.EventHandler(this.delRoute_MouseHover);
            // 
            // addAdmin
            // 
            this.addAdmin.BackColor = System.Drawing.Color.Transparent;
            this.addAdmin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addAdmin.FlatAppearance.BorderSize = 0;
            this.addAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addAdmin.Image = ((System.Drawing.Image)(resources.GetObject("addAdmin.Image")));
            this.addAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addAdmin.Location = new System.Drawing.Point(-1, 79);
            this.addAdmin.Name = "addAdmin";
            this.addAdmin.Size = new System.Drawing.Size(230, 46);
            this.addAdmin.TabIndex = 11;
            this.addAdmin.Text = "     Add New Admin";
            this.addAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addAdmin.UseVisualStyleBackColor = false;
            this.addAdmin.Click += new System.EventHandler(this.addAdmin_Click);
            this.addAdmin.MouseLeave += new System.EventHandler(this.addAdmin_MouseLeave);
            this.addAdmin.MouseHover += new System.EventHandler(this.addAdmin_MouseHover);
            // 
            // addNewRoute
            // 
            this.addNewRoute.BackColor = System.Drawing.Color.Transparent;
            this.addNewRoute.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addNewRoute.FlatAppearance.BorderSize = 0;
            this.addNewRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewRoute.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewRoute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addNewRoute.Image = ((System.Drawing.Image)(resources.GetObject("addNewRoute.Image")));
            this.addNewRoute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewRoute.Location = new System.Drawing.Point(0, 136);
            this.addNewRoute.Name = "addNewRoute";
            this.addNewRoute.Size = new System.Drawing.Size(229, 46);
            this.addNewRoute.TabIndex = 14;
            this.addNewRoute.Text = "     Insert A new Route";
            this.addNewRoute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addNewRoute.UseVisualStyleBackColor = false;
            this.addNewRoute.Click += new System.EventHandler(this.addNewRoute_Click);
            this.addNewRoute.MouseLeave += new System.EventHandler(this.addNewRoute_MouseLeave);
            this.addNewRoute.MouseHover += new System.EventHandler(this.addNewRoute_MouseHover);
            // 
            // greeting
            // 
            this.greeting.AutoSize = true;
            this.greeting.BackColor = System.Drawing.Color.Transparent;
            this.greeting.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.greeting.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.greeting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.greeting.Location = new System.Drawing.Point(5, 47);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(268, 25);
            this.greeting.TabIndex = 0;
            this.greeting.Text = "Good ****, welcome back ####.";
            this.greeting.Theme = MetroFramework.MetroThemeStyle.Light;
            this.greeting.UseCustomBackColor = true;
            this.greeting.UseCustomForeColor = true;
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.infoPanel.Controls.Add(this.dateOfBirth);
            this.infoPanel.Controls.Add(this.label5);
            this.infoPanel.Controls.Add(this.regDate);
            this.infoPanel.Controls.Add(this.label4);
            this.infoPanel.Controls.Add(this.fullName);
            this.infoPanel.Controls.Add(this.label2);
            this.infoPanel.Location = new System.Drawing.Point(319, 258);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(166, 190);
            this.infoPanel.TabIndex = 12;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.AutoSize = true;
            this.dateOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.dateOfBirth.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateOfBirth.Location = new System.Drawing.Point(3, 161);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(78, 18);
            this.dateOfBirth.TabIndex = 5;
            this.dateOfBirth.Text = "01/01/1900";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(3, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of Birth :";
            // 
            // regDate
            // 
            this.regDate.AutoSize = true;
            this.regDate.BackColor = System.Drawing.Color.Transparent;
            this.regDate.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.regDate.Location = new System.Drawing.Point(3, 105);
            this.regDate.Name = "regDate";
            this.regDate.Size = new System.Drawing.Size(86, 18);
            this.regDate.TabIndex = 3;
            this.regDate.Text = "DD/MM/YYYY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(3, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Administrator Since:";
            // 
            // fullName
            // 
            this.fullName.AutoSize = true;
            this.fullName.BackColor = System.Drawing.Color.Transparent;
            this.fullName.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fullName.Location = new System.Drawing.Point(3, 49);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(110, 18);
            this.fullName.TabIndex = 1;
            this.fullName.Text = "$$$$$$$ $$$$$$$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Full Name: ";
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logout.FlatAppearance.BorderSize = 2;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.Location = new System.Drawing.Point(379, 47);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(109, 44);
            this.logout.TabIndex = 10;
            this.logout.Text = "  LOGOUT";
            this.logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            this.logout.MouseLeave += new System.EventHandler(this.logout_MouseLeave);
            this.logout.MouseHover += new System.EventHandler(this.logout_MouseHover);
            // 
            // proPic
            // 
            this.proPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.proPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.proPic.HorizontalScrollbarBarColor = true;
            this.proPic.HorizontalScrollbarHighlightOnWheel = false;
            this.proPic.HorizontalScrollbarSize = 10;
            this.proPic.Location = new System.Drawing.Point(356, 97);
            this.proPic.Name = "proPic";
            this.proPic.Size = new System.Drawing.Size(129, 155);
            this.proPic.TabIndex = 8;
            this.proPic.UseCustomBackColor = true;
            this.proPic.VerticalScrollbarBarColor = true;
            this.proPic.VerticalScrollbarHighlightOnWheel = false;
            this.proPic.VerticalScrollbarSize = 10;
            // 
            // changes
            // 
            this.changes.AutoSize = true;
            this.changes.BackColor = System.Drawing.Color.Transparent;
            this.changes.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.changes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.changes.Location = new System.Drawing.Point(204, 460);
            this.changes.Name = "changes";
            this.changes.Size = new System.Drawing.Size(86, 19);
            this.changes.TabIndex = 9;
            this.changes.Text = "metroLabel1";
            this.changes.UseCustomBackColor = true;
            this.changes.UseCustomForeColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.minimize);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 40);
            this.panel2.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 40);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(47, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Admin Home Page";
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize.BackgroundImage")));
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Location = new System.Drawing.Point(440, 2);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(21, 25);
            this.minimize.TabIndex = 10;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(467, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(497, 488);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.greeting);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mySlidingPanel);
            this.Controls.Add(this.proPic);
            this.Controls.Add(this.changes);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "        Admin Homepage";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.mySlidingPanel.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel greeting;
        private string pin;
        private string userfname;
        private string userlname;
        private LoginPanel g1;
        private string d1;
        private General main;
        private MetroFramework.Controls.MetroPanel proPic;
        private MetroFramework.Controls.MetroLabel changes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addAdmin;
        private System.Windows.Forms.Button updateAll;
        private System.Windows.Forms.Label regDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label fullName;
        private System.Windows.Forms.Button delRoute;
        private System.Windows.Forms.Button addNewRoute;
        private System.Windows.Forms.Label dateOfBirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel mySlidingPanel;
        private System.Windows.Forms.Button slideButton;
        private System.Windows.Forms.Timer timer1;
    }
}