using System.Data.SqlClient;

namespace TOGETHERCULTURECRM.Classes.DbManager
{
    internal class DbHelper
    {
        //Connection string from project settings
        //write operations is working if i use the connection string directly
        //Problem: Data is being manupulated in Runtime DB not the MainDB
        //Read the Readme.txt for solution
        private string connectionString = Properties.Settings.Default.DBConnectionString;

        // Method to get a database connection
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Execute SELECT queries and return a SqlDataReader for reading results
        public SqlDataReader ExecuteReader(string query, SqlParameter[] parameters = null)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(query, connection);

            if (parameters != null)
                command.Parameters.AddRange(parameters);

            connection.Open();
            return command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }

        // Execute INSERT, UPDATE, DELETE queries that don't require a result to be returned
        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                connection.Open();
                return command.ExecuteNonQuery(); // Returns the number of affected rows
            }
        }

        // Execute a scalar query to return a single value (useful for getting counts, IDs, etc.)
        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                connection.Open();
                return command.ExecuteScalar(); // Returns a single value
            }
        }
    }
}
