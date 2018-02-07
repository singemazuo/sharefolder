using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProRacer
{
    public partial class Cash : Form
    {
        public Cash()
        {
            InitializeComponent();
        }

        private void Cash_Load(object sender,EventArgs e)
        {
            DataSet ds = PRDatabaseManager.Instance().race;
            lstRace.DataSource = ds;
            lstRace.DisplayMember = "Race.Name";
            lstRace.ValueMember = "Race.RaceId";
            lstRace.DataBindings.Add("SelectedValue", PRDatabaseManager.Instance().participant, "Result.RaceId");


        }

        private void lstRace_SelectedValueChanged(object sender, EventArgs e)
        {
            DataSet ds = PRDatabaseManager.Instance().participant;
            lstParticipants.DataSource = ds;
            lstParticipants.DisplayMember = "Participant.FirstName + ',' + Participant.LastName AS Full";
        }
    }
}
