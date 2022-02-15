namespace WiredBrainCoffeeCompany.Repositories
{
    public interface IReadRepository<out T> // covariant
    {
        IEnumerable<T> GetAll();
        T? GetById(int id);
    }
}