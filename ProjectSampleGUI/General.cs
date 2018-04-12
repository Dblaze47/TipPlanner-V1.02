using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseClasses;

namespace ProjectSampleGUI
{
    public partial class General : Form
    {
        private DisplaySearchResults dsresult;

        // Code of the Screenshot class is used to Draw an image of the current panel as it is.
        //[Code copied from Source: " https://stackoverflow.com/questions/17248748/c-sharp-dialog-form-with-blur-background " ]
        class Screenshot
        {
            public static Bitmap TakeSnapshot(Control ctl)
            {
                Bitmap bmp = new Bitmap(ctl.Size.Width, ctl.Size.Height);
                System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bmp);
                g.CopyFromScreen(ctl.PointToScreen(ctl.ClientRectangle.Location), new Point(0, 0), ctl.ClientRectangle.Size);
                return bmp;
            }
        }

        // The constructor initializes components, and sets all the lists to the their default loadup
        public General()
        {
            InitializeComponent();
            this.myconn = new DataLoader();
            this.myconn.resultSet = new List<string>();
            this.sp = "";
            this.myBlur = new PictureBox();
            this.panelBlur.Controls.Add(this.myBlur);
            this.myBlur.Dock = DockStyle.Fill;

            nodes = new string[] { "Barisal", "Chittagong", "Dhaka", "Khulna", "Moinamoti", "Mymensingh", "Rajshahi", "Rangpur", "Sylhet" };
            tripTimes = new string[] { "-------", "less than 4", "less than 5", "less than 6", "less than 7", "less than 8", "less than 9", "less than 10", "less than 11", "less than 15", "Above 15" };
            tripCosts = new string[] { "-------", "less than 300", "less than 400", "less than 500", "less than 600", "less than 700", "less than 800", "less than 900", "less than 1100", "Above 1100" };
        }

        // Loads everything required at the beginning of the form load.
        private void Form1_Load(object sender, EventArgs e) 
        {
            myProgBar.Maximum = 100;
            myProgBar.Minimum = 0;
            myProgBar.Hide();
            shProg.Text = "";
            loadButton.Enabled = true;
            tripCancel.Enabled = false;
            result1 = "";
            this.time = 10000000;
            this.cost = 10000000;
            this.tripCancel.Text = "I am not so sure....";

            mComboSrc.Items.AddRange(nodes);
            mCTime.Items.AddRange(tripTimes);
            mCCost.Items.AddRange(tripCosts);
            mCCost.SelectedItem = tripCosts[0];
            mCTime.SelectedItem = tripTimes[0];
        }

        //Defines what to do when a field reset is requested.
        public void resetFields() 
        {
            calc = new string[10];
            mComboSrc.Items.Clear();
            mComboSrc.Items.AddRange(nodes);
            mCCost.SelectedItem = tripCosts[0];
            mCTime.SelectedItem = tripTimes[0];
            this.time = 10000000;
            this.cost = 10000000;
            this.src = "";
            this.dest = "";
            this.sp = "";
            myconn.resultSet.Clear();
            this.tripCancel.Text = "I am not so sure....";
            if (tBus.Checked) { tBus.Checked = false; }
            else if (tTrain.Checked) { tTrain.Checked = false; }
            else if (tPlane.Checked) { tPlane.Checked = false; }
            else if (tLaunch.Checked) { tLaunch.Checked = false; }
        }

        // Initlizes the visualization of the progressbar and initial changes.
        private void initloadProgress() 
        {
            calculateTrip(this.calc);
            myProgBar.Show();
            loadButton.Enabled = false;
            tripCancel.Enabled = true;
            tripCancel.Text = "Oops.. I need to rethink !";
            myWorker.RunWorkerAsync();
        }

