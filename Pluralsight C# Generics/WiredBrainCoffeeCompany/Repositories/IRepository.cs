using WiredBrainCoffeeCompany.Entites;

namespace WiredBrainCoffeeCompany.Repositories
{
    public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T> 
        where T : IEntityBase
    //only usable with types that implement IEntityBase interface
    {
    }
}