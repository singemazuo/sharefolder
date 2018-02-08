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
    public partial class LoginForm : Form
    {
        private SqlDataAdapter daAuthen;
        private SqlCommand cmmd;
        private MainForm mainForm;
        private int times = 0;

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
                if (times < 3)
                {
                    
                    if (Authenticate())
                    {
                        Properties.Settings.Default.Userid = TxtUserName.Text;
                        Properties.Settings.Default.Password = TxtPassword.Text;

                        Close();
                    }
                    else
                    {
                        MessageBox.Show("You haven't owned an account!!");
                    }

                    times++;
                }
                else
                {
                    MessageBox.Show("Over three times, you missed your money!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection("server=(local);Database=ProRacer;integrated security=SSPI");
            //this.cmmd = new SqlCommand("",conn);
            //this.daAuthen = new SqlDataAdapter();
            //this.daAuthen.SelectCommand = this.cmmd;
        }

        private bool Authenticate()
        {
            DataSet ds = new DataSet();
            PRDatabaseManager.Instance().FillAuthen(ds, TxtUserName.Text, TxtPassword.Text);

            return ds.Tables[0].Rows.Count > 0;
        }
    }
}
