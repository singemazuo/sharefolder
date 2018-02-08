﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProRacer
{
    public partial class Participant : Form
    {

        private DataSet ds = new DataSet();
   
        public Participant()
        {
            InitializeComponent();
        }

        private void frmRacers_Load(object sender, EventArgs e)
        {
            PRDatabaseManager.Instance().FillParticipant(ds);

            cmbParticipants.DataSource = ds;
            cmbParticipants.DisplayMember = "Participant.FullName";
            cmbParticipants.ValueMember = "Participant.ParticipantId";
        }
    }
}