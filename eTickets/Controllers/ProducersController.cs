﻿using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
	public class ProducersController : Controller
	{
		// GET Data
		private readonly IProducersService _service;
		public ProducersController(IProducersService service)

		{
			_service = service;
		}
		// GET: All Producers
		public async Task<IActionResult> Index()
		{
			var allProducers = await _service.GetAllAsync();
			return View(allProducers);
		}

		// GET: Producers/Details/1
		public async Task<IActionResult> Details(int id)
		{
			var producerDetails = await _service.GetByIdAsync(id);
			if (producerDetails == null) return View("NotFound");
			return View(producerDetails);
		}

		// Get: Producers/Create
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]

		public async Task<IActionResult> Create([Bind("ProfilePictureURL,FullName,Bio")] Producer producer)
		{
			if (!ModelState.IsValid)
			{
				return View(producer);
			}
			await _service.AddAsync(producer);
			return RedirectToAction(nameof(Index));
		}
	}
}
