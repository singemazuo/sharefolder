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
    public interface IAdjustStatusBar
    {
        void AdjustPosition(int index, int size);
        void AdjustLoadStatus(int status);
    }

    public partial class MainForm : Form, IAdjustStatusBar
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetUpStatusStrip();

            SplashForm splash = new SplashForm();
            splash.ShowDialog();

            if (Properties.Settings.Default.Password == null || Properties.Settings.Default.Password.Length <= 0)
            {
                LoginForm loginForm = new LoginForm(this);
                DialogResult result = loginForm.ShowDialog();
                if(result == DialogResult.Cancel)
                {
                    Close();
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenHelpForm();
        }

        private void sponsorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSponsorForm();
        }

        private void raceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenRaceForm();
        }

        private void participantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenParticipantForm();
        }

        private void toolStripBtnHelp_Click(object sender, EventArgs e)
        {
            OpenHelpForm();
        }

        private void toolStripBtnParticipant_Click(object sender, EventArgs e)
        {
            OpenParticipantForm();
        }

        private void toolStripBtnRace_Click(object sender, EventArgs e)
        {
            OpenRaceForm();
        }

        private void toolStripBtnSponsor_Click(object sender, EventArgs e)
        {
            OpenSponsorForm();
        }

        #region "SetUpStatusStrip"
        private void SetUpStatusStrip()
        {
            statusStrip1.LayoutStyle = ToolStripLayoutStyle.Table;

            toolStripStatusLabel1.Text = System.DateTime.Now.ToShortTimeString();
            toolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft;
            toolStripStatusLabel1.BorderSides = ToolStripStatusLabelBorderSides.Right;

            toolStripStatusLabel2.Text = Properties.Settings.Default.Userid;
            toolStripStatusLabel2.TextAlign = ContentAlignment.MiddleLeft;
            toolStripStatusLabel2.BorderSides = ToolStripStatusLabelBorderSides.Right;

            toolStripStatusLabel3.Text = "Position: 0 of 0";
            toolStripStatusLabel3.TextAlign = ContentAlignment.MiddleLeft;
            toolStripStatusLabel3.BorderSides = ToolStripStatusLabelBorderSides.Right;

            toolStripStatusLabel4.Text = "OK";
            toolStripStatusLabel4.TextAlign = ContentAlignment.MiddleRight;
        }
        #endregion

        private void OpenHelpForm()
        {
            SplashForm help = new SplashForm();
            help.ShowDialog();
        }

        private void OpenRaceForm()
        {
            tabControl.TabPages.Add(new Race(this));
        }

        private void OpenParticipantForm()
        {
            tabControl.TabPages.Add(new Participant(this));
        }

        private void OpenSponsorForm()
        {
            tabControl.TabPages.Add(new Sponsor(this));
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Clear();
        }

        #region interface
        public void AdjustPosition(int index, int size)
        {
            toolStripStatusLabel3.Text = "Position: "+ index + " of "+ size;
        }

        public void AdjustLoadStatus(int status)
        {
            if (status == 0)
            {
                toolStripStatusLabel4.Text = "Ready";
            }
            else
            {
                toolStripStatusLabel4.Text = "Ok";
            }
        }
        #endregion
    }
}
