using Microsoft.EntityFrameworkCore;
using WiredBrainCoffeeCompany.Entites;

namespace WiredBrainCoffeeCompany.Repositories
{
    public class SqlRepository<T> : IRepository<T> where T : class, IEntityBase
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public SqlRepository(DbContext dbContext)
        {
            this._dbContext = dbContext;
            this._dbSet = dbContext.Set<T>();
        }

        public event EventHandler<T>? ElementAdded; // EventHandler è un delegate

        public void Add(T element)
        {
            this._dbSet.Add(element);
            this.ElementAdded?.Invoke(this, element);
        }

        public void Remove(T element)
        {
            this._dbSet.Remove(element);
        }

        public T? GetById(int id) => this._dbSet.Find(id);

        public void Save()
        {
            this._dbContext.SaveChanges();

        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.OrderBy(el => el.Id).ToList();
        }
    }
}