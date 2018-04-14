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
		/// <summary>
		/// Creates a form with functionality to compute the molar mass.
		/// </summary>
		public MolarMassForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Computes molar mass based on an input element and mass.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MolarMassButton_Click(object sender, EventArgs e) 
		{
			double weight = 1;
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
					weight = GetWeightFromDB(connection, element);
				}
			}
			catch (SqlException f)
			{
				Console.WriteLine(f.ToString());
			}

			try
			{
				MolarResultBox.Text = (Double.Parse(MassBox.Text) / weight).ToString();
			}
			catch
			{
				MolarResultBox.Text = "Error";
			}
		}

		/// <summary>
		/// Performs a SQL query that returns the atomic weight of an element
		/// from a database based on the input element.
		/// </summary>
		/// <param name="connection">The database connection information.</param>
		/// <param name="element">The symbol for the element of interest.</param>
		/// <returns>Returns the atomic weight of the element of interest.</returns>
		static double GetWeightFromDB(SqlConnection connection, string element)
		{
			element.Replace("\'", "");
			element.Replace(";", "");
			element.Replace("\"", "");

			string tsql = "select atomic_weight from Elements WHERE symbol = \'" + element + "\';";
			double weight = 1;
			using (var command = new SqlCommand(tsql, connection))
			{
				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						weight = reader.GetDouble(0);
					}
				}
			}
			return weight;
		}
	}
}
