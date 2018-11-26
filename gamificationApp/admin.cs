using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gamificationApp
{
    public partial class Admin : Form
    {
        //This holds the current DB Connection String
        private static String dbConnection = ImportantCode.dbConnection;

        //This is the SQL Connection String
        static SqlConnection con = new SqlConnection(@"" + dbConnection + "");

        //This stores how many questions are in the database
        static int numberOfQuestions;

        //This will hold all the questions held in the database
        String[,] Quiz;

        private String adminChoice = "";

        public Admin()
        {
            InitializeComponent();
            importantStart();
        }

        public void importantStart()
        {
            labelVersion.Text = ImportantCode.version;
            //This checks how many questions there are
            numberOfQuestions = questionCount();
            //This initialises the 2D Array for the Questions
            Quiz = new String[numberOfQuestions, 8];
            //This fills the dropdown
            for (int i = 0; i < numberOfQuestions; i++)
            {
                comboBoxQuestions.Items.Add(i + 1);
            }
        }

        //This method takes the questions in the database as well as the solutions, and puts them into the 2D Array Quiz
        private void getQuestions()
        {
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
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Hide();
            this.Dispose();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string question = textBoxQuestion.Text;
            string solution1 = textBoxAnswer1.Text;
            string solution2 = textBoxAnswer2.Text;

            textEntryCheck(question, solution1, solution2);
        }

        private void textEntryCheck(String question, String solution1, String solution2)
        {
            if (string.IsNullOrWhiteSpace(question))
            {
                MessageBox.Show("Please enter a question");
            } else if (string.IsNullOrWhiteSpace(solution1))
            {
                MessageBox.Show("Please enter text for the first solution");
            } else if (string.IsNullOrWhiteSpace(solution2))
            {
                MessageBox.Show("Please enter text for the second solution");
            } else
            {
                profanityCheck(question, solution1, solution2);
            }
        }

        private static int questionCount()
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

        private void profanityCheck(String question, String solution1, String solution2)
        {
            bool swearing = false;
            for(int i = 0; i< ProfanityCheck.profanity.Length; i++)
            {
                if (question.ToLower().Contains(ProfanityCheck.profanity[i]))
                {
                    badLanguageUsed(ProfanityCheck.profanity[i], "question");
                    swearing = true;
                    break;
                } else
                {
                    if (solution1.ToLower().Contains(ProfanityCheck.profanity[i]))
                    {
                        badLanguageUsed(ProfanityCheck.profanity[i], "first solution");
                        swearing = true;
                        break;
                    } else
                    {
                        if (solution2.ToLower().Contains(ProfanityCheck.profanity[i]))
                        {
                            badLanguageUsed(ProfanityCheck.profanity[i], "second solution");
                            swearing = true;
                            break;
                        }
                    }
                }
            }

            if (!swearing)
            {
                String[] cleanedInput = specialCharacterRemoval(question, solution1, solution2);

                if (adminChoice.Equals("new"))
                { 
                    insertQuestionIntoDatabase(cleanedInput);
                } else if (adminChoice.Equals("edit"))
                {
                    updateQuestionInDatabase(cleanedInput);
                }
            }
        }

        private void insertQuestionIntoDatabase(String[] cleanedInput)
        {
            String sql = "INSERT INTO questions(questionContent, questionAnswer1, questionAnswer2) OUTPUT INSERTED.questionID VALUES(@questionContent, @questionAnswer1, @questionAnswer2);";
            try
            {
                con.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@questionContent", cleanedInput[0]);
                cmd.Parameters.AddWithValue("@questionAnswer1", cleanedInput[1]);
                cmd.Parameters.AddWithValue("@questionAnswer2", cleanedInput[2]);
                try
                {
                    Int32 newId = (Int32)cmd.ExecuteScalar(); //Found on StackOverflow https://stackoverflow.com/questions/5228780/how-to-get-last-inserted-id
                    con.Close();
                    insertSolutionIntoDatabase(newId);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    
                }
            }
        }

        private void insertSolutionIntoDatabase(int questionID)
        {
            String sql = "INSERT INTO solutions(questionID, solution1Rep, solution1Virus, solution2Rep, Solution2Virus) VALUES(@questionID, @solution1Rep, @solution1Virus, @solution2Rep, @solution2Virus);";
            try
            {
                con.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@questionID", questionID);
                cmd.Parameters.AddWithValue("@solution1Rep", numericUpDownAns1Rep.Value);
                cmd.Parameters.AddWithValue("@solution1Virus", numericUpDownAns1Virus.Value);
                cmd.Parameters.AddWithValue("@solution2Rep", numericUpDownAns2Rep.Value);
                cmd.Parameters.AddWithValue("@solution2Virus", numericUpDownAns2Virus.Value);
                try
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Question was inserted to the database successfully");
                    Admin admin = new Admin();
                    admin.Show();
                    this.Close();
                    this.Dispose();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);

                }
            }
        }

        private void updateQuestionInDatabase(String[] cleanedInput)
        {
            
            int questionID = Int32.Parse(labelQuestionNumDisplay.Text);

            String sql = "UPDATE questions SET questionContent = @questionContent, questionAnswer1 = @questionAnswer1, questionAnswer2 = @questionAnswer2 WHERE questionID = @questionID;";
            try
            {
                con.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            using (var cmd = new SqlCommand(sql, con))
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
                    MessageBox.Show(err.Message);
                }

                try
                {
                    con.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }

            updateSolutionInDatabase(questionID);
        }

        private void updateSolutionInDatabase(int questionID)
        {
            String sql = "UPDATE solutions SET solution1Rep = @solution1Rep, solution1Virus = @solution1Virus, solution2Rep = @solution2Rep, Solution2Virus = @Solution2Virus WHERE questionID = @questionID;";
            try
            {
                con.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@questionID", questionID);
                cmd.Parameters.AddWithValue("@solution1Rep", numericUpDownAns1Rep.Value);
                cmd.Parameters.AddWithValue("@solution1Virus", numericUpDownAns1Virus.Value);
                cmd.Parameters.AddWithValue("@solution2Rep", numericUpDownAns2Rep.Value);
                cmd.Parameters.AddWithValue("@solution2Virus", numericUpDownAns2Virus.Value);
                try
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Question was updated in the database successfully");
                    Admin admin = new Admin();
                    admin.Show();
                    this.Close();
                    this.Dispose();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);

                }
            }
        }
        private void badLanguageUsed(String word, String location)
        {
            MessageBox.Show("You used a swear word which was " + word + " in " + location);
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            adminChoice = "new";

            sectionVisibility();
        }

        private void buttonEditQuestion_Click(object sender, EventArgs e)
        {
            
            if(numberOfQuestions == 0)
            {
                MessageBox.Show("There are no questions in the Database, please enter one before editing");
            } else
            {
                adminChoice = "edit";
                comboBoxQuestions.Visible = true;
                labelQuestionList.Visible = true;
            }
            
        }

        public void sectionVisibility()
        {

            labelQuestion.Visible = true;
            labelAnswer1.Visible = true;
            labelAns1Rep.Visible = true;
            labelAns1Virus.Visible = true;
            labelAnswer2.Visible = true;
            labelAns2Rep.Visible = true;
            labelAns2Virus.Visible = true;

            textBoxQuestion.Visible = true;
            textBoxAnswer1.Visible = true;
            textBoxAnswer2.Visible = true;

            numericUpDownAns1Rep.Visible = true;
            numericUpDownAns1Virus.Visible = true;
            numericUpDownAns2Rep.Visible = true;
            numericUpDownAns2Virus.Visible = true;

            buttonSubmit.Visible = true;

            if (!adminChoice.ToLower().Equals("edit") & !adminChoice.ToLower().Equals("new"))
            {
                MessageBox.Show("There has been an error showing the question section. Please return to the main menu and try again.");
            } else if (adminChoice.ToLower().Equals("edit"))
            {
                labelQuestionNum.Visible = true;
                labelQuestionNumDisplay.Visible = true;
                buttonDelete.Visible = true;
            }

            buttonAddQuestion.Visible = false;
            buttonEditQuestion.Visible = false;
        }

        public string[] specialCharacterRemoval(String question, String solution1, String solution2)
        {
            string[] cleanedArray = new string[3];

            //Question Clean
            cleanedArray[0] = stringCleaning(question);

            //Solution1 Clean
            cleanedArray[1] = stringCleaning(solution1);

            //Solution2 Clean
            cleanedArray[2] = stringCleaning(solution2);

            return cleanedArray;
        }

        public string stringCleaning(String checkString)
        {
            String cleanedString = "";
            char[] tempArray;
            tempArray = new char[checkString.Length];
            tempArray = checkString.ToCharArray();
            char[] restrictedCharacters = { '<', '>', '/', '"', '@', '#', '|', '=', '+', '(', ')', '{', '}', '[', ']'};

            for (int i = 0; i < tempArray.Length; i++)
            {
                int count = 0;
                bool valid = true;

                foreach (char c in restrictedCharacters)
                {
                    if (tempArray[i].Equals(c))
                    {
                        valid = false;
                        count++;
                    }
                    else if (!tempArray[i].Equals(c))
                    {
                        if (count.Equals(restrictedCharacters.Length - 1) && valid)
                        {
                            cleanedString += tempArray[i];

                        }
                        else
                        {
                            count++;
                        }

                    }
                }
            }

            return cleanedString;
        }

        private void comboBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            getQuestions();
            sectionVisibility();
            labelQuestionNumDisplay.Text = Quiz[(Int32.Parse(comboBoxQuestions.SelectedItem.ToString())-1),0];
            textBoxQuestion.Text = Quiz[(Int32.Parse(comboBoxQuestions.SelectedItem.ToString()) - 1), 1];
            textBoxAnswer1.Text = Quiz[(Int32.Parse(comboBoxQuestions.SelectedItem.ToString()) - 1), 2];
            textBoxAnswer2.Text = Quiz[(Int32.Parse(comboBoxQuestions.SelectedItem.ToString()) - 1), 3];
            numericUpDownAns1Rep.Value = Int32.Parse(Quiz[(Int32.Parse(comboBoxQuestions.SelectedItem.ToString()) - 1), 4]);
            numericUpDownAns1Virus.Value = Int32.Parse(Quiz[(Int32.Parse(comboBoxQuestions.SelectedItem.ToString()) - 1), 5]);
            numericUpDownAns2Rep.Value = Int32.Parse(Quiz[(Int32.Parse(comboBoxQuestions.SelectedItem.ToString()) - 1), 6]);
            numericUpDownAns2Virus.Value = Int32.Parse(Quiz[(Int32.Parse(comboBoxQuestions.SelectedItem.ToString()) - 1), 7]);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this question", "Delete Question", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(result == DialogResult.Yes)
            {
                deleteQuestion();
            }
        }

        private void deleteQuestion()
        {
            int questionID = Int32.Parse(labelQuestionNumDisplay.Text);

            String questionDelete = "DELETE FROM questions WHERE questionID = @questionID;";
            String solutionDelete = "DELETE FROM solutions WHERE questionID = @questionID;";
            try
            {
                con.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
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
                    MessageBox.Show(err.Message);
                }
            }

            using (var cmd = new SqlCommand(questionDelete, con))
            {
                cmd.Parameters.AddWithValue("@questionID", questionID);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            con.Close();
            
            MessageBox.Show("Question was deleted from the Database");
            Admin admin = new Admin();
            admin.Show();
            this.Close();
            this.Dispose();
        }
    }
}
