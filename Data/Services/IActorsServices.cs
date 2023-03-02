using eComerce.Models;

namespace eComerce.Data.Services
{
    public interface IActorsServices
    {
        Task<IEnumerable<Actor>> getAll();
        Actor getById();
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);
        void Delete(int id);
    }
}
