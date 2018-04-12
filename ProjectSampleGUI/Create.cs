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

namespace ProjectSampleGUI
{
    public partial class CreateAdmin : Form
    {
        //Default parameterized constructor.
        public CreateAdmin(Admin creator, string PIN)
        {
            InitializeComponent();
            this.owner = creator;
            this.pin = PIN;
            this.data = new DataLoader();
            this.panel1.BackColor = Color.FromArgb(80, 37, 46, 59);
            string[] dates = new string[21];
            for(int i = 1980, j = 0; i <= 2000; i++)
            {
                dates[j++] = i.ToString();
            }
            this.dobYear.Items.AddRange(dates);
        }

        // Defines all that is to be loaded when the Create form is created.
        private void Create_Load(object sender, EventArgs e)
        {
            this.error.Text = "";
            this.success.Text = "";
            this.unameCheck.Text = "";
            this.upass.PasswordChar = '*';
            this.ucpass.PasswordChar = '*';
            this.aPIN.PasswordChar = '*';
            this.uPIN.PasswordChar = '*';
            this.prev = "";
        }

        //Helps to refer to Admin PIN.
        private void help_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "This is the PIN for the admin in charge of creating the account.", "Help for PIN ?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
               
        //Checks all the username, password and PIN entered, and if all met, creates a new Admin.
        private void createUser_Click(object sender, EventArgs e)
        {
            if (upass.Text != ucpass.Text) { error.Text = "Passwords do not match."; return; }
            if (upass.Text.Length < 4) { error.Text = "Password Length must be min. 4 characters!"; return; }
            string s = aPIN.Text;
            int a;
            if (!Int32.TryParse(this.uPIN.Text, out a)) { MetroFramework.MetroMessageBox.Show(this, "PIN can only consist of numbers. Please try again.", "PIN in unrecognized format!", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (s != this.pin) { MetroFramework.MetroMessageBox.Show(this, "The provided PIN for admin does not match. Please try again.", "Admin PIN Incorrect!", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (this.uname.Text == this.prev) { this.unameCheck.Text = "Username Already Exists!"; return; }
            foreach (string names in data.adminList)
            {
                string[] str = names.Split(',');
                if (uname.Text == str[0]) { this.unameCheck.Text = "Username Already Exists!"; return; }
            }
            string dob = this.dobMonth.Text + "-" + this.dobDay.Text + "-" + this.dobYear.Text;

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Data_Files\C#ProjectDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Admin ([Username], [Password], [PIN], [First Name], [Last Name], [Joining Date], [Date of Birth]) VALUES (@name, @pass, @PIN, @Fname, @Lname, @Date, @DOB);", conn);

                cmd.Parameters.AddWithValue("@name", this.uname.Text);
                cmd.Parameters.AddWithValue("@pass", this.upass.Text);
                cmd.Parameters.AddWithValue("@PIN", this.uPIN.Text);
                cmd.Parameters.AddWithValue("@Fname", this.uFName.Text);
                cmd.Parameters.AddWithValue("@Lname", this.uLName.Text);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                cmd.Parameters.AddWithValue("@DOB", dob);
                cmd.ExecuteNonQuery();
            }
            this.success.Text = "Admin Successfully Registered!";
            this.owner.updateMSG("New Admin(s) Created! Update Database Now.");
            this.prev = this.uname.Text;
        }

        // Returns us to the Admin Home page.
        private void button1_Click(object sender, EventArgs e)
        {
            this.owner.Show();
            this.Hide();
        }
        
        //Defines what the CLOSE button does.
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
