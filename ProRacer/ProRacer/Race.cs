﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProRacer
{
    public partial class Race : Form
    {
        public Race()
        {
            InitializeComponent();
        }

        public void Race_Load(Object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.SqlConnectionString);
            SqlCommand command = new SqlCommand("SELECT * FROM Race",conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataSet ds = new DataSet();

            try
            {
                adapter.Fill(ds,"LocalRace");

                if(ds.Tables.Count > 0)
                {
                    cmbSearch.DataSource = ds;
                    cmbSearch.DisplayMember = "LocalRace.Name";
                }

                //dtpRaceDate.DataBindings.Add("Text",ds,"RaceDate");

            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
