﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SplashForm splash = new SplashForm();
            splash.ShowDialog();
        }

        private void cashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //tabControl.TabPages.Add(new Cash());
        }

        private void sponsorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Add();
        }

        private void raceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
