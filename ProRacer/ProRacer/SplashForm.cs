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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ((Timer)sender).Stop();
            Close();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            laProductName.Text = Application.ProductName;
        }
    }
}
