using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region initliazation data
        // try
        //     {

        //     }
        //     catch(SqlException ex)
        //     {
                    // MessageBox.Show(ex.Message,ex.GetType().ToString());
        //     }
        private void RetrieveFamilyWithCriteria(string criteria)
        {
            try
            {
                string statement = string.Format("SELECT * FROM Family WHERE FamName LIKE ('{0}%') OR FamName LIKE ('%{0}%') OR FamName LIKE ('{0}') ORDER BY FamName",criteria);
                DataSet ds = GetData(statement,"fam");

                lstFamily.DataSource = ds;
                lstFamily.DisplayMember = "fam.FamName";
                lstFamily.ValueMember = "fam.FamNo";

                txtStreet.DataBindings.Add("Text",ds,"fam.FamAddress");

                txtCity.DataBindings.Add("Text",ds,"fam.FamCity");

                Frame1.Visible = true;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message,ex.GetType().ToString());
            }
        }

        private void RetrieveChildrenWithFamNo(string famNo)
        {
            try
            {
                string statement = string.Format("SELECT * FROM Member WHERE FamNo = '{0}' ORDER BY MemName",famNo);
                DataSet ds = GetData(statement,"mem");

                dgvChildren.DataSource = ds;
                dgvChildren.DataMember = "mem";

                if(!Frame2.Visible)Frame2.Visible = true;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message,ex.GetType().ToString());
            }
        }

        #endregion

        #region data operating
        public static DataSet GetData(string statement, string name = null)
        {
            //SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnString);
            SqlConnection conn = new SqlConnection("server=sqlserver.cv4bnwlhigjt.ca-central-1.rds.amazonaws.com,1433;database=CHURCH;User ID=singemazuo;Password=z28397562");
            SqlCommand cmmd = new SqlCommand(statement, conn);
            SqlDataAdapter adpt = new SqlDataAdapter(cmmd);
            DataSet ds = new DataSet();
            using (conn)
            {
                if (name != null)
                    adpt.Fill(ds, name);
                else
                    adpt.Fill(ds);
            }
            return ds;
        }

        public static int SendData(string statement)
        {
            // SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnString);
            SqlConnection conn = new SqlConnection("server=sqlserver.cv4bnwlhigjt.ca-central-1.rds.amazonaws.com,1433;database=CHURCH;User ID=singemazuo;Password=z28397562");
            SqlCommand cmmd = new SqlCommand(statement, conn);

            int res = 0;
            using (conn)
            {
                conn.Open();
                res = cmmd.ExecuteNonQuery();
                conn.Close();
            }
            return res;
        }
        #endregion

        #region Button Click
        private void ButtonGo_Click(object sender, EventArgs args)
        {
            if(!Validation())return;

            string criteria = txtCriteria.Text;
            RetrieveFamilyWithCriteria(criteria);
        }
        #endregion

        #region Validation
        private bool Validation()
        {
            return true;
        }
        #endregion

        #region Family List Event Handler
        private void Family_SelectedValueChanged(object sender,EventArgs arg)
        {
            RetrieveChildrenWithFamNo(lstFamily.SelectedValue.ToString());
        }
        #endregion
    }
}
