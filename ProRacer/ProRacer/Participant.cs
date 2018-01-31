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

namespace ProRacer
{
    public partial class Participant : Form
    {
        private PRDatabaseManager dbContext;

        public Participant()
        {
            InitializeComponent();
        }

        private void Participant_Load(object sender, EventArgs e)
        {
            // dbContext = PRDatabaseManager.Create();
            SqlConnection conn = new SqlConnection("Data Source=sqlserver.cv4bnwlhigjt.ca-central-1.rds.amazonaws.com,1433;Initial Catalog=ProRacer;User ID=singemazuo;Password=z28397562");
            SqlCommand cmmd = new SqlCommand("SELECT * FROM Participant",conn);
            SqlDataAdapter da = new SqlDataAdapter(cmmd);
            DataSet ds = new DataSet();
            da.Fill(ds,"Country");

            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
