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
            LoginForm form2 = new LoginForm();
            DialogResult result = form2.ShowDialog();
            Console.WriteLine();
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}
