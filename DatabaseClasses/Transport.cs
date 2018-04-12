using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseClasses
{
    public class Transport
    {
        private string source;
        private string destination;
        private int time;
        private int cost;

        public Transport() { } // Creates an object with default values.
        public Transport(string src, string dst, int tm, int cst) // Creates a Transport object with set parameters.
        {
            this.source = src;
            this.destination = dst;
            this.time = tm;
            this.cost = cst;
        }

        public string Source // The property to get-set the source;
        {
            get { return this.source; }
            set { this.source = value;}
        }
        public string Destination // The property to get-set the destination;
        {
            get { return this.destination; }
            set { this.destination = value; }
        }
        public int Time // The property to get-set the time;
        {
            get { return this.time; }
            set { this.time = value; }
        }
        public int Cost // The property to get-set the cost;
        {
            get { return this.cost; }
            set { this.cost = value; }
        }

        public void load(out List<Transport> myload, string tr)
        {
            myload = new List<Transport>();
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Data_Files\C#ProjectDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                conn.Open();
              
                SqlCommand cmd;
                if (tr == "BUS") { cmd = new SqlCommand(@"SELECT * FROM Bus", conn); }
                else if (tr == "TRAIN") { cmd = new SqlCommand(@"SELECT * FROM Train", conn); }
                else if (tr == "LAUNCH") { cmd = new SqlCommand(@"SELECT * FROM Launch", conn); }
                else { cmd = new SqlCommand(@"SELECT * FROM Plane", conn); }
                SqlDataReader rdr = cmd.ExecuteReader();
                Transport t;
                while (rdr.Read())
                {
                    t = new Transport(rdr[0].ToString(), rdr[1].ToString(), int.Parse(rdr[2].ToString()), int.Parse(rdr[3].ToString()));
                    myload.Add(t);
                }
            }
        }
    }
}
