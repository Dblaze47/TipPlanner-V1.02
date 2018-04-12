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
    public partial class InsertTrip : Form
    {
        //the default constructor. Creates the panels and buttons. And initializes them.
        public InsertTrip(Admin Creator, string PIN)
        {
            InitializeComponent();
            this.nodes = new string[] { "----------", "Barisal", "Chittagong", "Dhaka", "Khulna", "Moinamoti", "Mymensingh", "Rajshahi", "Rangpur", "Sylhet" };
            this.owner = Creator;
            this.pin = PIN;
            this.panel1.BackColor = Color.FromArgb(80, 37, 46, 59);

            this.comboSrc.Items.AddRange(nodes);
        }

        //What happens when the form loads.
        private void InsertTrip_Load(object sender, EventArgs e)  // Defines all that is to be loaded when the InsertTrip form is created.
        {
            this.success.Hide();
            this.adminError.Hide();
            this.comboSrc.SelectedIndex = 0;
            this.myTime.Text = "";
            this.myCost.Text = "";
            this.comboDest.Text = "----------";
            this.transport.SelectedIndex = 0;
            this.aPIN.PasswordChar = '*';
            this.prevsrc = this.comboDest.Text;
            this.prevdst = this.comboDest.Text;
            this.prevtme = this.myTime.Text;
            this.prevcst = this.myCost.Text;
            this.prevtransport = this.transport.Text;
        }

        //Will check for inconsistencies and add the route to our database.
        private void insert_Click(object sender, EventArgs e)
        {
            if(this.prevtransport == this.transport.Text || this.prevsrc == this.comboDest.Text || this.prevdst == this.comboDest.Text || this.prevtme == this.myTime.Text || this.prevcst == this.myCost.Text)
            {
                MetroFramework.MetroMessageBox.Show(this, "This Record already exists. Please enter new values!", "Duplicate information entered.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (this.comboSrc.Text == "----------") { MetroFramework.MetroMessageBox.Show(this, "Please select a Valid Source!", "Invalid information entered.", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            else if (this.comboDest.Text == "----------") { MetroFramework.MetroMessageBox.Show(this, "Please enter a valid Destination!", "Invalid information entered.", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            else if (this.transport.Text == "----------") { MetroFramework.MetroMessageBox.Show(this, "Please enter a valid Transportation!", "Invalid information entered.", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            else if (this.pin != this.aPIN.Text) { this.adminError.Show(); return; }
            int x = 100000, y = 100000;
            if(myTime.Text != "")int.TryParse(this.myTime.Text, out x);
            if (myCost.Text != "") int.TryParse(this.myCost.Text, out y);
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Data_Files\C#ProjectDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                /* Here we will first add the route source -- > destination */
                if (this.transport.Text == "BUS") { cmd = new SqlCommand("INSERT INTO Bus ([Source], [Destination], [Time], [Cost], [Transport]) VALUES (@src, @dest, @time, @cost, @ride);", conn);}
                else if (this.transport.Text == "TRAIN") { cmd = new SqlCommand("INSERT INTO Train ([Source], [Destination], [Time], [Cost], [Transport]) VALUES (@src, @dest, @time, @cost, @ride);", conn); }
                else if (this.transport.Text == "PLANE") { cmd = new SqlCommand("INSERT INTO Plane ([Source], [Destination], [Time], [Cost], [Transport]) VALUES (@src, @dest, @time, @cost, @ride);", conn); }
                else if (this.transport.Text == "LAUNCH") { cmd = new SqlCommand("INSERT INTO Launch ([Source], [Destination], [Time], [Cost], [Transport]) VALUES (@src, @dest, @time, @cost, @ride);", conn); }
                cmd.Parameters.AddWithValue("@src", this.comboSrc.Text);
                cmd.Parameters.AddWithValue("@dest", this.comboDest.Text);
                cmd.Parameters.AddWithValue("@time", x);
                cmd.Parameters.AddWithValue("@cost", y);
                cmd.Parameters.AddWithValue("@ride", this.transport.Text);
                cmd.ExecuteNonQuery();

                /* Here we will first add the route destination -- > source, the reverse of the original entry. */
                /* 'For every entry there will be an opposite and equal entry!' */
                if (this.transport.Text == "BUS") { cmd = new SqlCommand("INSERT INTO Bus ([Source], [Destination], [Time], [Cost], [Transport]) VALUES (@src1, @dest`, @time1, @cost1, @ride1);", conn); }
                else if (this.transport.Text == "TRAIN") { cmd = new SqlCommand("INSERT INTO Train ([Source], [Destination], [Time], [Cost], [Transport]) VALUES (@src1, @dest1, @time1, @cost1, @ride1);", conn); }
                else if (this.transport.Text == "PLANE") { cmd = new SqlCommand("INSERT INTO Plane ([Source], [Destination], [Time], [Cost], [Transport]) VALUES (@src1 @dest1, @time1, @cost1, @ride1);", conn); }
                else if (this.transport.Text == "LAUNCH") { cmd = new SqlCommand("INSERT INTO Launch ([Source], [Destination], [Time], [Cost], [Transport]) VALUES (@src1, @dest1, @time1, @cost1, @ride1);", conn); }
                cmd.Parameters.AddWithValue("@src1", this.comboDest.Text);
                cmd.Parameters.AddWithValue("@dest1", this.comboSrc.Text);
                cmd.Parameters.AddWithValue("@time1", x);
                cmd.Parameters.AddWithValue("@cost1", y);
                cmd.Parameters.AddWithValue("@ride1", this.transport.Text);
                cmd.ExecuteNonQuery();
            }

            this.success.Show();
            this.adminError.Hide();
            this.owner.updateMSG("New Route(s) Added! Update Database Now.");
            this.prevsrc = this.comboDest.Text;
            this.prevdst = this.comboDest.Text;
            this.prevtme = this.myTime.Text;
            this.prevcst = this.myCost.Text;
            this.prevtransport = this.transport.Text;
        }

        //Defines what the ' Go Back ' button does.
        private void button1_Click(object sender, EventArgs e)
        {
            this.owner.Show();
            this.Close();
        }

        //Defines how the load order of the destination depends upon the source.
        private void comboSrc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.success.Hide();
            this.comboDest.Items.Clear();
            this.comboDest.Items.AddRange(this.nodes);
            this.comboDest.Items.Remove(this.comboSrc.SelectedItem);
        }
    }
}
