using System;
using System.Data.SqlClient;
using TOGETHERCULTURECRM.Classes.DbManager;

namespace TOGETHERCULTURECRM.Classes.Services.Membership
{
    internal class MembershipManager
    {
        private DbHelper dbHelper = new DbHelper();

        // Method to submit a membership request for approval
        public bool SubmitMembershipRequest(int userId, int planId)
        {
            // Insert into MembershipRequests, update Members and Users in a single transaction
            string insertRequestQuery = @"
                INSERT INTO MembershipRequests (member_id, selected_plan, status, request_date)
                SELECT member_id, @PlanId, 'Pending', GETDATE() 
                FROM Members 
                WHERE user_id = @UserId";

                    string updateMembersQuery = @"
                UPDATE Members 
                SET plan_id = @PlanId 
                WHERE user_id = @UserId";

                    string updateUserStatusQuery = @"
                UPDATE Users 
                SET membership_status = 'pending' 
                WHERE user_id = @UserId";

            try
            {
                using (SqlConnection connection = dbHelper.GetConnection())
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Insert into MembershipRequests
                        using (SqlCommand command = new SqlCommand(insertRequestQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@UserId", userId);
                            command.Parameters.AddWithValue("@PlanId", planId);
                            int rowsInserted = command.ExecuteNonQuery();

                            if (rowsInserted == 0)
                            {
                                throw new Exception("Failed to insert into MembershipRequests.");
                            }
                        }

                        // Update Members table
                        using (SqlCommand command = new SqlCommand(updateMembersQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@UserId", userId);
                            command.Parameters.AddWithValue("@PlanId", planId);
                            int rowsUpdated = command.ExecuteNonQuery();

                            if (rowsUpdated == 0)
                            {
                                throw new Exception("Failed to update Members table.");
                            }
                        }

                        // Update Users table
                        using (SqlCommand command = new SqlCommand(updateUserStatusQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@UserId", userId);
                            int rowsUpdated = command.ExecuteNonQuery();

                            if (rowsUpdated == 0)
                            {
                                throw new Exception("Failed to update Users table.");
                            }
                        }

                        // Commit transaction
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine($"Transaction Error: {ex.Message}");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

    }
}
