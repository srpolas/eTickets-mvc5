using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
	public class ActorsController : Controller
	{
		// GET Data
		private readonly IActorsService _service;
		public ActorsController(IActorsService service)
		
		{
			_service = service;
		}
	
		public async Task<IActionResult> Index()
		{
			var data = await _service.GetAll();
			return View(data);
		}

		//Get : Actors/Create
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Edit()
		{
			return View();
		}

	}
}
