
public class ReaderWriterInvariant<TEntity> : IReaderWriterInvariant<TEntity> where TEntity : new()
{
	public TEntity Read()
	{
		return new TEntity();
	}

	public void Write(TEntity entity)
	{
		System.Console.WriteLine("Ho scritto l'entità");
	}
}
