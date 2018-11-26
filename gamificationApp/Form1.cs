using System;
using System.Windows.Forms;

namespace gamificationApp
{
    //This form uses code that was created for my Graded Unit 2 - HND Computing: Software Development Application. 
    public partial class Form1 : Form
    {
        //This holds the current version number
        private String version = ImportantCode.version;

        public Form1()
        {
            InitializeComponent();
            versionSet();
        }

        private void versionSet()
        {
            labelVersion.Text = ImportantCode.version;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            String userName = userTextbox.Text;
            String password = passwordTextbox.Text;

            //This checks if the information entered by the user is Null or Whitespace
            //If it is, it alerts the user to this and lets them try again

            if (string.IsNullOrWhiteSpace(userName) || string.Equals(userName, "Enter Username")) {
                MessageBox.Show("Please enter your username");
            } else if (string.IsNullOrWhiteSpace(password)) {
                MessageBox.Show("Please enter your Password!");
            } else {
                loginCheck(userName, password);
            }
        }
        
        //This runs the login check through the User Queries and based on the result either sends the User ot the main menu
        //or asks them to try logging in again.
        private void loginCheck(string userName, string inputPassword)
        {
            bool result = sqlQueries.UserQueries.loginCheck(userName, inputPassword);
                if (result == true)
                {
                    userDetails.userName = userName;
                    MainMenu menu1 = new MainMenu();
                    menu1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please try to login Again");
                }
        }

        //This is accidental
        private void labelHeader_Click(object sender, EventArgs e)
        {

        }

        //This closes the program when clicked by the user.
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
