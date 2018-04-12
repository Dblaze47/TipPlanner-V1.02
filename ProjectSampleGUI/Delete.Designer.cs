namespace ProjectSampleGUI
{
    partial class Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.newPIN = new MetroFramework.Controls.MetroLabel();
            this.success = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteRoute = new MetroFramework.Controls.MetroButton();
            this.transport = new System.Windows.Forms.ComboBox();
            this.comboCost = new System.Windows.Forms.ComboBox();
            this.comboTime = new System.Windows.Forms.ComboBox();
            this.comboDest = new System.Windows.Forms.ComboBox();
            this.comboSrc = new System.Windows.Forms.ComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.aPIN = new MetroFramework.Controls.MetroTextBox();
            this.username = new MetroFramework.Controls.MetroLabel();
            this.back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.Silver;
            this.metroLabel2.Location = new System.Drawing.Point(3, 11);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(231, 25);
            this.metroLabel2.TabIndex = 26;
            this.metroLabel2.Text = "Delete an Existing Route: ";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.metroLabel7);
            this.panel1.Controls.Add(this.newPIN);
            this.panel1.Controls.Add(this.success);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.deleteRoute);
            this.panel1.Controls.Add(this.transport);
            this.panel1.Controls.Add(this.comboCost);
            this.panel1.Controls.Add(this.comboTime);
            this.panel1.Controls.Add(this.comboDest);
            this.panel1.Controls.Add(this.comboSrc);
            this.panel1.Controls.Add(this.metroLabel6);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.aPIN);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 402);
            this.panel1.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(234, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(118, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 15);
            this.label4.TabIndex = 52;
            this.label4.Text = "**  All fields marked \'     \' must be provided with values. **";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.ForeColor = System.Drawing.Color.Silver;
            this.metroLabel7.Location = new System.Drawing.Point(424, 206);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(44, 15);
            this.metroLabel7.TabIndex = 51;
            this.metroLabel7.Text = "BDT/=";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // newPIN
            // 
            this.newPIN.AutoSize = true;
            this.newPIN.BackColor = System.Drawing.Color.Transparent;
            this.newPIN.FontSize = MetroFramework.MetroLabelSize.Small;
            this.newPIN.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.newPIN.ForeColor = System.Drawing.Color.Silver;
            this.newPIN.Location = new System.Drawing.Point(424, 167);
            this.newPIN.Name = "newPIN";
            this.newPIN.Size = new System.Drawing.Size(41, 15);
            this.newPIN.TabIndex = 50;
            this.newPIN.Text = "hours.";
            this.newPIN.UseCustomBackColor = true;
            this.newPIN.UseCustomForeColor = true;
            // 
            // success
            // 
            this.success.AutoSize = true;
            this.success.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.success.ForeColor = System.Drawing.Color.Black;
            this.success.Location = new System.Drawing.Point(310, 327);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(233, 16);
            this.success.TabIndex = 49;
            this.success.Text = "Route has been successfully removed.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(434, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(99, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(70, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "*";
            // 
            // deleteRoute
            // 
            this.deleteRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteRoute.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deleteRoute.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.deleteRoute.ForeColor = System.Drawing.Color.White;
            this.deleteRoute.Location = new System.Drawing.Point(0, 346);
            this.deleteRoute.Name = "deleteRoute";
            this.deleteRoute.Size = new System.Drawing.Size(546, 56);
            this.deleteRoute.TabIndex = 45;
            this.deleteRoute.Text = "Delete the Route";
            this.deleteRoute.UseCustomBackColor = true;
            this.deleteRoute.UseCustomForeColor = true;
            this.deleteRoute.UseSelectable = true;
            this.deleteRoute.Click += new System.EventHandler(this.deleteRoute_Click);
            // 
            // transport
            // 
            this.transport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.transport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.transport.FormattingEnabled = true;
            this.transport.Items.AddRange(new object[] {
            "----------",
            "BUS",
            "TRAIN",
            "PLANE",
            "LAUNCH"});
            this.transport.Location = new System.Drawing.Point(339, 240);
            this.transport.Name = "transport";
            this.transport.Size = new System.Drawing.Size(90, 25);
            this.transport.TabIndex = 44;
            // 
            // comboCost
            // 
            this.comboCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboCost.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboCost.FormattingEnabled = true;
            this.comboCost.Location = new System.Drawing.Point(153, 200);
            this.comboCost.Name = "comboCost";
            this.comboCost.Size = new System.Drawing.Size(265, 25);
            this.comboCost.TabIndex = 43;
            // 
            // comboTime
            // 
            this.comboTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboTime.FormattingEnabled = true;
            this.comboTime.Location = new System.Drawing.Point(153, 161);
            this.comboTime.Name = "comboTime";
            this.comboTime.Size = new System.Drawing.Size(265, 25);
            this.comboTime.TabIndex = 42;
            // 
            // comboDest
            // 
            this.comboDest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboDest.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboDest.FormattingEnabled = true;
            this.comboDest.Location = new System.Drawing.Point(153, 122);
            this.comboDest.Name = "comboDest";
            this.comboDest.Size = new System.Drawing.Size(265, 25);
            this.comboDest.TabIndex = 41;
            // 
            // comboSrc
            // 
            this.comboSrc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboSrc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSrc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboSrc.FormattingEnabled = true;
            this.comboSrc.Location = new System.Drawing.Point(153, 83);
            this.comboSrc.Name = "comboSrc";
            this.comboSrc.Size = new System.Drawing.Size(265, 25);
            this.comboSrc.TabIndex = 40;
            this.comboSrc.SelectionChangeCommitted += new System.EventHandler(this.comboSrc_SelectionChangeCommitted);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.ForeColor = System.Drawing.Color.Silver;
            this.metroLabel6.Location = new System.Drawing.Point(19, 128);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(108, 19);
            this.metroLabel6.TabIndex = 39;
            this.metroLabel6.Text = "Destination    : ";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.Color.Silver;
            this.metroLabel5.Location = new System.Drawing.Point(19, 167);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(136, 19);
            this.metroLabel5.TabIndex = 38;
            this.metroLabel5.Text = "Calculated  Time  : ";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.Silver;
            this.metroLabel4.Location = new System.Drawing.Point(19, 206);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(136, 19);
            this.metroLabel4.TabIndex = 37;
            this.metroLabel4.Text = "Calculated Cost    : ";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.Black;
            this.metroLabel3.Location = new System.Drawing.Point(216, 243);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(116, 19);
            this.metroLabel3.TabIndex = 36;
            this.metroLabel3.Text = "TRANSPORT    : ";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(216, 271);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(117, 19);
            this.metroLabel1.TabIndex = 35;
            this.metroLabel1.Text = "ADMIN PIN      : ";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // aPIN
            // 
            this.aPIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            this.aPIN.CustomButton.Image = null;
            this.aPIN.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.aPIN.CustomButton.Name = "";
            this.aPIN.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.aPIN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.aPIN.CustomButton.TabIndex = 1;
            this.aPIN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.aPIN.CustomButton.UseSelectable = true;
            this.aPIN.CustomButton.Visible = false;
            this.aPIN.Lines = new string[0];
            this.aPIN.Location = new System.Drawing.Point(339, 271);
            this.aPIN.MaxLength = 32767;
            this.aPIN.Name = "aPIN";
            this.aPIN.PasswordChar = '\0';
            this.aPIN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aPIN.SelectedText = "";
            this.aPIN.SelectionLength = 0;
            this.aPIN.SelectionStart = 0;
            this.aPIN.ShortcutsEnabled = true;
            this.aPIN.Size = new System.Drawing.Size(90, 23);
            this.aPIN.TabIndex = 34;
            this.aPIN.UseCustomBackColor = true;
            this.aPIN.UseCustomForeColor = true;
            this.aPIN.UseSelectable = true;
            this.aPIN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.aPIN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.username.ForeColor = System.Drawing.Color.Silver;
            this.username.Location = new System.Drawing.Point(19, 89);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(83, 19);
            this.username.TabIndex = 28;
            this.username.Text = "Source     : ";
            this.username.UseCustomBackColor = true;
            this.username.UseCustomForeColor = true;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back.FlatAppearance.BorderSize = 2;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.Maroon;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back.Location = new System.Drawing.Point(426, 3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(117, 44);
            this.back.TabIndex = 27;
            this.back.Text = "    Go Back";
            this.back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(570, 426);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back;
        private MetroFramework.Controls.MetroLabel username;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox aPIN;
        private System.Windows.Forms.ComboBox comboSrc;
        private System.Windows.Forms.ComboBox transport;
        private System.Windows.Forms.ComboBox comboCost;
        private System.Windows.Forms.ComboBox comboTime;
        private System.Windows.Forms.ComboBox comboDest;
        private MetroFramework.Controls.MetroButton deleteRoute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label success;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel newPIN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private string pin;
        private string[] nodes;
        private Admin owner;
    }
}