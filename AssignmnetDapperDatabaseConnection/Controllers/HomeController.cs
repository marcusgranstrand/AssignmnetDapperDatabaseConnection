using AssignmnetDapperDatabaseConnection.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AssignmnetDapperDatabaseConnection.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			List<Cities>listOfCities = new DataAccess.CitiesQueries().ReadCities();

			return View(listOfCities);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}