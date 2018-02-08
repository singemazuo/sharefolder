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
            DataSet ds = new DataSet();
            PRDatabaseManager.Instance().FillSponsor(ds);
            PRDatabaseManager.Instance().FillParticipant(ds);
            PRDatabaseManager.Instance().FillResult(ds);

            lstRace.DataSource = ds.Tables["Sponsor"];
            lstRace.DisplayMember = "Sponsor.SponsorName";
            lstRace.ValueMember = "Sponsor.SponsorId";
            lstRace.DataBindings.Add("SelectedValue", ds.Tables["Participant"], "SponsorId");

            lstParticipants.DataSource = ds;
            lstParticipants.DisplayMember = "Participant.FullName";
            lstParticipants.ValueMember = "Participant.ParticipantId";
            lstParticipants.DataBindings.Add("SelectedValue", ds, "Result.ParticipantId");

            lblCash.DataBindings.Add("Text",ds,"Result.winnings");
        }
    }
}
