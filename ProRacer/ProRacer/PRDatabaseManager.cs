using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ProRacer
{
    public interface IPRDataCommands
    {
        
    }

    public class PRDatabaseManager
    {
        private static PRDatabaseManager _instance;
        private SqlConnection conn;

        public DataSet participant { get; set; }
        public DataSet race { get; set; }
        public DataSet sponsor { get; set; }
        public DataSet result { get; set; }

        private PRDatabaseManager(string url)
        {
            //this.conn = new SqlConnection(url);
            //SqlCommand cmmd = new SqlCommand("SELECT * FROM Participant", conn);
            //SqlDataAdapter da = new SqlDataAdapter(cmmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds, "Country");

            SqlConnection conn = new SqlConnection("Data Source=sqlserver.cv4bnwlhigjt.ca-central-1.rds.amazonaws.com,1433;Initial Catalog=ProRacer;User ID=singemazuo;Password=z28397562");
            SqlCommand cmmd = new SqlCommand("SELECT * FROM Participant", conn);
            SqlDataAdapter dapater = new SqlDataAdapter(cmmd);
            participant = new DataSet();
            dapater.Fill(participant, "Participant");

            cmmd = new SqlCommand("SELECT * FROM Race",conn);
            dapater = new SqlDataAdapter(cmmd);
            race = new DataSet();
            dapater.Fill(race,"Race");

            cmmd = new SqlCommand("SELECT * FROM Sponsor", conn);
            dapater = new SqlDataAdapter(cmmd);
            sponsor = new DataSet();
            dapater.Fill(sponsor,"Sponsor");
        }

        public static PRDatabaseManager instance(string url = "Data Source=sqlserver.cv4bnwlhigjt.ca-central-1.rds.amazonaws.com,1433;Initial Catalog=ProRacer;User ID=singemazuo;Password=z28397562")
        {
            if(_instance == null)
            {
                _instance = new PRDatabaseManager(url);
            }
            return _instance;
        }
    }
}
