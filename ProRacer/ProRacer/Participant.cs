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
        private SqlConnection conn;
        private SqlDataAdapter daAuthen;
        private SqlCommand cmmd;

        public Participant()
        {
            InitializeComponent();
        }

        private void Participant_Load(object sender, EventArgs e)
        {
            this.conn = new SqlConnection("server=sqlserver.cv4bnwlhigjt.ca-central-1.rds.amazonaws.com;Database=ProRacer;integrated security=false;User ID=singemazuo;Password=z28397562");
            this.cmmd = new SqlCommand();
            this.daAuthen = new SqlDataAdapter();
            this.cmmd.Connection = conn;
            this.daAuthen.SelectCommand = this.cmmd;
            this.conn.Open();
            this.cmmd.CommandText = "SELECT * FROM Participant";

            lstSearch.DataBindings.Add("DataSource",this.daAuthen);
            //SqlDataReader dr = this.cmmd.ExecuteReader();
            //if (dr.Read())
            //{
            //    dr.Close();
            //}
        }
    }
}
