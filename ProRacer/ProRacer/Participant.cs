using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProRacer
{
    public partial class Participant : Form
    {

        private DataSet ds = new DataSet();
        private IAdjustStatusBar adjustStatusBar;
   
        public Participant(IAdjustStatusBar adjust)
        {
            adjustStatusBar = adjust;

            InitializeComponent();
        }

        private void frmRacers_Load(object sender, EventArgs e)
        {
            adjustStatusBar.AdjustLoadStatus(0);

            //PRDatabaseManager.Instance().FillParticipantWithSponsor(ds, "PS");
            PRDatabaseManager.Instance().FillParticipant(ds);
            PRDatabaseManager.Instance().FillSponsor(ds);

            cmbParticipants.DataSource = ds;
            cmbParticipants.DisplayMember = "Participant.FullName";
            cmbParticipants.ValueMember = "Participant.PK_ParticipantId";
            cmbParticipants.DataBindings.Add("SelectedValue", ds, "Participant.FK_ParticipantId");

            txtFirstName.DataBindings.Add("Text",ds, "Participant.FirstName");

            txtLastName.DataBindings.Add("Text",ds, "Participant.LastName");

            cmbCountry.DataSource = ds;
            cmbCountry.DisplayMember = "Participant.Country";

            txtRank.DataBindings.Add("Text",ds, "Participant.Rank");

            cmbSponsor.DataSource = ds;
            cmbSponsor.DisplayMember = "Sponsor.SponsorName";
            cmbSponsor.ValueMember = "Sponsor.SponsorId";

            txtGender.DataBindings.Add("Text",ds, "Participant.Gender");

            chkMember.DataBindings.Add("Checked",ds, "Participant.IACMember");

            adjustStatusBar.AdjustLoadStatus(1);
        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {
            if (txtGender.Text == "F")
            {
                rdoFemale.Checked = true;
            }
            else if (txtGender.Text == "M")
            {
                rdoMale.Checked = true;
            }
            else
            {
                rdoOther.Checked = true;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            cmbParticipants.SelectedIndex = cmbParticipants.Items.Count - 1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cmbParticipants.SelectedIndex < cmbParticipants.Items.Count - 1)
            {
                cmbParticipants.SelectedIndex++;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (cmbParticipants.SelectedIndex > 0)
            {
                cmbParticipants.SelectedIndex--;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            cmbParticipants.SelectedIndex = 0;
        }

        private void cmbParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            adjustStatusBar.AdjustPosition(cmbParticipants.SelectedIndex+1,cmbParticipants.Items.Count);
        }
    }
}