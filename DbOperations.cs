using System;
using MySql.Data.MySqlClient;

public class DbOperations
{
    private readonly MySqlConnection _connection;

    public DbOperations(MySqlConnection connection)
    {
        _connection = connection;
    }

    public void CreateTable()
    {
        try
        {
            string createTableQuery = "CREATE TABLE IF NOT EXISTS Student (Id INT AUTO_INCREMENT PRIMARY KEY, Name VARCHAR(50))";

            MySqlCommand command = new MySqlCommand(createTableQuery, _connection);

            command.ExecuteNonQuery();


            Console.WriteLine("Table created successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error creating table: {ex.Message}");
        }
    }

    public void InsertData()
    {
        Console.WriteLine("Enter the name you want to insert ? ");
        string name = Console.ReadLine();
        Console.WriteLine(name);

        try
        {
            string insertDataQuery = "INSERT INTO Student (Name) VALUES (@name)";

            MySqlCommand command = new MySqlCommand(insertDataQuery, _connection);
            command.Parameters.AddWithValue("@name", name);
            command.ExecuteNonQuery();


            Console.WriteLine("Data inserted successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inserting data: {ex.Message}");
        }
    }

    public void UpdateData()
    {
        Console.WriteLine("Enter the id of the student you want to update : ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the new name: ");
        string newName = Console.ReadLine();

        try
        {
            string updateDataQuery = "UPDATE Student SET Name=@newName WHERE Id=@id";

            MySqlCommand cmd = new MySqlCommand(updateDataQuery, _connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@newName", newName);
            cmd.ExecuteNonQuery();

            Console.WriteLine("Data updated successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error updating data : {ex.Message} ");
        }
    }

    public void DeleteData()
    {
        Console.WriteLine("Enter the id of the student you want to delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        try
        {
            string deleteDataQuery = "DELETE FROM Student WHERE id=@id";

            MySqlCommand cmd = new MySqlCommand(deleteDataQuery, _connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

            Console.WriteLine("Data deleted successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error deleting : {ex.Message}");
        }
    }
}
