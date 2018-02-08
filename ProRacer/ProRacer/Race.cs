using System;
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
        private IAdjustStatusBar adjustStatusBar;

        public Race(IAdjustStatusBar adjust)
        {
            adjustStatusBar = adjust;

            InitializeComponent();
        }

        public void Race_Load(Object sender, EventArgs e)
        {
            adjustStatusBar.AdjustLoadStatus(0);

            DataSet ds = new DataSet();
            PRDatabaseManager.Instance().FillRace(ds);

            cmbSearch.DataSource = ds;
            cmbSearch.DisplayMember = "Race.Name";

            dtpRaceDate.DataBindings.Add("Value",ds,"Race.RaceDate");

            txtRaceName.DataBindings.Add("Text",ds,"Race.Name");

            txtRaceDistance.DataBindings.Add("Text",ds,"Race.Distance");

            cmbLocation.DataSource = ds;
            cmbLocation.DisplayMember = "Race.Location";

            txtStart.DataBindings.Add("Text",ds,"Race.StartPoint");

            txtFinish.DataBindings.Add("Text",ds,"Race.FinishPoint");

            txtLevel.DataBindings.Add("Text",ds,"Race.Level");

            adjustStatusBar.AdjustLoadStatus(1);
        }

        private void txtLevel_TextChanged(object sender, EventArgs e)
        {
            if (txtLevel.Text == "C")
            {
                optLevelC.Checked = true;
            }
            else if (txtLevel.Text == "B")
            {
                optLevelB.Checked = true;
            }
            else if (txtLevel.Text == "A")
            {
                optLevelA.Checked = true;
            }
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            adjustStatusBar.AdjustPosition(cmbSearch.SelectedIndex+1, cmbSearch.Items.Count);
        }
    }
}
