using eComerce.Models;

namespace eComerce.Data.Services
{
    public interface IActorsServices
    {
        Task<IEnumerable<Actor>> getAll();
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int id, Actor newActor);
        Task DeleteAsync(int id);
        Task<Actor> getByIdAsync(int id);
    }
}
