using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

public class empDBMS
{

    public int EmployeeID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    public string category { get; set; }
    public string Task { get; set; }
    public decimal Salary { get; set; }
    public string Address { get; set; }
    public string CNIC { get; set; }


    string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=F223722; PASSWORD = f223722";


    public void addEMP()
    {
        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            string query = "INSERT INTO F223722.EMPLOYEE (EmployeeID, Name, Email, Password, PhoneNumber, Role, Tasks, Salary, Address, CNIC) VALUES (:EmployeeID, :Name, :Email, :Password, :PhoneNumber, :Role, :Task, :Salary, :Address, :CNIC)";

            OracleCommand command = new OracleCommand(query, connection);
            command.Parameters.Add(":EmployeeID", EmployeeID);
            command.Parameters.Add(":Name", Name);
            command.Parameters.Add(":Email", Email);
            command.Parameters.Add(":Password", Password);
            command.Parameters.Add(":PhoneNumber", PhoneNumber);
            command.Parameters.Add(":Role", category);
            command.Parameters.Add(":Tasks", Task);
            command.Parameters.Add(":Salary", Salary);
            command.Parameters.Add(":Address", Address);
            command.Parameters.Add(":CNIC", CNIC);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }


    public void updateEMP()
    {
        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            string query = "UPDATE F223722.Employee SET Name = :Name, Email = :Email, Password = :Password, PhoneNumber = :PhoneNumber, Role = :Role,Tasks = :Tasks, Salary = :Salary, Address = :Address, CNIC = :CNIC WHERE EmployeeID = :EmployeeID";

            OracleCommand command = new OracleCommand(query, connection);
            command.Parameters.Add(":Name", Name);
            command.Parameters.Add(":Email", Email);
            command.Parameters.Add(":Password", Password);
            command.Parameters.Add(":PhoneNumber", PhoneNumber);
            command.Parameters.Add(":Role", category);
            command.Parameters.Add(":Tasks", Task);
            command.Parameters.Add(":Salary", Salary);
            command.Parameters.Add(":Address", Address);
            command.Parameters.Add(":CNIC", CNIC);
            command.Parameters.Add(":EmployeeID", EmployeeID);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }
    public void assignTask()
    {
        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            string query = "UPDATE F223722.Employee SET Tasks = :Tasks";

            OracleCommand command = new OracleCommand(query, connection);

            command.Parameters.Add(":Tasks", Task);


            connection.Open();
            command.ExecuteNonQuery();
        }
    }



    public void deleteEMP(int employeeID)
    {
        using (OracleConnection connection = new OracleConnection(connectionString))
        {

            string query = "DELETE FROM Employees WHERE EmployeeID = :EmployeeID";
            OracleCommand command = new OracleCommand(query, connection);
            command.Parameters.Add(":EmployeeID", employeeID);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }


    public DataTable RetriveEMP()
    {
        DataTable dataTable = new DataTable();

        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            string query = "SELECT EmployeeID, Name, Email, Password, Role, Tasks, Salary, Address, PHONENUMBER, CNIC FROM F223722.Employee";
            OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
            adapter.Fill(dataTable);
        }

        return dataTable;
    }


    public DataTable RETRIVEbyID(int employeeID)
    {
        DataTable dataTable = new DataTable();

        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            string query = "SELECT EmployeeID, Name, Email, Password, PhoneNumber, Role, Tasks, Salary, Address, CNIC FROM F223722.Employee WHERE EmployeeID = :employeeID";
            OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.Add(":EmployeeID", employeeID);
            adapter.Fill(dataTable);
        }

        return dataTable;
    }
}