using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gamificationApp
{
    public partial class MainMenu : Form
    {
        //This holds the current DB Connection String
        private static String dbConnection = ImportantCode.dbConnection;

        //This holds the current version number
        private String version = ImportantCode.version;

        //This creates the SQL connection
        SqlConnection con = new SqlConnection(@"" + dbConnection + "");

        public MainMenu()
        {
            InitializeComponent();
            versionSet();
            roleCheck();
            buttonVisibility();
        }

        private void versionSet()
        {
            labelVersion.Text = ImportantCode.version;
        }

        private void roleCheck()
        {
            con = new SqlConnection(@"" + dbConnection + "");
            con.Open();
            String query = "SELECT role FROM dbo.users WHERE userName = @userName";
            using (var cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@userName", userDetails.userName);
                userDetails.role = (String)cmd.ExecuteScalar();
            }
            con.Close();
        }

        private void gameStartButton_Click(object sender, EventArgs e)
        {
            GameScreen game = new GameScreen();
            game.Show();
            this.Close();
            this.Dispose();
        }

        private void buttonVisibility()
        {
            if(userDetails.role == "admin")
            {
                adminButton.Visible = true;
            }
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
            this.Dispose();
        }

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
