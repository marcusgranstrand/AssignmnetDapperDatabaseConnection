using AssignmnetDapperDatabaseConnection.Models;
using Dapper;
using MySqlConnector;

namespace AssignmnetDapperDatabaseConnection.DataAccess
{
	public class CitiesQueries
	{
		public CitiesQueries() 
		{ }

		public List<Cities> ReadCities()
		{
			List<Cities> cities = new List<Cities>();

			string sqlQuery = "" +
			"SELECT id, name, population, countrycode " +
			"FROM city " +
			"WHERE population " +
			"BETWEEN 15000 " +
			"AND 350000";

			string conString = "server=localhost;database=world;AllowUserVariables=True;password=123456789;user=root";

			using(var connection = new MySqlConnection(conString))
			{
				cities = connection.Query<Cities>(sqlQuery).ToList();
			}

			return cities;
		}

	}
}
