using AssignmnetDapperDatabaseConnection.Models;
using Dapper;
using Microsoft.Identity.Client;
using MySqlConnector;
using System.Data;

namespace AssignmnetDapperDatabaseConnection.DataAccess
{
	public class CitiesQueries
	{
		public CitiesQueries() 
		{ }

		public List<Cities> Opt1City()
		{
			List<Cities> citiesOptional1 = new List<Cities>();			

			// sqlOptional1 needs working on since syntax diff.
			string sqlOptional1 = "" +
			"SELECT id, name, population, countrycode " +
			"FROM city " +
			"WHERE population " +
			"BETWEEN 15000 " +
			"AND 350000 " +
			"LIMIT 100 ";

			string conString = "server=localhost;database=world;AllowUserVariables=True;password=123456789;user=root";

			using (var connection = new MySqlConnection(conString))
			{
				citiesOptional1 = connection.Query<Cities>(sqlOptional1).ToList();
			}

			return citiesOptional1;

		}

		public List<Cities> Opt2City()
		{
			List<Cities> citiesOptional2 = new List<Cities>();

			// sqlOptional2 works in MySQL Workbench
			string sqlOptional2 = "" +
			"SELECT name, countrycode " +
			"FROM city " +
			"ORDER BY countrycode Desc ";			

			string conString = "server=localhost;database=world;AllowUserVariables=True;password=123456789;user=root";

			using (var connection = new MySqlConnection(conString))
			{
				citiesOptional2 = connection.Query<Cities>(sqlOptional2).ToList();
			}

			return citiesOptional2;
		}

		public List<Cities> Opt3City()
		{
			List<Cities> citiesOptional3 = new List<Cities>();

			// sqlOptional3 works in MySQL Workbench
			string sqlOptional3 = "" +
			"SELECT name, lifeexpectancy,continent " +
			"FROM country " +
			"WHERE lifeexpectancy IS NOT NULL " +
			"AND continent = 'europe' " +
			"ORDER BY lifeexpectancy DESC ";

			string conString = "server=localhost;database=world;AllowUserVariables=True;password=123456789;user=root";

			using (var connection = new MySqlConnection(conString))
			{
				citiesOptional3 = connection.Query<Cities>(sqlOptional3).ToList();
			}

			return citiesOptional3;

		}

		public List<Cities> Opt4City()
		{
			List<Cities> citiesOptional4 = new List<Cities>();

			// sqlOptional4 works in MySQL Workbench
			string sqlOptional4 = "" +
			"SELECT name, countrycode " +
			"FROM city " +
			"WHERE countrycode = 'swe' ";

			string conString = "server=localhost;database=world;AllowUserVariables=True;password=123456789;user=root";

			using (var connection = new MySqlConnection(conString))
			{
				citiesOptional4 = connection.Query<Cities>(sqlOptional4).ToList();
			}

			return citiesOptional4;
		}

		public List<Cities> Opt5City()
		{
			List<Cities> citiesOptional5 = new List<Cities>();

			// sqlOptional5 works in MySQL Workbench
			string sqlOptional5 = "" +
			"SELECT city.name, country.continent, country.lifeexpectancy " +
			"FROM city " +
			"INNER JOIN country " +
			"ON country.code = city.countrycode " +
			"WHERE countrycode IN " +
			"		(SELECT code " +
			"		FROM country " +
			"		WHERE code IN " +
			"				(SELECT code " +
			"				FROM country " +
			"				WHERE lifeexpectancy > 50)) " +
			"				AND continent = 'africa' ";


			string conString = "server=localhost;database=world;AllowUserVariables=True;password=123456789;user=root";

			using (var connection = new MySqlConnection(conString))
			{
				citiesOptional5 = connection.Query<Cities>(sqlOptional5).ToList();
			}

			return citiesOptional5;

		}	
		
		public List<Cities> BasicCity()
		{ 
			List<Cities> citiesBasic = new List<Cities>();

			// sqlBasic works in MySQL Workbench
			string sqlBasic = "" +
			"SELECT id, name, population, countrycode " +
			"FROM city " +
			"WHERE population " +
			"BETWEEN 15000 " +
			"AND 350000";

			string conString = "server=localhost;database=world;AllowUserVariables=True;password=123456789;user=root";

			using (var connection = new MySqlConnection(conString))
			{
				citiesBasic = connection.Query<Cities>(sqlBasic).ToList();
			}

			return citiesBasic;

		}
	}
}
