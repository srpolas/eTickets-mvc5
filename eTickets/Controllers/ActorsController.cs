﻿using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        // GET Data
        private readonly AppDbContext _context;
        public ActorsController(AppDbContext context)
        
        {
            _context = context;
        }
    
    public async Task<IActionResult> Index()
    {
        var data = await _context.Actors.ToListAsync();
        return View(data);
    }
}
}
