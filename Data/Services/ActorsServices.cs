using eComerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace eComerce.Data.Services
{
    public class ActorsServices : IActorsServices
    {
        private readonly AppDbContext _context;
        public async Task AddAsync(Actor actor)
        {
            _context.Actors.Add(actor);
            await _context.SaveChangesAsync();
        }
        public ActorsServices(AppDbContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var actor = _context.Actors.Find(id);
            if (actor != null)
            {
                _context.Remove(actor);
                _context.SaveChanges();
            }
        }

        public AppDbContext Get_context()
        {
            return _context;
        }

        public async Task<IEnumerable<Actor>> getAll()
        {
            return await _context.Actors.ToListAsync();
        }

        public async Task<Actor> getByIdAsync(int id)
        {
            return await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
        }


        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }

    }
}
