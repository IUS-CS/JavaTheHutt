using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Browser
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Attempts to authenticate username and passphrase when button is clicked
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event argument sent by button</param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            String username = UserNameBox.Text;
            String passphrase = PassphraseBox.Text;

            try
            {
                var cb = new SqlConnectionStringBuilder();
                cb.DataSource = "c346.database.windows.net";
                cb.UserID = "js";
                cb.Password = "Postgres1";
                cb.InitialCatalog = "Chem";

                using (var connection = new SqlConnection(cb.ConnectionString))
                {
                    connection.Open();

                    //This is how you can insert data -- use the relevent static string below
                    //Note: you can't add the same information twice, so don't run this command
                    //with the same values twice
                    //Submit_Tsql_NonQuery(connection, "3 - Inserts",
                    //   Build_3_Tsql_Inserts());


                    //This is how you query use the relevant static string and function below
                    //You can test the file by only running this command
                    string password = GetPasswordFromDB(connection, username);
                    if (password.Equals(passphrase))
                    {
                        SK_m_0 browser = new SK_m_0(username);
                        this.Hide();
                        browser.ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (SqlException sqlException)
            {
                Console.WriteLine(sqlException.ToString());
            }
        }

        /// <summary>
        /// Attempts to authenticate username and passphrase when ENTER is pressed
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event argument sent by button</param>
        private void PassphraseBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                String username = UserNameBox.Text;
                String passphrase = PassphraseBox.Text;

                try
                {
                    var cb = new SqlConnectionStringBuilder();
                    cb.DataSource = "c346.database.windows.net";
                    cb.UserID = "js";
                    cb.Password = "Postgres1";
                    cb.InitialCatalog = "Chem";

                    using (var connection = new SqlConnection(cb.ConnectionString))
                    {
                        connection.Open();

                        //This is how you can insert data -- use the relevent static string below
                        //Note: you can't add the same information twice, so don't run this command
                        //with the same values twice
                        //Submit_Tsql_NonQuery(connection, "3 - Inserts",
                        //   Build_3_Tsql_Inserts());


                        //This is how you query use the relevant static string and function below
                        //You can test the file by only running this command
                        string password = GetPasswordFromDB(connection, username);
                        if (password.Equals(passphrase))
                        {
                            SK_m_0 browser = new SK_m_0(username);
                            this.Hide();
                            browser.ShowDialog();
                            this.Close();
                        }
                    }
                }
                catch (SqlException sqlException)
                {
                    Console.WriteLine(sqlException.ToString());
                }
            }
        }

        /// <summary>
        /// Searches for a webpage corresponding to URLBox.Text
        /// </summary>
        /// <param name="connection">Connection string to the database</param>
        /// <param name="user_name">The username pulled from database</param>
        static string GetPasswordFromDB(SqlConnection connection, string user_name)
        {
            user_name.Replace("\'", "");
            user_name.Replace(";", "");
            user_name.Replace("\"", "");

            string tsql = "select password from Users WHERE user_name = \'" + user_name + "\';";
            string password = "";
            using (var command = new SqlCommand(tsql, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        password = reader.GetString(0);
                    }
                }
            }
            return password;
        }
    }
}

