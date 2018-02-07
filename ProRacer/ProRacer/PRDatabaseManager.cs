﻿using System;
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

        public DataSet Participant { get; set; }
        public DataSet Race { get; set; }
        public DataSet Sponsor { get; set; }
        public DataSet Result { get; set; }

        private PRDatabaseManager(string url)
        {
            //this.conn = new SqlConnection(url);
            //SqlCommand cmmd = new SqlCommand("SELECT * FROM Participant", conn);
            //SqlDataAdapter da = new SqlDataAdapter(cmmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds, "Country");

            SqlConnection conn = new SqlConnection("Data Source=sqlserver.cv4bnwlhigjt.ca-central-1.rds.amazonaws.com,1433;Initial Catalog=ProRacer;User ID=singemazuo;Password=z28397562");
            SqlCommand cmmd = new SqlCommand("SELECT * FROM Participant", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmmd);
            Participant = new DataSet();
            da.Fill(Participant, "Participant");
            
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
