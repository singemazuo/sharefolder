using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ProRacer
{
    public interface IDataValidation
    {
        Boolean Validation(__arglist);
    }

    public class PRDatabaseManager
    {
        private static PRDatabaseManager _instance = null;
        private SqlConnection conn;

        public IDataValidation iDataValidation = null;

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

        public void FillAuthen(DataSet ds,string user = null,string password = null)
        {
            string query = "SELECT * FROM Authenticate";
            if (user != null && password != null)
            {
                query = "SELECT * FROM Authenticate WHERE Userid = '" + user + "' AND Password = '" + password + "'";
            }
            SqlCommand cmmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            adapter.Fill(ds, "Authen");
        }

        public void FillParticipantWithSponsor(DataSet ds,string name = "ParticipantWithSponsor")
        {
            SqlCommand cmmd = new SqlCommand("SELECT *, FirstName + ',' + LastName AS [FullName] FROM Participant LEFT JOIN Sponsor ON Participant.SponsorId = Sponsor.SponsorId ORDER BY FirstName, LastName", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            adapter.Fill(ds, name);

            if (iDataValidation)
            {

            }
        }

        private PRDatabaseManager()
        {
            //conn = new SqlConnection(Properties.Settings.Default.SqlServerHost);
            conn = new SqlConnection("Data Source=sqlserver.cv4bnwlhigjt.ca-central-1.rds.amazonaws.com,1433;Initial Catalog=ProRacer;User ID=singemazuo;Password=z28397562");
        }

        public static PRDatabaseManager Instance()
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
