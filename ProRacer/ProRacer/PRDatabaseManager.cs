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
        private static PRDatabaseManager _instance = null;
        private SqlConnection conn;

        public void FillRace(DataSet ds)
        {
            SqlCommand cmmd = new SqlCommand("SELECT * FROM Race", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            adapter.Fill(ds, "Race");
        }

        public void FillParticipant(DataSet ds)
        {
            SqlCommand cmmd = new SqlCommand("SELECT *, FirstName + ',' + LastName AS [FullName] FROM Participant ORDER BY FirstName, LastName", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            adapter.Fill(ds, "Participant");
        }

        public void FillResult(DataSet ds)
        {
            SqlCommand cmmd = new SqlCommand("SELECT * FROM Results", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            adapter.Fill(ds, "Result");
        }

        public void FillSponsor(DataSet ds)
        {
            SqlCommand cmmd = new SqlCommand("SELECT * FROM Sponsor ORDER BY SponsorName", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            adapter.Fill(ds, "Sponsor");
        }

        private PRDatabaseManager()
        {
            conn = new SqlConnection("Data Source=sqlserver.cv4bnwlhigjt.ca-central-1.rds.amazonaws.com,1433;Initial Catalog=ProRacer;User ID=singemazuo;Password=z28397562");   
        }

        public static PRDatabaseManager Instance(string url = "Data Source=sqlserver.cv4bnwlhigjt.ca-central-1.rds.amazonaws.com,1433;Initial Catalog=ProRacer;User ID=singemazuo;Password=z28397562")
        {
            if(_instance == null)
            {
                _instance = new PRDatabaseManager();
            }
            return _instance;
        }

        public DataSet SponsorWithParticipant(string name = null)
        {
            SqlCommand cmmd = new SqlCommand("SELECT Sponsor.SponsorId AS PKSponsorId,Participant.SponsorId AS FKSponsorId,SponsorName,LastName + ',' + FirstName AS FullName FROM Sponsor,Participant", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            DataSet ds = new DataSet();
            if (name != null)
                adapter.Fill(ds, name);
            else
                adapter.Fill(ds);
            return ds;
        }
    }
}
