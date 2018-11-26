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
            endingReason = end;
            virus = finalVirus;
            rep = finalRep;
            timeLeft = time;
            InitializeComponent();
            endReason();
            version();
        }

        public void version()
        {
            labelVersion.Text = ImportantCode.version;
        }

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
            else
            {
                labelHeader.Text = "There has been a problem with the program, please go back to the main menu and try again";
            }

            fillScore();
        }

        private void fillScore()
        {
            labelVirus.Text = "Virus: " + virus.ToString();
            labelRep.Text = "Rep: " + rep.ToString();
            labelTime.Text = "Time Left: " + timeLeft.ToString() + " Seconds";
            
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
