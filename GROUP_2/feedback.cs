using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace GROUP_2
{
    
    public partial class feedback : Form
    {
        
        String connectionString = @"DATA SOURCE =localhost:1521/XE;USER ID =F223722; PASSWORD=f223722";
        public feedback()
        {
            InitializeComponent();
        }

        private void feedbackView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void feedback_Load(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {

                connection.Open();
                string query = "SELECT USERID,FEEDBACK FROM F223722.PASSENGER";

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    DataTable dataTable = new DataTable();

                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    adapter.Fill(dataTable);

                    feedbackView.DataSource = dataTable;
                }
            }

        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void search_Click(object sender, EventArgs e)
        {
            
            DataTable RETRIVEbyID(int userID)
            {
                DataTable dataTable = new DataTable();

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    string query = "SELECT USERID,FEEDBACK FROM F223722.PASSENGER WHERE USERID = :userID";
                    OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.Add(":USERID", userID);
                    adapter.Fill(dataTable);
                }

                return dataTable;
            }
            DataTable dt = RETRIVEbyID(int.Parse(inputBox.Text));
            feedbackView.DataSource = dt;

        }
    }
}
