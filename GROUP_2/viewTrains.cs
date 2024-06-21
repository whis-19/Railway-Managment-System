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
    public partial class viewTrains : Form
    {
        TrainDBMS trainDBMSobj = new TrainDBMS();
        String connectionString = @"DATA SOURCE =localhost:1521/XE;USER ID =F223722; PASSWORD=f223722";

        public viewTrains()
        {
            InitializeComponent();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void taskDeadline_Click(object sender, EventArgs e)
        {

        }

        private void assignTask_Click(object sender, EventArgs e)
        {
            trainView.DataSource = null;

            DataTable dataTable = new DataTable();

            string departure = fromCity.Text;
            string arrival = toCity.Text;
            DateTime Date1 = dateTimePicker1.Value.Date;


            string query = "SELECT * FROM F223722.Train WHERE DEPARTURE = :departure AND DESTINATION = :arrival AND TRUNC(DEPARTURE_TIME) = :Date1";


            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {

                    command.Parameters.Add(":departure", OracleDbType.Varchar2).Value = departure;
                    command.Parameters.Add(":arrival", OracleDbType.Varchar2).Value = arrival;
                    command.Parameters.Add(":Date1", OracleDbType.Date).Value = Date1;


                    connection.Open();

                    try
                    {

                        OracleDataReader reader = command.ExecuteReader();


                        dataTable.Load(reader);


                        trainView.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void view_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void taskBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void empIDbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void empNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Task_Click(object sender, EventArgs e)
        {

        }

        private void arrivalCity_Click(object sender, EventArgs e)
        {

        }

        private void employeeID_Click(object sender, EventArgs e)
        {

        }

        private void employeeName_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void toCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void viewTrains_Load(object sender, EventArgs e)
        {
            trainView.DataSource = null;

            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM F223722.Train";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {

                    connection.Open();

                    try
                    {

                        OracleDataReader reader = command.ExecuteReader();

                        dataTable.Load(reader);
                        trainView.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tableData = trainDBMSobj.retrieveTrainByID(int.Parse(inputBox.Text));
            trainView.DataSource = tableData;
        }
    }
}


