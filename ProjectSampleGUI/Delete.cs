using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseClasses;

namespace ProjectSampleGUI
{
    public partial class Delete : Form
    {
        //The default constructor setting up.
        public Delete(Admin Creator, string PIN)
        {
            InitializeComponent();
            this.panel1.BackColor = Color.FromArgb(80, 37, 46, 59);
            this.pin = PIN;
            this.owner = Creator;
            this.nodes = new string[] { "----------", "Barisal", "Chittagong", "Dhaka", "Khulna", "Moinamoti", "Mymensingh", "Rajshahi", "Rangpur", "Sylhet" };
            string[] tripTimes = new string[] { "-------", "less than 4", "less than 5", "less than 6", "less than 7", "less than 8", "less than 9", "less than 10", "less than 11", "less than 15", "more than 15" };
            string[] tripCosts = new string[] { "-------", "less than 300", "less than 400", "less than 500", "less than 600", "less than 700", "less than 800", "less than 900", "less than 1100", "more than 1100" };
            this.comboSrc.Items.AddRange(nodes);
            this.comboTime.Items.AddRange(tripTimes);
            this.comboCost.Items.AddRange(tripCosts);
        }

        //Defines what happens when the form loads.
        private void Delete_Load(object sender, EventArgs e)
        {
            this.success.Hide();
            this.comboSrc.SelectedIndex = 0;
            this.comboCost.SelectedIndex = 0;
            this.comboTime.SelectedIndex = 0;
            this.comboDest.Text = "----------";
            this.transport.SelectedIndex = 0;
            this.aPIN.PasswordChar = '*';
        }

        //Defines what is done when the selected source disappears from the list of the selected destinations.
        private void comboSrc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.success.Hide();
            this.comboDest.Items.Clear();
            this.comboDest.Items.AddRange(this.nodes);
            this.comboDest.Items.Remove(this.comboSrc.SelectedItem);
        }

        //Defines what happens when we press the 'Go Back' button.
        private void back_Click(object sender, EventArgs e)
        {
            this.owner.Show();
            this.Close();
        }

        private void deleteRoute_Click(object sender, EventArgs e)
        {
            if (this.comboSrc.Text == "----------") { MetroFramework.MetroMessageBox.Show(this, "Please select a Valid Source!", "Invalid information entered.", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            else if (this.comboDest.Text == "----------") { MetroFramework.MetroMessageBox.Show(this, "Please enter a valid Destination!", "Invalid information entered.", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            else if (this.transport.Text == "----------") { MetroFramework.MetroMessageBox.Show(this, "Please enter a valid Transportation!", "Invalid information entered.", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            else if (this.pin != this.aPIN.Text) { MetroFramework.MetroMessageBox.Show(this, "ADMIN PIN does not match database. Please try again.", "Invalid Admin PIN provided.", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            bool vis = false;
            string src = this.comboSrc.Text, dest = this.comboDest.Text, choice = this.transport.Text;
            DataLoader ds = new DataLoader();
            if (choice == "BUS")
            {
                foreach (Transport s in ds.myBus)
                {
                    if (s.Source == src && s.Destination == dest) { vis = true; break; }
                }
            }
            else if (choice == "TRAIN")
            {
                foreach (Transport s in ds.myTrain)
                {
                    if (s.Source == src && s.Destination == dest) { vis = true; break; }
                }
            }
            else if (choice == "PLANE")
            {
                foreach (Transport s in ds.myPlane)
                {
                    if (s.Source == src && s.Destination == dest) { vis = true; break; }
                }
            }
            else if (choice == "LAUNCH")
            {
                foreach (Transport s in ds.myLaunch)
                {
                    if (s.Source == src && s.Destination == dest) { vis = true; break; }
                }
            }
            if (!vis) { MetroFramework.MetroMessageBox.Show(this, "Your route does not exist in the Database!", "Invalid delete attempted", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            string time = "1000000", cost = "1000000", t = this.comboTime.Text, c = this.comboCost.Text;
            int x, y;
            if (t != "-------")//Checks if there is any specific values chosen.
            {
                time = "";
                for (int i = 10; i < t.Length; i++)
                {
                    time += t[i].ToString();
                }
            }
            if (c != "-------")//Checks if there is any specific value chosen.
            {
                cost = "";
                for (int j = 0; j < c.Length; j++)
                {
                    cost += c[j].ToString();
                }
            }
            x = int.Parse(time);
            y = int.Parse(cost);
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Data_Files\C#ProjectDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();

                /* Here we will first delete the route source -- > destination */
                if (choice == "BUS") { cmd = new SqlCommand("DELETE FROM Bus WHERE [Source] = @src AND [Destination] = @dest;", conn); }
                else if (choice == "TRAIN") { cmd = new SqlCommand("DELETE FROM Train WHERE [Source] = @src AND [Destination] = @dest;", conn); }
                else if (choice == "PLANE") { cmd = new SqlCommand("DELETE FROM Plane WHERE [Source] = @src AND [Destination] = @dest;", conn); }
                else if (choice == "LAUNCH") { cmd = new SqlCommand("DELETE FROM Launch WHERE [Source] = @src AND [Destination] = @dest;", conn); }
                cmd.Parameters.AddWithValue("@src", this.comboSrc.Text);
                cmd.Parameters.AddWithValue("@dest", this.comboDest.Text);
                cmd.ExecuteNonQuery();

                /* Here we will first delete the route destination -- > source, the reverse of the original entry. */
                /* 'For every entry there was an opposite and equal entry!' */
                if (this.transport.Text == "BUS") { cmd = new SqlCommand("DELETE FROM Bus WHERE [Source] = @src1 AND [Destination] = @dest1;", conn); }
                else if (this.transport.Text == "TRAIN") { cmd = new SqlCommand("DELETE FROM Train WHERE [Source] = @src1 AND [Destination] = @dest1;", conn); }
                else if (this.transport.Text == "PLANE") { cmd = new SqlCommand("DELETE FROM Plane WHERE [Source] = @src1 AND [Destination] = @dest1;", conn); }
                else if (this.transport.Text == "LAUNCH") { cmd = new SqlCommand("DELETE FROM Launch WHERE [Source] = @src1 AND [Destination] = @dest1;", conn); }
                cmd.Parameters.AddWithValue("@src1", this.comboDest.Text);
                cmd.Parameters.AddWithValue("@dest1", this.comboSrc.Text);
                cmd.ExecuteNonQuery();
            }
            this.success.Show();
            this.owner.updateMSG("Route(s) Successfully Removed! Update Database Now.");
        }
    }
}
