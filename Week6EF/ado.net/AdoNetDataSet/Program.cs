using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace AdoNetDataSet;


public class Program
{
    const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=CompanyDB;Trusted_Connection=True;TrustServerCertificate=True;";

    static void Main(string[] args)
    {
        try
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- Menu ---");
                Console.WriteLine("1. Recupera un singolo set di risultati in una DataTable");
                Console.WriteLine("2. Recupera due set di risultati");
                Console.WriteLine("3. DataTable Tracking Changing e update Database");
                Console.WriteLine("4. Esci");
                Console.Write("Seleziona un'opzione (1-3): ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        FetchingSingleResultSetIntoDataTable();
                        break;

                    case "2":
                        FetchingTwoResultSets();
                        break;

                    case "3":
                        DataTableChangeTrackingAndUpdatingDB();
                        break;

                    case "4":
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

    private static void FetchingSingleResultSetIntoDataTable()
    {
        // Display application objective
        Console.WriteLine("Fetch all records from the Employees table into a DataTable");

        // Define the T-SQL query to fetch data from the Employees table
        string query = "SELECT EmployeeID, FirstName, LastName, Email, HireDate FROM Employees;";

        // Create a new DataTable to store the query results
        DataTable employeeTable = new DataTable();

        // Using block ensures that the SqlConnection is properly disposed after usage
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            // Open the connection to the database
            conn.Open();

            // Create the SqlCommand object with the T-SQL query and the connection object
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                // Create a SqlDataAdapter to execute the query and fill the DataTable
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    // Fill the DataTable with data from the query result
                    adapter.Fill(employeeTable);
                }
            }

            // Output the number of rows fetched
            Console.WriteLine($"Number of Employees Fetched: {employeeTable.Rows.Count}");

            // Loop through each row in the DataTable and display the record
            foreach (DataRow row in employeeTable.Rows)
            {
                Console.WriteLine($"ID: {row["EmployeeID"]}, Name: {row["FirstName"]} {row["LastName"]}, Email: {row["Email"]}, Hired On: {((DateTime)row["HireDate"]).ToShortDateString()}");
            }

        }
    }

    private static void FetchingTwoResultSets()
    {
        // Define a combined T-SQL query to fetch two result sets
        string multiQuery = @"
                SELECT EmployeeID, FirstName, LastName, Email, HireDate FROM Employees;
                SELECT DepartmentID, DepartmentName FROM Departments;
            ";
        // Create a DataSet to hold multiple DataTables (one for each result set)
        DataSet dataSet = new DataSet();
        // Using block ensures the SqlConnection is properly disposed after usage
        using (SqlConnection conn = new SqlConnection(connectionString))
        {

            // Open the SQL Server connection
            conn.Open();
            // Create a SqlCommand with the query and connection
            using (SqlCommand cmd = new SqlCommand(multiQuery, conn))
            {
                // Create a SqlDataAdapter using the SqlCommand
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    // Fill the DataSet with both result sets.
                    // The first result set goes into Tables[0] and the second into Tables[1]
                    adapter.Fill(dataSet);
                }
            }
            // Optionally, rename the DataTables for clarity
            if (dataSet.Tables.Count >= 1)
                dataSet.Tables[0].TableName = "Employees";
            if (dataSet.Tables.Count >= 2)
                dataSet.Tables[1].TableName = "Departments";
            // Display fetched Employee records if the table exists in the DataSet
            if (dataSet.Tables.Contains("Employees"))
            {
                DataTable? employeesTable = dataSet.Tables["Employees"];
                Console.WriteLine($"Number of Employees Fetched: {employeesTable?.Rows.Count}");
                if (employeesTable?.Rows != null)
                {
                    foreach (DataRow row in employeesTable.Rows)
                    {
                        // Output each employee record with detailed information
                        Console.WriteLine($"Employee ID: {row["EmployeeID"]}, Name: {row["FirstName"]} {row["LastName"]}, Email: {row["Email"]}, Hire Date: {((DateTime)row["HireDate"]).ToShortDateString()}");
                    }
                }
            }
            // Display fetched Department records if the table exists in the DataSet
            if (dataSet.Tables.Contains("Departments"))
            {
                DataTable? departmentsTable = dataSet.Tables["Departments"];
                Console.WriteLine($"\nNumber of Departments Fetched: {departmentsTable?.Rows.Count}");
                if (departmentsTable?.Rows != null)
                {
                    foreach (DataRow row in departmentsTable.Rows)
                    {
                        // Output each department record with its corresponding details
                        Console.WriteLine($"Department ID: {row["DepartmentID"]}, Department Name: {row["DepartmentName"]}");
                    }
                }
            }
        }
    }

    private static void DataTableChangeTrackingAndUpdatingDB()
    {
        // Create a DataTable to hold employee data.
        DataTable employeeTable = new DataTable("Employees");
        // Query to fetch employee details.
        string query = "SELECT EmployeeID, FirstName, LastName, Email, HireDate, DepartmentID FROM Employees;";
        // Using a SqlConnection and SqlDataAdapter to fill the DataTable.
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                // Fill the DataTable with data from the database.
                adapter.Fill(employeeTable);
                // Create a SqlCommandBuilder to auto-generate INSERT, UPDATE and DELETE commands.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                // ----------------------------------------------------------------
                // Step 1: Display initial state of each row (should be 'Unchanged')
                // ----------------------------------------------------------------
                Console.WriteLine("Initial DataRow states (After Fill):");
                foreach (DataRow row in employeeTable.Rows)
                {
                    Console.WriteLine($"EmployeeID: {row["EmployeeID"]} - RowState: {row.RowState}");
                }
                // ----------------------------------------------------------------
                // Step 2: Simulate modifications on the DataTable
                // ----------------------------------------------------------------
                // a) Modify an existing row to simulate a Modified state.
                if (employeeTable.Rows.Count > 0)
                {
                    // Change the email address of the first employee.
                    employeeTable.Rows[0]["Email"] = "updated.email@example.com";
                }
                // b) Add a new row to simulate an Added state.
                DataRow newRow = employeeTable.NewRow();
                // Since EmployeeID is an identity field in the database, leave it for the database to assign.
                newRow["FirstName"] = "Emma";
                newRow["LastName"] = "Williams";
                newRow["Email"] = "emma.williams@example.com";
                newRow["HireDate"] = DateTime.Today;      // Use today's date as HireDate.
                newRow["DepartmentID"] = 1;               // Assuming DepartmentID 1 exists.
                employeeTable.Rows.Add(newRow);           // New row state becomes 'Added'.
                                                          // c) Delete an existing row to simulate a Deleted state.
                if (employeeTable.Rows.Count > 1)
                {
                    // Delete the second row in the DataTable.
                    employeeTable.Rows[1].Delete();   // This marks the row as 'Deleted'.
                }
                // ----------------------------------------------------------------
                // Step 3: Display DataRow states after the changes.
                // ----------------------------------------------------------------
                Console.WriteLine("\nDataRow states after modifications:");
                foreach (DataRow row in employeeTable.Rows)
                {
                    // For rows in the 'Added' state, there's no EmployeeID assigned yet. So, we are displaying the Id as New
                    // For rows marked as 'Deleted', use the Original version to retrieve EmployeeID.
                    string? employeeId = row.RowState == DataRowState.Deleted
                        ? row["EmployeeID", DataRowVersion.Original].ToString()
                        : (row["EmployeeID"] == DBNull.Value ? "New" : row["EmployeeID"].ToString());

                    Console.WriteLine($"EmployeeID: {employeeId} - RowState: {row.RowState}");
                }
                // ----------------------------------------------------------------
                // Step 4: Update the database with the changes.
                // ----------------------------------------------------------------
                // The adapter.Update() method uses the row states to determine which command 
                // (INSERT, UPDATE, or DELETE) should be executed on the database.
                int rowsAffected = adapter.Update(employeeTable);
                Console.WriteLine($"\nDatabase updated. Total rows affected: {rowsAffected}");
                // After a successful update, we call AcceptChanges to mark all rows as 'Unchanged'.
                employeeTable.AcceptChanges();
                // ----------------------------------------------------------------
                // Step 5: Retrieve and display the final data from the database.
                // ----------------------------------------------------------------
                employeeTable.Clear(); // Clear local data.
                adapter.Fill(employeeTable); // Refill from the database.
                Console.WriteLine("\nFinal data in the database after Update:");
                foreach (DataRow row in employeeTable.Rows)
                {
                    Console.WriteLine($"EmployeeID: {row["EmployeeID"]}, " +
                                      $"Name: {row["FirstName"]} {row["LastName"]}, " +
                                      $"Email: {row["Email"]}, " +
                                      $"DepartmentID: {row["DepartmentID"]}");
                }
            }
        }
    }
}
