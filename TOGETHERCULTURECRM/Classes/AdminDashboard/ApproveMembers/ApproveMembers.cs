using System;
using System.Data;
using System.Data.SqlClient;
using TOGETHERCULTURECRM.Classes.DbManager;

namespace TOGETHERCULTURECRM.Classes.AdminDashboard.ApproveMembers
{
    // Class to manage membership approval operations
    internal class ApproveMembers
    {
        // Instance of DbHelper to handle database operations
        private DbHelper dbHelper = new DbHelper();

        // Method to retrieve all pending membership requests from the database
        public DataTable GetPendingMembershipRequests()
        {
            // SQL query to fetch details of pending membership requests
            string query = @"
                SELECT 
                    r.request_id, 
                    u.first_name, 
                    u.last_name, 
                    p.plan_name, 
                    r.request_date,
                    m.member_id,
                    r.selected_plan AS plan_id
                FROM MembershipRequests r
                JOIN Members m ON r.member_id = m.member_id
                JOIN Users u ON m.user_id = u.user_id
                JOIN MembershipPlans p ON r.selected_plan = p.plan_id
                WHERE r.status = 'Pending'";

            DataTable dataTable = new DataTable();

            // Using SqlConnection, SqlCommand, and SqlDataAdapter to execute the query
            using (SqlConnection connection = dbHelper.GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                // Open the database connection and fill the DataTable with the results
                connection.Open();
                adapter.Fill(dataTable);
            }

            // Return the populated DataTable
            return dataTable;
        }

        // Method to get the admin ID associated with a given user ID
        public int GetAdminIdByUserId(int userId)
        {
            // SQL query to fetch the admin ID using the user ID
            string query = "SELECT admin_id FROM Admin WHERE user_id = @UserId";
            SqlParameter parameter = new SqlParameter("@UserId", userId);

            // Execute the query and return the admin ID, or 0 if not found
            object result = dbHelper.ExecuteScalar(query, new SqlParameter[] { parameter });
            return result != null ? Convert.ToInt32(result) : 0;
        }

        // Method to approve a membership request
        public bool ApproveMembership(int memberId, int planId, int adminId)
        {
            // SQL query to update the status of the membership request
            string updateRequestQuery = @"
                UPDATE MembershipRequests 
                SET status = 'Approved', approved_by = @AdminId, approval_date = @ApprovalDate 
                WHERE member_id = @MemberId";

            // SQL query to update the member's plan and authorized admin
            string updateMemberQuery = @"
                UPDATE Members 
                SET plan_id = @PlanId, authorized_by = @AdminId 
                WHERE member_id = @MemberId";

            // SQL query to update the user's membership status to 'active'
            string updateUserStatusQuery = @"
                UPDATE Users 
                SET membership_status = 'active' 
                WHERE user_id = (SELECT user_id FROM Members WHERE member_id = @MemberId)";

            try
            {
                // Establish the database connection and begin a transaction
                using (SqlConnection connection = dbHelper.GetConnection())
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    // Execute the first command to update the membership request status
                    using (SqlCommand command = new SqlCommand(updateRequestQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@MemberId", memberId);
                        command.Parameters.AddWithValue("@AdminId", adminId);
                        command.Parameters.AddWithValue("@ApprovalDate", DateTime.Now);
                        command.ExecuteNonQuery();
                    }

                    // Execute the second command to update the member's plan and authorization
                    using (SqlCommand command = new SqlCommand(updateMemberQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@MemberId", memberId);
                        command.Parameters.AddWithValue("@PlanId", planId);
                        command.Parameters.AddWithValue("@AdminId", adminId);
                        command.ExecuteNonQuery();
                    }

                    // Execute the third command to update the user's membership status
                    using (SqlCommand command = new SqlCommand(updateUserStatusQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@MemberId", memberId);
                        command.ExecuteNonQuery();
                    }

                    // Commit the transaction if all commands execute successfully
                    transaction.Commit();
                }

                // Return true to indicate successful approval
                return true;
            }
            catch (Exception ex)
            {
                // Log the error message to the console
                Console.WriteLine($"Error: {ex.Message}");
                // Return false to indicate failure
                return false;
            }
        }
    }
}
