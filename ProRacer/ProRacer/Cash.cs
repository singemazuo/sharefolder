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
            DataSet dsPar = PRDatabaseManager.Instance().participant;
            DataSet dsRes = PRDatabaseManager.Instance().result;
            //DataSet ds = PRDatabaseManager.Instance().SponsorWithParticipant("Cash");

            lstRace.DataSource = dsSpo;
            lstRace.DisplayMember = "Sponsor.SponsorName";
            lstRace.ValueMember = "Sponsor.SponsorId";

            lstParticipants.DataSource = dsPar;
            lstParticipants.DisplayMember = "Participant.FullName";
            lstParticipants.ValueMember = "Participant.SponsorId";
            lstParticipants.DataBindings.Add("SelectedValue", dsSpo, "Sponsor.SponsorId");

            lblCash.DataBindings.Add("Text",dsRes,"Result.winnings");
        }
    }
}
