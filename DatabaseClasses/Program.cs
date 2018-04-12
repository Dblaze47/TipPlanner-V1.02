using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static void loadBus(out List<Transport> myBus) // Calls the load method of Transport for BUS.
        {
            Transport t = new Transport();
            t.load(out myBus, "BUS");
        }

        public static void loadTrain(out List<Transport> myTrain) // Calls the load method of Transport for TRAIN.
        {
            Transport t = new Transport();
            t.load(out myTrain, "TRAIN");
        }

        public static void loadPlane(out List<Transport> myPlane) // Calls the load method of Transport for PLANE.
        {
            Transport t = new Transport();
            t.load(out myPlane, "PLANE");
        }

        public static void loadLaunch(out List<Transport> myLaunch) // Calls the load method of Transport for LAUNCH.
        {
            Transport t = new Transport();
            t.load(out myLaunch, "LAUNCH");
        }
        
        public static void admin(out List<string> adminList) // Loads the complete Admin table into our referenced adminList.
        {
            adminList = new List<string>();
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Data_Files\C#ProjectDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                conn.Open();                
                SqlCommand cmd;
                cmd = new SqlCommand(@"SELECT * FROM Admin", conn); 
                SqlDataReader rdr = cmd.ExecuteReader();
                string str;
                while (rdr.Read())
                {
                    str = rdr[0] + "," + rdr[1] + "," + rdr[2] + "," + rdr[3] + "," + rdr[4] + "," + rdr[5] + "," + rdr[6];
                    adminList.Add(str);
                }
            }
        }
    }
}
