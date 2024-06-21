using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

public class TrainDBMS
{
    string connectionString = @"DATA SOURCE=localhost:1521/XE;USER ID=F223722; PASSWORD = f223722";

    public void addTrain( string trainName,DateTime departureTime, DateTime arrivalTime, string route, string departure, string destination, int capacity, decimal fare, string status)
    {
        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            string query = @"INSERT INTO Train (TRAIN_NAME, DEPARTURE_TIME, ARRIVAL_TIME, ROUTE, DEPARTURE, DESTINATION, CAPACITY, FARE, STATUS) 
                             VALUES (:TrainName, :DepartureTime, :ArrivalTime, :Route, :Departure, :Destination, :Capacity, :Fare, :Status)";

            OracleCommand command = new OracleCommand(query, connection);
         
            command.Parameters.Add(":TrainName", trainName);
        
            command.Parameters.Add(":DepartureTime", departureTime);
            command.Parameters.Add(":ArrivalTime", arrivalTime);
            command.Parameters.Add(":Route", route);
            command.Parameters.Add(":Departure", departure);
            command.Parameters.Add(":Destination", destination);
            command.Parameters.Add(":Capacity", capacity);
            command.Parameters.Add(":Fare", fare);
            command.Parameters.Add(":Status", status);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }
    public void UpdateTrain(int trainID, string trainName, DateTime departureTime, DateTime arrivalTime, string route, string departure, string destination, int capacity, decimal fare, string status)
    {
        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            string query = @"UPDATE Train 
                         SET TRAIN_NAME = :trainName, 
                             DEPARTURE_TIME = :departureTime, 
                             ARRIVAL_TIME = :arrivalTime, 
                             ROUTE = :toute, 
                             DEPARTURE = :departure, 
                             DESTINATION = :destination, 
                             CAPACITY = :capacity, 
                             FARE = :fare, 
                             STATUS = :Status 
                         WHERE TRAIN_ID = :trainID";

            OracleCommand command = new OracleCommand(query, connection);
            command.Parameters.Add(":TrainName", trainName);
            command.Parameters.Add(":DepartureTime", departureTime);
            command.Parameters.Add(":ArrivalTime", arrivalTime);
            command.Parameters.Add(":Route", route);
            command.Parameters.Add(":Departure", departure);
            command.Parameters.Add(":Destination", destination);
            command.Parameters.Add(":Capacity", capacity);
            command.Parameters.Add(":Fare", fare);
            command.Parameters.Add(":Status", status);
            command.Parameters.Add(":TrainID", trainID);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }

    public DataTable RetrieveTrain()
    {
        DataTable dataTable = new DataTable();

        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            string query = "SELECT * FROM F223722.Train";
            OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
            adapter.Fill(dataTable);
        }

        return dataTable;
    }

    public DataTable retrieveTrainByID(int trainID)
    {
        DataTable dataTable = new DataTable();

        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            string query = "SELECT TRAIN_ID, TRAIN_NAME, DEPARTURE, DESTINATION, ROUTE, DEPARTURE_TIME, ARRIVAL_TIME, CAPACITY, FARE, STATUS FROM Train WHERE TRAIN_ID = :trainID";

            OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.Add(":TrainID", trainID);
            adapter.Fill(dataTable);
        }

        return dataTable;
    }

    public void deleteTrain(int trainID)
    {
        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            string query = "DELETE FROM Train WHERE TRAIN_ID = :TrainID";
            OracleCommand command = new OracleCommand(query, connection);
            command.Parameters.Add(":TrainID", trainID);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
