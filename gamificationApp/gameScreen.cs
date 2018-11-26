using System;
using System.Windows.Forms;

namespace gamificationApp
{
    public partial class GameScreen : Form
    {
        //This holds the current version number
        private String version = ImportantCode.version;

        //This stores how many questions are in the database
        static int numberOfQuestions;

        //This will hold all the questions held in the database
        String[,] Quiz;
        
        //This will keep track of how much time is remaining
        int timeLeft;

        //This will track the current question number
        int questionNumber = 0;

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
            Questions test = new Questions();

            //This checks how many questions there are
            numberOfQuestions = Questions.questionCount();
            //This initialises the 2D Array for the Questions
            Quiz = new String[numberOfQuestions, 8];
            //This fills the 2D Array with the questions recieved from the Questions class.
            Quiz = Questions.getQuestions(numberOfQuestions);
            //Fills in the first question
            fillQuestion();

            labelVersion.Text = ImportantCode.version;
        }

        //This uses code taken from the Small Scale App done in HND Computing: Software Development Year 2
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

        //This takes the values for the first solution and updates the progress bars
        private void solution1Button_Click(object sender, EventArgs e)
        {
            virusProgress.Increment(Int32.Parse(Quiz[questionNumber, 5])); //This increases or decreases the progress bar based on the virus level set for this solution
            repProgress.Increment(Int32.Parse(Quiz[questionNumber, 4])); //This increases or decreases the progress bar based on the rep level set for this solution
            //This checks if the progress bars have reached the values which would cause the program to end, if not it moves to check if there are more questions
            //If it is, it ends the quiz and checks for the reason.
            if (repProgress.Value > repProgress.Minimum && virusProgress.Value < virusProgress.Maximum)
            {
                questionCheck();
            }
            else
            {
                endQuiz(endingCheck());
            }
        }
        //This takes the values for the first solution and updates the progress bars
        private void solution2Button_Click(object sender, EventArgs e)
        {

            virusProgress.Increment(Int32.Parse(Quiz[questionNumber, 7])); //This increases or decreases the progress bar based on the virus level set for this solution
            repProgress.Increment(Int32.Parse(Quiz[questionNumber, 6])); //This increases or decreases the progress bar based on the rep level set for this solution
            //This checks if the progress bars have reached the values which would cause the program to end, if not it moves to check if there are more questions
            //If it is, it ends the quiz and checks for the reason.
            if (repProgress.Value > repProgress.Minimum && virusProgress.Value < virusProgress.Maximum)
            {
                questionCheck();
            } else
            {
                endQuiz(endingCheck());
            }
        }

        //This reloads the page to reset the quiz for the user.
        private void resetQuiz_Click(object sender, EventArgs e)
        {
            GameScreen game = new GameScreen();
            game.Show();
            this.Close();
            this.Dispose();
        }

        //This method fills the question box and each of the solution buttons with the relevant text from the 2D Quiz Array
        private void fillQuestion()
        {
            quizContent.Text = "This is Question " + (questionNumber + 1) + " of " + numberOfQuestions + Environment.NewLine + Quiz[questionNumber, 1];
            
            solution1Button.Text = Quiz[questionNumber, 2];
            solution2Button.Text = Quiz[questionNumber, 3];
        }

        //This method checks if there are any questions left, if there are it fills the next one otherwise it ends the quiz
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

        //This method stops the timer to end the quiz and moves to the scoreboard, sending the reason, virus and Rep Values and time remaining.
        private void endQuiz(String endReason)
        {
            timer1.Stop();

            Scoreboard score = new Scoreboard(endReason, virusProgress.Value, repProgress.Value, timeLeft);
            score.Show();
            this.Close();
            this.Dispose();
        }

        //This checks why the game ended if the Virus goes over the Maximum or Rep below the minimum and returns this value
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

        //This takes the user back to the main menu.
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Close();
            this.Dispose();
        }
    }
}
