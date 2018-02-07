using System;
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
    public partial class Participant : Form
    {

        public Participant()
        {
            InitializeComponent();
        }

        private void Participant_Load(object sender, EventArgs e)
        {
            DataSet ds = PRDatabaseManager.Instance().participant;
            lstSearch.DataSource = ds;
            lstSearch.DisplayMember = "Participant.FullName";
            lstSearch.ValueMember = "Participant.ParticipantId";
            lstSearch.DataBindings.Add("SelectedValue",ds,"Participant.ParticipantId");


        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
