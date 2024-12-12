using System;
using System.Data;
using System.Data.SqlClient;
using TOGETHERCULTURECRM.Classes.DbManager;

namespace TOGETHERCULTURECRM.Classes.Services.Search
{
    internal class SearchManager
    {
        private DbHelper dbHelper = new DbHelper();


        public DataTable SearchAll(int userId, string keyword)
        {
            string query = @"
            SELECT event_id AS ID, event_name AS Name, 'Event' AS Category, location AS Location, event_date AS Date 
            FROM Events
            WHERE event_name LIKE @Keyword OR location LIKE @Keyword
            
            UNION ALL

            SELECT space_id AS ID, location AS Name, 'Space' AS Category, space_type AS Location, NULL AS Date
            FROM Spaces
            WHERE location LIKE @Keyword OR space_type LIKE @Keyword OR description LIKE @Keyword
            
            UNION ALL

            SELECT u.user_id AS ID, u.first_name + ' ' + u.last_name AS Name, 'Friend' AS Category, u.email AS Location, NULL AS Date
            FROM Friends f
            JOIN Users u ON f.friend_id = u.user_id
            WHERE f.user_id = @UserId AND (u.first_name LIKE @Keyword OR u.last_name LIKE @Keyword OR u.email LIKE @Keyword)
        ";

            SqlParameter[] parameters = {
                new SqlParameter("@UserId", userId),
                new SqlParameter("@Keyword", "%" + keyword + "%")
            };

            try
            {
                using (SqlDataReader reader = dbHelper.ExecuteReader(query, parameters))
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Search query failed: {ex.Message}");
                return null;
            }
        }



        public DataTable SearchAllEntities(string keyword)
        {
            string query = @"
            SELECT user_id AS ID, first_name + ' ' + last_name AS Name, 'User' AS Category, email AS Details, created_at AS Date
            FROM Users
            WHERE first_name LIKE @Keyword OR last_name LIKE @Keyword OR email LIKE @Keyword

            UNION ALL

            SELECT event_id AS ID, event_name AS Name, 'Event' AS Category, location AS Details, event_date AS Date
            FROM Events
            WHERE event_name LIKE @Keyword OR location LIKE @Keyword OR event_description LIKE @Keyword

            UNION ALL

            SELECT space_id AS ID, location AS Name, 'Space' AS Category, space_type AS Details, NULL AS Date
            FROM Spaces
            WHERE location LIKE @Keyword OR space_type LIKE @Keyword OR description LIKE @Keyword

            UNION ALL

            SELECT friend_id AS ID, first_name + ' ' + last_name AS Name, 'Friend' AS Category, email AS Details, NULL AS Date
            FROM Friends f
            JOIN Users u ON f.friend_id = u.user_id
            WHERE u.first_name LIKE @Keyword OR u.last_name LIKE @Keyword OR u.email LIKE @Keyword";

            SqlParameter[] parameters = {
                new SqlParameter("@Keyword", "%" + keyword + "%")
            };

            return ExecuteQuery(query, parameters);
        }


      

       


        // Execute a query and return results
        private DataTable ExecuteQuery(string query, SqlParameter[] parameters)
        {
            try
            {
                using (SqlDataReader reader = dbHelper.ExecuteReader(query, parameters))
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error executing search query: {ex.Message}");
                return null;
            }
        }
    }
}
