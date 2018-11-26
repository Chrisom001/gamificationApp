using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gamificationApp
{
    public partial class GameScreen : Form
    {
        //This holds the current DB Connection String
        private static String dbConnection = ImportantCode.dbConnection;

        //This holds the current version number
        private String version = ImportantCode.version;

        //This stores how many questions are in the database
        static int numberOfQuestions;

        //This will hold all the questions held in the database
        String[,] Quiz;

        //This will hold the solutions for the current question
        int[] Solution;

        //This will keep track of how much time is remaining
        int timeLeft;

        //This will track the current question number
        int questionNumber = 0;

        //This is the SQL Connection String
        static SqlConnection con = new SqlConnection(@"" + dbConnection + "");



        public GameScreen()
        {
            InitializeComponent();
            importantStartup();

            //Sets the timers second and label
            timeLeft = 80;
            timeLabel.Text = "80 Seconds";

            //Starts the timer
            timer1.Start();
        }



        private void importantStartup()
        {

            //This checks how many questions there are
            numberOfQuestions = questionCount();
            //This initialises the 2D Array for the Questions
            Quiz = new String[numberOfQuestions, 4];
            //This initialises the Array for the solutions
            Solution = new int[4];
            //Takes all questions and Inputs them into the Array
            getQuestions();
            //Fills in the first question
            fillQuestion();

            labelVersion.Text = ImportantCode.version;
        }

        private void getQuestions()
        {
            //SQL Query to get all questions from the database
            String query = "SELECT * FROM dbo.questions";

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
                        i++;
                    }
                    reader.Close();
                }
            }
            con.Close();
        }

        private void getSolution()
        {
            //SQL Query to get solutions based on question number
            String query = "Select * FROM dbo.solutions WHERE questionID = " + Quiz[questionNumber, 0] + "";
            con.Open();
            using (var cmd = new SqlCommand(query, con))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                       Solution[0] = Int32.Parse(reader["solution1Rep"].ToString());
                       Solution[1] = Int32.Parse(reader["solution1Virus"].ToString());
                       Solution[2] = Int32.Parse(reader["solution2Rep"].ToString());
                       Solution[3] = Int32.Parse(reader["solution2Virus"].ToString());
                    }
                }
            }
            con.Close();           
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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                //Display the new time left by updating the label
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                endQuiz("outoftime");
            }
        }

        private void solution1Button_Click(object sender, EventArgs e)
        {
            virusProgress.Increment(Solution[1]);
            repProgress.Increment(Solution[0]);
            if (repProgress.Value > repProgress.Minimum && virusProgress.Value < virusProgress.Maximum)
            {
                questionCheck();
            }
            else
            {
                endQuiz(endingCheck());
            }
        }

        private void solution2Button_Click(object sender, EventArgs e)
        {
            virusProgress.Increment(Solution[3]);
            repProgress.Increment(Solution[2]);
            if (repProgress.Value > repProgress.Minimum && virusProgress.Value < virusProgress.Maximum)
            {
                questionCheck();
            } else
            {
                String endCheck = endingCheck();
                endQuiz(endCheck);
            }
        }

        private void resetQuiz_Click(object sender, EventArgs e)
        {
            GameScreen game = new GameScreen();
            game.Show();
            this.Close();
            this.Dispose();
        }

        private void fillQuestion()
        {
            quizContent.Text = "This is Question " + Quiz[questionNumber, 0] + " of " + numberOfQuestions + Environment.NewLine + Quiz[questionNumber, 1];
            //option1Label.Text = Quiz[questionNumber, 2];
            //option2Label.Text = Quiz[questionNumber, 3];
            
            solution1Button.Text = Quiz[questionNumber, 2];
            solution2Button.Text = Quiz[questionNumber, 3];
            getSolution();
        }

        private void questionCheck()
        {
            questionNumber++;
            if (questionNumber < Quiz.GetLength(0))
            {
                fillQuestion();
            }
            else
            {
                endQuiz("outofquestions");
            }
        }

        private void endQuiz(String endReason)
        {
            timer1.Stop();

            Scoreboard score = new Scoreboard(endReason, virusProgress.Value, repProgress.Value, timeLeft);
            score.Show();
            this.Close();
            this.Dispose();
        }

        private String endingCheck()
        {
            String endValue;
            if (virusProgress.Value == virusProgress.Maximum)
            {
                endValue = "virus";
            } else if (repProgress.Value == 0) {
                endValue = "rep";
            } else
            {
                endValue = "fail";
            }
            return endValue;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Close();
            this.Dispose();
        }
    }
}
