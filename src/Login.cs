using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Browser
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String username = UserNameBox.Text;
            String passphrase = PassphraseBox.Text;

            
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            NpgsqlConnection conn = new NpgsqlConnection();
            //conn.ConnectionString = "User ID=postgres; Password=123; Host=localhost Port=5432; Database=Users; Pooling=true; Min Pool Size=100; Connection Lifetime=0;";
            conn.ConnectionString = "Host = 192.168.0.19; Port = 5432; Username = postgres; Password = 123; Database = users; ";
            conn.Open();
            String sql = "SELECT password FROM users.users_schema.user_info WHERE user_name = \'" + username +"\'";
            NpgsqlCommand command = new NpgsqlCommand(sql, conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
            da.Fill(dt);
            NpgsqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                foreach(DataRow row in dt.Rows)
                {
                    if (passphrase.Equals(row[0]))
                    {
                        SK_m_0 browser = new SK_m_0(username);
                        this.Hide();
                        browser.ShowDialog();
                        this.Close();
                    }
                }
            }
        }
    }
}
