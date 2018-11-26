using System;
using System.Data.SqlClient;

namespace gamificationApp.sqlQueries
{
    public class UserQueries
    {
        //This holds the current DB Connection String
        private static String dbConnection = ImportantCode.dbConnection;

        //This creates the SQL connection
        static SqlConnection con = new SqlConnection(@"" + dbConnection + "");

        public static void roleCheck()
        {
            con.Open();
            String query = "SELECT role FROM dbo.users WHERE userName = @userName";
            using (var cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@userName", userDetails.userName);
                userDetails.role = (String)cmd.ExecuteScalar();
            }
            con.Close();
        }

        //This connects to the database to check if the User ID and Password are correct.
        // If they are, it returns true otherwise it returns false.
        public static bool loginCheck(string userName, string inputPassword)
        {
            SqlDataReader sdr;
            Boolean result = false;

            con.Open();
            String query = "SELECT * FROM dbo.users WHERE userName = @userName AND password = @password";
            using (var cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@password", inputPassword);
                sdr = cmd.ExecuteReader();
                result = sdr.Read();
            }
            con.Close();
            return result;
        }
    }
}
