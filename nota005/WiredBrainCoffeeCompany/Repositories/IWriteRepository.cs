namespace WiredBrainCoffeeCompany.Repositories
{
    public interface IWriteRepository<in T> // contravariant
    {
        void Add(T element);
        void Remove(T element);
        void Save();
    }
}