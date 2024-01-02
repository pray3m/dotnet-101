using System;
using MySql.Data.MySqlClient;

class ConsoleApp
{
    public static void Main()
    {
        String ConnectionSting = "Server=localhost; Username=root;Password=; Database=dotnet";
        MySqlConnection conn = new MySqlConnection(ConnectionSting);

        try
        {
            conn.Open();
            Console.WriteLine("Connected succcessfully..");
            // Create an instance of DbOperations and use it to create a table and insert data
            DbOperations dbOperations = new DbOperations(conn);
            dbOperations.CreateTable();
            // dbOperations.InsertData();
            // dbOperations.UpdateData();
            dbOperations.DeleteData();

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);

        }
    }
}