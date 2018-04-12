using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjectSampleGUI
{
    partial class General
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(General));
            this.myWorker = new System.ComponentModel.BackgroundWorker();
            this.panelBlur = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.adminLogin = new System.Windows.Forms.Button();
            this.tripCancel = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mCDest = new MetroFramework.Controls.MetroComboBox();
            this.myProgBar = new MetroFramework.Controls.MetroProgressBar();
            this.mComboSrc = new MetroFramework.Controls.MetroComboBox();
            this.shortestPath = new MetroFramework.Controls.MetroCheckBox();
            this.shProg = new MetroFramework.Controls.MetroLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tLaunch = new MetroFramework.Controls.MetroRadioButton();
            this.tBus = new MetroFramework.Controls.MetroRadioButton();
            this.loadButton = new MetroFramework.Controls.MetroButton();
            this.tTrain = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.mCCost = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.mCTime = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.tPlane = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.panelBlur.SuspendLayout();
            this.SuspendLayout();
            // 
            // myWorker
            // 
            this.myWorker.WorkerReportsProgress = true;
            this.myWorker.WorkerSupportsCancellation = true;
            this.myWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.myWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.myWorker_ProgressChanged);
            this.myWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.myWorker_RunWorkerCompleted);
            // 
            // panelBlur
            // 
            this.panelBlur.BackColor = System.Drawing.Color.Transparent;
            this.panelBlur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBlur.BackgroundImage")));
            this.panelBlur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelBlur.Controls.Add(this.metroLabel1);
            this.panelBlur.Controls.Add(this.adminLogin);
            this.panelBlur.Controls.Add(this.tripCancel);
            this.panelBlur.Controls.Add(this.label1);
            this.panelBlur.Controls.Add(this.label4);
            this.panelBlur.Controls.Add(this.mCDest);
            this.panelBlur.Controls.Add(this.myProgBar);
            this.panelBlur.Controls.Add(this.mComboSrc);
            this.panelBlur.Controls.Add(this.shortestPath);
            this.panelBlur.Controls.Add(this.shProg);
            this.panelBlur.Controls.Add(this.label8);
            this.panelBlur.Controls.Add(this.label10);
            this.panelBlur.Controls.Add(this.label9);
            this.panelBlur.Controls.Add(this.tLaunch);
            this.panelBlur.Controls.Add(this.tBus);
            this.panelBlur.Controls.Add(this.loadButton);
            this.panelBlur.Controls.Add(this.tTrain);
            this.panelBlur.Controls.Add(this.metroLabel11);
            this.panelBlur.Controls.Add(this.metroLabel6);
            this.panelBlur.Controls.Add(this.mCCost);
            this.panelBlur.Controls.Add(this.metroLabel7);
            this.panelBlur.Controls.Add(this.metroLabel8);
            this.panelBlur.Controls.Add(this.mCTime);
            this.panelBlur.Controls.Add(this.metroLabel9);
            this.panelBlur.Controls.Add(this.tPlane);
            this.panelBlur.Controls.Add(this.metroLabel10);
            this.panelBlur.Controls.Add(this.metroLabel12);
            this.panelBlur.Controls.Add(this.metroLabel13);
            this.panelBlur.HorizontalScrollbarBarColor = true;
            this.panelBlur.HorizontalScrollbarHighlightOnWheel = false;
            this.panelBlur.HorizontalScrollbarSize = 10;
            this.panelBlur.Location = new System.Drawing.Point(-3, 0);
            this.panelBlur.Name = "panelBlur";
            this.panelBlur.Size = new System.Drawing.Size(1217, 697);
            this.panelBlur.TabIndex = 24;
            this.panelBlur.UseCustomBackColor = true;
            this.panelBlur.VerticalScrollbarBarColor = true;
            this.panelBlur.VerticalScrollbarHighlightOnWheel = false;
            this.panelBlur.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.metroLabel1.Location = new System.Drawing.Point(979, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(235, 15);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "For Administrative Purpose, please Login:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // adminLogin
            // 
            this.adminLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminLogin.BackgroundImage")));
            this.adminLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.adminLogin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLogin.Location = new System.Drawing.Point(1026, 27);
            this.adminLogin.Name = "adminLogin";
            this.adminLogin.Size = new System.Drawing.Size(144, 47);
            this.adminLogin.TabIndex = 13;
            this.adminLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.adminLogin.UseVisualStyleBackColor = true;
            this.adminLogin.Click += new System.EventHandler(this.adminLogin_Click);
            // 
            // tripCancel
            // 
            this.tripCancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.tripCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tripCancel.Location = new System.Drawing.Point(776, 320);
            this.tripCancel.Name = "tripCancel";
            this.tripCancel.Size = new System.Drawing.Size(198, 38);
            this.tripCancel.TabIndex = 27;
            this.tripCancel.Text = "Oops.. I need to Rethink.";
            this.tripCancel.UseSelectable = true;
            this.tripCancel.Click += new System.EventHandler(this.tripCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(637, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(510, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "(Available only for Bus Routes!)";
            // 
            // mCDest
            // 
            this.mCDest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mCDest.FormattingEnabled = true;
            this.mCDest.ItemHeight = 23;
            this.mCDest.Location = new System.Drawing.Point(451, 168);
            this.mCDest.Name = "mCDest";
            this.mCDest.Size = new System.Drawing.Size(313, 29);
            this.mCDest.TabIndex = 25;
            this.mCDest.UseSelectable = true;
            this.mCDest.SelectionChangeCommitted += new System.EventHandler(this.mCDest_SelectionChangeCommitted_2);
            // 
            // myProgBar
            // 
            this.myProgBar.Location = new System.Drawing.Point(334, 501);
            this.myProgBar.Name = "myProgBar";
            this.myProgBar.Size = new System.Drawing.Size(649, 18);
            this.myProgBar.Step = 1;
            this.myProgBar.TabIndex = 4;
            this.myProgBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myProgBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.myProgBar.UseCustomBackColor = true;
            // 
            // mComboSrc
            // 
            this.mComboSrc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mComboSrc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mComboSrc.FormattingEnabled = true;
            this.mComboSrc.ItemHeight = 23;
            this.mComboSrc.Location = new System.Drawing.Point(451, 134);
            this.mComboSrc.Name = "mComboSrc";
            this.mComboSrc.Size = new System.Drawing.Size(313, 29);
            this.mComboSrc.TabIndex = 24;
            this.mComboSrc.UseSelectable = true;
            this.mComboSrc.SelectionChangeCommitted += new System.EventHandler(this.mComboSrc_SelectionChangeCommitted_1);
            // 
            // shortestPath
            // 
            this.shortestPath.AutoSize = true;
            this.shortestPath.BackColor = System.Drawing.Color.Transparent;
            this.shortestPath.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.shortestPath.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.shortestPath.ForeColor = System.Drawing.Color.MidnightBlue;
            this.shortestPath.Location = new System.Drawing.Point(517, 271);
            this.shortestPath.Name = "shortestPath";
            this.shortestPath.Size = new System.Drawing.Size(175, 19);
            this.shortestPath.TabIndex = 21;
            this.shortestPath.Text = "Shortest Route Please!";
            this.shortestPath.UseCustomBackColor = true;
            this.shortestPath.UseCustomForeColor = true;
            this.shortestPath.UseSelectable = true;
            // 
            // shProg
            // 
            this.shProg.AutoSize = true;
            this.shProg.BackColor = System.Drawing.Color.Transparent;
            this.shProg.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.shProg.ForeColor = System.Drawing.Color.MidnightBlue;
            this.shProg.Location = new System.Drawing.Point(571, 455);
            this.shProg.Name = "shProg";
            this.shProg.Size = new System.Drawing.Size(121, 19);
            this.shProg.TabIndex = 5;
            this.shProg.Text = "will show progress";
            this.shProg.UseCustomBackColor = true;
            this.shProg.UseCustomForeColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(390, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "*";
            // 
            // label10
            // 
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(448, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(428, 14);
            this.label10.TabIndex = 23;
            this.label10.Text = "(Careful! Preferences might not match with Calculated Trip.)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(418, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "*";
            // 
            // tLaunch
            // 
            this.tLaunch.AutoSize = true;
            this.tLaunch.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.tLaunch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.tLaunch.Location = new System.Drawing.Point(776, 201);
            this.tLaunch.Name = "tLaunch";
            this.tLaunch.Size = new System.Drawing.Size(121, 15);
            this.tLaunch.TabIndex = 19;
            this.tLaunch.Text = "Journey by River?";
            this.tLaunch.UseCustomBackColor = true;
            this.tLaunch.UseCustomForeColor = true;
            this.tLaunch.UseSelectable = true;
            // 
            // tBus
            // 
            this.tBus.AutoSize = true;
            this.tBus.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.tBus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.tBus.Location = new System.Drawing.Point(776, 163);
            this.tBus.Name = "tBus";
            this.tBus.Size = new System.Drawing.Size(167, 15);
            this.tBus.TabIndex = 18;
            this.tBus.Text = "I want a Road Trip via bus!";
            this.tBus.UseCustomBackColor = true;
            this.tBus.UseCustomForeColor = true;
            this.tBus.UseSelectable = true;
            // 
            // loadButton
            // 
            this.loadButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.loadButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.loadButton.Location = new System.Drawing.Point(764, 265);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(219, 49);
            this.loadButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.loadButton.TabIndex = 6;
            this.loadButton.Text = "Let\'s GO!";
            this.loadButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loadButton.UseSelectable = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // tTrain
            // 
            this.tTrain.AutoSize = true;
            this.tTrain.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.tTrain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.tTrain.Location = new System.Drawing.Point(776, 144);
            this.tTrain.Name = "tTrain";
            this.tTrain.Size = new System.Drawing.Size(178, 15);
            this.tTrain.TabIndex = 17;
            this.tTrain.Text = "I want a scenic Train Route !";
            this.tTrain.UseCustomBackColor = true;
            this.tTrain.UseCustomForeColor = true;
            this.tTrain.UseSelectable = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.metroLabel11.Location = new System.Drawing.Point(776, 121);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(162, 19);
            this.metroLabel11.TabIndex = 16;
            this.metroLabel11.Text = "Preferences (optional):";
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.metroLabel6.Location = new System.Drawing.Point(334, 233);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(186, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Travelling Time (optional):";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // mCCost
            // 
            this.mCCost.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mCCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mCCost.FormattingEnabled = true;
            this.mCCost.ItemHeight = 23;
            this.mCCost.Location = new System.Drawing.Point(517, 202);
            this.mCCost.Name = "mCCost";
            this.mCCost.Size = new System.Drawing.Size(151, 29);
            this.mCCost.TabIndex = 10;
            this.mCCost.UseSelectable = true;
            this.mCCost.SelectionChangeCommitted += new System.EventHandler(this.mCCost_SelectionChangeCommitted);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.metroLabel7.Location = new System.Drawing.Point(671, 250);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(38, 15);
            this.metroLabel7.TabIndex = 11;
            this.metroLabel7.Text = "hours";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.metroLabel8.Location = new System.Drawing.Point(671, 214);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(47, 15);
            this.metroLabel8.TabIndex = 9;
            this.metroLabel8.Text = "BDT /=";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // mCTime
            // 
            this.mCTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mCTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mCTime.FormattingEnabled = true;
            this.mCTime.ItemHeight = 23;
            this.mCTime.Location = new System.Drawing.Point(517, 236);
            this.mCTime.Name = "mCTime";
            this.mCTime.Size = new System.Drawing.Size(151, 29);
            this.mCTime.TabIndex = 8;
            this.mCTime.UseSelectable = true;
            this.mCTime.SelectionChangeCommitted += new System.EventHandler(this.mCTime_SelectionChangeCommitted);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.metroLabel9.Location = new System.Drawing.Point(337, 201);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(165, 19);
            this.metroLabel9.TabIndex = 4;
            this.metroLabel9.Text = "Trip Budget (optional): ";
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // tPlane
            // 
            this.tPlane.AutoSize = true;
            this.tPlane.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.tPlane.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.tPlane.Location = new System.Drawing.Point(776, 182);
            this.tPlane.Name = "tPlane";
            this.tPlane.Size = new System.Drawing.Size(128, 15);
            this.tPlane.TabIndex = 20;
            this.tPlane.Text = "I want to fly there!";
            this.tPlane.UseCustomBackColor = true;
            this.tPlane.UseCustomForeColor = true;
            this.tPlane.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.metroLabel10.Location = new System.Drawing.Point(337, 172);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(112, 19);
            this.metroLabel10.TabIndex = 3;
            this.metroLabel10.Text = "Destination     : ";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel10.UseCustomBackColor = true;
            this.metroLabel10.UseCustomForeColor = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.metroLabel12.Location = new System.Drawing.Point(337, 144);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(111, 19);
            this.metroLabel12.TabIndex = 2;
            this.metroLabel12.Text = "Source            : ";
            this.metroLabel12.UseCustomBackColor = true;
            this.metroLabel12.UseCustomForeColor = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.metroLabel13.Location = new System.Drawing.Point(435, 306);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(295, 15);
            this.metroLabel13.TabIndex = 14;
            this.metroLabel13.Text = "# Providing Data for all fields marked       is mandatory.";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel13.UseCustomBackColor = true;
            this.metroLabel13.UseCustomForeColor = true;
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1214, 689);
            this.Controls.Add(this.panelBlur);
            this.Name = "General";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRIP PLANNER V1.02";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBlur.ResumeLayout(false);
            this.panelBlur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroProgressBar myProgBar;
        private MetroFramework.Controls.MetroLabel shProg;
        private System.ComponentModel.BackgroundWorker myWorker;
        private MetroFramework.Controls.MetroButton loadButton;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroCheckBox shortestPath;
        private System.Windows.Forms.Button adminLogin;
        private DataLoader myconn;
        private string[] nodes;
        private string[] tripTimes;
        private string[] tripCosts;
        private string dest;
        private string src;
        private int time;
        private int cost;
        private string sp;
        private string[] calc;
        private string result1;
        private PictureBox myBlur;
        private MetroFramework.Controls.MetroPanel panelBlur;
        private MetroFramework.Controls.MetroComboBox mCDest;
        private MetroFramework.Controls.MetroComboBox mComboSrc;
        private Label label8;
        private Label label9;
        private MetroFramework.Controls.MetroRadioButton tLaunch;
        private MetroFramework.Controls.MetroRadioButton tBus;
        private MetroFramework.Controls.MetroRadioButton tTrain;
        private Label label10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox mCCost;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox mCTime;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroRadioButton tPlane;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private Label label1;
        private MetroFramework.Controls.MetroButton tripCancel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

