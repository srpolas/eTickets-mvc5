using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
	public class ActorsService : IActorsService
	{
		//Get Data from Database
		private readonly AppDbContext _context;
		public ActorsService(AppDbContext context)
		{
			_context = context;
		}
		//Add Data to Database 
		public async Task AddAsync(Actor actor)
		{
			await _context.Actors.AddAsync(actor);
			await _context.SaveChangesAsync();
		}
		//Delete Data from Database
		public void Delete(int id)
		{
			throw new System.NotImplementedException();
		}
		//Get Data from Database
		public async Task<IEnumerable<Actor>> GetAllAsync()
		{
			var result = await _context.Actors.ToListAsync();
			return result;
		}
		//Get Actor Details from Database
		public async Task<Actor> GetByIdAsync(int id)
		{
			var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
			return result;
		}

		public Actor Update(int id, Actor newActor)
		{
			throw new System.NotImplementedException();
		}
	}
}
