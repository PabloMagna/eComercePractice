using eComerce.Models;

namespace eComerce.Data.Services
{
    public interface IActorsServices
    {
        Task<IEnumerable<Actor>> getAll();
        Task AddAsync(Actor actor);
        Actor Update(int id, Actor newActor);
        void Delete(int id);
        Task<Actor> getByIdAsync(int id);
    }
}
