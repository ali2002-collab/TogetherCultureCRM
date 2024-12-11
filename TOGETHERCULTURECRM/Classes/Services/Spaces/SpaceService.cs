using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TOGETHERCULTURECRM.Classes.DbManager;

namespace TOGETHERCULTURECRM.Classes.Services.Spaces
{
    internal class SpaceService
    {
        private DbHelper dbHelper = new DbHelper();

        // Get Admin ID using User ID
        public int? GetAdminId(int userId)
        {
            string query = "SELECT admin_id FROM Admin WHERE user_id = @UserId";
            SqlParameter[] parameters = { new SqlParameter("@UserId", userId) };
            object result = dbHelper.ExecuteScalar(query, parameters);
            return result != null ? (int?)Convert.ToInt32(result) : null;
        }

        // Create Space
        public bool CreateSpace(string location, string spaceType, int capacity, TimeSpan openingTime, TimeSpan closingTime, string description, int userId)
        {
            int? adminId = GetAdminId(userId); // Fetch admin_id from the user_id
            if (adminId == null)
                throw new Exception("The logged-in user is not an admin.");

            // Insert into Spaces table
            string query = @"
            INSERT INTO Spaces (location, space_type, capacity, opening_time, closing_time, description, created_by_admin)
            VALUES (@Location, @SpaceType, @Capacity, @OpeningTime, @ClosingTime, @Description, @AdminId)";

                SqlParameter[] parameters = {
                new SqlParameter("@Location", location),
                new SqlParameter("@SpaceType", spaceType),
                new SqlParameter("@Capacity", capacity),
                new SqlParameter("@OpeningTime", openingTime),
                new SqlParameter("@ClosingTime", closingTime),
                new SqlParameter("@Description", description ?? (object)DBNull.Value),
                new SqlParameter("@AdminId", adminId)
            };

            return dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public Dictionary<string, object> GetSpaceDetails(int spaceId)
        {
            string query = "SELECT * FROM Spaces WHERE space_id = @SpaceId";
            SqlParameter[] parameters = { new SqlParameter("@SpaceId", spaceId) };

            using (SqlDataReader reader = dbHelper.ExecuteReader(query, parameters))
            {
                if (reader.Read())
                {
                    var details = new Dictionary<string, object>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        details[reader.GetName(i)] = reader.GetValue(i);
                    }
                    return details;
                }
                else
                {
                    throw new Exception("Space not found.");
                }
            }
        }




        public DataTable GetMemberBookedSpaces(int userId)
        {
            string query = @"
            SELECT su.utilization_id, s.space_id, s.location, s.space_type, su.date, su.start_time, su.end_time, su.purpose
            FROM SpaceUtilization su
            JOIN Spaces s ON su.space_id = s.space_id
            WHERE su.user_id = @UserId
            ORDER BY su.date, su.start_time";

            SqlParameter[] parameters = { new SqlParameter("@UserId", userId) };

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
                Console.WriteLine($"Error fetching booked spaces: {ex.Message}");
                return null;
            }
        }

        public bool UnbookSpace(int utilizationId)
        {
            string query = "DELETE FROM SpaceUtilization WHERE utilization_id = @UtilizationId";
            SqlParameter[] parameters = { new SqlParameter("@UtilizationId", utilizationId) };

            return dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }


        // Update Space
        public bool UpdateSpace(int spaceId, string location, string spaceType, int capacity, TimeSpan openingTime, TimeSpan closingTime, string description)
        {
            string query = @"
            UPDATE Spaces
            SET location = @Location, space_type = @SpaceType, capacity = @Capacity,
                opening_time = @OpeningTime, closing_time = @ClosingTime, description = @Description
            WHERE space_id = @SpaceId";

            SqlParameter[] parameters = {
                new SqlParameter("@SpaceId", spaceId),
                new SqlParameter("@Location", location),
                new SqlParameter("@SpaceType", spaceType),
                new SqlParameter("@Capacity", capacity),
                new SqlParameter("@OpeningTime", openingTime),
                new SqlParameter("@ClosingTime", closingTime),
                new SqlParameter("@Description", description ?? (object)DBNull.Value)
            };

            return dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }


        // Delete Space
        public bool DeleteSpace(int spaceId)
        {
            string query = "DELETE FROM Spaces WHERE space_id = @SpaceId";
            SqlParameter[] parameters = { new SqlParameter("@SpaceId", spaceId) };
            return dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Get All Spaces
        public DataTable GetSpaces()
        {
            string query = "SELECT * FROM Spaces ORDER BY space_id DESC";

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
                Console.WriteLine($"Error fetching spaces: {ex.Message}");
                return null;
            }
        }

        // Book Space
        public bool BookSpace(int spaceId, int userId, DateTime date, TimeSpan startTime, TimeSpan endTime, string purpose)
        {
            string query = @"
                INSERT INTO SpaceUtilization (space_id, user_id, date, start_time, end_time, purpose)
                VALUES (@SpaceId, @UserId, @Date, @StartTime, @EndTime, @Purpose)";

            SqlParameter[] parameters = {
                new SqlParameter("@SpaceId", spaceId),
                new SqlParameter("@UserId", userId),
                new SqlParameter("@Date", date),
                new SqlParameter("@StartTime", startTime),
                new SqlParameter("@EndTime", endTime),
                new SqlParameter("@Purpose", purpose ?? (object)DBNull.Value)
            };

            return dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Check Space Utilization
        public int GetSpaceBookingCount(int spaceId, DateTime date)
        {
            string query = @"
                SELECT COUNT(*) FROM SpaceUtilization
                WHERE space_id = @SpaceId AND date = @Date";

            SqlParameter[] parameters = {
                new SqlParameter("@SpaceId", spaceId),
                new SqlParameter("@Date", date)
            };

            object result = dbHelper.ExecuteScalar(query, parameters);
            return result != null ? Convert.ToInt32(result) : 0;
        }

        public int GetTotalBookings(int spaceId)
        {
            string query = "SELECT COUNT(*) FROM SpaceUtilization WHERE space_id = @SpaceId";
            SqlParameter[] parameters = { new SqlParameter("@SpaceId", spaceId) };

            object result = dbHelper.ExecuteScalar(query, parameters);
            return result != null ? Convert.ToInt32(result) : 0;
        }


        // Get Booking List for a Space
        public DataTable GetSpaceBookings(int spaceId)
        {
            string query = @"
                SELECT su.utilization_id, u.first_name, u.last_name, su.date, su.start_time, su.end_time, su.purpose
                FROM SpaceUtilization su
                JOIN Users u ON su.user_id = u.user_id
                WHERE su.space_id = @SpaceId
                ORDER BY su.date, su.start_time";

            SqlParameter[] parameters = { new SqlParameter("@SpaceId", spaceId) };

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
                Console.WriteLine($"Error fetching space bookings: {ex.Message}");
                return null;
            }
        }
    }
}
