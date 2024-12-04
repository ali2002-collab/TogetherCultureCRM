using System;
using System.Data;
using System.Data.SqlClient;
using TOGETHERCULTURECRM.Classes.DbManager;

namespace TOGETHERCULTURECRM.Classes.Services.Friends
{
    internal class FriendService
    {
        private readonly DbHelper dbHelper = new DbHelper();

        // Get Friends List
        public DataTable GetFriendsList(int userId)
        {
            string query = @"
                SELECT 
                    u.user_id, 
                    u.first_name, 
                    u.last_name, 
                    u.email
                FROM Friends f
                INNER JOIN Users u ON u.user_id = f.friend_id
                WHERE f.user_id = @UserId AND u.user_type = 'Member'";

            SqlParameter[] parameters = { new SqlParameter("@UserId", userId) };

            return ExecuteQuery(query, parameters);
        }

        // Get Non-Friends List
        public DataTable GetNonFriendsList(int userId)
        {
            string query = @"
                SELECT 
                    u.user_id, 
                    u.first_name, 
                    u.last_name, 
                    u.email
                FROM Users u
                WHERE u.user_id != @UserId 
                  AND u.user_id NOT IN (
                      SELECT friend_id FROM Friends WHERE user_id = @UserId
                  )
                  AND u.user_type = 'Member'";

            SqlParameter[] parameters = { new SqlParameter("@UserId", userId) };

            return ExecuteQuery(query, parameters);
        }

        // Get Pending Friend Requests
        public DataTable GetPendingFriendRequests(int userId)
        {
            string query = @"
                SELECT 
                    r.request_id, 
                    r.sender_id, 
                    u.first_name, 
                    u.last_name, 
                    u.email, 
                    r.requested_at
                FROM FriendRequests r
                INNER JOIN Users u ON u.user_id = r.sender_id
                WHERE r.receiver_id = @UserId AND r.status = 'Pending'";

            SqlParameter[] parameters = { new SqlParameter("@UserId", userId) };

            return ExecuteQuery(query, parameters);
        }

        // Send Friend Request
        public bool SendFriendRequest(int senderId, int receiverId)
        {
            string query = @"
                INSERT INTO FriendRequests (sender_id, receiver_id, status)
                VALUES (@SenderId, @ReceiverId, 'Pending')";

            SqlParameter[] parameters = {
                new SqlParameter("@SenderId", senderId),
                new SqlParameter("@ReceiverId", receiverId)
            };

            return ExecuteNonQuery(query, parameters) > 0;
        }

        // Accept Friend Request
        public bool AcceptFriendRequest(int requestId, int senderId, int receiverId)
        {
            string updateRequestQuery = @"
        UPDATE FriendRequests
        SET status = 'Accepted', responded_at = @RespondedAt
        WHERE request_id = @RequestId";

            string insertFriendQuery = @"
        INSERT INTO Friends (user_id, friend_id)
        VALUES (@UserId, @FriendId)";

            try
            {
                using (SqlConnection connection = dbHelper.GetConnection())
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Update the friend request status to 'Accepted'
                            using (SqlCommand updateCommand = new SqlCommand(updateRequestQuery, connection, transaction))
                            {
                                updateCommand.Parameters.Add(new SqlParameter("@RespondedAt", DateTime.Now));
                                updateCommand.Parameters.Add(new SqlParameter("@RequestId", requestId));
                                updateCommand.ExecuteNonQuery();
                            }

                            // Insert friendship for the receiver
                            using (SqlCommand insertFriendCommand = new SqlCommand(insertFriendQuery, connection, transaction))
                            {
                                insertFriendCommand.Parameters.Add(new SqlParameter("@UserId", receiverId));
                                insertFriendCommand.Parameters.Add(new SqlParameter("@FriendId", senderId));
                                insertFriendCommand.ExecuteNonQuery();
                            }

                            // Insert friendship for the sender
                            using (SqlCommand insertFriendCommand = new SqlCommand(insertFriendQuery, connection, transaction))
                            {
                                insertFriendCommand.Parameters.Add(new SqlParameter("@UserId", senderId));
                                insertFriendCommand.Parameters.Add(new SqlParameter("@FriendId", receiverId));
                                insertFriendCommand.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Console.WriteLine($"Error accepting friend request: {ex.Message}");
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error accepting friend request: {ex.Message}");
                return false;
            }
        }


        // Reject Friend Request
        public bool RejectFriendRequest(int requestId)
        {
            string query = "DELETE FROM FriendRequests WHERE request_id = @RequestId";

            SqlParameter[] parameters = { new SqlParameter("@RequestId", requestId) };

            return ExecuteNonQuery(query, parameters) > 0;
        }

        // Remove Friend
        public bool RemoveFriend(int userId, int friendId)
        {
            string query = @"
                DELETE FROM Friends 
                WHERE (user_id = @UserId AND friend_id = @FriendId)
                   OR (user_id = @FriendId AND friend_id = @UserId)";

            SqlParameter[] parameters = {
                new SqlParameter("@UserId", userId),
                new SqlParameter("@FriendId", friendId)
            };

            return ExecuteNonQuery(query, parameters) > 0;
        }

        // Utility to Execute Queries
        private DataTable ExecuteQuery(string query, SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection connection = dbHelper.GetConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    command.Parameters.AddRange(parameters);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error executing query: {ex.Message}");
                return null;
            }
        }

        // Utility to Execute Non-Query
        private int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            try
            {
                return dbHelper.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error executing non-query: {ex.Message}");
                return 0;
            }
        }
    }
}
