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
    public partial class empProfile : Form
    {
        string emailCred, accTF;
        String connectionString = @"DATA SOURCE =localhost:1521/XE;USER ID =F223722; PASSWORD=f223722";

        public empProfile()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string cnic = cnicBOX.Text;
            string Name = namebox.Text;
            string email = emailBox.Text;
            string address = cityBox.Text;
            string gender = genderBox.Text;
            string phoneNumber = contactBox.Text;
            string query = $"UPDATE F223722.Employee SET Name = '{Name}', Email = '{email}', Address = '{address}',PhoneNumber = '{phoneNumber}', Gender = '{gender}', CNIC = '{cnic}' WHERE EMAIL = '{email}'";


            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    try
                    {

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Records updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No records updated. EMPLOYEE ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void empProfile_Load(object sender, EventArgs e)
        {
            if (accTF == "Employee")
            {
                string query = $"SELECT * FROM F223722.Employee WHERE EMAIL ='{emailCred}'";

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();

                            OracleDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {

                                namebox.Text = reader["NAME"].ToString();
                                emailBox.Text = reader["EMAIL"].ToString();
                                cnicBOX.Text = reader["CNIC"].ToString();
                                genderBox.Text = reader["GENDER"].ToString();
                                contactBox.Text = reader["PHONENUMBER"].ToString();
                                cityBox.Text = reader["ADDRESS"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No data found for the provided User ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else { MessageBox.Show("MOYE MOE"); }
        }
        public void sendCredentials(string email, string accT)
        {
            emailCred = email;
            accTF = accT;
        }
    }
}
