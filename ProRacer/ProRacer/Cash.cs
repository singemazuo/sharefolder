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

            lstRace.DataSource = ds;
            lstRace.DisplayMember = "Sponsor.SponsorName";
            lstRace.ValueMember = "Sponsor.SponsorId";
            lstRace.DataBindings.Add("SelectedValue", ds, "Participant.SponsorId");

            PRDatabaseManager.Instance().FillParticipant(ds);
            lstParticipants.DataSource = ds;
            lstParticipants.DisplayMember = "Participant.FullName";
            lstParticipants.ValueMember = "";

            PRDatabaseManager.Instance().FillResult(ds);
            lblCash.DataBindings.Add("Text",ds,"Result.winnings");
        }
    }
}
