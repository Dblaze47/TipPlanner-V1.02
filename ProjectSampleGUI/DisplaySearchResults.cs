using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSampleGUI
{
    public partial class DisplaySearchResults : Form
    {
        //Constructor
        public DisplaySearchResults(string str, General g)
        {
            InitializeComponent();
            this.message = str;
            this.result1.Text = "";
            this.owner = g;
            this.adminEmail.Hide();
        }

        //Defines how the timer controls the sliding in and out of the discretion label
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.discretion.Left < this.Width) { this.discretion.Left += 5; }
            else
            {
                this.discretion.Location = new Point(0 - this.discretion.Width, this.discretion.Location.Y);
            }
        }

        //Creates a new thread to type in results and call the method.
        private void DisplaySearchResults_Load(object sender, EventArgs e)
        {
            Thread t1 = new Thread(new ThreadStart(loadText));
            t1.Start();
        }

        //Loads the Trip Results as fetched from the Database / Provides warning for invalid results.
        private void loadText()
        {
            result1.Text = "";
            if (this.error) {
                this.result1.Invoke(new Action(() => this.result1.Text += this.message));
                this.result1.Invoke(new Action(() => { this.adminEmail.Show(); }));
                return;
            }
            for (int i = 0; i < this.message.Length; ++i)
            {
                Thread.Sleep(5);
                this.result1.Invoke(new Action(() => { this.result1.Text += this.message[i]; }));
            }                   
        }

        //Defines what the "Plane new trip" button does.
        private void button1_Click(object sender, EventArgs e)
        {
            this.owner.resetFields();
            this.owner.Show();
            this.Hide();
        }

        //Defines what happens when client clicks the contact admin label.
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo email = new ProcessStartInfo();//@"C:\Program Files\Internet Explorer\iexplore.exe");
            email.FileName = "firefox.exe";
            email.Arguments = "mailto:manosh.office015@gmail.com?subject=Request%20to%20recalculate%20TripPlannerApplication%20recommendations.";
            email.UseShellExecute = true;
            email.CreateNoWindow = true;
            Process.Start(email);
        }
    }
}
