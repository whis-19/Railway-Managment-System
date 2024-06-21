using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace GROUP_2
{

    public partial class signUP : Form
    {

        public signUP()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.ShowDialog();
        }

        private void signUPButton_Click(object sender, EventArgs e)
        {



            string email = userName.Text;
            string password = passwordBox.Text;
            string accountType = choice.Text;
            String connectionString = @"DATA SOURCE =localhost:1521/XE;USER ID =F223722; PASSWORD=f223722";
            
            if (accountType == "Passenger")
            {
              
                using (OracleConnection connection = new OracleConnection(connectionString))
                {

                    connection.Open();
                    string query = "INSERT INTO F223722.PASSENGER (EMAIL, ACCOUNT_TYPE, PASSWORD) VALUES (:email, :accountType, :password)";

                    OracleCommand command = new OracleCommand(query, connection);
                    command.Parameters.Add(":EMAIL", email);
                    command.Parameters.Add(":ACCOUNT_TYPE", accountType);
                    command.Parameters.Add(":PASSWORD", password);
                    
                    command.ExecuteNonQuery();                
                }
            }

            else if (accountType == "Employee")
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {

                    connection.Open();
                    string query = "INSERT INTO F223722.EMPLOYEE (EMAIL, ACCOUNT_TYPE, PASSWORD) VALUES (:email, :accountType, :password)";

                    OracleCommand command = new OracleCommand(query, connection);
                    command.Parameters.Add(":EMAIL", email);
                    command.Parameters.Add(":ACCOUNT_TYPE", accountType);
                    command.Parameters.Add(":PASSWORD", password);

                    command.ExecuteNonQuery();
                }
            }
            else
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {

                    connection.Open();
                    string query = "INSERT INTO F223722.ADMIN (EMAIL, ACCOUNT_TYPE, PASSWORD) VALUES (:email, :accountType, :password)";

                    OracleCommand command = new OracleCommand(query, connection);
                    command.Parameters.Add(":EMAIL", email);
                    command.Parameters.Add(":ACCOUNT_TYPE", accountType);
                    command.Parameters.Add(":PASSWORD", password);

                    command.ExecuteNonQuery();
                }
            }
            Form1 obj = new Form1();
            obj.ShowDialog();
        }

        private void signUP_Load(object sender, EventArgs e)
        {

        }
    }
}
