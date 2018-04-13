using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Browser
{
	public partial class MolarMassForm : Form
	{
		public MolarMassForm()
		{
			InitializeComponent();
		}

		private void MolarMassButton_Click(object sender, EventArgs e) // TODO
		{
			string weight = "";
			string element = ElementBox.Text;

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

					//This is how you query use the relevant static string and function below
					//You can test the file by only running this command
					weight = GetWeightFromDB(connection, element);
				}
			}
			catch (SqlException f)
			{
				Console.WriteLine(f.ToString());
			}
			double data = Double.Parse(weight);

			try
			{
				MolarResultBox.Text = (Double.Parse(MassBox.Text) / data).ToString();
			}
			catch
			{
				MolarResultBox.Text = "Error";
			}
		}


		static string GetWeightFromDB(SqlConnection connection, string element)
		{
			element.Replace("\'", "");
			element.Replace(";", "");
			element.Replace("\"", "");

			string tsql = "select atomic_weight from Elements WHERE symbol = \'" + element + "\';";
			string weight = "";
			using (var command = new SqlCommand(tsql, connection))
			{
				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						weight = reader.GetString(0);
					}
				}
			}
			return weight;
		}
	}
}
