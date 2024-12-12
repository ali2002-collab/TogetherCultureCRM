using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TOGETHERCULTURECRM.Classes.DbManager;

namespace TOGETHERCULTURECRM.Classes.Services.Insights
{
    internal class InsightService
    {
        private DbHelper dbHelper = new DbHelper();

        public int GetMembersJoinedLastWeek()
        {
            string query = @"
                SELECT COUNT(*)
                FROM Users
                WHERE user_type = 'Member' AND created_at >= DATEADD(DAY, -7, GETDATE())";

            object result = dbHelper.ExecuteScalar(query);
            return result != null ? Convert.ToInt32(result) : 0;
        }

        public int GetActiveMembers()
        {
            string query = "SELECT COUNT(*) FROM Users WHERE user_type = 'Member' AND is_online = 1";
            object result = dbHelper.ExecuteScalar(query);
            return result != null ? Convert.ToInt32(result) : 0;
        }

        public DataTable GetUserGrowthStats()
        {
            string query = @"
                SELECT 
                    CAST(created_at AS DATE) AS RegistrationDate, 
                    COUNT(*) AS UsersCount
                FROM Users
                WHERE user_type = 'Member'
                GROUP BY CAST(created_at AS DATE)
                ORDER BY RegistrationDate";

            using (SqlDataReader reader = dbHelper.ExecuteReader(query))
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
        }

        public DataTable GetMembershipPlanStats()
        {
            string query = @"
                SELECT 
                    mp.plan_name, 
                    COUNT(m.member_id) AS MembersCount
                FROM Members m
                JOIN MembershipPlans mp ON m.plan_id = mp.plan_id
                GROUP BY mp.plan_name
                ORDER BY MembersCount DESC";

            using (SqlDataReader reader = dbHelper.ExecuteReader(query))
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
        }
    }
}
