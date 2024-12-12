using System;
using System.Data;
using System.Data.SqlClient;
using TOGETHERCULTURECRM.Classes.DbManager;

namespace TOGETHERCULTURECRM.Classes.Services.Events
{
    internal class EventsService
    {
        private DbHelper dbHelper = new DbHelper();

        //get admin id from db utilizing the user id
        public int? GetAdminId(int userId)
        {
                string query = "SELECT admin_id FROM Admin WHERE user_id = @UserId";
                SqlParameter[] parameters = {
                new SqlParameter("@UserId", userId)
                };

            object result = dbHelper.ExecuteScalar(query, parameters);
            return result != null ? (int?)Convert.ToInt32(result) : null;
        }


        // Create Event
        public bool CreateEvent(string name, string description, string type, int? limit, string location, DateTime date, decimal? fee, byte[] image, int userId)
        {
            // Retrieve the admin_id from the Admin table
            int? adminId = GetAdminId(userId);
            if (adminId == null)
            {
                throw new Exception("The logged-in user is not an admin.");
            }

            // Proceed with creating the event
            string query = @"
            INSERT INTO Events (event_name, event_description, event_type, attendance_limit, location, event_date, fee, image, created_by_admin)
            VALUES (@Name, @Description, @Type, @Limit, @Location, @Date, @Fee, @Image, @AdminId)";

            SqlParameter[] parameters = {
            new SqlParameter("@Name", name),
            new SqlParameter("@Description", description ?? (object)DBNull.Value),
            new SqlParameter("@Type", type ?? (object)DBNull.Value),
            new SqlParameter("@Limit", limit ?? (object)DBNull.Value),
            new SqlParameter("@Location", location),
            new SqlParameter("@Date", date),
            new SqlParameter("@Fee", fee ?? (object)DBNull.Value),
            new SqlParameter("@Image", image ?? (object)DBNull.Value),
            new SqlParameter("@AdminId", adminId)
        };

            return dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }



        // Update Event
        public bool UpdateEvent(int eventId, string name, string description, string type, int? limit, string location, DateTime date, decimal? fee, byte[] image)
        {
            string query = @"
                UPDATE Events
                SET event_name = @Name, event_description = @Description, event_type = @Type,
                    attendance_limit = @Limit, location = @Location, event_date = @Date,
                    fee = @Fee, image = @Image
                WHERE event_id = @EventId";

            SqlParameter[] parameters = {
                new SqlParameter("@EventId", eventId),
                new SqlParameter("@Name", name),
                new SqlParameter("@Description", description ?? (object)DBNull.Value),
                new SqlParameter("@Type", type ?? (object)DBNull.Value),
                new SqlParameter("@Limit", limit ?? (object)DBNull.Value),
                new SqlParameter("@Location", location),
                new SqlParameter("@Date", date),
                new SqlParameter("@Fee", fee ?? (object)DBNull.Value),
                new SqlParameter("@Image", image ?? (object)DBNull.Value)
            };

            return dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Delete Event
        public bool DeleteEvent(int eventId)
        {
            string query = "DELETE FROM Events WHERE event_id = @EventId";

            SqlParameter[] parameters = {
                new SqlParameter("@EventId", eventId)
            };

            return dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Get Events
        public DataTable GetEvents()
        {
            string query = "SELECT * FROM Events ORDER BY event_date DESC";

            try
            {
                using (SqlDataReader reader = dbHelper.ExecuteReader(query))
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching events: {ex.Message}");
                return null;
            }
        }

        // Attend Event
        public bool AttendEvent(int eventId, int userId)
        {
            string query = @"
                INSERT INTO EventAttendance (event_id, user_id, attendance_status)
                VALUES (@EventId, @UserId, 'Attending')";

            SqlParameter[] parameters = {
                new SqlParameter("@EventId", eventId),
                new SqlParameter("@UserId", userId)
            };

            return dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public DataTable GetAvailableEvents(int userId)
        {
            string query = @"
                SELECT e.*, 
                       ISNULL((SELECT COUNT(*) FROM EventAttendance ea WHERE ea.event_id = e.event_id), 0) AS attendance_count
                FROM Events e
                WHERE e.event_date >= GETDATE() 
                  AND NOT EXISTS (
                      SELECT 1 FROM EventAttendance ea 
                      WHERE ea.event_id = e.event_id AND ea.user_id = @UserId
                  )
                ORDER BY e.event_date DESC";

            SqlParameter[] parameters = {
                new SqlParameter("@UserId", userId)
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
                Console.WriteLine($"Error fetching available events: {ex.Message}");
                return null;
            }
        }


        public DataTable GetUserAttendingEvents(int userId)
        {
            string query = @"
            SELECT e.event_id, e.event_name, e.event_date, e.location, e.fee, e.event_type
            FROM EventAttendance ea
            JOIN Events e ON ea.event_id = e.event_id
            WHERE ea.user_id = @UserId";

            SqlParameter[] parameters = {
                new SqlParameter("@UserId", userId)
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
                Console.WriteLine($"Error fetching events: {ex.Message}");
                throw;
            }
        }


        public DataRow GetLatestAvailableEvent(int userId)
        {
            string query = @"
            SELECT TOP 1 e.*, 
                   ISNULL((SELECT COUNT(*) FROM EventAttendance ea WHERE ea.event_id = e.event_id), 0) AS attendance_count
            FROM Events e
            WHERE e.event_date >= GETDATE() 
              AND NOT EXISTS (
                  SELECT 1 FROM EventAttendance ea 
                  WHERE ea.event_id = e.event_id AND ea.user_id = @UserId
              )
            ORDER BY e.event_date ASC";

            SqlParameter[] parameters = {
                new SqlParameter("@UserId", userId)
            };

            try
            {
                using (SqlDataReader reader = dbHelper.ExecuteReader(query, parameters))
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    return dt.Rows.Count > 0 ? dt.Rows[0] : null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching latest available event: {ex.Message}");
                return null;
            }
        }




        // Get Attendance List
        public DataTable GetAttendanceList(int eventId)
        {
            string query = @"
                SELECT u.user_id, u.first_name, u.last_name, ea.attendance_status
                FROM EventAttendance ea
                JOIN Users u ON ea.user_id = u.user_id
                WHERE ea.event_id = @EventId";

            SqlParameter[] parameters = {
                new SqlParameter("@EventId", eventId)
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
                Console.WriteLine($"Error fetching attendance: {ex.Message}");
                return null;
            }
        }



        public bool WithdrawFromEvent(int eventId, int userId)
        {
            string query = "DELETE FROM EventAttendance WHERE event_id = @EventId AND user_id = @UserId";

            SqlParameter[] parameters = {
                new SqlParameter("@EventId", eventId),
                new SqlParameter("@UserId", userId)
            };

            return dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

    }
}
