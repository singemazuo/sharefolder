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
        private DataSet _participant,_race,_sponsor,_result,_ds;

        public DataSet participant {
            get
            {
                if (_participant == null)
                {
                    SqlCommand cmmd = new SqlCommand("SELECT *, FirstName + ',' + LastName AS [FullName] FROM Participant ORDER BY FirstName, LastName", conn);
                    SqlDataAdapter dapater = new SqlDataAdapter(cmmd);
                    _participant = new DataSet();
                    dapater.Fill(_participant, "Participant");
                }
                return _participant;
            }
        }

        public DataSet race {
            get
            {
                if (_race == null)
                {
                    SqlCommand cmmd = new SqlCommand("SELECT * FROM Race", conn);
                    SqlDataAdapter dapater = new SqlDataAdapter(cmmd);
                    _race = new DataSet();
                    dapater.Fill(_race, "Race");
                }
                return _race;
            }
        }

        public DataSet sponsor {
            get
            {
                if (_sponsor == null)
                {
                    SqlCommand cmmd = new SqlCommand("SELECT * FROM Sponsor ORDER BY SponsorName", conn);
                    SqlDataAdapter dapater = new SqlDataAdapter(cmmd);
                    _sponsor = new DataSet();
                    dapater.Fill(_sponsor, "Sponsor");
                }
                return _sponsor;
            }
        }
        public DataSet result {
            get
            {
                if (_result == null)
                {
                    SqlCommand cmmd = new SqlCommand("SELECT * FROM Results", conn);
                    SqlDataAdapter dapater = new SqlDataAdapter(cmmd);
                    _result = new DataSet();
                    dapater.Fill(_result, "Result");
                }
                return _result;
            }
        }

        public DataSet ds {
            get
            {
                if (_ds == null)
                {
                    SqlCommand cmmd = new SqlCommand("SELECT * FROM Results", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
                    _ds = new DataSet();
                    adapter.Fill(_ds, "Result");

                    cmmd = new SqlCommand("SELECT * FROM Sponsor ORDER BY SponsorName", conn);
                    adapter = new SqlDataAdapter(cmmd);
                    adapter.Fill(_ds, "Sponsor");

                    cmmd = new SqlCommand("SELECT * FROM Race", conn);
                    adapter = new SqlDataAdapter(cmmd);
                    adapter.Fill(_race, "Race");
                }
                return _ds;
            }
        }

        private PRDatabaseManager()
        {
            //this.conn = new SqlConnection(url);
            //SqlCommand cmmd = new SqlCommand("SELECT * FROM Participant", conn);
            //SqlDataAdapter da = new SqlDataAdapter(cmmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds, "Country");

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
