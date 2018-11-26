using System;
using System.Data.SqlClient;

namespace gamificationApp
{
    public class Questions
    {
        //This holds the current DB Connection String
        private static String dbConnection = ImportantCode.dbConnection;

        //This is the SQL Connection String
        static SqlConnection con = new SqlConnection(@"" + dbConnection + "");

        //This will hold all the questions held in the database
        static String[,] Quiz;

        //This queries the database and returns the number of questions in it
        public static int questionCount()
        {
            int rowCount = 0;
            String countQuery = "SELECT COUNT(questionID) FROM dbo.questions";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(countQuery, con);
            using (SqlCommand cmd = new SqlCommand(countQuery, con))
            {
                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rowCount = Int32.Parse(reader[0].ToString());
                    }
                    reader.Close();
                }
                con.Close();
            }
            return rowCount;
        }

        //This takes the questions that are in the database, and returns a copy of them within a 2D Array.
        public static string[,] getQuestions(int numberOfQuestions)
        {
            //This initialises the 2D Array for the Questions
            Quiz = new String[numberOfQuestions, 8];

            //SQL Query to get all questions from the database
            String query = "SELECT dbo.questions.questionID, dbo.questions.questionContent, dbo.questions.questionAnswer1, dbo.questions.questionAnswer2, dbo.solutions.solution1Rep, dbo.solutions.solution1Virus, dbo.solutions.solution2Rep, dbo.solutions.solution2Virus FROM dbo.questions INNER JOIN dbo.solutions ON dbo.questions.questionID=dbo.solutions.questionID;";
            con.Open();
            using (var cmd = new SqlCommand(query, con))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        Quiz[i, 0] = reader["questionID"].ToString();
                        Quiz[i, 1] = reader["questionContent"].ToString();
                        Quiz[i, 2] = reader["questionAnswer1"].ToString();
                        Quiz[i, 3] = reader["questionAnswer2"].ToString();
                        Quiz[i, 4] = reader["solution1Rep"].ToString();
                        Quiz[i, 5] = reader["solution1Virus"].ToString();
                        Quiz[i, 6] = reader["solution2Rep"].ToString();
                        Quiz[i, 7] = reader["solution2Virus"].ToString();
                        i++;
                    }
                    reader.Close();
                }
            }
            con.Close();
            return Quiz;
        }
    }
}
