﻿using System;
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
            PRDatabaseManager.Instance().FillParticipant(ds);
            PRDatabaseManager.Instance().FillSponsor(ds);

            lstRace.DataSource = ds;
            lstRace.DisplayMember = "Sponsor.SponsorName";
            lstRace.ValueMember = "Sponsor.SponsorId";

            lstParticipants.DataSource = ds;
            lstParticipants.DisplayMember = "Participant.FullName";
            lstParticipants.ValueMember = "Participant.SponsorId";
            lstParticipants.DataBindings.Add("SelectedValue", ds, "Sponsor.SponsorId");

            lblCash.DataBindings.Add("Text",dsRes,"Result.winnings");
        }
    }
}
