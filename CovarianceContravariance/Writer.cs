public class Writer<TEntity> : IWriter<TEntity> where TEntity : new()
{
    public void Write(TEntity entity)
    {
        System.Console.WriteLine("Scritto l'entità");
    }
}