using eComerce.Models;
using Microsoft.EntityFrameworkCore;

namespace eComerce.Data.Services
{
    public class ActorsServices : IActorsServices
    {
        private readonly AppDbContext _context;
        public void Add(Actor actor)
        {
            throw new NotImplementedException();
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

        public Actor getById()
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
