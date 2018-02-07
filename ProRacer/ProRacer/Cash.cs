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
            DataSet dsSpo = PRDatabaseManager.Instance().sponsor;
            DataSet dsPar = PRDatabaseManager.Instance().participant;
            //DataSet ds = PRDatabaseManager.Instance().SponsorWithParticipant("Cash");

            lstRace.DataSource = dsSpo;
            lstRace.DisplayMember = "Sponsor.SponsorName";
            lstRace.ValueMember = "Sponsor.SponsorId";
            lstRace.DataBindings.Add("SelectedValue", dsPar, "Cash.SponsorId");

            lstParticipants.DataSource = dsPar;
            lstParticipants.DisplayMember = "Cash.FullName";
        }
    }
}
