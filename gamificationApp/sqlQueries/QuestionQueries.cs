using System;
using System.Data.SqlClient;

namespace gamificationApp.sqlQueries
{
    public class QuestionQueries
    {
        //This holds the current DB Connection String
        private static String dbConnection = ImportantCode.dbConnection;

        //This is the SQL Connection String
        static SqlConnection con = new SqlConnection(@"" + dbConnection + "");

        //This method takes the cleaned input from the Admin Form and puts the Question and Solutions into the Database
        public static string insertQuestionIntoDatabase(String[] cleanedInput, int[] values)
        {
            Int32 questionID = 0;
            String questionSQL = "INSERT INTO questions(questionContent, questionAnswer1, questionAnswer2) OUTPUT INSERTED.questionID VALUES(@questionContent, @questionAnswer1, @questionAnswer2);";
            String solutionSQL = "INSERT INTO solutions(questionID, solution1Rep, solution1Virus, solution2Rep, Solution2Virus) VALUES(@questionID, @solution1Rep, @solution1Virus, @solution2Rep, @solution2Virus);";
            try
            {
                con.Open();
            }
            catch (Exception err)
            {
                return err.Message;
            }

            //This takes the prepared SQL statement and inserts the cleaned input into the relevant sections
            using (var cmd = new SqlCommand(questionSQL, con))
            {
                cmd.Parameters.AddWithValue("@questionContent", cleanedInput[0]);
                cmd.Parameters.AddWithValue("@questionAnswer1", cleanedInput[1]);
                cmd.Parameters.AddWithValue("@questionAnswer2", cleanedInput[2]);
                try
                {
                    //This executes the SQL Statement and returns the QuestionID for the inserted Question
                    questionID = (Int32)cmd.ExecuteScalar(); //Found on StackOverflow https://stackoverflow.com/questions/5228780/how-to-get-last-inserted-id
                }
                catch (Exception err)
                {
                    return err.Message;
                }
            }
            //This takes the values for the solutions and puts them into the prepared statement
            using (var cmd = new SqlCommand(solutionSQL, con))
            {
                cmd.Parameters.AddWithValue("@questionID", questionID);
                cmd.Parameters.AddWithValue("@solution1Rep", values[0]);
                cmd.Parameters.AddWithValue("@solution1Virus", values[1]);
                cmd.Parameters.AddWithValue("@solution2Rep", values[2]);
                cmd.Parameters.AddWithValue("@solution2Virus", values[3]);
                try
                {
                    //This executes the query and if successful will return this to the Admin screen to advise user that question has been inserted.
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return "success";
                }
                catch (Exception err)
                {
                    return err.Message;
                }
            }
        }

        //This method updates a question in the database by taking the Question ID, Input and Solution values
        public static string updateQuestionInDatabase(int questionID, String[] cleanedInput, int[] values)
        {
            String questionSQL = "UPDATE questions SET questionContent = @questionContent, questionAnswer1 = @questionAnswer1, questionAnswer2 = @questionAnswer2 WHERE questionID = @questionID;";
            String solutionSQL = "UPDATE solutions SET solution1Rep = @solution1Rep, solution1Virus = @solution1Virus, solution2Rep = @solution2Rep, Solution2Virus = @Solution2Virus WHERE questionID = @questionID;";
            try
            {
                con.Open();
            }
            catch (Exception err)
            {
                return err.Message;
            }
            //This uses the prepared SQL statement and inserts the QuestionID and cleaned inputs into the statement then executes it
            using (var cmd = new SqlCommand(questionSQL, con))
            {
                cmd.Parameters.AddWithValue("@questionID", questionID);
                cmd.Parameters.AddWithValue("@questionContent", cleanedInput[0]);
                cmd.Parameters.AddWithValue("@questionAnswer1", cleanedInput[1]);
                cmd.Parameters.AddWithValue("@questionAnswer2", cleanedInput[2]);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    return err.Message;
                }
            }

            //This uses the prepared SQL statement and inserts the questioniD and solution values 
            using (var cmd = new SqlCommand(solutionSQL, con))
            {
                cmd.Parameters.AddWithValue("@questionID", questionID);
                cmd.Parameters.AddWithValue("@solution1Rep", values[0]);
                cmd.Parameters.AddWithValue("@solution1Virus", values[1]);
                cmd.Parameters.AddWithValue("@solution2Rep", values[2]);
                cmd.Parameters.AddWithValue("@solution2Virus", values[3]);
                try
                {
                    //This executes the statement and if successfuly passes this back to advice hte user that this has been updated
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return "success";
                }
                catch (Exception err)
                {
                    return err.Message;
                }
            }
        }

        //This method takes the questionID and deletes the relevant question
        public static string deleteQuestion(int questionID)
        {

            String questionDelete = "DELETE FROM questions WHERE questionID = @questionID;";
            String solutionDelete = "DELETE FROM solutions WHERE questionID = @questionID;";
            try
            {
                con.Open();
            }
            catch (Exception err)
            {
                return err.Message;
            }

            using (var cmd = new SqlCommand(solutionDelete, con))
            {
                cmd.Parameters.AddWithValue("@questionID", questionID);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    return err.Message;
                }
            }

            using (var cmd = new SqlCommand(questionDelete, con))
            {
                cmd.Parameters.AddWithValue("@questionID", questionID);
                try
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return "success";
                }
                catch (Exception err)
                {
                    return err.Message;
                }
            }
        }
    }
}
