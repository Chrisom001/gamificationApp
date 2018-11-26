using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gamificationApp
{
    public partial class Form1 : Form
    {
        //This holds the current DB Connection String
        private static String dbConnection = ImportantCode.dbConnection;

        //This holds the current version number
        private String version = ImportantCode.version;

        //This starts the SQL Connection
        SqlConnection con = new SqlConnection(@"" + dbConnection + "");

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
        
        private void loginCheck(string userName, string inputPassword)
        {
                SqlDataReader sdr;
                Boolean result = false;

            //This connects to the database to check if the User ID and Password are correct.
            // If they are, it returns a true result and moves the user to the Main Menu
            // If not, they are shown an error and are told to try to login again

            
            con.Open();
                String query = "SELECT * FROM dbo.users WHERE userName = @userName AND password = @password";
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@password", inputPassword);
                    sdr = cmd.ExecuteReader();
                    result = sdr.Read();
                }
                con.Close();

                if (result == true)
                {

                    userDetails.userName = userName;
                    MainMenu menu1 = new MainMenu();
                    menu1.Show();
                    this.Hide();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please try to login Again");
                }
        }

        private void labelHeader_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
