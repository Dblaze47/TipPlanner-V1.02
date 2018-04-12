namespace ProjectSampleGUI
{
    partial class DisplaySearchResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplaySearchResults));
            this.discretion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.result1 = new MetroFramework.Controls.MetroLabel();
            this.adminEmail = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // discretion
            // 
            this.discretion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.discretion.BackColor = System.Drawing.Color.Transparent;
            this.discretion.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discretion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(19)))), ((int)(((byte)(8)))));
            this.discretion.Location = new System.Drawing.Point(12, 388);
            this.discretion.Name = "discretion";
            this.discretion.Size = new System.Drawing.Size(464, 15);
            this.discretion.TabIndex = 0;
            this.discretion.Text = "** PROJECT UNDER DEVELOPMENT. FOR DEMONSTRATION PURPOSES ONLY! ** ";
            this.discretion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(527, 285);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "PLAN A NEW TRIP !";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result1
            // 
            this.result1.AutoSize = true;
            this.result1.BackColor = System.Drawing.Color.Transparent;
            this.result1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.result1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(14)))), ((int)(((byte)(0)))));
            this.result1.Location = new System.Drawing.Point(12, 20);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(188, 19);
            this.result1.TabIndex = 2;
            this.result1.Text = "Results are displayed here.";
            this.result1.UseCustomBackColor = true;
            this.result1.UseCustomForeColor = true;
            // 
            // adminEmail
            // 
            this.adminEmail.AutoSize = true;
            this.adminEmail.BackColor = System.Drawing.Color.Transparent;
            this.adminEmail.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminEmail.Location = new System.Drawing.Point(548, 79);
            this.adminEmail.Name = "adminEmail";
            this.adminEmail.Size = new System.Drawing.Size(189, 15);
            this.adminEmail.TabIndex = 3;
            this.adminEmail.TabStop = true;
            this.adminEmail.Text = "manosh.office015@gmail.com";
            this.adminEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // DisplaySearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(758, 473);
            this.Controls.Add(this.adminEmail);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.discretion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisplaySearchResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Our Recommended Route For You";
            this.Load += new System.EventHandler(this.DisplaySearchResults_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label discretion;
        private System.Windows.Forms.Timer timer1;
        private string message;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroLabel result1;
        private General owner;
        public bool error;
        private System.Windows.Forms.LinkLabel adminEmail;
    }
}