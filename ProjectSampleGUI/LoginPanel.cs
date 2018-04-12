using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSampleGUI
{
    public partial class LoginPanel : Form
    {
        private DataLoader myconn;

        //The constructor.
        public LoginPanel(General g, DataLoader mm)
        {
            InitializeComponent();
            this.login_error.Hide();
            this.Owner = g;
            g.Blur();
            this.myconn = mm;
            this.login_error.Text = "";
            this.panel1.BackColor = Color.FromArgb(80, 171, 167, 142);
            this.adminUser.BackColor = this.BackColor;
            this.adminPass.BackColor = this.BackColor;
            this.ActiveControl = this.adminUser;
        }

        //Slides the DemoWarning message from Left to Right out of the screen.
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.demoWarn.Left < this.Width) { this.demoWarn.Left += 2; }
            else
            {
                this.demoWarn.Location = new Point(0 - this.demoWarn.Width, this.demoWarn.Location.Y);
            }
        }

        //During loading, loads the blurred sections adn others.
        private void LoginPanel_Load(object sender, EventArgs e)
        {
            //Disabling the three Icon buttons.
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        //Closes the application.
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Minimizes the current windows.
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Checks if there is anything to update in the database via the Dataloader instance.
        public string checkForUpdates(string s)
        {
            if (s != "" && s != "No Changes to Save!") { this.myconn.saveChanges(); return "Changes Saved!"; }
            return "No Changes to Save!";
        }

        //resets the password field when coming back here.
        public void resetPass()
        {
            this.adminPass.Text = "";
        }

        //This will match the credentials provided and match with the system data to validate the login.
        //It also loads the admin homepage.
        private void loginMain_Click(object sender, EventArgs e)
        {
            string user = adminUser.Text, pass;
            pass = adminPass.Text;
            foreach (string s in this.myconn.adminList)
            {                
                string[] arr = s.Split(',');
                if (arr[0] == user && arr[1] == pass)
                {
                    Admin my = new Admin((General)this.Owner, arr[2], arr[3], arr[4], this, arr[5], arr[6]);
                    this.Owner.Hide();
                    this.Hide();
                    my.Show();
                    return;
                }
            }
            login_error.Text = "Username or Password provided is incorrect.";
            login_error.Show();
        }

        //Hides this form, unblurs and returns control to the Parent Form.
        private void back_Click(object sender, EventArgs e)
        {
            General g = (General)this.Owner;
            g.UnBlur();
            this.Close();
        }
    }
}
