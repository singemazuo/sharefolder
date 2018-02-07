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
            lstRace.DataSource = PRDatabaseManager.Instance().race;
            lstRace.DisplayMember = "";
        }

    }
}
