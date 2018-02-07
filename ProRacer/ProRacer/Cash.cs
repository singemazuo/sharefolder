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
            DataSet dsSponsor = PRDatabaseManager.Instance().sponsor;
            lstRace.DataSource = dsSponsor;
            lstRace.DisplayMember = "Sponsor.SponsorName";
            lstRace.ValueMember = "Sponsor.SponsorId";
            lstRace.DataBindings.Add("SelectedValue", PRDatabaseManager.Instance().participant, "Participant.SponsorId");


        }

        private void lstRace_SelectedValueChanged(object sender, EventArgs e)
        {
            DataSet ds = PRDatabaseManager.Instance().participant;
            lstParticipants.DataSource = ds;
            lstParticipants.DisplayMember = "Participant.FirstName";
        }
    }
}
