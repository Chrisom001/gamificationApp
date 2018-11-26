using System;
using System.Windows.Forms;

namespace gamificationApp
{
    public partial class Admin : Form
    {
        //This stores how many questions are in the database
        static int numberOfQuestions;

        //This will hold all the questions held in the database
        String[,] Quiz;

        //This will create an array for the rep/virus values
        int[] values;

        //This will hold the result of the SQL Queries
        String result = "";

        private String adminChoice = "";

        public Admin()
        {
            InitializeComponent();
            importantStart();
        }

        public void importantStart()
        {
            Questions test = new Questions();

            labelVersion.Text = ImportantCode.version;
            //This checks how many questions there are
            numberOfQuestions = Questions.questionCount();
            //This initialises the 2D Array for the Questions
            Quiz = new String[numberOfQuestions, 8];

            //This fills the dropdown
            for (int i = 0; i < numberOfQuestions; i++)
            {
                comboBoxQuestions.Items.Add(i + 1);
            }

            //This fills the 2D Array with the questions recieved from the Questions class.
            Quiz = Questions.getQuestions(numberOfQuestions);
        }

        //This method checks that the user has entered text into each of the text boxes and alerts them if they haven't done so
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

        //This method checks the input given by the user and compares it to a list of swear words to ensure they don't make it into the database
        //and become visible to children.
        private void profanityCheck(String question, String solution1, String solution2)
        {
            bool swearing = false;
            //This loops through the list of swear words currently stored
            for(int i = 0; i< ProfanityCheck.profanity.Length; i++)
            {
                //This checks the question against the current word in the list, If there is swearing it breaks the loop
                //And changes Swearing to true so this can be highlighted to the user.
                if (question.ToLower().Contains(ProfanityCheck.profanity[i]))
                {
                    badLanguageUsed(ProfanityCheck.profanity[i], "question");
                    swearing = true;
                    break;
                } else
                {
                    //This checks the First Solution against the current word in the list, If there is swearing it breaks the loop
                    //And changes Swearing to true so this can be highlighted to the user.
                    if (solution1.ToLower().Contains(ProfanityCheck.profanity[i]))
                    {
                        badLanguageUsed(ProfanityCheck.profanity[i], "first solution");
                        swearing = true;
                        break;
                    } else
                    {
                        //This checks the Second Solution against the current word in the list, If there is swearing it breaks the loop
                        //And changes Swearing to true so this can be highlighted to the user.
                        if (solution2.ToLower().Contains(ProfanityCheck.profanity[i]))
                        {
                            badLanguageUsed(ProfanityCheck.profanity[i], "second solution");
                            swearing = true;
                            break;
                        }
                    }
                }
            }
            //If the program doesn't detect any swearing, it will then move to remove special characters
            if (!swearing)
            {
                //This removes special characters from the question and solution, and then returns it as a String Array
                String[] cleanedInput = InputCleaning.specialCharacterRemoval(question, solution1, solution2);
                //This takes each of the values given for the Rep/Virus in solutinos and places them into an array
                values = new int[4] { Int32.Parse(numericUpDownAns1Rep.Value.ToString()), Int32.Parse(numericUpDownAns1Virus.Value.ToString()), Int32.Parse(numericUpDownAns2Rep.Value.ToString()), Int32.Parse(numericUpDownAns2Virus.Value.ToString())};
                sqlQueries.QuestionQueries queries = new sqlQueries.QuestionQueries();
                //This checks if this is a new question or edited, and then submits the cleaned string and values to the relevant SQL Queries to be updated
                //in the database.
                if (adminChoice.Equals("new"))
                {
                    result = sqlQueries.QuestionQueries.insertQuestionIntoDatabase(cleanedInput, values);
                    if (result.Equals("success"))
                    {
                        MessageBox.Show("Question was added successfully");
                        Admin admin = new Admin();
                        admin.Show();
                        this.Close();
                        this.Dispose();
                    } else
                    {
                        MessageBox.Show(result);
                    }
                } else if (adminChoice.Equals("edit"))
                {
                    result = sqlQueries.QuestionQueries.updateQuestionInDatabase(Int32.Parse(labelQuestionNumDisplay.Text), cleanedInput, values);
                    if (result.Equals("success"))
                    {
                        MessageBox.Show("Question was updated successfully");
                        Admin admin = new Admin();
                        admin.Show();
                        this.Close();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show(result);
                    }
                }
            }
        }
        //This takes the swear word used by the user and location, and highlights it
        private void badLanguageUsed(String word, String location)
        {
            MessageBox.Show("You used a swear word which was " + word + " in " + location);
        }

        //This method unhides buttons and areas where applicable for the program to run.
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
            //If there is a problem with the program detecting what kind of change is being made, it will highlight this nad ask the user to move back
            //To the main menu and try again.
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

        //This method takes the current value that has been selected in the combo box and puts the relevant options from the Quiz array 
        //into the sections for the user to edit.
        private void comboBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        //This returns the user to the Main Menu.
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Hide();
            this.Dispose();
        }

        //This takes the text input from the user and begins to run through the checks.
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string question = textBoxQuestion.Text;
            string solution1 = textBoxAnswer1.Text;
            string solution2 = textBoxAnswer2.Text;

            textEntryCheck(question, solution1, solution2);
        }

        //This method takes the question number and deletes the question from the database after the user confirms.
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this question", "Delete Question", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                int questionID = Int32.Parse(labelQuestionNumDisplay.Text);
                String result1 = sqlQueries.QuestionQueries.deleteQuestion(questionID);
                if (result1.Equals("success"))
                {
                    MessageBox.Show("Question was deleted from the Database");
                    Admin admin = new Admin();
                    admin.Show();
                    this.Close();
                    this.Dispose();
                } else
                {
                    MessageBox.Show("Error: " + result1);
                }
            }
        }

        //This button shows the sections valid for adding a new question to the database
        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            adminChoice = "new";

            sectionVisibility();
        }

        //This button show the sections valid for editing a question in the database.
        private void buttonEditQuestion_Click(object sender, EventArgs e)
        {
            //This checks to make sure there are questions in the database, if there are none, it will highlight this to the user.
            if (numberOfQuestions == 0)
            {
                MessageBox.Show("There are no questions in the Database, please enter one before editing");
            }
            else
            {
                adminChoice = "edit";
                comboBoxQuestions.Visible = true;
                labelQuestionList.Visible = true;
            }

        }
    }
}
