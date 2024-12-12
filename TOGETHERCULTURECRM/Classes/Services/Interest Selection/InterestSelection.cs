using System;
using System.Data;
using System.Data.SqlClient;
using TOGETHERCULTURECRM.Classes.DbManager;

namespace TOGETHERCULTURECRM.Classes.Services.Interest_Selection
{
    internal class InterestSelection
    {
        private DbHelper dbHelper = new DbHelper();

        // Fetch all available tags
        public DataTable GetAllTags()
        {
            string query = "SELECT * FROM Tags ORDER BY tag_name";
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
                Console.WriteLine($"Error fetching tags: {ex.Message}");
                return null;
            }
        }

        // Fetch selected interests for a member
        public DataTable GetMemberInterests(int userId)
        {
            string query = @"
                SELECT t.tag_id, t.tag_name
                FROM MemberTags mt
                JOIN Tags t ON mt.tag_id = t.tag_id
                WHERE mt.user_id = @UserId";

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
                Console.WriteLine($"Error fetching member interests: {ex.Message}");
                return null;
            }
        }

        // Add a tag to the member's interests
        public bool AddMemberInterest(int userId, int tagId)
        {
            // Ensure the tag is not already selected
            if (IsTagAlreadySelected(userId, tagId))
            {
                throw new Exception("Tag already selected.");
            }

            string query = "INSERT INTO MemberTags (user_id, tag_id) VALUES (@UserId, @TagId)";
            SqlParameter[] parameters = {
                new SqlParameter("@UserId", userId),
                new SqlParameter("@TagId", tagId)
            };

            return dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Check if the tag is already selected
        public bool IsTagAlreadySelected(int userId, int tagId)
        {
            string query = "SELECT COUNT(*) FROM MemberTags WHERE user_id = @UserId AND tag_id = @TagId";
            SqlParameter[] parameters = {
                new SqlParameter("@UserId", userId),
                new SqlParameter("@TagId", tagId)
            };

            object result = dbHelper.ExecuteScalar(query, parameters);
            return result != null && Convert.ToInt32(result) > 0;
        }
    }
}
