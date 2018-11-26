using System;
using System.Windows.Forms;

namespace gamificationApp
{
    public partial class Scoreboard : Form
    {
        //This stores the Reason the game ended
        String endingReason = "";

        //This stores the value of the Virus bar
        int virus = 0;

        //This stores the value of the Rep bar
        int rep = 0;

        //This stores the amount of time left
        int timeLeft = 0;
        public Scoreboard(String end, int finalVirus, int finalRep, int time)
        {
            //This stores the reason the game ended which was passed by the GameScreen form
            endingReason = end;
            //This stores the value of the Virus progress bar once the game ended.
            virus = finalVirus;
            //This stores the value of the Rep progress bar once the game ended
            rep = finalRep;
            //This stores the remaining time on the clock once the game ended
            timeLeft = time;
            InitializeComponent();
            //This starts the method to display the end reason on the screen for the user
            endReason();
            //This starts the method to display the version number
            version();
        }

        //This sets the version number at the bottom of the screen
        public void version()
        {
            labelVersion.Text = ImportantCode.version;
        }

        //This method takes the reason the game ended and works through a nested IF statement to 
        //display the applicable reason to the user
        private void endReason()
        {
            if (endingReason.Equals("outoftime"))
            {
                labelHeader.Text = "The game ended because you ran out of time." + Environment.NewLine + Environment.NewLine + "Your score is below";
            }
            else if (endingReason.Equals("outofquestions"))
            {
                labelHeader.Text = "You answered all of the questions without getting too high of a reputation or virus. Well Done." + Environment.NewLine + Environment.NewLine + "Your score is below";
            }
            else if (endingReason.Equals("virus"))
            {
                labelHeader.Text = "The game ended because your virus level was too high, try to remember to follow good internet practices." + Environment.NewLine + Environment.NewLine + "Your score is below";
            }
            else if (endingReason.Equals("rep"))
            {
                labelHeader.Text = "The game ended because your rep was too low, try to remember that what you do online effects how others think of you." + Environment.NewLine + Environment.NewLine + "Your score is below";
            }
            //If nothing is passed through by the Game Screen page, then this will execute to indicate there has been an error within the program.
            else
            {
                labelHeader.Text = "There has been a problem with the program, please go back to the main menu and try again";
            }

            //This starts the method to display the Score
            fillScore();
        }

        //This method takes the scores given from the Game Screen and displays them
        private void fillScore()
        {
            labelVirus.Text = "Virus: " + virus.ToString(); // Puts the Virus score into the Label on screen
            labelRep.Text = "Rep: " + rep.ToString(); // Puts the Rep score into the label on screen
            labelTime.Text = "Time Left: " + timeLeft.ToString() + " Seconds"; // Puts the Time Left into the label on screen
            
        }

        //This sends the user back to the main menu.
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Close();
            this.Dispose();
        }
    }
}