        // Defines how the increment of the progressbar will be carried out.
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) 
        {
            for(int i = 0; i < 100; i++)
            {
                Thread.Sleep(20);
                myWorker.ReportProgress(i);
                
                if(myWorker.CancellationPending) // Checks if there is any cancel request pending from triggered event.
                {
                    e.Cancel = true;
                    myWorker.ReportProgress(0);
                    return;
                }
            }
        }

        // Defines changes for every change in value of the progressbar.
        private void myWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) 
        {
            myProgBar.Value = e.ProgressPercentage;
            shProg.Text = "Calculating Possible Options ...... " + myProgBar.Value.ToString() + " %";
        }

        // Defines checks needed to be done upon progressbar completion.
        private void myWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) 
        {
            if (e.Cancelled) { shProg.Text = "Request has been cancelled."; myProgBar.Hide(); }
            else if (e.Error != null) { shProg.Text = "Task Completion has been compromised."; myProgBar.Hide(); loadButton.Text = "Reset Results"; }
            else {
                calculateTrip(this.calc);
                shProg.Text = "Results Displayed.";
                myProgBar.Hide();
                tripResult();
                resetFields();
            }

            loadButton.Enabled = true;
            tripCancel.Enabled = false;
        }

        // Defines tasks to be done when the Calculate Trip button is pressed.
        private void loadButton_Click(object sender, EventArgs e)  
        {
           this.calc = new string[10];
           if (shortestPath.Checked) {
                if (tTrain.Checked || tPlane.Checked || tLaunch.Checked)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Shortest Trip Plan is Only for Bus Routes!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
                else if (mCCost.Text != "-------" || mCTime.Text != "-------") {
                    MetroFramework.MetroMessageBox.Show(this, "Shortest Route Plan does not have any preferred budget or time length!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
                tBus.Checked = true;
                this.calc = myconn.Dijkstra(this.src, this.dest);
                printShortestPath(this.calc);
            }
            initloadProgress();
        }

        //Recieves the path array, and prepares us a string to call
        private void printShortestPath(String[] ans)
        {
            this.sp = "";
            string s = "The shortest suggested path is: " + "\n";
            //s = s.Replace(".", "." + System.Environment.NewLine);
            s += ans[0];
            for(int i = 1; i < ans.Length; ++i)
            {
                s += "  --- >  " + ans[i];
            }
            this.sp += s;
        }

        // Defines what happens when the Cancel button is pressed.
        private void tripCancel_Click(object sender, EventArgs e)
        {
            if (myWorker.IsBusy)
            {
                myWorker.CancelAsync();
            }
        }

        // Does the possible calculations and calls for the resultset.
        private void calculateTrip(string[] query) 
        {
            string choice;
            myconn.resultSet = new List<string>();
            if (tBus.Checked) { choice = "BUS"; }
            else if (tTrain.Checked) { choice = "TRAIN"; }
            else if (tPlane.Checked) { choice = "PLANE"; }
            else if (tLaunch.Checked) { choice = "LAUNCH"; }
            else { choice = "NULL"; }

            if(query[0] == null)myconn.loadResults(this.src, this.dest, this.time, this.cost, choice);
            else
            {
                for(int i = 1; i < query.Length; i++)
                {
                    if(query[i] != null)myconn.loadResults(query[i-1], query[i], this.time, this.cost, choice);
                }
            }
        }

        // Displays possible output of the trip to the general user.
        private void tripResult() 
        {
            result1 = "";
            if(this.sp.Length != 0)this.result1 += this.sp + "\n";
            int i = 1;
            string ss; 
            if (myconn.resultSet.Count() == 0) {
                result1 = "Sorry, your preferred trip doesn't exist in our database." + "\n" + "Please go back and plan a different trip. " + "\n";
                result1 += "\n" + "If you are sure that there has been a miscalculation please contact the admin at:                             ";
                this.dsresult = new DisplaySearchResults(result1, this);
                dsresult.error = true;
            }
            else
            {
                string ans = "";
                foreach (string s in myconn.resultSet)
                {
                    ss = "Recommended Route " + i + ":" + "\n";
                    string[] str = s.Split(',');
                    ans = ss + "Trip Source: " + str[0] + " Trip Destination: " + str[1] + " Trip Time: " + str[2] + " Trip Cost: " + str[3] + " Transport: " + str[4] + "\n";
                    ans = ans.Replace(".", "." + System.Environment.NewLine);
                    result1 += ans;
                    i++;
                }
                this.dsresult = new DisplaySearchResults(result1, this);
            }            
            
            this.dsresult.Show();
            this.Hide();
        }

        // Defines what happens when Login button is pressed. 
        private void adminLogin_Click(object sender, EventArgs e) 
        {
            LoginPanel my = new LoginPanel(this, this.myconn);
            my.ShowDialog();
        }

        //Checks and strores the user selected destination.
       private void mCDest_SelectionChangeCommitted_2(object sender, EventArgs e)
        {
            this.dest = mCDest.Text;
        }

        //Checks what source has been chosen, and updates possible destination accordingly.
        private void mComboSrc_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            this.src = mComboSrc.Text;
            mCDest.Items.Clear();
            mCDest.Items.AddRange(nodes);
            mCDest.Items.Remove(this.src);
            mComboSrc.SelectedItem = this.src;
        }

        //Calculates the user selected preferred trip time length (if any). 
        private void mCTime_SelectionChangeCommitted(object sender, EventArgs e)
        {
             if (mCTime.Text == "-------") { return; }
            string s = mCTime.Text, s1 = "";
            foreach (char c in s)
            {
                if (c >= 48 && c <= 57) s1 += c;
            }
            this.time = int.Parse(s1);
        }

        //Calculates the user selected preferred trip cost (if any).
        private void mCCost_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (mCCost.Text == "-------") { return; }
            string s = mCCost.Text, s1 = "";
            foreach (char c in s)
            {
                if (c >= 48 && c <= 57) s1 += c;
            }
            this.cost = int.Parse(s1);
        }        

        //Uses Gaussian Blur to blur the whole Panel.
        public void Blur()
        {
            Bitmap bmp = Screenshot.TakeSnapshot(this.panelBlur);
            BitmapFilter.GaussianBlur(bmp, 4);
            BitmapFilter.GaussianBlur(bmp, 4);
            BitmapFilter.GaussianBlur(bmp, 4);

            this.myBlur.Image = bmp;
            this.myBlur.BringToFront();
        }

        //Unblurs the panel.
        public void UnBlur()
        {
            this.myBlur.Image = null;
            this.myBlur.SendToBack();
        }
    }
}
