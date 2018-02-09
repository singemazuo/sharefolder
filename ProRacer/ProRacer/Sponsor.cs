using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProRacer
{
    public partial class Sponsor : Form
    {
        private IAdjustStatusBar adjStatusBar;

        public Sponsor(IAdjustStatusBar adjust)
        {
            adjStatusBar = adjust;

            InitializeComponent();
        }

        private void Sponsor_Load(object sender, EventArgs e)
        {
            adjStatusBar.AdjustLoadStatus(0);

            DataSet ds = new DataSet();
            PRDatabaseManager.Instance().FillSponsor(ds);

            lstSearch.DataSource = ds;
            lstSearch.DisplayMember = "Sponsor.SponsorName";

            txtName.DataBindings.Add("Text",ds,"Sponsor.SponsorName");
            txtAddress.DataBindings.Add("Text",ds,"Sponsor.Address");

            adjStatusBar.AdjustLoadStatus(1);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            lstSearch.SelectedIndex = lstSearch.Items.Count - 1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lstSearch.SelectedIndex < lstSearch.Items.Count - 1)
            {
                lstSearch.SelectedIndex++;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (lstSearch.SelectedIndex > 0)
            {
                lstSearch.SelectedIndex--;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            lstSearch.SelectedIndex = 0;
        }

        private void lstSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            adjStatusBar.AdjustPosition(lstSearch.SelectedIndex+1,lstSearch.Items.Count);
        }
    }
}
