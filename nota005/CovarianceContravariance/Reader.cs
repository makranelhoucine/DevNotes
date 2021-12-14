public class Reader<TEntity> : IReader<TEntity> where TEntity : new()
{
    public TEntity Read()
    {
        return new TEntity();
    }
}