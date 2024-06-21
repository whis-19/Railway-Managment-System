using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace GROUP_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = UsernameBox.Text;
            string password = PasswordBox.Text;
            string accountType = choice.Text;
            String connectionString = @"DATA SOURCE =localhost:1521/XE;USER ID =F223722; PASSWORD=f223722";

            admin adobj = new admin();
            passenger psobj = new passenger();
            employee empobj = new employee();

            adobj.sendCredentials(UsernameBox.Text, choice.Text);
            empobj.sendCredentials(UsernameBox.Text, choice.Text);
            psobj.sendCredentials(UsernameBox.Text, choice.Text);


            using (OracleConnection connection = new OracleConnection(connectionString))

            {

                try

                {
                    connection.Open();


                    if (accountType == "Admin")
                    {
                        string sqlQuery = "SELECT COUNT(*) FROM ADMIN WHERE EMAIL = :email AND PASSWORD = :password AND ACCOUNT_TYPE = :accountType";
                        using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                        {
                            command.Parameters.Add(new OracleParameter("email", email));
                            command.Parameters.Add(new OracleParameter("password", password));
                            command.Parameters.Add(new OracleParameter("accountType", accountType));


                            int count = Convert.ToInt32(command.ExecuteScalar());

                            if (count > 0)
                            {


                                
                                adobj.ShowDialog();


                            }



                            connection.Close();

                          

                        }
                    }
                    else if (accountType == "Passenger")
                    {
                        string sqlQuery = "SELECT COUNT(*) FROM PASSENGER WHERE EMAIL = :email AND PASSWORD = :password AND ACCOUNT_TYPE = :accountType";
                        using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                        {
                            command.Parameters.Add(new OracleParameter("email", email));
                            command.Parameters.Add(new OracleParameter("password", password));
                            command.Parameters.Add(new OracleParameter("accountType", accountType));


                            int count = Convert.ToInt32(command.ExecuteScalar());

                            if (count > 0)
                            {


                                
                                psobj.ShowDialog();


                            }



                            connection.Close();


                        }
                    }
                    else
                    {
                        string sqlQuery = "SELECT COUNT(*) FROM EMPLOYEE WHERE EMAIL = :email AND PASSWORD = :password AND ACCOUNT_TYPE = :accountType";
                        using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                        {
                            command.Parameters.Add(new OracleParameter("email", email));
                            command.Parameters.Add(new OracleParameter("password", password));
                            command.Parameters.Add(new OracleParameter("accountType", accountType));


                            int count = Convert.ToInt32(command.ExecuteScalar());

                            if (count > 0)
                            {


                                
                                empobj.ShowDialog();


                            }



                            connection.Close();

                        }
                    }
                }

                catch (Exception ex)

                {

                    MessageBox.Show("Error: " + ex.Message);

                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            signUP obj = new signUP();
            obj.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
