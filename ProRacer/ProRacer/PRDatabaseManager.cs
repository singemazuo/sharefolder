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
        private DataSet _participant,_race,_sponsor,_result;

        public DataSet participant {
            get
            {
                if (_participant == null)
                {
                    SqlCommand cmmd = new SqlCommand("SELECT LastName, FirstName, FirstName + ',' + LastName AS [FullName], Country, Rank, Gender, IACMember, ParticipantId, SponsorId FROM Participant", conn);
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
                    SqlCommand cmmd = new SqlCommand("SELECT * FROM Sponsor", conn);
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

        public DataSet SponsorWithParticipant()
        {

        }
    }
}
