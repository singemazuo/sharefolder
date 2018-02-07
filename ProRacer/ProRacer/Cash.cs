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
            //DataSet dsSpo = PRDatabaseManager.Instance().sponsor;
            //DataSet dsPar = PRDatabaseManager.Instance().participant;
            DataSet ds = PRDatabaseManager.Instance().SponsorWithParticipant("Cash");

            lstRace.DataSource = ds;
            lstRace.DisplayMember = "Cash.SponsorName";
            lstRace.ValueMember = "Cash.SponsorId";
            lstRace.DataBindings.Add("SelectedValue", ds, "Cash.SponsorId");

            lstParticipants.DataSource = ds;
            lstParticipants.DisplayMember = "Participant.FullName";
        }
    }
}
