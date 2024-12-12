using System;
using System.Data;
using System.Data.SqlClient;
using TOGETHERCULTURECRM.Classes.DbManager;

namespace TOGETHERCULTURECRM.Classes.Services.FeedbackService
{
    internal class FeedbackService
    {
        private readonly DbHelper dbHelper = new DbHelper();

       
        public void SaveFeedback(int userId, string entityType, string feedbackText, int rating)
        {
            try
            {
                string query = @"
                    INSERT INTO Feedback (user_id, entity_type, feedback_text, rating, created_at)
                    VALUES (@UserId, @EntityType, @FeedbackText, @Rating, GETDATE())";

                SqlParameter[] parameters = {
                    new SqlParameter("@UserId", userId),
                    new SqlParameter("@EntityType", entityType),
                    new SqlParameter("@FeedbackText", feedbackText ?? (object)DBNull.Value),
                    new SqlParameter("@Rating", rating)
                };

                dbHelper.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving feedback: {ex.Message}", ex);
            }
        }

        
        public DataTable GetAllFeedback()
        {
            try
            {
                string query = @"
                    SELECT 
                        f.feedback_id, 
                        u.first_name + ' ' + u.last_name AS MemberName,
                        f.entity_type, 
                        f.feedback_text, 
                        f.rating, 
                        f.created_at
                    FROM Feedback f
                    JOIN Users u ON f.user_id = u.user_id
                    ORDER BY f.created_at DESC";

                using (SqlDataReader reader = dbHelper.ExecuteReader(query))
                {
                    DataTable feedbackTable = new DataTable();
                    feedbackTable.Load(reader);
                    return feedbackTable;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving feedback: {ex.Message}", ex);
            }
        }

        
        public DataTable GetFeedbackByUser(int userId)
        {
            try
            {
                string query = @"
                    SELECT 
                        feedback_id, 
                        entity_type, 
                        feedback_text, 
                        rating, 
                        created_at
                    FROM Feedback
                    WHERE user_id = @UserId
                    ORDER BY created_at DESC";

                SqlParameter[] parameters = { new SqlParameter("@UserId", userId) };

                using (SqlDataReader reader = dbHelper.ExecuteReader(query, parameters))
                {
                    DataTable feedbackTable = new DataTable();
                    feedbackTable.Load(reader);
                    return feedbackTable;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving feedback for user: {ex.Message}", ex);
            }
        }

       
        public bool DeleteFeedback(int feedbackId)
        {
            try
            {
                string query = "DELETE FROM Feedback WHERE feedback_id = @FeedbackId";

                SqlParameter[] parameters = { new SqlParameter("@FeedbackId", feedbackId) };

                return dbHelper.ExecuteNonQuery(query, parameters) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting feedback: {ex.Message}", ex);
            }
        }

       
        public double GetAverageRating(string entityType)
        {
            try
            {
                string query = @"
                    SELECT AVG(CAST(rating AS FLOAT))
                    FROM Feedback
                    WHERE entity_type = @EntityType";

                SqlParameter[] parameters = { new SqlParameter("@EntityType", entityType) };

                object result = dbHelper.ExecuteScalar(query, parameters);
                return result != null ? Convert.ToDouble(result) : 0.0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error calculating average rating: {ex.Message}", ex);
            }
        }

       
        public int GetFeedbackCountByEntityType(string entityType)
        {
            try
            {
                string query = @"
                    SELECT COUNT(*)
                    FROM Feedback
                    WHERE entity_type = @EntityType";

                SqlParameter[] parameters = { new SqlParameter("@EntityType", entityType) };

                object result = dbHelper.ExecuteScalar(query, parameters);
                return result != null ? Convert.ToInt32(result) : 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error counting feedback for entity type: {ex.Message}", ex);
            }
        }
    }
}
