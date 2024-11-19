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
            // Query to insert the membership request
            string insertRequestQuery = @"
                INSERT INTO MembershipRequests (member_id, selected_plan, status, request_date)
                VALUES (@UserId, @PlanId, 'Pending', GETDATE());";

            // Query to update the Members table with the selected plan ID
            string updateMembersQuery = @"
                UPDATE Members 
                SET plan_id = @PlanId 
                WHERE user_id = @UserId;";

            // Query to update the Users table and set membership status to 'pending'
            string updateUserStatusQuery = @"
                UPDATE Users 
                SET membership_status = 'pending' 
                WHERE user_id = @UserId;";

            try
            {
                // Using a single database connection and transaction
                using (SqlConnection connection = dbHelper.GetConnection())
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Insert the membership request
                        using (SqlCommand command = new SqlCommand(insertRequestQuery, connection, transaction))
                        {
                            command.Parameters.Add(new SqlParameter("@UserId", userId));
                            command.Parameters.Add(new SqlParameter("@PlanId", planId));
                            command.ExecuteNonQuery();
                        }

                        // Update the Members table
                        using (SqlCommand command = new SqlCommand(updateMembersQuery, connection, transaction))
                        {
                            command.Parameters.Add(new SqlParameter("@UserId", userId));
                            command.Parameters.Add(new SqlParameter("@PlanId", planId));
                            int membersUpdated = command.ExecuteNonQuery();
                            if (membersUpdated == 0)
                            {
                                throw new Exception("No rows were updated in the Members table.");
                            }
                        }

                        // Update the Users table
                        using (SqlCommand command = new SqlCommand(updateUserStatusQuery, connection, transaction))
                        {
                            command.Parameters.Add(new SqlParameter("@UserId", userId));
                            int usersUpdated = command.ExecuteNonQuery();
                            if (usersUpdated == 0)
                            {
                                throw new Exception("No rows were updated in the Users table.");
                            }
                        }

                        // Commit the transaction if all updates succeed
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        // Roll back the transaction if any update fails
                        transaction.Rollback();
                        Console.WriteLine($"Transaction Error: {ex.Message}");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any other errors
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
    }
}
