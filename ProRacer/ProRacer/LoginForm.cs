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
        private SqlConnection conn;
        private SqlDataAdapter daAuthen;
        private SqlCommand cmmd;

        public LoginForm()
        {
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

                this.conn.Open();
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
            finally
            {
                this.conn.Close();
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.conn = new SqlConnection("server=(local);Database=ProRacer;integrated security=SSPI");
            this.cmmd = new SqlCommand();
            this.daAuthen = new SqlDataAdapter();
            this.cmmd.Connection = conn;
            this.daAuthen.SelectCommand = this.cmmd;
        }
    }
}
