using System.Data;
using Microsoft.Data.SqlClient;
using SuperMaker.Database.Commands;
using SuperMaker.Database.Database;
using SuperMaker.Database.Models;

namespace SuperMarket.App
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private bool isCustomer = true;

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void login_click(object sender, EventArgs e)
        {
            try
            {
                string phoneEmail = Identitfier.Text;
                if (string.IsNullOrEmpty(phoneEmail))
                {
                    MessageBox.Show("Phone or email is required!");
                    return;
                }
                string password = Password.Text;
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Password is required !");
                    return;
                }

                var db = new SuperMarketDB();
                db.OpenConnection();

                string loginCommand = isCustomer ? LogInCommands.CustomerLogin : LogInCommands.AdminLogin;
                SqlCommand cmd = db.Command(loginCommand);

                cmd.Parameters.Add(new SqlParameter(LogInCommandParameters.Identifier, SqlDbType.NVarChar)
                { Value = phoneEmail });

                cmd.Parameters.Add(new SqlParameter(LogInCommandParameters.Password, SqlDbType.NVarChar)
                { Value = password });

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Session.LoggedInUser = User.CreateFromReader(reader);
                        Session.IsAdmin = isCustomer;
                        MessageBox.Show("Welcome " + Session.LoggedInUser.FullName);
                    }
                    else
                    {
                        MessageBox.Show("User was not found, please try again !");

                    }
                }


                db.CloseConnection();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Coludn't complete your request !");
            }

        }

        private void adminLogIn_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isCustomer = false;
            AdminLogIn.Visible = false;
            CustomerLogIn.Visible = true;
            WelcomeLabel.Visible = false;
            welcomeAdmin.Visible = true;
        }

        private void customerLogIn_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isCustomer = true;
            AdminLogIn.Visible = true;
            CustomerLogIn.Visible = false;
            WelcomeLabel.Visible = true;
            welcomeAdmin.Visible = false;
        }
    }
}