using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseClasses;
using System.Data.SqlClient;

namespace ProjectSampleGUI
{
    public delegate void Loader(out List<Transport> myT); // Delegate for accessing the methods of the Program class in DatabaseClasses project.

    public class DataLoader
    {
        public List<Transport> myBus;
        public List<Transport> myTrain;
        public List<Transport> myPlane;
        public List<Transport> myLaunch;
        public List<string> adminList;
        public List<string> resultSet;
        private Loader bus;
        private Loader train;
        private Loader plane;
        private Loader launch;

        class Pair<T, U> // Template class for to use Generic Pairs.
        {
            public Pair() { }
            public Pair(T first, U second)
            {
                this.First = first;
                this.Second = second;
            }
            public T First { get; set; }
            public U Second { get; set; }
        };

        public DataLoader() // It assigns the loader functions from the DatabaseClasses.Program namespace to its delegates, and initializes the lists.
        {
            this.bus = new Loader(DatabaseClasses.Program.loadBus);
            this.train = new Loader(DatabaseClasses.Program.loadTrain);
            this.plane = new Loader(DatabaseClasses.Program.loadPlane);
            this.launch = new Loader(DatabaseClasses.Program.loadLaunch);
            
           
            bus(out this.myBus);
            train(out this.myTrain);
            plane(out this.myPlane);
            launch(out this.myLaunch);
            DatabaseClasses.Program.admin(out this.adminList);
        }

        public void saveChanges()
        {
            this.bus(out this.myBus);
            this.train(out this.myTrain);
            this.plane(out this.myPlane);
            this.launch(out this.myLaunch);
            DatabaseClasses.Program.admin(out this.adminList);
        }

        public string[] Dijkstra(string src, string dest) // Plans the shortest route (if any) for Bus routes.
        {
            int[,] adj = new int[12,12];
            int[,] wgt = loadWeight();

            for (int i = 0; i < 9; i++) {
                for (int j = 0; j < 9; j++) adj[i,j] = 1;
            }
            string[] names = new string[] { "Barisal", "Chittagong", "Dhaka", "Khulna", "Moinamoti", "Mymensingh", "Rajshahi", "Rangpur", "Sylhet" };
            Pair<string, int>[] nodes = new Pair<string, int>[12];
            int start = 0, end = 0;
            for (int i = 0; i < 9; i++)
            {
                nodes[i] = new Pair<string, int>();
                nodes[i].First = names[i];
                nodes[i].Second = i;
                if (names[i] == src) start = i;
                if (names[i] == dest) end = i;
            }
            bool[] vis = new bool[12];
            int[] par = new int[12];
            int[] dist = new int[12];
            for (int i = 0; i < par.Length; i++) par[i] = -10;
            for (int i = 0; i < dist.Length; i++) dist[i] = int.MaxValue;
            dist[start] = 0;
            par[start] = -1;
            int curr = start;
            while(!vis[curr])
            {
                vis[curr] = true;
                for(int i = 0; i < 9; i++)
                {
                    if(wgt[curr, i] != int.MaxValue)
                    {
                        int d = wgt[curr, i] + dist[curr];
                        if (d < dist[i])
                        {
                            dist[i] = d;
                            par[i] = curr;
                        }
                    }
                }
                int mx = int.MaxValue;
                for(int i = 0; i < 9; i++)
                {
                    if(dist[i] < mx && vis[i] == false)
                    {
                        curr = i;
                        mx = dist[i];
                    }
                }
            }

            List<int> sPath = new List<int>();
            curr = end;
            while (curr != start)
            {
                sPath.Add(curr);
                curr = par[curr];
            }
            sPath.Add(start);
            sPath.Reverse();
            string[] route = new string[sPath.Count()];
            int x = 0;
            foreach(int i in sPath)
            {
                foreach(Pair<string, int> p in nodes)
                {
                   if (p!=null && p.Second == i)
                    {
                        route[x++] = p.First;
                    }
                        
                }
            }
            return route;
        }

