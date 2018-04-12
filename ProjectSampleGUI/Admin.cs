using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSampleGUI
{
    public partial class Admin : Form
    {
        private int wd;
        private bool hidden;
        //Creates and initializes all that is necessary.
        public Admin(General g, string PIN, string USERFNAME, string USERLNAME, LoginPanel creator, string data, string DOB)
        {
            InitializeComponent();
            this.main = g;
            this.pin = PIN;
            this.userfname = USERFNAME;
            this.userlname = USERLNAME;
            this.g1 = creator;
            this.d1 = data;
            this.infoPanel.BackColor = Color.Transparent;
            if (this.userfname == "Manosh") {
                proPic.BackgroundImage = Properties.Resources.Manosh;
            }
            else if (this.userfname == "Dark") {
                proPic.BackgroundImage = Properties.Resources.Dark;
            }
            else {
                proPic.BackgroundImage = Properties.Resources.guest;
            }
            this.fullName.Text = "";
            this.regDate.Text = "";
            this.dateOfBirth.Text = "";
            this.regDate.Text += String.Format(CultureInfo.InvariantCulture, "{0:M-d-yyyy}", System.Convert.ToDateTime(this.d1));
            this.dateOfBirth.Text += DOB;
            wd = this.mySlidingPanel.Width;
            this.mySlidingPanel.Width = this.slideButton.Width;
            this.mySlidingPanel.BackColor = Color.FromArgb(80, 37, 46, 59);
            this.proPic.BackColor = Color.Transparent;
            this.infoPanel.BackColor = Color.FromArgb(80, 37, 46, 59);
            hidden = true;
        }

        // Sets the text of the Greeting Label as per time of the day.
        private void setGreet()
        {
            string s = DateTime.Now.ToString("h:mm:ss tt");
            if (s[s.Length - 2] == 'A') s = "morning";
            else
            {
                if (s[0] >= 48 && s[0] <= 54) s = "afternoon";
                else s = "evening";
            }
            greeting.Text = "Good " + s + "! Welcome back " + this.userfname + ".";
            this.fullName.Text += this.userfname + " " + this.userlname;            
        }

        // Loads the inintial greeting.
        private void Admin_Load(object sender, EventArgs e)
        {
            setGreet();
            this.changes.Text = ""; 
        }

        // Updates the changes made warning;
        public void updateMSG(string s) { this.changes.Text = s;}

        //Calls the Application.Exit()
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Minimizes the WindowState
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Calls an instance of the Create admin form.
        private void addAdmin_Click(object sender, EventArgs e)
        {
            CreateAdmin cs = new CreateAdmin(this, this.pin);
            cs.Show();
            this.Hide();
        }

        //Saves all changes made and call for to update Database.
        private void updateAll_Click(object sender, EventArgs e)
        {
            this.changes.Text = g1.checkForUpdates(this.changes.Text);
            if (this.changes.Text != "No Changes to Save!") this.changes.Text = "Changes Saved!";
        }

        //Controls the addAdmin buttons color when mouse hovers and leaves.
        private void addAdmin_MouseHover(object sender, EventArgs e)
        {
            this.addAdmin.BackColor = Color.DodgerBlue;
        }

        private void addAdmin_MouseLeave(object sender, EventArgs e)
        {
            this.addAdmin.BackColor = Color.Transparent;
        }

        //Controls the addNewRoute buttons color when mouse hovers and leaves.
        private void addNewRoute_MouseHover(object sender, EventArgs e)
        {
            this.addNewRoute.BackColor = Color.DodgerBlue;
        }

        private void addNewRoute_MouseLeave(object sender, EventArgs e)
        {
            this.addNewRoute.BackColor = Color.Transparent;
        }

        //Controls the delRoute buttons color when mouse hovers and leaves.
        private void delRoute_MouseHover(object sender, EventArgs e)
        {
            this.delRoute.BackColor = Color.DodgerBlue;
        }

        private void delRoute_MouseLeave(object sender, EventArgs e)
        {
            this.delRoute.BackColor = Color.Transparent;
        }

        //Controls the updateAll buttons color when mouse hovers and leaves.
        private void updateAll_MouseHover(object sender, EventArgs e)
        {
            this.updateAll.BackColor = Color.DodgerBlue;
        }

        private void updateAll_MouseLeave(object sender, EventArgs e)
        {
            this.updateAll.BackColor = Color.Transparent;
        }

        //Controls the logout buttons color when mouse hovers and leaves;
        private void logout_MouseHover(object sender, EventArgs e)
        {
            this.logout.BackColor = Color.DodgerBlue;
        }

        private void logout_MouseLeave(object sender, EventArgs e)
        {
            this.logout.BackColor = Color.Transparent;
        }
        
        //My Logout buttons event handled.
        //Takes us back to the original Form and also call to show the blurred Trip Planner main page.
        private void logout_Click(object sender, EventArgs e)
        {
            this.g1.resetPass();
            this.main.Show();
            this.g1.Show();
            this.Close();
        }

        //Starts the animation of the sliding panel.
        private void timer1_Tick(object sender, EventArgs e) 
        {
            if(!hidden) //Modifies the buttons and width if Hidden.
            {
                this.mySlidingPanel.Width += 20;
                if(this.mySlidingPanel.Width >= wd)
                {
                    this.addAdmin.Width = this.mySlidingPanel.Width;
                    this.addNewRoute.Width = this.mySlidingPanel.Width;
                    this.delRoute.Width = this.mySlidingPanel.Width;
                    this.updateAll.Width = this.mySlidingPanel.Width;
                    timer1.Stop();
                    hidden = false;
                    //this.Refresh();
                }
                
            }
            else //Retracts the panel to hide the labels.
            {
                this.mySlidingPanel.Width -= 40;
                if(this.mySlidingPanel.Width <= slideButton.Width)
                {
                    timer1.Stop();
                    hidden = true;
                    //this.Refresh();
                }
            }
        }

        //Calls the sliding panel animation. Updates panel hidden status.
        private void slideButton_Click(object sender, EventArgs e)
        {
            if (hidden) { hidden = false; }
            else { hidden = true; }
            timer1.Start();
        }

        //Creates an instances of the insert route form.
        private void addNewRoute_Click(object sender, EventArgs e)
        {
            InsertTrip ins = new InsertTrip(this, this.pin);
            ins.Show();
            this.Hide();
        }

        //Creates an instance of delete route form.
        private void delRoute_Click(object sender, EventArgs e)
        {
            Delete ds = new Delete(this, this.pin);
            ds.Show();
            this.Hide();
        }
    }
}
