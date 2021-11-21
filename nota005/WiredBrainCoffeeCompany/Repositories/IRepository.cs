using WiredBrainCoffeeCompany.Entites;

namespace WiredBrainCoffeeCompany.Repositories
{
    public interface IRepository<T> where T : IEntityBase
    //only usable with types that implement IEntityBase interface
    {
        void Add(T element);
        T? GetById(int id);
        IEnumerable<T> GetAll();
        void Remove(T element);
        void Save();
    }
}