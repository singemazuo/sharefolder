﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProRacer
{
    public partial class LoginForm : Form
    {
        private SqlDataAdapter daAuthen;
        private SqlCommand cmmd;
        private MainForm mainForm;

        public LoginForm(MainForm form)
        {
            this.mainForm = form;

            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                PRDatabaseManager.Instance().FillAuthen(ds, TxtUserName.Text, TxtPassword.Text);
                this.cmmd.CommandText = "SELECT * FROM Authenticate WHERE Userid = '" + TxtUserName.Text + "' AND Password = '" + TxtPassword.Text + "'";
                SqlDataReader dr = this.cmmd.ExecuteReader();
                if (dr.Read())
                {
                    if (CbxPassword.Checked)
                    {
                        Properties.Settings.Default[TxtUserName.Text] = TxtPassword.Text;
                    }
                    else
                    {
                        Properties.Settings.Default[TxtUserName.Text] = string.Empty;
                    }
                    
                }
                else
                {
                    MessageBox.Show("You haven't owned an account!!");
                }
            }
            catch (Exception ex)
            {

            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=(local);Database=ProRacer;integrated security=SSPI");
            this.cmmd = new SqlCommand("",conn);
            this.daAuthen = new SqlDataAdapter();
            this.daAuthen.SelectCommand = this.cmmd;
        }
    }
}
