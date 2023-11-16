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
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		public IActionResult Basic()
		{
			List<Cities> citiesBasic = new DataAccess.CitiesQueries().BasicCity();

			return View(citiesBasic);
		}

		public IActionResult Optional1()
		{
			List<Cities> citiesOpt1 = new DataAccess.CitiesQueries().Opt1City();

			return View(citiesOpt1);
		}

		public IActionResult Optional2()
		{
			List<Cities> citiesOpt2 = new DataAccess.CitiesQueries().Opt2City();

			return View(citiesOpt2);
		}

		public IActionResult Optional3()
		{
			List<Cities> citiesOpt3 = new DataAccess.CitiesQueries().Opt3City();

			return View(citiesOpt3);
		}

		public IActionResult Optional4()
		{
			List<Cities> citiesOpt4 = new DataAccess.CitiesQueries().Opt4City();

			return View(citiesOpt4);
		}

		public IActionResult Optional5()
		{
			List<Cities> citiesOpt5 = new DataAccess.CitiesQueries().Opt5City();

			return View(citiesOpt5);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}