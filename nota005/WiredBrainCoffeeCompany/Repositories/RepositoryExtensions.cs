namespace WiredBrainCoffeeCompany.Repositories
{
    public static class RepositoryExtensions
    {
        public static void AddBatch<T>(this IWriteRepository<T> repository, T[] elements)
        {
            foreach (var item in elements)
            {
                repository.Add(item);
            }
            repository.Save();
        }
    }
}