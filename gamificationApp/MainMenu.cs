using System;
using System.Windows.Forms;

namespace gamificationApp
{
    public partial class MainMenu : Form
    {
        //This holds the current version number
        private String version = ImportantCode.version;

        public MainMenu()
        {
            InitializeComponent();
            importantStart();
            buttonVisibility();
        }

        private void importantStart()
        {
            labelVersion.Text = ImportantCode.version;
            sqlQueries.UserQueries.roleCheck();
        }

        //This takes the user to the start of the game.
        private void gameStartButton_Click(object sender, EventArgs e)
        {
            GameScreen game = new GameScreen();
            game.Show();
            this.Close();
            this.Dispose();
        }

        //This checks if the users roles is an admin, if so it will display the admin button.
        private void buttonVisibility()
        {
            if(userDetails.role == "admin")
            {
                adminButton.Visible = true;
            }
        }

        //This takes the user to the admin menu.
        private void adminButton_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
            this.Dispose();
        }

        //This logs the user out and defaults the userdetails to nothing.
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            userDetails.role = "";
            userDetails.userID = 0;
            userDetails.userName = "";
            logout.Show();
            this.Close();
            this.Dispose();
        }
    }
}
