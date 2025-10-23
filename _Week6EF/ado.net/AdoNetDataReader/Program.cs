using Microsoft.Data.SqlClient;

namespace AdoNetDataReader;

public class Program
{
    const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=EmployeeDB;Trusted_Connection=True;TrustServerCertificate=True;";

    static void Main(string[] args)
    {
        try
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- Menu ---");
                Console.WriteLine("1. Inserisci John Doe (Employee)");
                Console.WriteLine("2. Visualizza records (Employees)");
                Console.WriteLine("3. Esci");
                Console.Write("Seleziona un'opzione (1-3): ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        InsertJhonDoe();
                        break;

                    case "2":
                        ReadEmployees();
                        break;

                    case "3":
                        exit = true;
                        Console.WriteLine("Uscita dal programma...");
                        break;

                    default:
                        Console.WriteLine("Opzione non valida. Riprova.");
                        break;
                }
            }
        }
        catch (SqlException sqlEx)
        {
            // Handle SQL-specific exceptions.
            Console.WriteLine($"SQL Exception: {sqlEx.Message}");
        }
        catch (Exception ex)
        {
            // Catch any exception that might happen during the process.
            Console.WriteLine($"Something went wrong: {ex.Message}");
        }
    }

    private static void InsertJhonDoe()
    {
        // SQL command to insert a new employee record.
        string insertQuery = @"INSERT INTO Employee (FirstName, LastName, Email, Position, Salary) 
                                   VALUES (@FirstName, @LastName, @Email, @Position, @Salary)";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            // Begin a transaction to ensure the insert operation is atomic.
            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                // Create a SqlCommand instance using the constructor with command text, connection, and transaction.
                using (SqlCommand command = new SqlCommand(insertQuery, connection, transaction))
                {
                    // Define parameters and assign values.
                    command.Parameters.AddWithValue("@FirstName", "John");
                    command.Parameters.AddWithValue("@LastName", "Doe");
                    command.Parameters.AddWithValue("@Email", "john.doe@example.com");
                    command.Parameters.AddWithValue("@Position", "Quality Assurance");
                    command.Parameters.AddWithValue("@Salary", 55000);
                    int rowsAffected = command.ExecuteNonQuery();// ExecuteNonQuery returns the number of affected rows.
                    transaction.Commit();// Commit the transaction if the insert was successful.

                    Console.WriteLine($"{rowsAffected} row(s) inserted into the Employee table.");
                }
            }
            catch
            {
                Console.WriteLine("Rollback");
                transaction.Rollback();
            }
        }
    }

    private static void ReadEmployees()
    {
        // Establish the connection using the SqlConnection object.
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // Open the database connection.
            connection.Open();
            // Define the SQL query to select data from the Employee table.
            string sqlQuery = "SELECT EmployeeID, FirstName, LastName, Email, Position, Salary FROM Employee";
            // Create a command using the SQL query and the open connection.
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                // Execute the command, which returns a SqlDataReader instance.
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Check if the reader has rows before iterating.
                    if (reader.HasRows)
                    {
                        Console.WriteLine("Employee Details:");
                        // Iterate over the returned rows.
                        while (reader.Read())
                        {
                            // Reading each column's data using the reader indexer.
                            Console.WriteLine($"ID: {reader["EmployeeID"]}, Name: {reader["FirstName"]}, Last Name: {reader["LastName"]}, Email: {reader["Email"]}, Position: {reader["Position"]}, Salary: {reader["Salary"]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Employee data found.");
                    }
                } // The SqlDataReader is closed here.
            } // The SqlCommand is closed here.
        }// The connection is closed here.
    }
}
