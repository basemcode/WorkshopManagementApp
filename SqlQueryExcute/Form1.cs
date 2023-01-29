using System.Data.SqlClient;

namespace SqlQueryExcute
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckDatabaseExists();
        }
        public void CheckDatabaseExists()
        {
            string databaseName = "Workshop";
            string sqlCreateDBQuery;
            bool result = false;

            try
            {
                SqlConnection tmpConn = new SqlConnection("server=(local)\\SQLEXPRESS;Trusted_Connection=yes");

                sqlCreateDBQuery = richTextBox1.Text;
                    //string.Format("SELECT database_id FROM sys.databases WHERE Name = '{0}'", databaseName);

                using (tmpConn)
                {
                    using (SqlCommand sqlCmd = new SqlCommand(sqlCreateDBQuery, tmpConn))
                    {
                        tmpConn.Open();

                        object resultObj = sqlCmd.ExecuteNonQuery();

                        /*int databaseID = 0;

                        if (resultObj != null)
                        {
                            int.TryParse(resultObj.ToString(), out databaseID);
                        }
*/
                        tmpConn.Close();

                        //result = (databaseID > 0);
                    }
                }
            }
            catch (Exception ex)
            {
                //result = false;
            }

            //return result;
        }
    }
}