        public int[,] loadWeight() // Set all the weights for the graph matrix. 
        {
            int[,] arr = new int[12, 12];
            int[] a = new int[] { 0, 11, 6, 7, 10, 10, 8, 6, 12 };
            int[] b = new int[] { 11, 0, 6, 12, 3, 9, 10, 15, 9 };
            int[] c = new int[] { 6, 6, 0, 7, 3, 3, 6, 8, 6 };
            int[] d = new int[] { 7, 12, 7, 0, 9, 11, 5, 4, 12 };
            int[] e = new int[] { 10, 3, 3, 9, 0, 5, 9, 11, 7 };
            int[] f = new int[] { 10, 9, 3, 11, 5, 0, 7, 6, 5};
            int[] g = new int[] { 5, 10, 6, 5, 9, 7, 0, 3, 11};
            int[] h = new int[] { 6, 15, 8, 4, 11, 6, 3, 0, 13};
            int[] i = new int[] { 12, 9, 6, 12, 7, 5, 11, 13, 0};

            for (int x = 0; x < 9; x++) arr[0, x] = a[x];
            for (int x = 0; x < 9; x++) arr[1, x] = b[x];
            for (int x = 0; x < 9; x++) arr[2, x] = c[x];
            for (int x = 0; x < 9; x++) arr[3, x] = d[x];
            for (int x = 0; x < 9; x++) arr[4, x] = e[x];
            for (int x = 0; x < 9; x++) arr[5, x] = f[x];
            for (int x = 0; x < 9; x++) arr[6, x] = g[x];
            for (int x = 0; x < 9; x++) arr[7, x] = h[x];
            for (int x = 0; x < 9; x++) arr[8, x] = i[x];
            return arr;
        }

        public void loadResults(string src, string dest, int time, int cost, string tr) // Creates and Executes SELECT queries with parameter values.
        {
            if (tr == "BUS")// Executes the query for the Bus table only
            {
                foreach (Transport s in myBus)
                {
                    if(s.Source == src && s.Destination == dest && s.Time <= time && s.Cost <= cost)
                    {
                        string str = s.Source + "," + s.Destination +"," + s.Time.ToString() +"," + s.Cost.ToString() + "," + "Bus";
                        this.resultSet.Add(str);
                    }
                }
            }
            else if (tr == "TRAIN")// Executes the query for the Train table only
            {
                foreach (Transport s in myTrain)
                {
                    if (s.Source == src && s.Destination == dest && s.Time <= time && s.Cost <= cost)
                    {
                        string str = s.Source + "," + s.Destination + "," + s.Time.ToString() + "," + s.Cost.ToString() + "," + "Train";
                        this.resultSet.Add(str);
                    }
                }
            }
            else if (tr == "PLANE")  // Executes the query for the Plane table only
            {
                foreach (Transport s in myPlane)
                {
                    if (s.Source == src && s.Destination == dest && s.Time <= time && s.Cost <= cost)
                    {
                        string str = s.Source + "," + s.Destination + "," + s.Time.ToString() + "," + s.Cost.ToString() + "," + "Plane";
                        this.resultSet.Add(str);
                    }
                }
            }
            else if (tr == "LAUNCH")  // Executes the query for the Launch table only
            {
                foreach (Transport s in myLaunch)
                {
                    if (s.Source == src && s.Destination == dest && s.Time <= time && s.Cost <= cost)
                    {
                        string str = s.Source + "," + s.Destination + "," + s.Time.ToString() + "," + s.Cost.ToString() + "," + "Launch";
                        this.resultSet.Add(str);
                    }
                }
            }
            else if (tr == "NULL") //Executes query for all the tables one by one
            {
                foreach (Transport s in myBus)
                {
                    if (s.Source == src && s.Destination == dest && s.Time <= time && s.Cost <= cost)
                    {
                        string str = s.Source + "," + s.Destination + "," + s.Time.ToString() + "," + s.Cost.ToString() + "," + "Bus";
                        this.resultSet.Add(str);
                    }
                }
                foreach (Transport s in myTrain)
                {
                    if (s.Source == src && s.Destination == dest && s.Time <= time && s.Cost <= cost)
                    {
                        string str = s.Source + "," + s.Destination + "," + s.Time.ToString() + "," + s.Cost.ToString() + "," + "Train";
                        this.resultSet.Add(str);
                    }
                }
                foreach (Transport s in myPlane)
                {
                    if (s.Source == src && s.Destination == dest && s.Time <= time && s.Cost <= cost)
                    {
                        string str = s.Source + "," + s.Destination + "," + s.Time.ToString() + "," + s.Cost.ToString() + "," + "Plane";
                        this.resultSet.Add(str);
                    }
                }
                foreach (Transport s in myLaunch)
                {
                    if (s.Source == src && s.Destination == dest && s.Time <= time && s.Cost <= cost)
                    {
                        string str = s.Source + "," + s.Destination + "," + s.Time.ToString() + "," + s.Cost.ToString() + "," + "Launch";
                        this.resultSet.Add(str);
                    }
                }
            }
        }
    }
}
